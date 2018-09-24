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
    public partial class WhosOnline : MaterialForm 
    {
        //sets connection string
        public string connstr;

        //sets currentuser id
        public int userId;

        //sets targetuserId
        public int targetUserId;

        //
        public string currentUserName;

        public WhosOnline()
        {
            InitializeComponent();
        }

        private void WhosOnline_Load(object sender, EventArgs e)
        {
            tmr_UpdateChat.Enabled = false;

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

    SELECT dbUsername AS 'Username',
		CASE WHEN USR.intActive = 1 THEN 'Online' ELSE 'Offline' END AS 'Status'

        FROM[dbo].[dbUsers] USR INNER JOIN[dbo].[dbUserGroups] GRPS ON USR.intSecurity = GRPS.dbGroupID";

            var c = new SqlConnection(connstr);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dgv_Users.ReadOnly = true;
            dgv_Users.DataSource = ds.Tables[0];

            //checks for offline users
            foreach (DataGridViewRow Myrow in dgv_Users.Rows)
            {            
                //if user offline, row is gray, otherwise light green..
                if (Myrow.Cells[1].Value.ToString() == "Offline")
                {
                    Myrow.DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }

            //Sends message to chat history
            SqlConnection sqlConnection1 = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;

            cmd.CommandText = "USE [dbWizard] SELECT dbUsername FROM dbUsers WHERE dbUserID=" + userId;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue= cmd.ExecuteScalar();
            sqlConnection1.Close();

            currentUserName = returnValue.ToString();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //checks to see if any message is actually present, if it is then sends
            if(txtSendMessage.Text=="")
            {
                txtSendMessage.Focus();
            }
            else
            {
                //Sends message to chat history
                SqlConnection sqlConnection1 = new SqlConnection(connstr);
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "USE [dbWizard] INSERT INTO dbMessageHistory (dbUserSentName,dbUserSentBy,dbUserReceived,dbMessageContent,dtDateSent) SELECT '"+currentUserName+"'," + userId + "," + targetUserId + ",'" + txtSendMessage.Text + "',GETDATE()";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteScalar();
                sqlConnection1.Close();

                txtSendMessage.Clear();
                txtSendMessage.Focus();
                
            }
        }

        private void dgv_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Users_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //clears chat box
            rtb_ChatHistory.Clear();

            //sets targetUserID also fills text box with chat history
            string userNameTarget = dgv_Users.SelectedRows[0].Cells[0].Value.ToString();
            //sets count of messages
            int MessageCount;

            //gets target user id
            SqlConnection sqlConnection1 = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;

            cmd.CommandText = "USE [dbWizard] SELECT dbUserId FROM dbUsers WHERE dbUsername = '"+userNameTarget+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            targetUserId = Convert.ToInt32(returnValue.ToString());

            //sets the message log count for top 150
            cmd.CommandText = "USE [dbWizard] SELECT TOP 150 COUNT(*) FROM dbMessageHistory WHERE dbUserSentBy IN (" + userId + "," + targetUserId + ") AND dbUserReceived IN (" + userId + "," + targetUserId + ")";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            MessageCount = Convert.ToInt32(returnValue.ToString());

            //Returns chat history
            for(int i = 1; i < MessageCount + 1; i++)
            {
                //gets each line of chat history up to 150 messages
                cmd.CommandText = "USE [dbWizard]; WITH chatHistory AS (SELECT (ROW_NUMBER() OVER (ORDER BY dbMessageHistory.dtDateSent)) as row,* FROM dbMessageHistory) SELECT dbUserSentName + ' ' + CAST(CAST(dtDateSent AS date) AS VARCHAR) + ': ' + dbMessageContent FROM chatHistory WHERE row = " + i+ " AND dbUserSentBy IN (" + userId + ","+targetUserId+ ") AND dbUserReceived IN (" + userId + "," + targetUserId + ")";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                returnValue = cmd.ExecuteScalar();
                sqlConnection1.Close();

                //sets new line of chat history
                rtb_ChatHistory.Text += Environment.NewLine + returnValue.ToString();
            }
            tmr_UpdateChat.Enabled = true;

        }

        private void tmr_UpdateChat_Tick(object sender, EventArgs e)
        {
            //clears chat
            rtb_ChatHistory.Clear();

            //sets connection
            SqlConnection sqlConnection1 = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand();
            Object returnValue;

            //variable for max message count
            int MessageCount;

            //sets the message log count for top 150
            cmd.CommandText = "USE [dbWizard] SELECT TOP 150 COUNT(*) FROM dbMessageHistory WHERE dbUserSentBy IN (" + userId + "," + targetUserId + ") AND dbUserReceived IN (" + userId + "," + targetUserId + ")";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            returnValue = cmd.ExecuteScalar();
            sqlConnection1.Close();

            MessageCount = Convert.ToInt32(returnValue.ToString());

            //Returns chat history
            for (int i = 1; i < MessageCount + 1; i++)
            {
                //gets each line of chat history up to 150 messages
                cmd.CommandText = "USE [dbWizard]; WITH chatHistory AS (SELECT (ROW_NUMBER() OVER (ORDER BY dbMessageHistory.dtDateSent)) as row,* FROM dbMessageHistory) SELECT dbUserSentName + ' ' + CAST(CAST(dtDateSent AS date) AS VARCHAR) + ': ' + dbMessageContent FROM chatHistory RWS INNER JOIN dbUsers USRS ON RWS.dbUserReceived = USRS.dbUserID OR RWS.dbUserSentBy=USRS.dbUserID WHERE row = " + i + " AND dbUserSentBy IN (" + userId + "," + targetUserId + ") AND dbUserReceived IN (" + userId + "," + targetUserId + ")";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                returnValue = cmd.ExecuteScalar();
                sqlConnection1.Close();

                //sets new line of chat history
                rtb_ChatHistory.Text += Environment.NewLine + returnValue.ToString();
            }
        }
    }
}
