using interativopdv.dao;
using interativopdv.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interativopdv.server
{
    internal class ServiceCategory
    {
        
        
        public bool insertCategoryDao(CategoryModel category)
        {
            
            ConexaoDb1 conexaoDb1 = new ConexaoDb1();
            bool conn = conexaoDb1.OpenConexao();
            try
            {
                if (conn == true)
                {
                    var command = new MySqlCommand("insert into category (name, company_id) values ( @name, @company );", conexaoDb1.GetConnection());
                    command.Parameters.AddWithValue("@name", category.Name);
                    command.Parameters.AddWithValue("@company", category.CompanyId);
                    command.ExecuteNonQuery();
                    // MessageBox.Show(" entrou no if do try da inserção ");
                }
                else
                {
                    Console.WriteLine(" conexção não foi bem sucedida!");

                   // MessageBox.Show(" entrou no else do try da inserção");
                }

                    return true;
            }

            catch (Exception ex)
            {
                // MessageBox.Show(" Entrou na Exeption da inserção");
                Console.WriteLine(" Entrou na Exeption" + ex.Message);
                return false;
            }
        }
    }
}
