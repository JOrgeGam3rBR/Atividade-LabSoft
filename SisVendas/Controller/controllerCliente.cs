using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SisVendas.Model;
using Npgsql;
using SisVendas.Controller;
using SisVenda.Controller;

namespace SisVendas.Controller
{
    class controllerCliente
    {
        public string cadastroCliente(modeloCliente mCliente)
        {
            string sql = "insert into cliente(cpf, nomecliente, rg, nascimento," +
            " endereco, telefone, idcidade) " +
            "values(@cpf, @nomecliente, @rg, @nascimento, @endereco, @telefone, @idcidade)";

            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();      
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {                
                comm.Parameters.AddWithValue("@cpf", mCliente.Cpf);
                comm.Parameters.AddWithValue("@nomecliente", mCliente.NomeCliente);
                comm.Parameters.AddWithValue("@rg", mCliente.Rg);
                comm.Parameters.AddWithValue("@nascimento", mCliente.Nascimento);
                comm.Parameters.AddWithValue("@endereco", mCliente.Endereco);
                comm.Parameters.AddWithValue("@telefone", mCliente.Telefone);
                comm.Parameters.AddWithValue("@idcidade", mCliente.IdCidade);

                comm.ExecuteNonQuery();
                return "Cliente cadastrado com sucesso!";
            }
            catch (NpgsqlException erro)
            {
                return erro.ToString(); 
                //return "Erro ao cadastrar cliente!";
            }


        }

        public NpgsqlDataReader pesquisaClientePorNome(modeloCliente mCliente)
        {
            string sql = "SELECT cliente.nomecliente, cliente.cpf, cliente.rg, cliente.nascimento, cliente.endereco, cliente.telefone, " +
                "cidade.nomecidade FROM cliente INNER JOIN cidade ON cliente.idcidade = cidade.idcidade WHERE cliente.nomecliente LIKE @nomecliente";

            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@nomecliente", mCliente.NomeCliente);
                return comm.ExecuteReader();
            }
            catch (NpgsqlException erro)
            {
                return null;
            }
        }
        public NpgsqlDataReader pesquisaClientePorCPF(modeloCliente mCliente)

        {
            string sql = "SELECT cliente.nomecliente, cliente.cpf, cliente.rg, cliente.nascimento, cliente.endereco, cliente.telefone, " +
                "cidade.nomecidade FROM cliente INNER JOIN cidade ON cliente.idcidade = cidade.idcidade WHERE cliente.cpf = @cpf"; 

            Connection conexao = new Connection();
            NpgsqlConnection conn = conexao.conectaPG();
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                comm.Parameters.AddWithValue("@cpf", mCliente.Cpf);

                return comm.ExecuteReader();
            }
            catch (NpgsqlException erro)
            {
                return null;
            }
        }
    }
}
