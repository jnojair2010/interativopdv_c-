using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace interativopdv.dao
{
    internal class ConexaoDb1
    {
        string connectionString = "Server=localhost;Database=interativopdv;Uid=root;Pwd=Lwx5nk@Lwx5nk;";
        private static  MySqlConnection connection = new MySqlConnection();

        public bool OpenConexao()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                return false;
            }
        }

        public MySqlConnection GetConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                OpenConexao();
            }
            return connection;
        }



    }
}
