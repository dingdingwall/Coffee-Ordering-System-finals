using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Ordering_System
{
    internal class GetData
    {

        public static void getMaxItem()
        {

            try
            {

                string sql = "Select MAX(itemcode) from stock";
                Connection.Connection.DB();
                GlobaclDeclaration.command = new OleDbCommand(sql, Connection.Connection.conn);
                GlobaclDeclaration.reader = GlobaclDeclaration.command.ExecuteReader();
                if (GlobaclDeclaration.reader.Read())
                {

                    sql = GlobaclDeclaration.reader[0].ToString();

                    if (sql == "")
                    {

                        GlobaclDeclaration.itemcode = 1;
                    }
                    else
                    {

                        GlobaclDeclaration.itemcode = Convert.ToInt32(GlobaclDeclaration.reader[0].ToString()) + 1;
                    }
                    GlobaclDeclaration.reader.Close();
                }
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show("Error -----> GET MAX ID" + ex.Message);

            }
        }

            public static void getMaxORNO()
            {

            try
            {

                string sql = "Select MAX(orno) from sales_master";
                Connection.Connection.DB();
                GlobaclDeclaration.command = new OleDbCommand(sql, Connection.Connection.conn);
                GlobaclDeclaration.reader = GlobaclDeclaration.command.ExecuteReader();

                if (GlobaclDeclaration.reader.Read())
                {

                    if (sql == "")
                    {

                        GlobaclDeclaration.ORNO = 10001;
                    }
                    else
                    {

                        GlobaclDeclaration.ORNO = Convert.ToInt32(GlobaclDeclaration.reader[0].ToString()) + 1;
                    }
                    GlobaclDeclaration.reader.Close();

                }
                Connection.Connection.conn.Close();
            }


            catch (Exception ex)
            {
                 Connection.Connection.conn.Close();
                MessageBox.Show("Error ---->GET MAX ORNO " + ex.Message);
            }

        }
    }
}
