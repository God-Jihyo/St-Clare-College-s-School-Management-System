using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Login
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Provider =Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Hachiru\Desktop\loginusernamepassword.accdb;Persist Security Info=False;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(160, Color.Maroon);
            panel1.BackColor = Color.FromArgb(150, Color.Black);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox.Checked == true)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }
        public static String user;
        public static String pos;
        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String pass = textBox2.Text;
            String query = $"SELECT FULLNAME, [POSITION] FROM LOGIN WHERE USERNAME = '{name}' AND PASSWORD = '{pass}'";

            using (OleDbConnection connect = new OleDbConnection(connectionString))
            {
                connect.Open();
                OleDbCommand command = new OleDbCommand(query, connect);
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    String fullName = reader.GetString(0);
                    String position = reader.GetString(1);
                    label9.Text = fullName;
                    label10.Text = position;
                    user = label9.Text;
                    pos = label10.Text;
                    loginmsg msg = new loginmsg();
                    msg.Show();
                    this.Hide();
                 
                }
                else
                {
                    panel3.Show();
                }
            }
        }
    }
      
    }
    

