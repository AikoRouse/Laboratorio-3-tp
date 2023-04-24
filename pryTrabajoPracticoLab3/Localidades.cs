using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
namespace pryTrabajoPracticoLab3
{
    internal class Localidades
    {
        private OleDbConnection conn;
        private OleDbCommand cmd;
        private OleDbDataAdapter adap;  //declaro los oledb
        private DataTable tabla;
        private String Cadena = "";

        public void Localidad()
        {
            Cadena = "provider=microsoft.jet.oledb.4.0;data source=CLIMA.mdb";
            conn = new OleDbConnection(Cadena);
            cmd = new OleDbCommand();
            tabla = new DataTable();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.TableDirect;
            cmd.CommandText = "LOCALIDAD";

            adap = new OleDbDataAdapter(cmd);
            adap.Fill(tabla);
        }

        
    }
}
