
namespace Projeto_Vendas_FATEC.br.com.pdv.views
{
    partial class FrmFuncionario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDadosFuncionario = new System.Windows.Forms.TabControl();
            this.tabPageFuncionario = new System.Windows.Forms.TabPage();
            this.cbCargoFunc = new System.Windows.Forms.ComboBox();
            this.txtNivelAcessoFunc = new System.Windows.Forms.TextBox();
            this.txtSenhaFunc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstadoFunc = new System.Windows.Forms.ComboBox();
            this.txtCidadeFunc = new System.Windows.Forms.TextBox();
            this.txtBairroFuncFunc = new System.Windows.Forms.TextBox();
            this.txtComplementoFunc = new System.Windows.Forms.TextBox();
            this.txtNumeroFunc = new System.Windows.Forms.TextBox();
            this.txtEnderecoFunc = new System.Windows.Forms.TextBox();
            this.btPesquisaCepFunc = new System.Windows.Forms.Button();
            this.txtCepFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtCelularFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailFunc = new System.Windows.Forms.TextBox();
            this.txtCpfFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtRgFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.txtCodigoFunc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPageDadosFuncionario = new System.Windows.Forms.TabPage();
            this.dgFuncionarios = new System.Windows.Forms.DataGridView();
            this.lbnomeconsulta = new System.Windows.Forms.Label();
            this.btpesqFunc = new System.Windows.Forms.Button();
            this.txtpesquisaFunc = new System.Windows.Forms.TextBox();
            this.btEditarFunc = new System.Windows.Forms.Button();
            this.btExcluirFunc = new System.Windows.Forms.Button();
            this.btSalvarFunc = new System.Windows.Forms.Button();
            this.btNovoFunc = new System.Windows.Forms.Button();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.panel1.SuspendLayout();
            this.tabDadosFuncionario.SuspendLayout();
            this.tabPageFuncionario.SuspendLayout();
            this.tabPageDadosFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Funcionário";
            // 
            // tabDadosFuncionario
            // 
            this.tabDadosFuncionario.Controls.Add(this.tabPageFuncionario);
            this.tabDadosFuncionario.Controls.Add(this.tabPageDadosFuncionario);
            this.tabDadosFuncionario.Location = new System.Drawing.Point(13, 77);
            this.tabDadosFuncionario.Name = "tabDadosFuncionario";
            this.tabDadosFuncionario.SelectedIndex = 0;
            this.tabDadosFuncionario.Size = new System.Drawing.Size(775, 327);
            this.tabDadosFuncionario.TabIndex = 1;
            // 
            // tabPageFuncionario
            // 
            this.tabPageFuncionario.Controls.Add(this.cbCargoFunc);
            this.tabPageFuncionario.Controls.Add(this.txtNivelAcessoFunc);
            this.tabPageFuncionario.Controls.Add(this.txtSenhaFunc);
            this.tabPageFuncionario.Controls.Add(this.label4);
            this.tabPageFuncionario.Controls.Add(this.label3);
            this.tabPageFuncionario.Controls.Add(this.label2);
            this.tabPageFuncionario.Controls.Add(this.cbEstadoFunc);
            this.tabPageFuncionario.Controls.Add(this.txtCidadeFunc);
            this.tabPageFuncionario.Controls.Add(this.txtBairroFuncFunc);
            this.tabPageFuncionario.Controls.Add(this.txtComplementoFunc);
            this.tabPageFuncionario.Controls.Add(this.txtNumeroFunc);
            this.tabPageFuncionario.Controls.Add(this.txtEnderecoFunc);
            this.tabPageFuncionario.Controls.Add(this.btPesquisaCepFunc);
            this.tabPageFuncionario.Controls.Add(this.txtCepFunc);
            this.tabPageFuncionario.Controls.Add(this.txtCelularFunc);
            this.tabPageFuncionario.Controls.Add(this.txtTelefoneFunc);
            this.tabPageFuncionario.Controls.Add(this.txtEmailFunc);
            this.tabPageFuncionario.Controls.Add(this.txtCpfFunc);
            this.tabPageFuncionario.Controls.Add(this.txtRgFunc);
            this.tabPageFuncionario.Controls.Add(this.txtNomeFunc);
            this.tabPageFuncionario.Controls.Add(this.txtCodigoFunc);
            this.tabPageFuncionario.Controls.Add(this.label16);
            this.tabPageFuncionario.Controls.Add(this.label17);
            this.tabPageFuncionario.Controls.Add(this.label18);
            this.tabPageFuncionario.Controls.Add(this.label19);
            this.tabPageFuncionario.Controls.Add(this.label20);
            this.tabPageFuncionario.Controls.Add(this.label21);
            this.tabPageFuncionario.Controls.Add(this.label22);
            this.tabPageFuncionario.Controls.Add(this.label23);
            this.tabPageFuncionario.Controls.Add(this.label24);
            this.tabPageFuncionario.Controls.Add(this.label25);
            this.tabPageFuncionario.Controls.Add(this.label26);
            this.tabPageFuncionario.Controls.Add(this.label27);
            this.tabPageFuncionario.Controls.Add(this.label28);
            this.tabPageFuncionario.Controls.Add(this.label29);
            this.tabPageFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tabPageFuncionario.Name = "tabPageFuncionario";
            this.tabPageFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFuncionario.Size = new System.Drawing.Size(767, 301);
            this.tabPageFuncionario.TabIndex = 0;
            this.tabPageFuncionario.Text = "Dados Funcionário";
            this.tabPageFuncionario.UseVisualStyleBackColor = true;
            // 
            // cbCargoFunc
            // 
            this.cbCargoFunc.FormattingEnabled = true;
            this.cbCargoFunc.Items.AddRange(new object[] {
            "Diretor",
            "Gerente",
            "Vendedor"});
            this.cbCargoFunc.Location = new System.Drawing.Point(261, 105);
            this.cbCargoFunc.Name = "cbCargoFunc";
            this.cbCargoFunc.Size = new System.Drawing.Size(153, 21);
            this.cbCargoFunc.TabIndex = 7;
            // 
            // txtNivelAcessoFunc
            // 
            this.txtNivelAcessoFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivelAcessoFunc.Location = new System.Drawing.Point(532, 105);
            this.txtNivelAcessoFunc.Name = "txtNivelAcessoFunc";
            this.txtNivelAcessoFunc.Size = new System.Drawing.Size(122, 23);
            this.txtNivelAcessoFunc.TabIndex = 8;
            // 
            // txtSenhaFunc
            // 
            this.txtSenhaFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaFunc.Location = new System.Drawing.Point(78, 105);
            this.txtSenhaFunc.Name = "txtSenhaFunc";
            this.txtSenhaFunc.PasswordChar = '*';
            this.txtSenhaFunc.Size = new System.Drawing.Size(121, 23);
            this.txtSenhaFunc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(432, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nível de Acesso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(217, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(33, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Senha";
            // 
            // cbEstadoFunc
            // 
            this.cbEstadoFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoFunc.FormattingEnabled = true;
            this.cbEstadoFunc.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbEstadoFunc.Location = new System.Drawing.Point(368, 248);
            this.cbEstadoFunc.Name = "cbEstadoFunc";
            this.cbEstadoFunc.Size = new System.Drawing.Size(165, 23);
            this.cbEstadoFunc.TabIndex = 18;
            this.cbEstadoFunc.SelectedIndexChanged += new System.EventHandler(this.cbEstadoFunc_SelectedIndexChanged);
            // 
            // txtCidadeFunc
            // 
            this.txtCidadeFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeFunc.Location = new System.Drawing.Point(107, 248);
            this.txtCidadeFunc.Name = "txtCidadeFunc";
            this.txtCidadeFunc.Size = new System.Drawing.Size(189, 23);
            this.txtCidadeFunc.TabIndex = 17;
            // 
            // txtBairroFuncFunc
            // 
            this.txtBairroFuncFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroFuncFunc.Location = new System.Drawing.Point(368, 215);
            this.txtBairroFuncFunc.Name = "txtBairroFuncFunc";
            this.txtBairroFuncFunc.Size = new System.Drawing.Size(165, 23);
            this.txtBairroFuncFunc.TabIndex = 16;
            // 
            // txtComplementoFunc
            // 
            this.txtComplementoFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplementoFunc.Location = new System.Drawing.Point(107, 212);
            this.txtComplementoFunc.Name = "txtComplementoFunc";
            this.txtComplementoFunc.Size = new System.Drawing.Size(189, 23);
            this.txtComplementoFunc.TabIndex = 15;
            // 
            // txtNumeroFunc
            // 
            this.txtNumeroFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFunc.Location = new System.Drawing.Point(685, 176);
            this.txtNumeroFunc.Name = "txtNumeroFunc";
            this.txtNumeroFunc.Size = new System.Drawing.Size(59, 23);
            this.txtNumeroFunc.TabIndex = 14;
            // 
            // txtEnderecoFunc
            // 
            this.txtEnderecoFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoFunc.Location = new System.Drawing.Point(305, 179);
            this.txtEnderecoFunc.Name = "txtEnderecoFunc";
            this.txtEnderecoFunc.Size = new System.Drawing.Size(316, 23);
            this.txtEnderecoFunc.TabIndex = 13;
            // 
            // btPesquisaCepFunc
            // 
            this.btPesquisaCepFunc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btPesquisaCepFunc.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisaCepFunc.ForeColor = System.Drawing.Color.White;
            this.btPesquisaCepFunc.Location = new System.Drawing.Point(407, 136);
            this.btPesquisaCepFunc.Name = "btPesquisaCepFunc";
            this.btPesquisaCepFunc.Size = new System.Drawing.Size(89, 30);
            this.btPesquisaCepFunc.TabIndex = 12;
            this.btPesquisaCepFunc.Text = "Pesquisar";
            this.btPesquisaCepFunc.UseVisualStyleBackColor = false;
            this.btPesquisaCepFunc.Click += new System.EventHandler(this.btPesquisaCepFunc_Click);
            // 
            // txtCepFunc
            // 
            this.txtCepFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCepFunc.Location = new System.Drawing.Point(307, 142);
            this.txtCepFunc.Mask = "00000-000";
            this.txtCepFunc.Name = "txtCepFunc";
            this.txtCepFunc.Size = new System.Drawing.Size(89, 23);
            this.txtCepFunc.TabIndex = 11;
            // 
            // txtCelularFunc
            // 
            this.txtCelularFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelularFunc.Location = new System.Drawing.Point(82, 176);
            this.txtCelularFunc.Mask = "(00) 0 0000-0000";
            this.txtCelularFunc.Name = "txtCelularFunc";
            this.txtCelularFunc.Size = new System.Drawing.Size(133, 23);
            this.txtCelularFunc.TabIndex = 10;
            // 
            // txtTelefoneFunc
            // 
            this.txtTelefoneFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneFunc.Location = new System.Drawing.Point(82, 143);
            this.txtTelefoneFunc.Mask = "(00) 0000-0000";
            this.txtTelefoneFunc.Name = "txtTelefoneFunc";
            this.txtTelefoneFunc.Size = new System.Drawing.Size(133, 23);
            this.txtTelefoneFunc.TabIndex = 9;
            // 
            // txtEmailFunc
            // 
            this.txtEmailFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFunc.Location = new System.Drawing.Point(76, 72);
            this.txtEmailFunc.Name = "txtEmailFunc";
            this.txtEmailFunc.Size = new System.Drawing.Size(338, 23);
            this.txtEmailFunc.TabIndex = 3;
            // 
            // txtCpfFunc
            // 
            this.txtCpfFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfFunc.Location = new System.Drawing.Point(532, 72);
            this.txtCpfFunc.Mask = "000,000,000-00";
            this.txtCpfFunc.Name = "txtCpfFunc";
            this.txtCpfFunc.Size = new System.Drawing.Size(122, 23);
            this.txtCpfFunc.TabIndex = 5;
            // 
            // txtRgFunc
            // 
            this.txtRgFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgFunc.Location = new System.Drawing.Point(532, 44);
            this.txtRgFunc.Mask = "00,000,000-0";
            this.txtRgFunc.Name = "txtRgFunc";
            this.txtRgFunc.Size = new System.Drawing.Size(122, 23);
            this.txtRgFunc.TabIndex = 4;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFunc.Location = new System.Drawing.Point(76, 41);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(338, 23);
            this.txtNomeFunc.TabIndex = 2;
            // 
            // txtCodigoFunc
            // 
            this.txtCodigoFunc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFunc.Location = new System.Drawing.Point(76, 11);
            this.txtCodigoFunc.Name = "txtCodigoFunc";
            this.txtCodigoFunc.Size = new System.Drawing.Size(121, 23);
            this.txtCodigoFunc.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label16.Location = new System.Drawing.Point(341, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 15);
            this.label16.TabIndex = 27;
            this.label16.Text = "UF";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label17.Location = new System.Drawing.Point(57, 250);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 15);
            this.label17.TabIndex = 26;
            this.label17.Text = "Cidade";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label18.Location = new System.Drawing.Point(22, 215);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 15);
            this.label18.TabIndex = 24;
            this.label18.Text = "Complemento";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label19.Location = new System.Drawing.Point(26, 179);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 15);
            this.label19.TabIndex = 20;
            this.label19.Text = "Celular";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label20.Location = new System.Drawing.Point(22, 145);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 15);
            this.label20.TabIndex = 19;
            this.label20.Text = "Telefone";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label21.Location = new System.Drawing.Point(34, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 15);
            this.label21.TabIndex = 18;
            this.label21.Text = "Email";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label22.Location = new System.Drawing.Point(30, 44);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 15);
            this.label22.TabIndex = 15;
            this.label22.Text = "Nome";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label23.Location = new System.Drawing.Point(28, 14);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 15);
            this.label23.TabIndex = 14;
            this.label23.Text = "Código";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label24.Location = new System.Drawing.Point(323, 218);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 15);
            this.label24.TabIndex = 25;
            this.label24.Text = "Bairro";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label25.Location = new System.Drawing.Point(630, 179);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 15);
            this.label25.TabIndex = 23;
            this.label25.Text = "Número";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label26.Location = new System.Drawing.Point(243, 179);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 15);
            this.label26.TabIndex = 22;
            this.label26.Text = "Endereço";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label27.Location = new System.Drawing.Point(273, 145);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(28, 15);
            this.label27.TabIndex = 21;
            this.label27.Text = "CEP";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label28.Location = new System.Drawing.Point(499, 75);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(28, 15);
            this.label28.TabIndex = 17;
            this.label28.Text = "CPF";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label29.Location = new System.Drawing.Point(501, 44);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 15);
            this.label29.TabIndex = 16;
            this.label29.Text = "RG";
            // 
            // tabPageDadosFuncionario
            // 
            this.tabPageDadosFuncionario.Controls.Add(this.dgFuncionarios);
            this.tabPageDadosFuncionario.Controls.Add(this.lbnomeconsulta);
            this.tabPageDadosFuncionario.Controls.Add(this.btpesqFunc);
            this.tabPageDadosFuncionario.Controls.Add(this.txtpesquisaFunc);
            this.tabPageDadosFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tabPageDadosFuncionario.Name = "tabPageDadosFuncionario";
            this.tabPageDadosFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDadosFuncionario.Size = new System.Drawing.Size(767, 301);
            this.tabPageDadosFuncionario.TabIndex = 1;
            this.tabPageDadosFuncionario.Text = "Consulta Funcionário";
            this.tabPageDadosFuncionario.UseVisualStyleBackColor = true;
            // 
            // dgFuncionarios
            // 
            this.dgFuncionarios.AllowUserToAddRows = false;
            this.dgFuncionarios.AllowUserToDeleteRows = false;
            this.dgFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncionarios.Location = new System.Drawing.Point(15, 55);
            this.dgFuncionarios.Name = "dgFuncionarios";
            this.dgFuncionarios.ReadOnly = true;
            this.dgFuncionarios.Size = new System.Drawing.Size(737, 230);
            this.dgFuncionarios.TabIndex = 28;
            this.dgFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFuncionarios_CellClick);
            // 
            // lbnomeconsulta
            // 
            this.lbnomeconsulta.AutoSize = true;
            this.lbnomeconsulta.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnomeconsulta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbnomeconsulta.Location = new System.Drawing.Point(18, 23);
            this.lbnomeconsulta.Name = "lbnomeconsulta";
            this.lbnomeconsulta.Size = new System.Drawing.Size(40, 15);
            this.lbnomeconsulta.TabIndex = 27;
            this.lbnomeconsulta.Text = "Nome";
            // 
            // btpesqFunc
            // 
            this.btpesqFunc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btpesqFunc.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesqFunc.ForeColor = System.Drawing.Color.White;
            this.btpesqFunc.Location = new System.Drawing.Point(280, 15);
            this.btpesqFunc.Name = "btpesqFunc";
            this.btpesqFunc.Size = new System.Drawing.Size(89, 30);
            this.btpesqFunc.TabIndex = 26;
            this.btpesqFunc.Text = "Pesquisar";
            this.btpesqFunc.UseVisualStyleBackColor = false;
            this.btpesqFunc.Click += new System.EventHandler(this.btpesqFunc_Click);
            // 
            // txtpesquisaFunc
            // 
            this.txtpesquisaFunc.Location = new System.Drawing.Point(64, 21);
            this.txtpesquisaFunc.Name = "txtpesquisaFunc";
            this.txtpesquisaFunc.Size = new System.Drawing.Size(210, 20);
            this.txtpesquisaFunc.TabIndex = 25;
            this.txtpesquisaFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpesquisaFunc_KeyPress);
            // 
            // btEditarFunc
            // 
            this.btEditarFunc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btEditarFunc.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarFunc.ForeColor = System.Drawing.Color.White;
            this.btEditarFunc.Location = new System.Drawing.Point(526, 420);
            this.btEditarFunc.Name = "btEditarFunc";
            this.btEditarFunc.Size = new System.Drawing.Size(118, 39);
            this.btEditarFunc.TabIndex = 2;
            this.btEditarFunc.Text = "EDITAR";
            this.btEditarFunc.UseVisualStyleBackColor = false;
            this.btEditarFunc.Click += new System.EventHandler(this.btEditarFunc_Click);
            // 
            // btExcluirFunc
            // 
            this.btExcluirFunc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btExcluirFunc.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirFunc.ForeColor = System.Drawing.Color.White;
            this.btExcluirFunc.Location = new System.Drawing.Point(402, 420);
            this.btExcluirFunc.Name = "btExcluirFunc";
            this.btExcluirFunc.Size = new System.Drawing.Size(118, 39);
            this.btExcluirFunc.TabIndex = 3;
            this.btExcluirFunc.Text = "EXCLUIR";
            this.btExcluirFunc.UseVisualStyleBackColor = false;
            this.btExcluirFunc.Click += new System.EventHandler(this.btExcluirFunc_Click);
            // 
            // btSalvarFunc
            // 
            this.btSalvarFunc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btSalvarFunc.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarFunc.ForeColor = System.Drawing.Color.White;
            this.btSalvarFunc.Location = new System.Drawing.Point(278, 420);
            this.btSalvarFunc.Name = "btSalvarFunc";
            this.btSalvarFunc.Size = new System.Drawing.Size(118, 39);
            this.btSalvarFunc.TabIndex = 19;
            this.btSalvarFunc.Text = "SALVAR";
            this.btSalvarFunc.UseVisualStyleBackColor = false;
            this.btSalvarFunc.Click += new System.EventHandler(this.btSalvarFunc_Click);
            // 
            // btNovoFunc
            // 
            this.btNovoFunc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btNovoFunc.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoFunc.ForeColor = System.Drawing.Color.White;
            this.btNovoFunc.Location = new System.Drawing.Point(154, 420);
            this.btNovoFunc.Name = "btNovoFunc";
            this.btNovoFunc.Size = new System.Drawing.Size(118, 39);
            this.btNovoFunc.TabIndex = 5;
            this.btNovoFunc.Text = "NOVO";
            this.btNovoFunc.UseVisualStyleBackColor = false;
            this.btNovoFunc.Click += new System.EventHandler(this.btNovoFunc_Click);
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.btNovoFunc);
            this.Controls.Add(this.btSalvarFunc);
            this.Controls.Add(this.btExcluirFunc);
            this.Controls.Add(this.btEditarFunc);
            this.Controls.Add(this.tabDadosFuncionario);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFuncionario";
            this.Text = "FrmFuncionario";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabDadosFuncionario.ResumeLayout(false);
            this.tabPageFuncionario.ResumeLayout(false);
            this.tabPageFuncionario.PerformLayout();
            this.tabPageDadosFuncionario.ResumeLayout(false);
            this.tabPageDadosFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabDadosFuncionario;
        private System.Windows.Forms.TabPage tabPageFuncionario;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TabPage tabPageDadosFuncionario;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.TextBox txtCodigoFunc;
        private System.Windows.Forms.ComboBox cbEstadoFunc;
        private System.Windows.Forms.TextBox txtCidadeFunc;
        private System.Windows.Forms.TextBox txtBairroFuncFunc;
        private System.Windows.Forms.TextBox txtComplementoFunc;
        private System.Windows.Forms.TextBox txtNumeroFunc;
        private System.Windows.Forms.TextBox txtEnderecoFunc;
        private System.Windows.Forms.Button btPesquisaCepFunc;
        private System.Windows.Forms.MaskedTextBox txtCepFunc;
        private System.Windows.Forms.MaskedTextBox txtCelularFunc;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFunc;
        private System.Windows.Forms.TextBox txtEmailFunc;
        private System.Windows.Forms.MaskedTextBox txtCpfFunc;
        private System.Windows.Forms.MaskedTextBox txtRgFunc;
        private System.Windows.Forms.Button btEditarFunc;
        private System.Windows.Forms.Button btExcluirFunc;
        private System.Windows.Forms.Button btSalvarFunc;
        private System.Windows.Forms.Button btNovoFunc;
        private System.Windows.Forms.TextBox txtNivelAcessoFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgFuncionarios;
        private System.Windows.Forms.Label lbnomeconsulta;
        private System.Windows.Forms.Button btpesqFunc;
        private System.Windows.Forms.TextBox txtpesquisaFunc;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.TextBox txtSenhaFunc;
        private System.Windows.Forms.ComboBox cbCargoFunc;
    }
}