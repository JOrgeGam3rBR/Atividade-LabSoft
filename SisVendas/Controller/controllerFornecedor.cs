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
    class controllerFornecedor
    {
        public string cadastroFornecedor(modeloFornecedor mFornecedor)
        {
            string sql = "insert into fornecedor(cnpj, nomefornecedor, endereco, telefone," +
            " email, idcidade) " +
            "values(@cnpj, @nomefornecedor, @endereco, @telefone, @email, @idcidade)";

            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@cnpj", mFornecedor.Cnpj);
                comm.Parameters.AddWithValue("@nomefornecedor", mFornecedor.NomeFornecedor);
                comm.Parameters.AddWithValue("@endereco", mFornecedor.Endereco);
                comm.Parameters.AddWithValue("@telefone", mFornecedor.Telefone);
                comm.Parameters.AddWithValue("@email", mFornecedor.Email);
                comm.Parameters.AddWithValue("@idcidade", mFornecedor.IdCidade);

                comm.ExecuteNonQuery();
                return "Fornecedor cadastrado com sucesso!";
            }
            catch (NpgsqlException erro)
            {
                return erro.ToString();
                //return "Erro ao cadastrar Fornecedor!";
            }

        }

        public NpgsqlDataReader listaFornecedores()
        {
            string sql = "select * from fornecedor";

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
