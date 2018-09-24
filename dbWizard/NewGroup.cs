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
    public partial class NewGroup : MaterialForm
    {
        //sets connection string
        public string connstr;

        public NewGroup()
        {
            InitializeComponent();
        }

        private void NewGroup_Load(object sender, EventArgs e)
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

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //pulls ID for selected user group
            SqlConnection sqlConnection1 = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;

            //checks to see if user already exists
            cmd.CommandText = "USE [dbWizard] SELECT COUNT(*) FROM dbUserGroups WHERE dbGroupAlias = '" + txtGroupName.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            //checks to see if user exists, if not creates
            if (returnValue.ToString() == "1")
            {
                MessageBox.Show("Duplicate user group, please assign different group name.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtGroupName.Text = "";
            }
            else
            {
                //inserts into user groups table
                cmd.CommandText = "USE [dbWizard] INSERT INTO dbUserGroups (dbGroupAlias,dbGroupRights,dtDateCreated) SELECT '" + txtGroupName.Text + "','" + cmb_Security.Text + "',GETDATE()";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteScalar();
                sqlConnection1.Close();

                MessageBox.Show("The user group: " + txtGroupName.Text + " has been created.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //closes this form, re-opens users.
                Users users = new Users();
                users.connstr = connstr;
                users.Show();
                this.Hide();
            }
        }
    }
}
