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
    public partial class ConnectionDetails : MaterialForm
    {
        //dataSource:
        public string connstr = "";
        public string connstrHidden = "";

        public ConnectionDetails()
        {
            InitializeComponent();
        }

        private void ConnectionDetails_Load(object sender, EventArgs e)
        {
            //checks if already connected to database
            if(File.Exists("C:\\dbWizard\\dbWizardConnectionStrings.txt"))
            {
                DialogResult dialogResult = MessageBox.Show("Connection strings already setup, reset?", "Message", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    File.Delete(@"C:\\dbWizard\\dbWizardConnectionStrings.txt");
                }
                else if (dialogResult == DialogResult.No)
                {
                    //closes this form, opens home
                    Home home = new Home();
                    home.Show();
                }
            }

            //gets connection to main form
            Home frm = new Home();

            //sets colour scheme
            if (frm.ColourScheme == 0)
            {
                var skinManager = MaterialSkin.MaterialSkinManager.Instance;
                skinManager.AddFormToManage(this);
                skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
                skinManager.ColorScheme = new MaterialSkin.ColorScheme
                         (MaterialSkin.Primary.Grey800, MaterialSkin.Primary.Grey700, MaterialSkin.Primary.Grey500,
                MaterialSkin.Accent.Green100, MaterialSkin.TextShade.WHITE
                    );
            }
            else if (frm.ColourScheme == 1)
            {
                var skinManager = MaterialSkin.MaterialSkinManager.Instance;
                skinManager.AddFormToManage(this);
                skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
                skinManager.ColorScheme = new MaterialSkin.ColorScheme
                    (MaterialSkin.Primary.Grey800, MaterialSkin.Primary.Grey700, MaterialSkin.Primary.Grey500,
                    MaterialSkin.Accent.Green100, MaterialSkin.TextShade.WHITE
                    );
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtConnectToServer_Click(object sender, EventArgs e)
        {
            //creates connection to db
            connstr = "Data Source =" + txtServerAddress.Text + "; User ID =" + txtUser.Text + "; Password=" + txtPassword.Text;

           //attempts to get db names from server
            string Conn = "Data Source =" + txtServerAddress.Text + "; User ID =" + txtUser.Text + "; Password=" + txtPassword.Text + ";";

            //attempts connection to server
            using (SqlConnection con = new SqlConnection(Conn))
            {
                try {
                    con.Open();
                    cmbSource.Items.Clear();
                    //pulls existing db names
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                //adds db list to combo box
                                cmbSource.Items.Add(dr[0].ToString());
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
            //highlights db selector after connection is made
            cmbSource.BackColor = Color.LightGreen;
            }

        private void btnCreateCon_Click(object sender, EventArgs e)
        {
            //sets public connection string
            connstr = "Data Source =" + txtServerAddress.Text + "; Initial Catalog=" + cmbSource.SelectedItem.ToString() +"; User ID =" + txtUser.Text + "; Password=" + txtPassword.Text;
            connstrHidden = "Data Source =" + txtServerAddress.Text + "; Initial Catalog=" + cmbSource.SelectedItem.ToString() + "; User ID =" + txtUser.Text + ";";

            //saves connstrings to file on C:\
            string path = @"C:\dbWizard\";
            if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path + "dbWizardConnectionStrings.txt", true))
                {
                    tw.WriteLine("The next line!");
                    tw.Close();
                    System.IO.File.WriteAllText(@"C:\\dbWizard\\dbWizardConnectionStrings.txt", connstr);
                }
            }

            //sets main connection string for home form
            Home home = new Home();
            home.connstr = connstr;
            home.lbl_ConnectionString.Text = connstrHidden;
            home.Show();
            this.Hide();

        }
    }
}
