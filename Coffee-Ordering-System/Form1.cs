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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Coffee_Ordering_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Connection.Connection.DB();
                DBHelper.cs.DBHelper.gen = "SELECT * from users where username = '" + textboxuser.Text + "' and password = '" + textBox1.Text + "'";
                DBHelper.cs.DBHelper.command = new OleDbCommand(DBHelper.cs.DBHelper.gen, Connection.Connection.conn);
                DBHelper.cs.DBHelper.reader = DBHelper.cs.DBHelper.command.ExecuteReader();


                if (DBHelper.cs.DBHelper.reader.HasRows)
                {

                    DBHelper.cs.DBHelper.reader.Read();

                    textboxuser.Text = (DBHelper.cs.DBHelper.reader["username"].ToString());
                   textBox1.Text = (DBHelper.cs.DBHelper.reader["password"].ToString());

                    timer1.Enabled = true;
                    timer1.Start();
                    timer1.Interval = 1;
                    progressBar1.Maximum = 200;
                    timer1.Tick += new EventHandler(timer1_Tick);
                }


                else
                {
                    MessageBox.Show("Invalid Username and Password");
                }
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show(ex.Message);
            }





        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 200)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                progressBar1.Value = 0;
                Menu f = new Menu();
                f.Show();
                this.Hide();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textboxpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
