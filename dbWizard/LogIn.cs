using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.IO;
using System.Data.SqlClient;

namespace dbWizard
{
    public partial class LogIn : MaterialForm
    {
        //sets connection string
        string connstr = "";

        //user session id
        int userId;

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            //hides successful login image
            pbSuccess.Visible = false;

       

        //Sets skin to light mode.
        var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme
                   (MaterialSkin.Primary.Grey800, MaterialSkin.Primary.Grey700, MaterialSkin.Primary.Grey500,
                MaterialSkin.Accent.Green100, MaterialSkin.TextShade.WHITE
                );

            //checks if connection strings are already setup and sets them
            if (File.Exists("C:\\dbWizard\\dbWizardConnectionStrings.txt"))
            {
                var content = File.ReadAllText("C:\\dbWizard\\dbWizardConnectionStrings.txt");
                Clipboard.SetText(content);
                connstr = content.ToString();
            }
            else
            {
                MessageBox.Show("Connection string not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //checks user credentials
            SqlConnection sqlConnection1 = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;

            cmd.CommandText = "USE [dbWizard] SELECT COUNT(*) FROM dbUsers WHERE dbUsername = '" + txtUsername.Text + "' AND dbPassword = '"+txtPassword.Text+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            //if creds are correct then logs in, sets intActive to 1 to show user is online
            if(returnValue.ToString() != "")
            {
                //logs user in and sets their session id
                cmd.CommandText = "USE [dbWizard] SELECT dbUserID FROM dbUsers WHERE dbUsername = '" + txtUsername.Text + "' AND dbPassword = '" + txtPassword.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                returnValue = cmd.ExecuteScalar();
                sqlConnection1.Close();

                //sets user id
                userId = Convert.ToInt32(returnValue.ToString());

                //sets user to be active
                cmd.CommandText = "USE [dbWizard] UPDATE dbUsers SET intActive = 1 WHERE dbUserID = " + userId;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteScalar();
                sqlConnection1.Close();

                pbSuccess.Visible = true;

                cmd.CommandText = "USE [dbWizard] SELECT dbUsername FROM dbUsers WHERE dbUserID = " + userId;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                returnValue = cmd.ExecuteScalar();
                sqlConnection1.Close();

                //saves credentials if checked
                if(chkRemember.Checked==true)
                {
                    //saves connstrings to file on C:\
                    string path = @"C:\dbWizard\";
                    if (!File.Exists(path))
                    {
                        using (var tw = new StreamWriter(path + "credentials.txt", true))
                        {
                            tw.WriteLine("The next line!");
                            tw.Close();
                            System.IO.File.WriteAllText(@"C:\\dbWizard\\credentials.txt", "USE [dbWizard] SELECT dbUserID FROM dbUsers WHERE dbUsername = '" + txtUsername.Text + "' AND dbPassword = '" + txtPassword.Text + "'");
                        }
                    }
                }

                //closes this form sets userId
                Home home = new Home();
                home.userId = userId;
                home.lbl_User.Text = "Logged in as: " + returnValue.ToString();

                //gives higher access once logged in
                home.viewsToolStripMenuItem.Visible = true;
                home.GroupBoxTools.Visible = true;
                home.Show();
                this.Hide();
            }
            else
            {
                //tells user that creds are incorrect
                MessageBox.Show("Credentials incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
