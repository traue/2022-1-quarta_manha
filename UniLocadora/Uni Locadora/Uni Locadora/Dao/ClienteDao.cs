using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Uni_Locadora.Model;

namespace Uni_Locadora.Dao
{
    public class ClienteDao
    {
        public bool AdicionaCliente(Cliente cliente)
        {
            MySqlConnection conn = Conexao.GetConnection();

            try
            {
                //instrução de inserção no banco
                string query = "INSERT INTO cliente(nome, cpf, data_nasc) " +
                    "VALUES(@nome, @cpf, @dtNasc)";

                //abertura da conexão
                if(conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                //Cria um objeto do tipo "comando Mysql" com a instrução e a conexão
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //define os parâmetros da query:
                cmd.Parameters.Add(new MySqlParameter("@nome", cliente.Nome));
                cmd.Parameters.Add(new MySqlParameter("@cpf", cliente.Cpf));
                cmd.Parameters.Add(new MySqlParameter("@dtNasc", cliente.Nasc));

                //executa o comenado:
                cmd.ExecuteNonQuery();

                //fecha a conexão com o banco:
                conn.Close();

                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
