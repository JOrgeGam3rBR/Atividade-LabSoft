using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Model
{
    class modeloCliente
    {
        private long cpf;
        private string nomeCliente;
        private string rg;
        private DateTime nascimento;
        private string endereco;
        private string telefone;
        private int idCidade;

        public long Cpf { get => cpf; set => cpf = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string Rg { get => rg; set => rg = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public int IdCidade { get => idCidade; set => idCidade = value; }
    }
}
