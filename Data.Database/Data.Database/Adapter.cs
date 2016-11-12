using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {

        #region Propiedades
        private string conexion = "Server=localhost;Database=tp2_net;Uid=root;Pwd=;";
        private SqlConnection _sqlConn;

        public SqlConnection sqlConn
        {
            get { return _sqlConn; }
            set { _sqlConn = value; }
        }

        #endregion
  
        protected void OpenConnection()
        {            
            sqlConn = new SqlConnection(conexion);
            sqlConn.Open();           
            throw new Exception("Metodo no implementado");
        }

        protected void CloseConnection()
        {
            sqlConn.Close();
            sqlConn = null;
            throw new Exception("Metodo no implementado");
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }

       
    }
}
