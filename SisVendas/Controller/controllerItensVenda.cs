using Npgsql;
using SisVenda.Controller;
using SisVendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVendas.Controller
{
    internal class controllerItensVenda
    {
        public string adicionaItensVenda(modeloItensVenda mItens)
        {
            string sql = "insert into itensvenda(idvenda, codigobarras, quantidade, valortotal) " +
                "values(@idvenda, @codigobarras, @quantidade, @valortotal);";

            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@idvenda", mItens.IdVenda);
                comm.Parameters.AddWithValue("@codigobarras", mItens.IdProduto);
                comm.Parameters.AddWithValue("@quantidade", mItens.Quantidade);
                comm.Parameters.AddWithValue("@valortotal", mItens.ValorTotal);

                comm.ExecuteNonQuery();
                return "Item adicionado!";
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro ao adicionar o item: " + ex.Message);
                return null;
            }
        }
    }

}
