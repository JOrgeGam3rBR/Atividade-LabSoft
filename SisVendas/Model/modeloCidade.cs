using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVendas.Model
{
    class modeloCidade
    {
        private int idCidade;
        private string nomeCidade;

        #region IdCidade
        public int IdCidade
        {
            get => idCidade;
            set => idCidade = value;
        }
        #endregion

        #region NomeCidade
        public string NomeCidade
        {
            get => nomeCidade;
            set => nomeCidade = value;
        }
        #endregion
    }
}
