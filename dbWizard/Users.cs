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

    SELECT dbUserID, dbUsername, CASE WHEN dbPassword<> '' THEN '***' ELSE 'Error' END AS 'dbPassword',GRPS.dbGroupAlias,USR.dtDateCreated,
		CASE WHEN USR.intActive = 1 THEN 'Online' ELSE 'Offline' END AS 'Activity'

        FROM[dbo].[dbUsers] USR INNER JOIN[dbo].[dbUserGroups] GRPS ON USR.intSecurity = GRPS.dbGroupID";

            var c = new SqlConnection(connstr); 
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgv_Users.ReadOnly = true;
            dgv_Users.DataSource = ds.Tables[0];

            userId = Convert.ToInt32(dgv_Users.Rows[0].Cells[0].Value.ToString());

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
            //tells user changes have been saved
            lbl_Saved.Visible = false;
            pb_Saved.Visible = false;

            //sets user profile
            userId = Convert.ToInt32(dgv_Users.SelectedRows[0].Cells[0].Value.ToString());

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

            cmd.CommandText = "USE [dbWizard] UPDATE dbUserProfile SET dbForename = '" +txtForename.Text + "',dbSurname='"+txtSurname.Text+"',dtDateOfBirth='"+txtDOB.Text+"',dbEmailAddress='"+txtEmail.Text+"',dbCountry='"+txtCountry.Text+"' WHERE dbUserID = " + userId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteScalar();
            sqlConnection1.Close();

            //tells user changes have been saved
            lbl_Saved.Visible = true;
            pb_Saved.Visible = true;
        }
    }
}
