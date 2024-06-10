using Npgsql;
using SisVenda.Controller;
using SisVendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Controller
{
    internal class controllerMarca
    {
        public string novaMarca(modeloMarca mMarca)
        {
            string sql = "insert into marca(nomemarca) values(@nomemarca)";

            Connection conexao = new Connection();

            NpgsqlConnection conn = conexao.conectaPG();

            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@nomemarca", mMarca.NomeMarca);
                comm.ExecuteNonQuery();
                return "Marca cadastrada com sucesso!";
            }
            catch (NpgsqlException erro)
            {
                /* return erro.ToString() //Retorna o erro do banco */
                return "Erro ao cadastrar Marca!";
            }
        }

        public NpgsqlDataReader listaMarcas()
        {
            string sql = "select * from marca";

            Connection conexao = new Connection();

            NpgsqlConnection conn = conexao.conectaPG();

            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                return comm.ExecuteReader();
            }
            catch (NpgsqlException erro)
            {
                return null;
            }
        }
    }
}
