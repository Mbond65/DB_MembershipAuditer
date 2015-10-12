using MetroFramework.Forms;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;
using System.Net;

namespace DBMembershipAuditer
{
    public partial class DropboxMembershipAuditer : MetroForm
    {
        public DropboxMembershipAuditer()
        {
            InitializeComponent();
        }
        public async Task GetData()
        {
            string content;
            RootObject result = null;
            Random intRandom = new Random();
            pbMemberInformationProgress.Value = intRandom.Next(20, 80);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.dropbox.com");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + txtAccessToken.Text);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                var limit = GetLimit();
                var response = await client.PostAsJsonAsync("1/team/members/list", limit);
                content = await response.Content.ReadAsStringAsync();

                result = new JavaScriptSerializer().Deserialize<RootObject>(content);
            }

            if (result.members == null)
            {
                pbMemberInformationProgress.Value = 0;
                throw new Exception(content.Replace("{", "").Replace("}","").Replace("\""," "));
            }

            PopulateDataGridView(result);
            EndProgressBar();

        }
        public void EndProgressBar()
        {
            pbMemberInformationProgress.Value = 100;
        }
        public void PopulateDataGridView(dynamic result)
        {
            SetColumnsDataGridView();

            int intRowCount = 0;
            DVGResults.Rows.Clear();
            pbMemberInformationProgress.Value = 60;

            foreach (var member in result.members)
            {
                Profile DropboxMember = (Profile)member.profile;
                Permissions Permission = (Permissions)member.permissions;
                DVGResults.Rows.Add();
                DVGResults.Rows[intRowCount].Cells[0].Value = DropboxMember.given_name;
                DVGResults.Rows[intRowCount].Cells[1].Value = DropboxMember.surname;
                DVGResults.Rows[intRowCount].Cells[2].Value = DropboxMember.email;
                DVGResults.Rows[intRowCount].Cells[3].Value = DropboxMember.status;
                DVGResults.Rows[intRowCount].Cells[4].Value = Permission.is_admin;

                if (DropboxMember.groups.Count != 0)
                {
                    foreach (object group in DropboxMember.groups)
                    {
                        DVGResults.Rows[intRowCount].Cells[5].Value += " " + (string)group;
                    }
                }
                else
                {
                    DVGResults.Rows[intRowCount].Cells[5].Value = "none";
                }

                DVGResults.Rows[intRowCount].Cells[6].Value = DropboxMember.member_id;              

                intRowCount = intRowCount + 1;
            }


        }
        public void SetColumnsDataGridView()
        {
            DVGResults.Columns.Clear();
            DVGResults.Columns.Add("First Name", "First Name");
            DVGResults.Columns.Add("Surname", "Surname");
            DVGResults.Columns.Add("Email Address", "Email Address");
            DVGResults.Columns.Add("Status", "Status");
            DVGResults.Columns.Add("Admin", "Admin");
            DVGResults.Columns.Add("Groups", "Groups");
            DVGResults.Columns.Add("Member ID", "Member ID");
        }
        public DropboxMemberCallLimit GetLimit()
        {
            var limit = new DropboxMemberCallLimit();

            if (txtLimit.Text.Length == 0)
            {
                limit.limit = 1000;
            }
            else
            {
                limit.limit = Convert.ToInt32(txtLimit.Text);
            }

            return limit;
        }
        public class DropboxMemberCallLimit
        {
            public int limit { get; set; }
        }
        public class Profile
        {
            public string given_name { get; set; }
            public string surname { get; set; }
            public string status { get; set; }
            public string member_id { get; set; }
            public string email { get; set; }
            public string external_id { get; set; }
            public List<object> groups { get; set; }
        }
        public class Permissions
        {
            public bool is_admin { get; set; }
        }
        public class Member
        {
            public Profile profile { get; set; }
            public Permissions permissions { get; set; }
        }
        public class RootObject
        {
            public List<Member> members { get; set; }
        }
        public void OnClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void txtLimit_TextChanged(object sender, EventArgs e)
        {
            MetroTextBox txtLimit = (MetroTextBox)sender;
            int? intLimit = null;

            if (txtLimit.Text.Length != 0)
            {
                try
                {
                    intLimit = Convert.ToInt32(txtLimit.Text);
                }
                catch
                {
                    MetroMessageBox.Show(this, "Limit must be a number", "Error: not a number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLimit.Text = null;
                }

                if (intLimit > 1000)
                {
                    MetroMessageBox.Show(this, "The number you've entered is above 1000, please lower the limit and try again.", "Error: limit exceeds allowed value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public void StartProgressBar()
        {
            pbMemberInformationProgress.Visible = true;
            pbMemberInformationProgress.Minimum = 0;
            pbMemberInformationProgress.Maximum = 100;
            pbMemberInformationProgress.Value = 0;
        }
        public void ValidateAccessToken()
        {
            if (txtAccessToken.Text.Length == 0)
            {
                throw new Exception("Access token is empty.");
            }
        }
        public async void btnStart_Click_1(object sender, EventArgs e)
        {
            StartProgressBar();

            try
            {
                CheckForInternetConnection();
                ValidateAccessToken();
                await GetData();

                if (txtFilePath.Text.Length != 0)
                {
                    SaveAsCSV(DVGResults, txtFilePath.Text);
                }
            }
            catch (Exception exp)
            {
                pbMemberInformationProgress.Value = 0;
                MetroMessageBox.Show(this, exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SaveAsCSV(MetroGrid grid, string filelocation)
        {
            if (grid.RowCount != 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();

                using (StreamWriter sw = new StreamWriter(File.Open(filelocation, FileMode.OpenOrCreate)))
                {

                    for (var i = 0; i < grid.Columns.Count; i++)
                    {
                        if (i > 0)
                        {
                            sw.Write(",");
                        }

                        sw.Write(grid.Columns[i].HeaderText);
                    }

                    sw.WriteLine();

                    for (var r = 0; r < grid.RowCount - 1; r++)
                    {
                        if (r > 0)
                        {
                            sw.WriteLine();
                        }

                        dr = grid.Rows[r];

                        for (var p = 0; p < grid.Columns.Count; p++)
                        {
                            value = dr.Cells[p].Value.ToString();
                            value = value + ",";

                            sw.Write(value);

                        }
                    }
                    
                    sw.Close();


                }
            }

        }
        public void btnBrowse_Click(object sender, EventArgs e)
        {
            SVCsvSave.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            SVCsvSave.Filter = "Comma Seperated Value (*.csv)|.csv";
            SVCsvSave.ShowDialog();
        }
        public void SVCsvSave_FileOk(object sender, CancelEventArgs e)
        {
            SaveFileDialog sf = (SaveFileDialog)sender;
            txtFilePath.Text = sf.FileName;
        }
        public static void CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                }
            }
            catch
            {
                throw new Exception("The computer you're using has no internet connection.");
            }
        }
    }
}
