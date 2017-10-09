using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
//Esta referencia se agrega para acceder a la variable connStreingLocal que esta en el App.Config dentro del Solution Items
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        //private SqlConnection sqlConnection = new SqlConnection("ConnectionString;");
        //Clave por defecto a utlizar para la cadena de conexion
        //const string consKeyDefaultCnnString = "ConnStringLocal";
        const string consKeyDefaultCnnString = "Server= localhost; Database = tp2_net; Trusted_Connection = True";
        public SqlConnection sqlConn
        { set; get; }
        protected void OpenConnection()
        {
            //string miConString = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            string miConString = "Server=localhost; Database = tp2_net; Trusted_Connection = True";
            sqlConn = new SqlConnection(miConString);
            sqlConn.Open();
        }

        protected void CloseConnection()
        {
            sqlConn.Close();
            sqlConn = null;
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
