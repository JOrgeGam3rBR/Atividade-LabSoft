using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Model
{
    class modeloFornecedor
    {
        private string cnpj;
        private string nomeFornecedor;
        private string endereco;
        private string telefone;
        private string email;
        private int idCidade;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string NomeFornecedor { get => nomeFornecedor; set => nomeFornecedor = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public int IdCidade { get => idCidade; set => idCidade = value; }
    }
}
