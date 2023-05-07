using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Ordering_System
{
    public partial class Menu :Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void NameLabel(object sender, EventArgs e)
        {
            
        }

        private void LabelName_Click(object sender, EventArgs e)
        {

            


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkLabel1.Enabled)
            {
                 Form1 f = new Form1();
                f.Show();
               this.Hide();
                 
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(pictureBox2.Enabled) 
            
            { 
                Form2 f = new Form2();
                f.Show();
                this.Hide();
                 
            }
        }
    }
}
