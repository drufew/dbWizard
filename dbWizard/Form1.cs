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
using System.Data.SqlClient;
using System.IO;

namespace dbWizard
{
    public partial class Home : MaterialForm
    {
        //0 = dark, 1 = light.
        public int ColourScheme;

        //sets public connstr from connectiondetails
        public string connstr = "";

        //userId
        public int userId = 0000000000;

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //creates dbWizard directory
            string root = @"C:\dbWizard";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }

            //hides users tab 
            settingsToolStripMenuItem.DropDownItems[3].Visible = false;

            //sets tooltips
            ttOpenTable.SetToolTip(btn_OpenTable, "Open database table");
            ttOpenTable.SetToolTip(btn_Fullrestore, "Full restore wizard");
            ttOpenTable.SetToolTip(btn_PartialRestore, "Patial restore wizard");
            ttOpenTable.SetToolTip(btn_BulkUpdate, "Bulk update");
            ttOpenTable.SetToolTip(btn_Import, "Import (into existing tables or new)");
            ttOpenTable.SetToolTip(btn_QueryEditor, "Manually write SQL queries");
            ttOpenTable.SetToolTip(btn_OtherUsers, "See who is online & chat");
            ttOpenTable.SetToolTip(btn_DeleteData, "Delete data wizard");
            ttOpenTable.SetToolTip(btn_Backup, "Backup data (individual, or entire database");
            ttOpenTable.SetToolTip(btn_Export, "Create new export or view saved exports");

            //Sets skin to light mode.
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme
                   (MaterialSkin.Primary.Grey800, MaterialSkin.Primary.Grey700, MaterialSkin.Primary.Grey500,
                MaterialSkin.Accent.Green100, MaterialSkin.TextShade.WHITE
                );

            ColourScheme = 1;

            //checks if connection strings are already setup and sets them
            if (File.Exists("C:\\dbWizard\\dbWizardConnectionStrings.txt"))
            {
                var content = File.ReadAllText("C:\\dbWizard\\dbWizardConnectionStrings.txt");
                Clipboard.SetText(content);
                connstr = content.ToString();


                //trims off password for security on label
                int index = connstr.IndexOf("Password=");
                string result = connstr.Substring(0, index);
                lbl_ConnectionString.Text = result;

                //sets connection
                SqlConnection sqlConnection1 = new SqlConnection(connstr);
                SqlCommand cmd = new SqlCommand();
                Object returnValue;

                //checks to see if saved login
                if (File.Exists("C:\\dbWizard\\credentials.txt"))
                {


                    //sets user id
                    content = File.ReadAllText("C:\\dbWizard\\credentials.txt");
                    Clipboard.SetText(content);

                    //runs query in textfile
                    cmd.CommandText = content.ToString();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = sqlConnection1;

                    sqlConnection1.Open();
                    returnValue = cmd.ExecuteScalar();
                    sqlConnection1.Close();

                    userId = Convert.ToInt32(returnValue.ToString());

                    //sets username
                    cmd.CommandText = "USE [dbWizard] SELECT dbUsername FROM dbUsers WHERE dbUserID = " + userId;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = sqlConnection1;

                    sqlConnection1.Open();
                    returnValue = cmd.ExecuteScalar();
                    sqlConnection1.Close();

                    lbl_User.Text = "Logged in as: " + returnValue.ToString();


                    //alows admin to control security groups etc.
                    if (returnValue.ToString() == "Administrator")
                    {
                        settingsToolStripMenuItem.DropDownItems[3].Visible = true;
                    }

                }
            }          

