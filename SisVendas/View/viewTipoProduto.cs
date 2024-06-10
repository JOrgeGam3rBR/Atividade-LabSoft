using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SisVendas.Controller;
using SisVendas.Model;
using Npgsql;

namespace SisVendas.View
{
    public partial class viewTipoProduto : Form
    {        
        public viewTipoProduto()
        {
            InitializeComponent();          
        }

        private bool validaTipo()
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Preencha este campo");
                return false;
            }

            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private void novoTipo(object sender, EventArgs e)
        {
            modeloTipoProduto mTipoProduto = new modeloTipoProduto();
            controllerTipoProduto cTipoProduto = new controllerTipoProduto();
            if (validaTipo())
            {
                //armazenar os dados do FORM nos atributos
                mTipoProduto.NomeTipo = textBox1.Text.ToUpper();

                //envia os dados para o banco (método de cadastro)
                string res = cTipoProduto.novoTipo(mTipoProduto);

                MessageBox.Show(res);
            }
        }


        private void fechaForm(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void limpaCampos(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void viewTipoProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
