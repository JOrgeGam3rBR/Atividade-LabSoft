using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Model
{
    class modeloVenda
    {
        private int idVenda;
        private long cpfCliente;
        private DateTime dataVenda;
        private decimal totalVenda;

        public int IdVenda { get => idVenda; set => idVenda = value; }
        public long CpfCliente { get => cpfCliente; set => cpfCliente = value; }
        public DateTime DataVenda { get => dataVenda; set => dataVenda = value; }
        public decimal TotalVenda { get => totalVenda; set => totalVenda = value; }
    }
}