            //hides toolbar from users if not logged in
            if (userId == 0000000000)
            {
                viewsToolStripMenuItem.Visible = false;
                GroupBoxTools.Visible = false;
            }
            else
            {
                viewsToolStripMenuItem.Visible = true;
                GroupBoxTools.Visible = true;
            }


           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sets skin to light mode.
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.Amber200, MaterialSkin.Primary.Amber100, MaterialSkin.Primary.Amber100,
                MaterialSkin.Accent.Amber100, MaterialSkin.TextShade.BLACK
                );

            ColourScheme = 0;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sets skin to dark mode.
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.Grey800, MaterialSkin.Primary.Grey700, MaterialSkin.Primary.Grey500,
                MaterialSkin.Accent.Green100, MaterialSkin.TextShade.WHITE
                );

            ColourScheme = 1;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes application.
            this.Close();
        }

        private void closeToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hides tool box.
            GroupBoxTools.Hide();
        }

        private void openToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Shows toolbox.
            GroupBoxTools.Show();
        }

        private void connectToNewDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens conn details
            ConnectionDetails CD = new ConnectionDetails();
            CD.Show();
            this.Hide();
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hides connstr
            lbl_ConnectionString.Hide();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //shows connstr
            lbl_ConnectionString.Show();
        }

        private void createDbWizardDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //checks connection
            if (connstr == "")
            {
                MessageBox.Show("No connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //checks if database exists, if not creates
                SqlConnection sqlConnection1 = new SqlConnection(connstr);
                SqlCommand cmd = new SqlCommand();
                Object returnValue;

                cmd.CommandText = "SELECT COUNT(NAME) FROM sys.databases WHERE NAME = 'dbWizard'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                returnValue = cmd.ExecuteScalar();
                sqlConnection1.Close();

                if (returnValue.ToString() == "1")
                {
                    //lets user know db already exists
                    MessageBox.Show("dbWizard database already exists.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    //creates new dbWizard database
                    cmd.CommandText = "CREATE DATABASE dbWizard";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = sqlConnection1;

                    sqlConnection1.Open();
                    cmd.ExecuteScalar();
                    sqlConnection1.Close();

                    //creates dbUsers table and logs in admin as current user
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connstr))
                        using (SqlCommand cmd2 = new SqlCommand(SQL_Scripts.dbWizardSetup.dbSetup, conn))
                        {
                            try
                            {
                                //opens connection and sends query
                                conn.Open();
                                cmd2.ExecuteNonQuery();
                            }
                            catch (SqlException se)
                            {
                                //sql exception
                                MessageBox.Show(se.ToString());
                            }

                            //tells user dbWizard has been created

                        }
                    }
                    catch (SqlException x)
                    {
                        //if error happens when attempting connection will show this exception
                        MessageBox.Show(x.ToString());
                    }
                }

                MessageBox.Show("dbWizard database has been created to: " + lbl_ConnectionString.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void connectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colourSchemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void switchDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void db1_Click(object sender, EventArgs e)
        {

        }

        private void viewsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void populateDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connstr != "")
            {
                SqlConnection sqlConnection1 = new SqlConnection(connstr);
                SqlCommand cmd = new SqlCommand();
                Object returnValue;

                cmd.CommandText = "SELECT COUNT(NAME) FROM sys.databases WHERE NAME = 'dbWizard'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                returnValue = cmd.ExecuteScalar();
                sqlConnection1.Close();

                if (returnValue.ToString() == "1")
                {
                    //checks to see if user already logged in 
                    if (userId != 0000000000)
                    {
                        //asks user if they want to logout
                        DialogResult dialogResult = MessageBox.Show("You're already logged in as: " + lbl_User.Text + ", would you like to logout?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //logs user out
                            userId = 0000000000;
                            lbl_User.Text = "Not currently logged in.";

                            //checks for saved user
                            if (File.Exists("C:\\dbWizard\\credentials.txt"))
                            {
                                //removes saved credentials
                                File.Delete(@"C:\\dbWizard\\credentials.txt");
                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {

                        }
                    }
                    else
                    {
                        //opens login form
                        LogIn login = new LogIn();
                        login.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("dbWizard database does not exist.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Connection to database not established", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ttOpenTable_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btn_Fullrestore_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.connstr = connstr;
            users.Show();
            
        }
    }
}
