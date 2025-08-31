using interativopdv.dao;
using interativopdv.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interativopdv.server
{
    internal class ServiceAtividadesColabroador
    {

        public List<FuncoesAtividadeColaboradorModel> Funcoes()
        {
            List<FuncoesAtividadeColaboradorModel> listaFuncoes = new List<FuncoesAtividadeColaboradorModel> ();

            ConexaoDb1 conexaoDb1 = new ConexaoDb1();
            bool conn = conexaoDb1.OpenConexao();

            try
            {
                if (conn == true)
                {
                    var command = new MySqlCommand("select * from funcoes_employee;", conexaoDb1.GetConnection());
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        FuncoesAtividadeColaboradorModel funcao = new FuncoesAtividadeColaboradorModel();
                        funcao.IdFuncoes = reader.GetInt32("idFuncoes");
                        funcao.Name = reader.GetString("Name");

                        listaFuncoes.Add(funcao);

                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(" erro  " + e.Message);

            }

            return listaFuncoes;

        }

    }
}
