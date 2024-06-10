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
    internal class controllerVenda
    {
        public NpgsqlDataReader novaVenda(modeloVenda mVenda)
        {
            string sql = "INSERT INTO venda (cpfCliente, dataVenda, totalVenda) " +
                         "VALUES(@cpfCliente, @dataVenda, @totalVenda) " +
                         "RETURNING idVenda";

            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@cpfcliente", mVenda.CpfCliente);
                comm.Parameters.AddWithValue("@datavenda", mVenda.DataVenda);
                comm.Parameters.AddWithValue("@totalvenda", 0); // Valor inicial padrão

                return comm.ExecuteReader();
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro ao inserir a venda: " + erro.Message);
                return null;
            }
        }

        public string atualizaTotalVenda(modeloVenda mVenda)
        {
            string sql = "UPDATE venda SET totalvenda = @totalvenda WHERE idvenda = @idvenda;";

            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@idvenda", mVenda.IdVenda);
                comm.Parameters.AddWithValue("@totalvenda", mVenda.TotalVenda);
                comm.ExecuteReader();
                return "Venda finalizada!";
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro ao atualizar a venda: " + ex.Message);
                return null;
            }
        }
    }
}

