using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Model
{
    class modeloProduto
    {
        private string codigoBarras;
        private string nomeProduto;
        private DateTime validade;
        private decimal precoCusto;
        private decimal precoVenda;
        private string descricao;
        private int quantidade;
        private int idTipo;
        private int idMarca;
        private string cnpj;

        public string CodigoBarras { get => codigoBarras; set => codigoBarras = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public DateTime Validade { get => validade; set => validade = value; }
        public decimal PrecoCusto { get => precoCusto; set => precoCusto = value; }
        public decimal PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
    }
}
