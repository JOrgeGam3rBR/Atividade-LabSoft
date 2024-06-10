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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SisVendas.View
{
    public partial class viewMarca :Form
    {        
        public viewMarca()
        {
            InitializeComponent();          
        }
        private bool validaMarca()
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


        private void novaMarca(object sender, EventArgs e)
        {
            modeloMarca mMarca = new modeloMarca();
            controllerMarca cMarca = new controllerMarca();
            if (validaMarca())
            {
                //armazenar os dados do FORM nos atributos
                mMarca.NomeMarca = textBox1.Text.ToUpper();

                //envia os dados para o banco (método de cadastro)
                string res = cMarca.novaMarca(mMarca);

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

        private void viewMarca_Load(object sender, EventArgs e)
        {
            
        }
    }
}
