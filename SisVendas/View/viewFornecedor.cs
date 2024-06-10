using Npgsql;
using SisVendas.Controller;
using SisVendas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace SisVendas.View
{
    public partial class viewFornecedor : Form
    {
        public viewFornecedor()
        {
            InitializeComponent();
            carregaCombobox();
        }

        private void frmCidade(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewCidade frmCidade = new viewCidade();
            frmCidade.ShowDialog();
        }

        private void atualizaCombobox(object sender, EventArgs e)
        {
            carregaCombobox();
        }
        private bool validaFornecedor()
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Preencha este campo");
                return false;
            }
            if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox2, "Preencha este campo");
                return false;
            }
            if (String.IsNullOrWhiteSpace(textBox4.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox4, "Preencha este campo");
                return false;
            }
            if (String.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(maskedTextBox1, "Preencha este campo"); ;
                return false;
            }
            if (String.IsNullOrWhiteSpace(maskedTextBox2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(maskedTextBox2, "Preencha este campo");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private void cadastrarFornecedor(object sender, EventArgs e)
        {
            modeloFornecedor mFornecedor = new modeloFornecedor();
            controllerFornecedor cFornecedor = new controllerFornecedor();
            if (validaFornecedor())
            {
                mFornecedor.Cnpj = maskedTextBox1.Text;
                mFornecedor.NomeFornecedor = textBox1.Text;
                mFornecedor.Email = textBox2.Text;
                mFornecedor.Endereco = textBox4.Text;
                mFornecedor.IdCidade = Convert.ToInt32(comboCidade_cliente.SelectedValue);
                mFornecedor.Telefone = maskedTextBox2.Text;

                string res = cFornecedor.cadastroFornecedor(mFornecedor);
                MessageBox.Show(res);
            }
        }


        private void limparAbaFornecedor(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
        }

        /* MÉTODOS DE CONFIGURAÇÃO DOS COMPONENTES DO FORM */

        private void carregaCombobox()
        {
            controllerCidade cCidade = new controllerCidade();

            /* NpgsqlDataReader - tipo de dado que armazena o resultado
             de consultas (SELECT) no banco de dados */
            NpgsqlDataReader dados = cCidade.listaCidade();

            //DataTable - armazena dados no formato de tabela
            DataTable cidade = new DataTable();

            //preenche o dataTable com os dados do DataReader
            cidade.Load(dados);

            comboCidade_cliente.DataSource = cidade;

            //DisplayMember - define qual coluna será exibida na combobox
            comboCidade_cliente.DisplayMember = "nomecidade";

            //ValueMember - define qual coluna será usada como valor válido na combobox 
            comboCidade_cliente.ValueMember = "idcidade";
        }

        private void viewFornecedor_Load(object sender, EventArgs e)
        {

        }


        private void fechaForm(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
