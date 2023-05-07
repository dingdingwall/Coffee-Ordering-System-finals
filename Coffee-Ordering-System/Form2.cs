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

namespace Coffee_Ordering_System
{
    public partial class Form2 : Form
    {
        private string sql;
      

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            try
            {
                //sql ="INSERT INTO stock(item.code.Description.Sprice.Reorderpt,Unit,Expirydate,Datemodifie,Stockonhand,Category)
                //values("+txt.ItemNo.Text+"," +txtdescription.Text+'"."'+txtsprice.Text+'" txtreorderpoint.Text+",+"txtunit.Text+'",'"+dpexpirydate.Text+'",'",'"+DateTime.Now.ToShortDateString()+'",'"+txtstockonhand.Text+","'+cbocategory.Text+'")";

                sql = "INSERT INTO stocks (itemcode,Description,Sprice,Reorderpt,Unit,Expirydate,Datemodified,Stockonhand,Category)" + "values(" + txtItemNo.Text + "," + txtdescription.Text + "," + txtsprice.Text + "," + txtreorderpoint.Text + "," + txtunit.Text + "," + "" + dpexpirydate.Value.Date +","  + DateTime.Now.ToShortDateString() + "," + txtstocksonhand.Text + "," + cbocategory.Text + "')";


                DBHelper.cs.DBHelper.ModifyRecord(sql);
                MessageBox.Show("Data has been added ...", "Save new stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2_Load(sender , e);
                clearfields();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sql = "Update stock SET Description   =" + txtdescription.Text + ", Sprice =" + txtsprice.Text + ", Reorder = " + txtreorderpoint.Text + ",Unit = " + txtunit.Text + ", Reorder = " + txtreorderpoint.Text + ",Expirydate  =" + dpexpirydate.Value.Date.ToShortDateString() + "Stockonhand =" + cbocategory.Text + "where Itemcode =" + txtItemNo.Text;
            DBHelper.cs.DBHelper.ModifyRecord(sql);
            MessageBox.Show("Data has been updated ...", "Update stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form2_Load(sender, e);
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete this record?", "Delete this Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (res == DialogResult.Yes) 
            
            {
                sql = "Delete * from stocks where itemcode =" + txtItemNo.Text + "";
                DBHelper.cs.DBHelper.ModifyRecord(sql);
                Form2_Load(sender, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemNo.Text = dgvStock[0,e.RowIndex].Value.ToString();
            txtdescription.Text = dgvStock[1, e.RowIndex].Value.ToString();
            txtsprice.Text = dgvStock[2, e.RowIndex].Value.ToString();
            txtreorderpoint.Text = dgvStock[3, e.RowIndex].Value.ToString();
           txtunit.Text = dgvStock[4, e.RowIndex].Value.ToString();
            dpexpirydate.Text = dgvStock[5, e.RowIndex].Value.ToString();
            txtstocksonhand.Text = dgvStock[6, e.RowIndex].Value.ToString();
            cbocategory.Text = dgvStock[7, e.RowIndex].Value.ToString();


        }

        public void clearfields()
        {
             txtItemNo.Clear();
            txtdescription.Clear(); 
            txtsprice.Clear();
            txtreorderpoint.Clear();    
            txtunit.Clear();
            dpexpirydate.Text = DateTime.Now.ToShortDateString();   
            txtstocksonhand.Clear();
            cbocategory.Text = "";
            txtdescription.Select();

        }
    }
}
