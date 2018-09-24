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
    public partial class Users : MaterialForm
    {
        //sets connection string
        public string connstr = "";

        //sets id of user
        int userId;

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            //Sets skin to light mode.
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme
                   (MaterialSkin.Primary.Grey800, MaterialSkin.Primary.Grey700, MaterialSkin.Primary.Grey500,
                MaterialSkin.Accent.Green100, MaterialSkin.TextShade.WHITE
                );

            //fills dgv_Users
            var select = @"USE [dbWizard] 

    SELECT dbUserID AS 'User ID', dbUsername AS 'Username', CASE WHEN dbPassword<> '' THEN '***' ELSE 'Error' END AS 'Password',GRPS.dbGroupAlias AS 'Security Group',USR.dtDateCreated AS 'Date Created',
		CASE WHEN USR.intActive = 1 THEN 'Online' ELSE 'Offline' END AS 'Activity'

        FROM[dbo].[dbUsers] USR INNER JOIN[dbo].[dbUserGroups] GRPS ON USR.intSecurity = GRPS.dbGroupID";

            var c = new SqlConnection(connstr);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgv_Users.ReadOnly = true;
            dgv_Users.DataSource = ds.Tables[0];

            //sets user groups table
            select = @"USE [dbWizard] 

    SELECT dbGroupId, dbGroupAlias AS 'Group Name', dbGroupRights AS 'Rights (none/read/write/all)',dtDateCreated AS 'Date Created'

        FROM[dbo].[dbUserGroups]";

            c = new SqlConnection(connstr);
            dataAdapter = new SqlDataAdapter(select, c);

            commandBuilder = new SqlCommandBuilder(dataAdapter);
            ds = new DataSet();
            dataAdapter.Fill(ds);
            dgv_SecurityGroups.ReadOnly = true;
            dgv_SecurityGroups.DataSource = ds.Tables[0];

            //sets user id for the selected row
            userId = Convert.ToInt32(dgv_Users.Rows[0].Cells[0].Value.ToString());

            //sets whether or not online with image
            if (dgv_Users.Rows[0].Cells[5].Value.ToString() == "Online")
            {
                pb_Online.Visible = true;
            }
            else
            {
                pb_Offline.Visible = true;
            }


            //sets profile info
            SqlConnection sqlConnection1 = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;

            cmd.CommandText = "USE [dbWizard] SELECT dbForename FROM dbUserProfile WHERE dbUserID = " + userId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            txtForename.Text = returnValue.ToString();

            cmd.CommandText = "USE [dbWizard] SELECT dbSurname FROM dbUserProfile WHERE dbUserID = " + userId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            txtSurname.Text = returnValue.ToString();

            cmd.CommandText = "USE [dbWizard] SELECT dtDateOfBirth FROM dbUserProfile WHERE dbUserID = " + userId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            txtDOB.Text = returnValue.ToString();

            cmd.CommandText = "USE [dbWizard] SELECT dbEmailAddress FROM dbUserProfile WHERE dbUserID = " + userId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            txtEmail.Text = returnValue.ToString();

            cmd.CommandText = "USE [dbWizard] SELECT dbCountry FROM dbUserProfile WHERE dbUserID = " + userId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            txtCountry.Text = returnValue.ToString();

            lbl_Fullname.Text = txtForename.Text + ", " + txtSurname.Text;
        }

        private void gb_UserData_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Users_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //hides avaliability status
            pb_Offline.Visible = false;
            pb_Online.Visible = false;

            //tells user changes have been saved
            lbl_Saved.Visible = false;
            pb_Saved.Visible = false;

            //sets user profile
            userId = Convert.ToInt32(dgv_Users.SelectedRows[0].Cells[0].Value.ToString());

            if (dgv_Users.SelectedRows[0].Cells[5].Value.ToString() == "Online")
            {
                pb_Online.Visible = true;
            }
            else
            {
                pb_Offline.Visible = true;
            }

            SqlConnection sqlConnection1 = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;

            cmd.CommandText = "USE [dbWizard] SELECT dbForename FROM dbUserProfile WHERE dbUserID = " + userId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            txtForename.Text = returnValue.ToString();

            cmd.CommandText = "USE [dbWizard] SELECT dbSurname FROM dbUserProfile WHERE dbUserID = " + userId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            txtSurname.Text = returnValue.ToString();

            cmd.CommandText = "USE [dbWizard] SELECT dtDateOfBirth FROM dbUserProfile WHERE dbUserID = " + userId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            txtDOB.Text = returnValue.ToString();

            cmd.CommandText = "USE [dbWizard] SELECT dbEmailAddress FROM dbUserProfile WHERE dbUserID = " + userId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            txtEmail.Text = returnValue.ToString();

            cmd.CommandText = "USE [dbWizard] SELECT dbCountry FROM dbUserProfile WHERE dbUserID = " + userId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            txtCountry.Text = returnValue.ToString();

            //populates usergroups
            using (SqlConnection con = new SqlConnection(connstr))
            {
                try
                {
                    con.Open();
                    cmb_SecurityGroups.Items.Clear();
                    //pulls existing security group names
                    using (cmd = new SqlCommand("USE[dbWizard] SELECT dbGroupAlias FROM dbUserGroups", con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                //adds security groups list to combo box
                                cmb_SecurityGroups.Items.Add(dr[0].ToString());
                            }
                        }
                    }

                }
                catch (SqlException E)
                {
                    //sql errors
                    MessageBox.Show(E.ToString());
                }
            }

            //if no name is present
            if (txtForename.Text == "" && txtSurname.Text == "")
            {
                lbl_Fullname.Text = "No name!";
            }
            else
            {
                lbl_Fullname.Text = txtForename.Text + ", " + txtSurname.Text;
            }
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            //saves any changes to text boxes 
            SqlConnection sqlConnection1 = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;

            cmd.CommandText = "USE [dbWizard] UPDATE dbUserProfile SET dbForename = '" + txtForename.Text + "',dbSurname='" + txtSurname.Text + "',dtDateOfBirth='" + txtDOB.Text + "',dbEmailAddress='" + txtEmail.Text + "',dbCountry='" + txtCountry.Text + "' WHERE dbUserID = " + userId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteScalar();
            sqlConnection1.Close();

            //sets user group if cmb is not empty
            if (cmb_SecurityGroups.Text == "")
            {

            }
            else
            {
                cmd.CommandText = "USE [dbWizard] SELECT dbGroupID FROM dbUserGroups WHERE dbGroupAlias = '" +cmb_SecurityGroups.Text+"'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                returnValue = cmd.ExecuteScalar();
                sqlConnection1.Close();

                cmd.CommandText = "USE [dbWizard] UPDATE dbUsers SET intSecurity = " + returnValue.ToString() + " WHERE dbUserID = " + userId;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteScalar();
                sqlConnection1.Close();

                var select = @"USE [dbWizard] 

    SELECT dbUserID, dbUsername, CASE WHEN dbPassword<> '' THEN '***' ELSE 'Error' END AS 'dbPassword',GRPS.dbGroupAlias,USR.dtDateCreated,
		CASE WHEN USR.intActive = 1 THEN 'Online' ELSE 'Offline' END AS 'Activity'

        FROM[dbo].[dbUsers] USR INNER JOIN[dbo].[dbUserGroups] GRPS ON USR.intSecurity = GRPS.dbGroupID";

                //resets table
                var c = new SqlConnection(connstr);
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dgv_Users.ReadOnly = true;
                dgv_Users.DataSource = ds.Tables[0];
            }

            //tells user changes have been saved
            lbl_Saved.Visible = true;
            pb_Saved.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_UserOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmb change for delete users

            if (cmb_UserOptions.Text == "Delete selected users")
            {
                //asks user if they want to delete users
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected user? This will remove all data associated.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedUser = Convert.ToInt32(dgv_Users.SelectedRows[0].Cells[0].Value.ToString());

                    //if admin, cant delete
                    if (selectedUser == 1)
                    {
                        MessageBox.Show("You cannot delete the Administrator account.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        //deletes user data
                        SqlConnection sqlConnection1 = new SqlConnection(connstr);
                        SqlCommand cmd = new SqlCommand();
                        Object returnValue;

                        cmd.CommandText = "USE [dbWizard] DELETE FROM dbUserProfile WHERE dbUserID = " + selectedUser + "; USE [dbWizard] DELETE FROM dbUsers WHERE dbUserID = " + selectedUser;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = sqlConnection1;

                        sqlConnection1.Open();
                        returnValue = cmd.ExecuteScalar();
                        sqlConnection1.Close();


                        //checks to see if deleted user is currently logged in and removes save
                        Home home = new Home();

                        if(selectedUser==home.userId)
                        {
                            if (File.Exists("C:\\dbWizard\\credentials.txt"))
                            {
                                //removes saved credentials
                                File.Delete(@"C:\\dbWizard\\credentials.txt");
                            }

                        }


                        var select = @"USE [dbWizard] 

    SELECT dbUserID, dbUsername, CASE WHEN dbPassword<> '' THEN '***' ELSE 'Error' END AS 'dbPassword',GRPS.dbGroupAlias,USR.dtDateCreated,
		CASE WHEN USR.intActive = 1 THEN 'Online' ELSE 'Offline' END AS 'Activity'

        FROM[dbo].[dbUsers] USR INNER JOIN[dbo].[dbUserGroups] GRPS ON USR.intSecurity = GRPS.dbGroupID";

                        //resets table
                        var c = new SqlConnection(connstr);
                        var dataAdapter = new SqlDataAdapter(select, c);

                        var commandBuilder = new SqlCommandBuilder(dataAdapter);
                        var ds = new DataSet();
                        dataAdapter.Fill(ds);
                        dgv_Users.ReadOnly = true;
                        dgv_Users.DataSource = ds.Tables[0];
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            //Reset passwords (via email, defaults to "letmein")
            if (cmb_UserOptions.Text == "Reset passwords (via email, defaults to 'letmein')")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset the password for the selected user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedUser = Convert.ToInt32(dgv_Users.SelectedRows[0].Cells[0].Value.ToString());

                    //resets password
                    SqlConnection sqlConnection1 = new SqlConnection(connstr);
                    SqlCommand cmd = new SqlCommand();
                    Object returnValue;

                    cmd.CommandText = "USE [dbWizard] UPDATE dbUsers SET dbPassword = 'letmein' WHERE dbUserID = " + selectedUser;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = sqlConnection1;

                    sqlConnection1.Open();
                    returnValue = cmd.ExecuteScalar();
                    sqlConnection1.Close();

                    //lets user know password has been reset
                    MessageBox.Show("Password has been reset for: " + dgv_Users.SelectedRows[0].Cells[1].Value.ToString(), "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            //Reset passwords (via email, defaults to "letmein")
            if (cmb_UserOptions.Text == "Delete Security Group")
            {
               
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected security group?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int selectedGroup = Convert.ToInt32(dgv_SecurityGroups.SelectedRows[0].Cells[0].Value.ToString());

                    if (selectedGroup == 1)
                    {
                        MessageBox.Show("Sorry, you cannot delete the original admin group.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        //resets password
                        SqlConnection sqlConnection1 = new SqlConnection(connstr);
                        SqlCommand cmd = new SqlCommand();
                        Object returnValue;

                        cmd.CommandText = "USE [dbWizard] SELECT COUNT(*) FROM dbUsers WHERE intSecurity = " + selectedGroup;
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = sqlConnection1;

                        sqlConnection1.Open();
                        returnValue = cmd.ExecuteScalar();
                        sqlConnection1.Close();

                        if (Convert.ToInt32(returnValue.ToString()) > 0)
                        {
                            MessageBox.Show("You cannot delete a group with users already within it, there are " + returnValue.ToString() + " users within this group.", "Stop!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {

                            cmd.CommandText = "USE [dbWizard] DELETE FROM dbUserGroups WHERE dbGroupID = " + selectedGroup;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = sqlConnection1;

                            sqlConnection1.Open();
                            returnValue = cmd.ExecuteScalar();
                            sqlConnection1.Close();

                            //lets user know password has been reset
                            MessageBox.Show("Group: " + dgv_Users.SelectedRows[0].Cells[1].Value.ToString() + " has been deleted.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //sets user groups table
                            var select = @"USE [dbWizard] 

    SELECT dbGroupId, dbGroupAlias AS 'Group Name', dbGroupRights AS 'Rights (none/read/write/all)',dtDateCreated AS 'Date Created'

        FROM[dbo].[dbUserGroups]";

                            var c = new SqlConnection(connstr);
                            var dataAdapter = new SqlDataAdapter(select, c);

                            var commandBuilder = new SqlCommandBuilder(dataAdapter);
                            var ds = new DataSet();
                            dataAdapter.Fill(ds);
                            dgv_SecurityGroups.ReadOnly = true;
                            dgv_SecurityGroups.DataSource = ds.Tables[0];
                        }
                    }
                }
            }
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closes window
            this.Hide();
        }

        private void addNewUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closes users and opens new user form
            NewUser nwUser = new NewUser();
            nwUser.connstr = connstr;
            nwUser.Show();
            this.Hide();
        }

        private void securityGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sets connection string and opens form
            NewGroup newGrp = new NewGroup();
            newGrp.connstr = connstr;
            newGrp.Show();
            this.Hide();
        }

        private void tbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //detects changes on tabs
            if(tbUsers.SelectedIndex==1)
            {
                //if groups is selected, combo box changes
                cmb_UserOptions.Items.Clear();
                cmb_UserOptions.Items.Add("Delete Security Group");
            }
            else if(tbUsers.SelectedIndex==0)
            {
                //sets combo box back to normal
                cmb_UserOptions.Items.Clear();
                cmb_UserOptions.Items.Add("Export selected users");
                cmb_UserOptions.Items.Add("Delete selected users");
                cmb_UserOptions.Items.Add("Reset passwords(via email, defaults to 'letmein')");
            }
        }
    }
}
