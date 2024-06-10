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
    public partial class viewCidade :Form
    {        
        public viewCidade()
        {
            InitializeComponent();          
        }
        private bool validaCidade()
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
        private void novaCidade(object sender, EventArgs e)
        {
            modeloCidade mCidade = new modeloCidade();
            controllerCidade cCidade = new controllerCidade();
            if (validaCidade())
            {
                //armazenar os dados do FORM nos atributos
                mCidade.NomeCidade = textBox1.Text.ToUpper();

                //envia os dados para o banco (método de cadastro)
                string res = cCidade.novaCidade(mCidade);

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

        private void viewCidade_Load(object sender, EventArgs e)
        {

        }
    }
}
