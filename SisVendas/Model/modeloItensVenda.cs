using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Model
{
    class modeloItensVenda
    {
        private int idVenda;
        private string idProduto;
        private int quantidade;
        private decimal valorTotal;

        public int IdVenda { get => idVenda; set => idVenda = value; }
        public string IdProduto { get => idProduto; set => idProduto = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal ValorTotal { get => valorTotal; set => valorTotal = value; }
    }
}
