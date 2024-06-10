using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SisVendas.Model;
using SisVendas.View;
using SisVendas.Controller;
using Npgsql;


namespace SisVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void carregaPrincipal(object sender, EventArgs e)
        {
            //evento load do form 1
            carregaComboboxCidade();
            carregaComboboxTipoProduto();
            carregaComboboxMarca();
            carregaComboboxFornecedor();
        }

        private void novoProduto(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            abaNovoProduto.Parent = tabControl1;
            tabControl1.SelectedTab = abaNovoProduto;

            abaNovoCliente.Parent = null;
            abaNovaVenda.Parent = null;
            abaBuscaCliente.Parent = null;
            abaBuscaProduto.Parent = null;
            abaListarVendas.Parent = null;
        }

        private void novoCliente(object sender, EventArgs e)
        {
            errorProvider1.Clear(); //remove os erros para um novo cadastro 

            tabControl1.Visible = true; //deixa visível um tabControl

            abaNovoCliente.Parent = tabControl1; //vincula um tabPage a um tabControl
            tabControl1.SelectedTab = abaNovoCliente; //seleciona uma aba para uso

            abaNovoProduto.Parent = null; //desvincula um tabPage de um tabControl
            abaNovaVenda.Parent = null;
            abaBuscaCliente.Parent = null;
            abaBuscaProduto.Parent = null;
            abaListarVendas.Parent = null;
        }

        private void frmCidade(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewCidade frmCidade = new viewCidade();
            frmCidade.ShowDialog();
        }

        private void atualizaCombobox(object sender, EventArgs e)
        {
            carregaComboboxCidade();
        }

        private void novaVenda(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            abaBuscaCliente.Parent = tabControl1;
            abaBuscaProduto.Parent = tabControl1;
            abaNovaVenda.Parent = tabControl1;
            tabControl1.SelectedTab = abaNovaVenda;

            abaNovoCliente.Parent = null;
            abaNovoProduto.Parent = null;
            abaListarVendas.Parent = null;
        }

        private void fechaNovoCliente_btnSair(object sender, EventArgs e)
        {
            abaNovoCliente.Parent = null;
            tabControl1.SelectedTab = null;
            tabControl1.Visible = false;
        }

        private void cadastrarCliente(object sender, EventArgs e)
        {
            modeloCliente mCliente = new modeloCliente();
            controllerCliente cCliente = new controllerCliente();

            if (validaCliente())
            {
                mCliente.Cpf = Convert.ToInt64(maskedTextBox1.Text);
                mCliente.NomeCliente = textBox1.Text;
                mCliente.Rg = textBox3.Text;
                mCliente.Endereco = textBox4.Text;
                mCliente.IdCidade = Convert.ToInt32(comboCidade_cliente.SelectedValue);
                mCliente.Nascimento = dateTimePicker1.Value;
                mCliente.Telefone = maskedTextBox2.Text;

                string res = cCliente.cadastroCliente(mCliente);
                MessageBox.Show(res);
            }


        }

        private void limparAbaCliente(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
        }

        /* MÉTODOS DE CONFIGURAÇÃO DOS COMPONENTES DO FORM */

        private void carregaComboboxCidade()
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

        private void carregaComboboxTipoProduto()
        {
            controllerTipoProduto cTipoProduto = new controllerTipoProduto();

            /* NpgsqlDataReader - tipo de dado que armazena o resultado
             de consultas (SELECT) no banco de dados */
            NpgsqlDataReader dados = cTipoProduto.listaTipos();

            //DataTable - armazena dados no formato de tabela
            DataTable tipo = new DataTable();

            //preenche o dataTable com os dados do DataReader
            tipo.Load(dados);

            comboTipo_Produto.DataSource = tipo;

            //DisplayMember - define qual coluna será exibida na combobox
            comboTipo_Produto.DisplayMember = "nometipo";

            //ValueMember - define qual coluna será usada como valor válido na combobox 
            comboTipo_Produto.ValueMember = "idtipo";
        }

        private void carregaComboboxMarca()
        {
            controllerMarca cMarca = new controllerMarca();

            /* NpgsqlDataReader - tipo de dado que armazena o resultado
             de consultas (SELECT) no banco de dados */
            NpgsqlDataReader dados = cMarca.listaMarcas();

            //DataTable - armazena dados no formato de tabela
            DataTable marca = new DataTable();

            //preenche o dataTable com os dados do DataReader
            marca.Load(dados);

            comboMarca_Produto.DataSource = marca;

            //DisplayMember - define qual coluna será exibida na combobox
            comboMarca_Produto.DisplayMember = "nomemarca";

            //ValueMember - define qual coluna será usada como valor válido na combobox 
            comboMarca_Produto.ValueMember = "idmarca";
        }

        private void carregaComboboxFornecedor()
        {
            controllerFornecedor cFornecedor = new controllerFornecedor();

            /* NpgsqlDataReader - tipo de dado que armazena o resultado
             de consultas (SELECT) no banco de dados */
            NpgsqlDataReader dados = cFornecedor.listaFornecedores();

            //DataTable - armazena dados no formato de tabela
            DataTable fornecedor = new DataTable();

            //preenche o dataTable com os dados do DataReader
            fornecedor.Load(dados);

            comboFornecedor_Produto.DataSource = fornecedor;

            //DisplayMember - define qual coluna será exibida na combobox
            comboFornecedor_Produto.DisplayMember = "nomefornecedor";

            //ValueMember - define qual coluna será usada como valor válido na combobox 
            comboFornecedor_Produto.ValueMember = "cnpj";
        }

        private bool validaCliente()
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox1, "Preencha este campo");
                return false;
            }
            if (String.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(maskedTextBox1, "Preencha este campo");
                return false;
            }
            if (String.IsNullOrWhiteSpace(textBox3.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox3, "Preencha este campo");
                return false;
            }
            if (String.IsNullOrWhiteSpace(textBox4.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox4, "Preencha este campo"); ;
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

        private void frmTipoProduto(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewTipoProduto frmTipoProduto = new viewTipoProduto();
            frmTipoProduto.ShowDialog();
        }

        private void frmMarca(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewMarca frmMarca = new viewMarca();
            frmMarca.ShowDialog();
        }

        private void frmFornecedor(object sender, LinkLabelLinkClickedEventArgs e)
        {
            viewFornecedor frmFornecedor = new viewFornecedor();
            frmFornecedor.ShowDialog();
        }

        private void atualizaComboboxTipo(object sender, EventArgs e)
        {
            carregaComboboxTipoProduto();
        }

        private void atualizaComboboxMarca(object sender, EventArgs e)
        {
            carregaComboboxMarca();
        }

        private void atualizaComboboxFornecedor(object sender, EventArgs e)
        {
            carregaComboboxFornecedor();
        }

        private void cadastrarProduto(object sender, EventArgs e)
        {
            modeloProduto mProduto = new modeloProduto();
            controllerProduto cProduto = new controllerProduto();

            if (validaProduto())
            {
                mProduto.CodigoBarras = textBox2.Text;
                mProduto.NomeProduto = textBox5.Text;
                mProduto.Validade = dateTimePicker2.Value;
                mProduto.PrecoCusto = Convert.ToDecimal(textBox6.Text);
                mProduto.PrecoVenda = Convert.ToDecimal(textBox7.Text);
                mProduto.Descricao = textBox9.Text;
                mProduto.Quantidade = Convert.ToInt32(textBox8.Text);
                mProduto.IdTipo = Convert.ToInt32(comboTipo_Produto.SelectedValue);
                mProduto.IdMarca = Convert.ToInt32(comboMarca_Produto.SelectedValue);
                mProduto.Cnpj = Convert.ToString(comboFornecedor_Produto.SelectedValue);
                string res = cProduto.cadastroProduto(mProduto);
                MessageBox.Show(res);
            }

        }

        private bool validaProduto()
        {
            if (String.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox2, "Preencha este campo");
                return false;
            }
            if (String.IsNullOrWhiteSpace(textBox5.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox5, "Preencha este campo");
                return false;
            }
            if (String.IsNullOrWhiteSpace(textBox6.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox6, "Preencha este campo");
                return false;
            }
            if (String.IsNullOrWhiteSpace(textBox7.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox7, "Preencha este campo"); ;
                return false;
            }
            if (String.IsNullOrWhiteSpace(textBox8.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox8, "Preencha este campo");
                return false;
            }
            if (String.IsNullOrWhiteSpace(textBox9.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox9, "Preencha este campo");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }


        private void limparAbaProduto(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            maskedTextBox2.Text = "";
        }

        private void fechaNovoProduto_btnSair(object sender, EventArgs e)
        {
            abaNovoProduto.Parent = null;
            tabControl1.SelectedTab = null;
            tabControl1.Visible = false;
        }

        private void fechaTudo_btnHome(object sender, EventArgs e)
        {

            tabControl1.SelectedTab = null;
            tabControl1.Visible = false;
        }

        private void abaNovoProduto_Click(object sender, EventArgs e)
        {

        }

        private void abaNovoCliente_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void consultaCliente(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            abaBuscaCliente.Parent = tabControl1;
            tabControl1.SelectedTab = abaBuscaCliente;

            abaNovoCliente.Parent = null;
            abaNovoProduto.Parent = null;
            abaNovaVenda.Parent = null;
            abaBuscaProduto.Parent = null;
            abaListarVendas.Parent = null;
        }

        private void consultaProduto(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            abaBuscaProduto.Parent = tabControl1;
            tabControl1.SelectedTab = abaBuscaProduto;

            abaNovoCliente.Parent = null;
            abaNovoProduto.Parent = null;
            abaNovaVenda.Parent = null;
            abaBuscaCliente.Parent = null;
            abaListarVendas.Parent = null;
        }

        private void buscaCliente(object sender, EventArgs e)
        {

            modeloCliente mCliente = new modeloCliente();
            controllerCliente cCliente = new controllerCliente();
            NpgsqlDataReader cliente;

            if (!String.IsNullOrWhiteSpace(textBoxPesquisaCliente.Text))
            {

                if (radioNomeCliente.Checked)
                {

                    mCliente.NomeCliente = textBoxPesquisaCliente.Text + "%";
                    cliente = cCliente.pesquisaClientePorNome(mCliente);
                    gridCliente(cliente);


                }
                else if (radioClienteCPF.Checked)
                {
                    if (textBoxPesquisaCliente.Text.Length == 11)
                    {
                        mCliente.Cpf = long.Parse(textBoxPesquisaCliente.Text);
                        cliente = cCliente.pesquisaClientePorCPF(mCliente);
                        gridCliente(cliente);
                    }
                    else
                    {
                        cliente = null;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("compo esta errado");

                }


            }
        }

        private void gridCliente(NpgsqlDataReader dados)
        {

            {
                //apara as colunas da tabela
                dataGridView1.Columns.Clear();

                // define a quantidade de coluna da grid = DataReader
                dataGridView1.ColumnCount = dados.FieldCount;

                //definir os nomes da colunas da grid
                for (int i = 0; i < dados.FieldCount; i++)
                {
                    dataGridView1.Columns[i].Name = dados.GetName(i);
                }

                string[] linha = new string[dados.FieldCount];

                while (dados.Read())
                {
                    for (int i = 0; i < dados.FieldCount; i++)
                    {
                        linha[i] = dados.GetValue(i).ToString();
                    }
                    dataGridView1.Rows.Add(linha);

                }
            }
        }

        private void maskNomeCliente(object sender, EventArgs e)
        {
            textBoxPesquisaCliente.Mask = null;
        }

        private void maskCpfCliente(object sender, EventArgs e)
        {
            textBoxPesquisaCliente.Mask = "000,000,000,-00";
        }

        private void buscaProduto(object sender, EventArgs e)
        {
            /* Executa pesquisa de produto*/

            modeloProduto mProduto = new modeloProduto();
            controllerProduto cProduto = new controllerProduto();
            NpgsqlDataReader produto;

            if (!String.IsNullOrWhiteSpace(textBoxPesquisaProduto.Text))
            {
                if (radioNomeProduto.Checked)
                {
                    mProduto.NomeProduto = textBoxPesquisaProduto.Text + "%";
                    produto = cProduto.pesquisarProdutoNome(mProduto);
                    gridProduto(produto);
                }
                else if (radioProdutoBarras.Checked)
                {
                    if (textBoxPesquisaProduto.Text.Length == 13)
                    {
                        mProduto.CodigoBarras = textBoxPesquisaProduto.Text;
                        produto = cProduto.pesquisarProdutoCodigo(mProduto);
                        gridProduto(produto);
                    }
                }
                else
                {
                    produto = null;
                    MessageBox.Show("Não foi possível realizar a consulta");
                }
            }
        }

        private void gridProduto(NpgsqlDataReader produto)
        {
            //apaga as colunas do datagrid
            dataGridView2.Columns.Clear();

            //define a quantidade da coluna da grid igual ao da dataReader
            dataGridView2.ColumnCount = produto.FieldCount; //propriedade do dataReader que conta quantas colunas o banco devolveu/a consulta retornou

            //definir os nomes das colunas da grid
            for (int i = 0; i < produto.FieldCount; i++)
            {
                dataGridView2.Columns[i].Name = produto.GetName(i);
            }

            string[] linha = new string[produto.FieldCount];

            while (produto.Read())
            {
                for (int i = 0; i < produto.FieldCount; i++)
                {
                    linha[i] = produto.GetValue(i).ToString();
                }

                dataGridView2.Rows.Add(linha);
            }
        }
        private void maskNomeProduto(object sender, EventArgs e)
        {
            textBoxPesquisaProduto.Mask = null;
        }

        private void gridProdutoVenda(NpgsqlDataReader produto)
        {
            //apaga as colunas do datagrid
            dataGridView3.Columns.Clear();

            //define a quantidade da coluna da grid igual ao da dataReader
            dataGridView3.ColumnCount = produto.FieldCount; //propriedade do dataReader que conta quantas colunas o banco devolveu/a consulta retornou

            //definir os nomes das colunas da grid
            for (int i = 0; i < produto.FieldCount; i++)
            {
                dataGridView3.Columns[i].Name = produto.GetName(i);
            }

            string[] linha = new string[produto.FieldCount];

            while (produto.Read())
            {
                for (int i = 0; i < produto.FieldCount; i++)
                {
                    linha[i] = produto.GetValue(i).ToString();
                }

                dataGridView3.Rows.Add(linha);
            }
        }

        private void maskCodigoProduto(object sender, EventArgs e)
        {
            textBoxPesquisaProduto.Mask = "0000000000000";
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void buscaCPFCliente(object sender, KeyPressEventArgs e)
        {
            modeloCliente mCliente = new modeloCliente();
            controllerCliente cCliente = new controllerCliente();
            NpgsqlDataReader cliente;

            if (maskedTextBox3.Text.Length == 11)
            {
                if (e.KeyChar == 13)
                {
                    mCliente.Cpf = long.Parse(maskedTextBox3.Text);
                    cliente = cCliente.pesquisaClientePorCPF(mCliente);

                    if (!cliente.HasRows)
                    {
                        MessageBox.Show("Cliente Não Encontrado!");

                    }
                    else
                    {
                        while (cliente.Read())
                        {
                            txbClienteVenda.Text = cliente.GetValue(0).ToString();

                        }
                    }


                }
            }
        }

        private void buscaProdutoVenda(object sender, KeyPressEventArgs e)
        {
            modeloProduto mProduto = new modeloProduto();
            controllerProduto cProduto = new controllerProduto();
            NpgsqlDataReader produto;

            if (e.KeyChar == 13)
            {
                if (radioButton1.Checked)
                {
                    mProduto.CodigoBarras = maskedTextBox4.Text;
                    mProduto.NomeProduto = null;
                    produto = cProduto.pesquisarProdutoVendaCodigo(mProduto);
                } else
                {
                    mProduto.NomeProduto = maskedTextBox4.Text + "%";
                    mProduto.CodigoBarras = null;
                    produto = cProduto.pesquisarProdutoVendaNome(mProduto);
                }

                if (!produto.HasRows)
                {
                    MessageBox.Show("Produto Não ENcontardo");
                } else
                {
                    gridProdutoVenda(produto);
                }
                
            }
        }
        


        decimal preco = 0, total = 0;
        int quantidade = 0, novaQuantidade = 0;

        private void selecionarLinha(object sender, DataGridViewCellEventArgs e)
        {
            quantidade = Convert.ToInt32(dataGridView5.CurrentRow.Cells[3].Value);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void RemoverItem(object sender, EventArgs e)
        {
            if (dataGridView5.RowCount > 0)
            {
                DialogResult confirm = MessageBox.Show("Remover item",
                    "Deseja remover este item?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    novaQuantidade = Convert.ToInt32(dataGridView5.CurrentRow.Cells[3].Value);
                    preco = decimal.Parse(dataGridView5.CurrentRow.Cells[2].Value.ToString());

                    total = total - (novaQuantidade * preco);
                    lbTotalItens.Text = total.ToString();
                    lbTotalVenda.Text = total.ToString();
                    dataGridView5.Rows.Remove(dataGridView5.CurrentRow);
                }
            }
        }

        private void CalcularDesconto(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                total = decimal.Parse(lbTotalItens.Text);
                decimal desc = decimal.Parse(txbDesc.Text) / 100;
                decimal totalVenda = total - (total * desc);
                lbTotalVenda.Text = totalVenda.ToString();

            }
        }

        private void AtualizarTotal(object sender, DataGridViewCellEventArgs e)
        {
            novaQuantidade = Convert.ToInt32(dataGridView5.CurrentRow.Cells[3].Value);
            preco = decimal.Parse(dataGridView5.CurrentRow.Cells[2].Value.ToString());

            if(novaQuantidade > 0)
            {
                if (novaQuantidade > quantidade)
                {
                    total += ((novaQuantidade - quantidade) * preco);
                }
                if (novaQuantidade < quantidade)
                {
                    total -= ((quantidade - novaQuantidade) * preco);
                }

                quantidade = novaQuantidade;
                lbTotalItens.Text = total.ToString();
                lbTotalVenda.Text = total.ToString();
            } else
            {
                dataGridView5.CurrentRow.Cells[3].Value = quantidade.ToString();
            }
            novaQuantidade = 0;
        }

        private void addItensVendas(object sender, DataGridViewCellEventArgs e)
        {
            /*Calcula iten venda*/
            string[] produto = new string[4];
            produto[0] = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            produto[1] = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            produto[2] = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            produto[3] = "1";

            /*calcula e atualiza o total*/
            preco = decimal.Parse(produto[2]);
            quantidade = Convert.ToInt32(produto[3]);
            total = decimal.Parse(lbTotalItens.Text) + (preco * quantidade);

            dataGridView5.Rows.Add(produto);
            lbTotalItens.Text = total.ToString();
            lbTotalVenda.Text = total.ToString();
        }

        
        private void abaNovaVenda_Click(object sender, EventArgs e)
        {

        }

        private void insertItensVenda(object sender, EventArgs e)
        {
            modeloVenda mVenda = new modeloVenda();
            controllerVenda cVenda = new controllerVenda();

            modeloItensVenda mItens = new modeloItensVenda();
            controllerItensVenda cItens = new controllerItensVenda();

            if (!String.IsNullOrEmpty(txbClienteVenda.Text))
            {
                if (dataGridView5.Rows.Count > 0)
                {
                    /*dados do cliente e data da venda*/
                    mVenda.CpfCliente = long.Parse(maskedTextBox3.Text);
                    mVenda.DataVenda = DateTime.Now;

                    /*insere uma nova venda*/
                    NpgsqlDataReader venda = cVenda.novaVenda(mVenda);

                    /*verifica se a venda não é nula*//**/
                    if (venda != null && venda.Read())
                    {
                        mItens.IdVenda = Convert.ToInt32(venda.GetValue(0));
                        /*MessageBox.Show(mItens.IdVenda.ToString());*/

                        /*percorre a grid de itens e insere no banco*/
                        for (int l = 0; l < dataGridView5.RowCount; l++)
                        {
                            var idProduto = dataGridView5.Rows[l].Cells[0].Value;
                            var quantidade = dataGridView5.Rows[l].Cells[3].Value;
                            var valorUnitario = dataGridView5.Rows[l].Cells[2].Value;

                            /* Verifica se os valores não são nulos */
                            if (idProduto != null && quantidade != null && valorUnitario != null)
                            {
                                mItens.IdProduto = idProduto.ToString();
                                mItens.Quantidade = Convert.ToInt32(quantidade);
                                mItens.ValorTotal = mItens.Quantidade * decimal.Parse(valorUnitario.ToString());

                                cItens.adicionaItensVenda(mItens);
                        /* MessageBox.Show(cItens.adicionaItensVenda(mItens));*/
                    }
                            else
                            {
                                MessageBox.Show("Dados do item inválidos.");
                            }
                        }

                        mVenda.IdVenda = mItens.IdVenda;
                        mVenda.TotalVenda = decimal.Parse(lbTotalVenda.Text);
                        MessageBox.Show(cVenda.atualizaTotalVenda(mVenda));
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir a venda.");
                    }
                }
                else
                {
                    MessageBox.Show("Não há itens na venda!");
                }
            }
            else
            {
                MessageBox.Show("Nenhum cliente foi selecionado!");
            }
        }


    }
}


