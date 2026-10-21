using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.OleDb;
namespace Login
{
    public partial class dashboard : Form
    {
        private string connectionString = @"Provider =Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Hachiru\Desktop\loginusernamepassword.accdb;Persist Security Info=False;";
        public dashboard()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            GRADINGSHEET GS = new GRADINGSHEET();
            GS.Show();
            this.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label14.Text = DateTime.Now.ToLongTimeString();
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToLongDateString();
            label2.Text = Form1.user;
            label16.Text = Form1.pos;

            label19.Text = DateTime.Now.ToLongTimeString();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO DASHBOARDLOGINS ([ACCOUNT_NAME],[DATE_1],[TIME_1]) VALUES ('" + label2.Text + "','" + label13.Text + "','" + label19.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();


            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            logout logout = new logout();
            logout.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            logout logout = new logout();
            logout.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.Show();
            this.Hide();
        }
    }
}
