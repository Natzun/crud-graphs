namespace CRUD_GRAPHS.Cadastros {
    partial class CadastroClientes {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroClientes));
            this.labelNome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.textDocumento = new System.Windows.Forms.TextBox();
            this.labelEndeco = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.textComplemento = new System.Windows.Forms.TextBox();
            this.labelCep = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelUf = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.labelTel1 = new System.Windows.Forms.Label();
            this.labelTel2 = new System.Windows.Forms.Label();
            this.maskedTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedCep = new System.Windows.Forms.MaskedTextBox();
            this.labelDataCadastro = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.labelMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(24, 20);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(26, 38);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(414, 23);
            this.textNome.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(455, 20);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 15);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            this.labelID.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(455, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(26, 64);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(30, 15);
            this.labelTipo.TabIndex = 4;
            this.labelTipo.Text = "Tipo";
            this.labelTipo.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica"});
            this.comboBoxTipo.Location = new System.Drawing.Point(26, 82);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(169, 23);
            this.comboBoxTipo.TabIndex = 5;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.Location = new System.Drawing.Point(210, 64);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(60, 15);
            this.labelDocumento.TabIndex = 6;
            this.labelDocumento.Text = "CPF/CNPJ";
            // 
            // textDocumento
            // 
            this.textDocumento.Location = new System.Drawing.Point(210, 82);
            this.textDocumento.Name = "textDocumento";
            this.textDocumento.Size = new System.Drawing.Size(230, 23);
            this.textDocumento.TabIndex = 7;
            // 
            // labelEndeco
            // 
            this.labelEndeco.AutoSize = true;
            this.labelEndeco.Location = new System.Drawing.Point(26, 181);
            this.labelEndeco.Name = "labelEndeco";
            this.labelEndeco.Size = new System.Drawing.Size(56, 15);
            this.labelEndeco.TabIndex = 8;
            this.labelEndeco.Text = "Endereço";
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(26, 199);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(414, 23);
            this.textEndereco.TabIndex = 9;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(455, 181);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(21, 15);
            this.labelNumero.TabIndex = 10;
            this.labelNumero.Text = "Nº";
            this.labelNumero.Click += new System.EventHandler(this.label6_Click);
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(455, 199);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(85, 23);
            this.textNumero.TabIndex = 11;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(26, 225);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(84, 15);
            this.labelComplemento.TabIndex = 12;
            this.labelComplemento.Text = "Complemento";
            // 
            // textComplemento
            // 
            this.textComplemento.Location = new System.Drawing.Point(26, 243);
            this.textComplemento.Name = "textComplemento";
            this.textComplemento.Size = new System.Drawing.Size(375, 23);
            this.textComplemento.TabIndex = 13;
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(407, 225);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(28, 15);
            this.labelCep.TabIndex = 14;
            this.labelCep.Text = "CEP";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(26, 269);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(38, 15);
            this.labelBairro.TabIndex = 16;
            this.labelBairro.Text = "Bairro";
            // 
            // textBairro
            // 
            this.textBairro.Location = new System.Drawing.Point(26, 287);
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(169, 23);
            this.textBairro.TabIndex = 17;
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(210, 287);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(191, 23);
            this.textCidade.TabIndex = 18;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(210, 269);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(44, 15);
            this.labelCidade.TabIndex = 19;
            this.labelCidade.Text = "Cidade";
            // 
            // labelUf
            // 
            this.labelUf.AutoSize = true;
            this.labelUf.Location = new System.Drawing.Point(414, 269);
            this.labelUf.Name = "labelUf";
            this.labelUf.Size = new System.Drawing.Size(21, 15);
            this.labelUf.TabIndex = 20;
            this.labelUf.Text = "UF";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(26, 126);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(283, 23);
            this.textEmail.TabIndex = 23;
            // 
            // labelTel1
            // 
            this.labelTel1.AutoSize = true;
            this.labelTel1.Location = new System.Drawing.Point(315, 108);
            this.labelTel1.Name = "labelTel1";
            this.labelTel1.Size = new System.Drawing.Size(60, 15);
            this.labelTel1.TabIndex = 24;
            this.labelTel1.Text = "Telefone 1";
            // 
            // labelTel2
            // 
            this.labelTel2.AutoSize = true;
            this.labelTel2.Location = new System.Drawing.Point(434, 108);
            this.labelTel2.Name = "labelTel2";
            this.labelTel2.Size = new System.Drawing.Size(60, 15);
            this.labelTel2.TabIndex = 26;
            this.labelTel2.Text = "Telefone 2";
            this.labelTel2.Click += new System.EventHandler(this.label14_Click);
            // 
            // maskedTelefone1
            // 
            this.maskedTelefone1.Location = new System.Drawing.Point(315, 126);
            this.maskedTelefone1.Mask = "(00) 00000-9999";
            this.maskedTelefone1.Name = "maskedTelefone1";
            this.maskedTelefone1.Size = new System.Drawing.Size(106, 23);
            this.maskedTelefone1.TabIndex = 27;
            // 
            // maskedTelefone2
            // 
            this.maskedTelefone2.Location = new System.Drawing.Point(434, 126);
            this.maskedTelefone2.Mask = "(00) 00000-9999";
            this.maskedTelefone2.Name = "maskedTelefone2";
            this.maskedTelefone2.Size = new System.Drawing.Size(106, 23);
            this.maskedTelefone2.TabIndex = 28;
            // 
            // maskedCep
            // 
            this.maskedCep.Location = new System.Drawing.Point(407, 243);
            this.maskedCep.Mask = "00000-000";
            this.maskedCep.Name = "maskedCep";
            this.maskedCep.Size = new System.Drawing.Size(133, 23);
            this.maskedCep.TabIndex = 29;
            // 
            // labelDataCadastro
            // 
            this.labelDataCadastro.AutoSize = true;
            this.labelDataCadastro.Location = new System.Drawing.Point(660, 20);
            this.labelDataCadastro.Name = "labelDataCadastro";
            this.labelDataCadastro.Size = new System.Drawing.Size(96, 15);
            this.labelDataCadastro.TabIndex = 30;
            this.labelDataCadastro.Text = "Data do cadastro";
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(660, 38);
            this.maskedTextBox4.Mask = "00/00/0000 90:00";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(96, 23);
            this.maskedTextBox4.TabIndex = 31;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoSalvar.BackgroundImage")));
            this.botaoSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botaoSalvar.Location = new System.Drawing.Point(633, 126);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(148, 140);
            this.botaoSalvar.TabIndex = 32;
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(26, 108);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(41, 15);
            this.labelMail.TabIndex = 33;
            this.labelMail.Text = "E-mail";
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 339);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.labelDataCadastro);
            this.Controls.Add(this.maskedCep);
            this.Controls.Add(this.maskedTelefone2);
            this.Controls.Add(this.maskedTelefone1);
            this.Controls.Add(this.labelTel2);
            this.Controls.Add(this.labelTel1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelUf);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.textBairro);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.labelCep);
            this.Controls.Add(this.textComplemento);
            this.Controls.Add(this.labelComplemento);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.labelEndeco);
            this.Controls.Add(this.textDocumento);
            this.Controls.Add(this.labelDocumento);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.labelNome);
            this.Name = "CadastroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroClientes";
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textNome;
        private Label labelID;
        private TextBox textBox2;
        private Label labelTipo;
        private ComboBox comboBoxTipo;
        private Label labelDocumento;
        private TextBox textDocumento;
        private Label labelEndeco;
        private TextBox textEndereco;
        private Label labelNumero;
        private TextBox textNumero;
        private Label labelComplemento;
        private TextBox textComplemento;
        private Label labelCep;
        private Label labelBairro;
        private TextBox textBairro;
        private TextBox textCidade;
        private Label labelCidade;
        private Label labelUf;
        private TextBox textEmail;
        private Label labelTel1;
        private Label labelTel2;
        private MaskedTextBox maskedTelefone1;
        private MaskedTextBox maskedTelefone2;
        private MaskedTextBox maskedCep;
        private Label labelDataCadastro;
        private MaskedTextBox maskedTextBox4;
        private Button botaoSalvar;
        private EventHandler textBox10_TextChanged;
        private Label labelMail;
    }
}