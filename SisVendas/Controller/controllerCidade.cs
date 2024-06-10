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
    class controllerCidade
    {
        public string novaCidade (modeloCidade mCidade)
        {
            //string que recebe o código que será executado no servidor 
            string sql = "insert into cidade(nomecidade) values(@nomecidade)";

            //objeto da classe Connection que possui os métodos de conectar ao BD
            Connection conexao = new Connection();

            //objeto da classe NpgsqlConnection que mantém a conexão com o BD
            NpgsqlConnection conn = conexao.conectaPG();

            //objeto da classe NpgsqlCommand que executa comandos SQL no BD
            NpgsqlCommand comm = new NpgsqlCommand(sql, conn);

            try
            {
                //passagem de valores (parâmetros) para o BD
                comm.Parameters.AddWithValue("@nomecidade", mCidade.NomeCidade);

                //executar o comando SQL no BD
                comm.ExecuteNonQuery();
                return "Cidade cadastrada com sucesso!";

            }
            catch(NpgsqlException erro)
            {
                return erro.ToString(); //retorna o erro do banco
                //return "Erro ao cadastrar cidade!";
            }
        }

        public NpgsqlDataReader listaCidade()
        {
            string sql = "select * from cidade";            
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
