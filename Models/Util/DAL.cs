using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Financeiro.Util
{
    public class DAL
    {
        private static string server = "localhost" ;
        private static string database = "financeiro" ;
        private static string user = "root" ;
        private static string password = "123456" ;
        private string connectionString = $"Server={server};Database={database};Uid={user};Pwd={password}; SslMode=none";
        private MySqlConnection connection;

        public DAL()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        // retornando dados em formato tabela, execultando Select

        public DataTable RetDataTable(string sql)
        {
            DataTable dataTable = new DataTable();
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dataTable);
            return dataTable;   
           
        }
        // Execulta Insert, Deletes, Updates

        public void ExecultarComandosSQL(string sql)
        {

            MySqlCommand command = new MySqlCommand(sql,connection);
            command.ExecuteNonQuery();

        }


    }
}
