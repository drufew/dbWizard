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
    public partial class NewUser : MaterialForm
    {
        //sets connection string
        public string connstr;

        public NewUser()
        {
            InitializeComponent();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            //Sets skin to light mode.
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme
                   (MaterialSkin.Primary.Grey800, MaterialSkin.Primary.Grey700, MaterialSkin.Primary.Grey500,
                MaterialSkin.Accent.Green100, MaterialSkin.TextShade.WHITE
                );

            
        }

        private void txtSubmitNewUser_Click(object sender, EventArgs e)
        {
            //saves group id
            int group;

            //pulls ID for selected user group
            SqlConnection sqlConnection1 = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;

            //checks to see if user already exists
            cmd.CommandText = "USE [dbWizard] SELECT COUNT(*) FROM dbUsers WHERE dbUsername = '" + txtUsername.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            //checks to see if user exists, if not creates
            if (returnValue.ToString() == "1")
            {
                MessageBox.Show("Duplicate user, please assign different username", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtUsername.Text = "";
            }
            else
            {

                cmd.CommandText = "USE [dbWizard] SELECT dbGroupID FROM dbUserGroups WHERE dbGroupAlias = '" + cmb_SecurityGroups.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                returnValue = cmd.ExecuteScalar();
                sqlConnection1.Close();

                //sets group id
                group = Convert.ToInt32(returnValue.ToString());

                //inserts into users table
                cmd.CommandText = "USE [dbWizard] INSERT INTO dbUsers (dbUsername,dbPassword,intSecurity,dtDateCreated,intActive) SELECT '" + txtUsername.Text + "','" + txtPassword.Text + "'," + group + ",GETDATE(),0";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteScalar();
                sqlConnection1.Close();

                //inserts blank values into user data table
                cmd.CommandText = "USE [dbWizard] INSERT INTO dbUserProfile (dbUserId,dbForename,dbSurname,dtDateOfBirth,dbEmailAddress,dbCountry) SELECT dbUserID,'','','','','' FROM dbUsers WHERE dbUsername = '" + txtUsername.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteScalar();
                sqlConnection1.Close();

                MessageBox.Show("The user: " + txtUsername.Text + " has been created.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //closes this form, re-opens users.
                Users users = new Users();
                users.connstr = connstr;
                users.Show();
                this.Hide();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            //populates usergroups
            using (SqlConnection con = new SqlConnection(connstr))
            {
                try
                {
                    con.Open();
                    cmb_SecurityGroups.Items.Clear();
                    //pulls existing security group names
                    using (SqlCommand cmd = new SqlCommand("USE[dbWizard] SELECT dbGroupAlias FROM dbUserGroups", con))
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
            cmb_SecurityGroups.BackColor = Color.LightGreen;
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Tab)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
