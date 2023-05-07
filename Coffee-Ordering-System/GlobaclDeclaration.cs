using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Coffee_Ordering_System
{
    internal class GlobaclDeclaration
    {
        public static OleDbCommand command;
        public static OleDbDataReader reader;
        public static int itemcode;
        public static int ORNO;
    }
}
