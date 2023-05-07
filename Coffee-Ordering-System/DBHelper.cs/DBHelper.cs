using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Ordering_System.DBHelper.cs
{
 
    
        class DBHelper
        {
            public static string gen = "";
            public static OleDbConnection conn= null;
            public static OleDbCommand command;
            public static OleDbDataReader reader;

            public static void fill(string q, DataGridView dgv)
            {
                try
                {
                    Connection.Connection.DB();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter data = null;

                    data = new OleDbDataAdapter(command);
                    data.Fill(dt);
                    Connection.Connection.conn.Close();
                }
                catch (Exception ex)
                {

                    Connection.Connection.conn.Close();
                    MessageBox.Show(ex.Message, "Error FillDataGridView", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            public static void ModifyRecord(string updates)
            {
                try
                {
                    Connection.Connection.DB();
                    OleDbCommand command = new OleDbCommand(updates, Connection.Connection.conn);
                    command.ExecuteNonQuery();
                    Connection.Connection.conn.Close();
                }
                catch (Exception ex)
                {

                    Connection.Connection.conn.Close();
                    MessageBox.Show("Error --->" + updates + ex.Message);
                }
            }
        }
    }
