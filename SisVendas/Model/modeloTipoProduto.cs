using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Model
{
    class modeloTipoProduto
    {
        private int idTipo;
        private string nomeTipo;

        public int IdTipo { get => idTipo; set => idTipo = value; }
        public string NomeTipo { get => nomeTipo; set => nomeTipo = value; }
    }
}
