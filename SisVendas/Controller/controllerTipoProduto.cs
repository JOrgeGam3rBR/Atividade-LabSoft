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
    class controllerTipoProduto
    {
        public string novoTipo(modeloTipoProduto mTipoProduto)
        {
            string sql = "insert into tipo(nometipo) values(@nometipo)";

            Connection conexao = new Connection();

            NpgsqlConnection conn = conexao.conectaPG();

            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@nometipo", mTipoProduto.NomeTipo);
                comm.ExecuteNonQuery();
                return "Tipo do Produto cadastrado com sucesso!";
            }
            catch (NpgsqlException erro)
            {
                /* return erro.ToString() //Retorna o erro do banco */
                return "Erro ao cadastrar Tipo do Produto!";
            }
        }

        public NpgsqlDataReader listaTipos()
        {
            string sql = "select * from tipo";

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
