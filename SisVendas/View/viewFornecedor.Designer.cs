namespace SisVendas.View
{
    partial class viewFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewFornecedor));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboCidade_cliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLimpar_cliente = new System.Windows.Forms.Button();
            this.btnCadastrar_cliente = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(112, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(526, 30);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(36, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "CNPJ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(112, 92);
            this.maskedTextBox1.Mask = " 00,000,000/0000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(191, 30);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(496, 92);
            this.maskedTextBox2.Mask = "(00)00000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(145, 30);
            this.maskedTextBox2.TabIndex = 18;
            this.maskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "TEL.";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(172, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(466, 30);
            this.textBox4.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.Location = new System.Drawing.Point(36, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "ENDEREÇO";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 258);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(513, 30);
            this.textBox2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.Location = new System.Drawing.Point(36, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "EMAIL";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(488, 203);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(150, 25);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "NOVA CIDADE";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.frmCidade);
            // 
            // comboCidade_cliente
            // 
            this.comboCidade_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCidade_cliente.FormattingEnabled = true;
            this.comboCidade_cliente.Location = new System.Drawing.Point(136, 200);
            this.comboCidade_cliente.Name = "comboCidade_cliente";
            this.comboCidade_cliente.Size = new System.Drawing.Size(337, 33);
            this.comboCidade_cliente.TabIndex = 22;
            this.comboCidade_cliente.Click += new System.EventHandler(this.atualizaCombobox);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "CIDADE";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(569, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 56);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.fechaForm);
            // 
            // btnLimpar_cliente
            // 
            this.btnLimpar_cliente.AutoSize = true;
            this.btnLimpar_cliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpar_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar_cliente.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar_cliente.Image")));
            this.btnLimpar_cliente.Location = new System.Drawing.Point(298, 328);
            this.btnLimpar_cliente.Name = "btnLimpar_cliente";
            this.btnLimpar_cliente.Size = new System.Drawing.Size(56, 56);
            this.btnLimpar_cliente.TabIndex = 25;
            this.btnLimpar_cliente.UseVisualStyleBackColor = true;
            this.btnLimpar_cliente.Click += new System.EventHandler(this.limparAbaFornecedor);
            // 
            // btnCadastrar_cliente
            // 
            this.btnCadastrar_cliente.AutoSize = true;
            this.btnCadastrar_cliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCadastrar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar_cliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar_cliente.Image")));
            this.btnCadastrar_cliente.Location = new System.Drawing.Point(57, 328);
            this.btnCadastrar_cliente.Name = "btnCadastrar_cliente";
            this.btnCadastrar_cliente.Size = new System.Drawing.Size(56, 56);
            this.btnCadastrar_cliente.TabIndex = 24;
            this.btnCadastrar_cliente.UseVisualStyleBackColor = true;
            this.btnCadastrar_cliente.Click += new System.EventHandler(this.cadastrarFornecedor);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(578, 385);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 25);
            this.label20.TabIndex = 29;
            this.label20.Text = "Sair";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(293, 387);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 25);
            this.label19.TabIndex = 28;
            this.label19.Text = "Limpar";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(56, 385);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 25);
            this.label18.TabIndex = 27;
            this.label18.Text = "Salvar";
            // 
            // viewFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 410);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLimpar_cliente);
            this.Controls.Add(this.btnCadastrar_cliente);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.comboCidade_cliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "viewFornecedor";
            this.Text = "FORNECEDOR";
            this.Load += new System.EventHandler(this.viewFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboCidade_cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLimpar_cliente;
        private System.Windows.Forms.Button btnCadastrar_cliente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
    }
}