
namespace Projeto_Vendas_FATEC.br.com.pdv.views
{
    partial class Frmclientes
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.tabDadosCliente = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabconsulta = new System.Windows.Forms.TabPage();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.lbnomeconsulta = new System.Windows.Forms.Label();
            this.btpesq = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.btnovo = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabDadosCliente.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabconsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 0;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo.Location = new System.Drawing.Point(192, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(382, 55);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cadastro Cliente";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabDadosCliente
            // 
            this.tabDadosCliente.Controls.Add(this.tabPage1);
            this.tabDadosCliente.Controls.Add(this.tabconsulta);
            this.tabDadosCliente.Location = new System.Drawing.Point(7, 77);
            this.tabDadosCliente.Name = "tabDadosCliente";
            this.tabDadosCliente.SelectedIndex = 0;
            this.tabDadosCliente.Size = new System.Drawing.Size(783, 353);
            this.tabDadosCliente.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbestado);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btpesquisar);
            this.tabPage1.Controls.Add(this.txtcep);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtcomplemento);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtcelular);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txttelefone);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtcpf);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtrg);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cbestado
            // 
            this.cbestado.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
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
            this.cbestado.Location = new System.Drawing.Point(367, 252);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(165, 23);
            this.cbestado.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label14.Location = new System.Drawing.Point(325, 255);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "UF";
            // 
            // txtcidade
            // 
            this.txtcidade.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcidade.Location = new System.Drawing.Point(368, 208);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(218, 23);
            this.txtcidade.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(322, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "Cidade";
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(681, 168);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(59, 23);
            this.txtnumero.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(629, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Número";
            // 
            // txtendereco
            // 
            this.txtendereco.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendereco.Location = new System.Drawing.Point(306, 168);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(316, 23);
            this.txtendereco.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(242, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Endereço";
            // 
            // btpesquisar
            // 
            this.btpesquisar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btpesquisar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisar.ForeColor = System.Drawing.Color.White;
            this.btpesquisar.Location = new System.Drawing.Point(407, 127);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(89, 30);
            this.btpesquisar.TabIndex = 9;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = false;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // txtcep
            // 
            this.txtcep.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcep.Location = new System.Drawing.Point(306, 132);
            this.txtcep.Mask = "#####-###";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(89, 23);
            this.txtcep.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(272, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "CEP";
            // 
            // txtbairro
            // 
            this.txtbairro.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbairro.Location = new System.Drawing.Point(109, 249);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(191, 23);
            this.txtbairro.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(63, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Bairro";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomplemento.Location = new System.Drawing.Point(111, 208);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(189, 23);
            this.txtcomplemento.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(21, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Complemento";
            // 
            // txtcelular
            // 
            this.txtcelular.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(79, 168);
            this.txtcelular.Mask = "(##) # ####-####";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(133, 23);
            this.txtcelular.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(25, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Celular";
            // 
            // txttelefone
            // 
            this.txttelefone.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.Location = new System.Drawing.Point(79, 131);
            this.txttelefone.Mask = "(##) ####-####";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(133, 23);
            this.txttelefone.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(21, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefone";
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(530, 95);
            this.txtcpf.Mask = "###,###,###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(122, 23);
            this.txtcpf.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(498, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(79, 95);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(338, 23);
            this.txtemail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(33, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // txtrg
            // 
            this.txtrg.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrg.Location = new System.Drawing.Point(530, 54);
            this.txtrg.Mask = "##,###,###-#";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(122, 23);
            this.txtrg.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(500, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(79, 54);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(338, 23);
            this.txtnome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(29, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(79, 19);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(121, 23);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabconsulta
            // 
            this.tabconsulta.Controls.Add(this.dgClientes);
            this.tabconsulta.Controls.Add(this.lbnomeconsulta);
            this.tabconsulta.Controls.Add(this.btpesq);
            this.tabconsulta.Controls.Add(this.txtpesquisa);
            this.tabconsulta.Location = new System.Drawing.Point(4, 22);
            this.tabconsulta.Name = "tabconsulta";
            this.tabconsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabconsulta.Size = new System.Drawing.Size(775, 327);
            this.tabconsulta.TabIndex = 1;
            this.tabconsulta.Text = "Consulta";
            this.tabconsulta.UseVisualStyleBackColor = true;
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(18, 68);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.Size = new System.Drawing.Size(737, 230);
            this.dgClientes.TabIndex = 24;
            this.dgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellClick);
            // 
            // lbnomeconsulta
            // 
            this.lbnomeconsulta.AutoSize = true;
            this.lbnomeconsulta.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnomeconsulta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbnomeconsulta.Location = new System.Drawing.Point(21, 36);
            this.lbnomeconsulta.Name = "lbnomeconsulta";
            this.lbnomeconsulta.Size = new System.Drawing.Size(40, 15);
            this.lbnomeconsulta.TabIndex = 23;
            this.lbnomeconsulta.Text = "Nome";
            // 
            // btpesq
            // 
            this.btpesq.BackColor = System.Drawing.Color.DodgerBlue;
            this.btpesq.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesq.ForeColor = System.Drawing.Color.White;
            this.btpesq.Location = new System.Drawing.Point(283, 28);
            this.btpesq.Name = "btpesq";
            this.btpesq.Size = new System.Drawing.Size(89, 30);
            this.btpesq.TabIndex = 22;
            this.btpesq.Text = "Pesquisar";
            this.btpesq.UseVisualStyleBackColor = false;
            this.btpesq.Click += new System.EventHandler(this.btpesq_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(67, 34);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(210, 20);
            this.txtpesquisa.TabIndex = 1;
            this.txtpesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpesquisa_KeyPress);
            // 
            // btnovo
            // 
            this.btnovo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnovo.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnovo.ForeColor = System.Drawing.Color.White;
            this.btnovo.Location = new System.Drawing.Point(156, 436);
            this.btnovo.Name = "btnovo";
            this.btnovo.Size = new System.Drawing.Size(118, 39);
            this.btnovo.TabIndex = 19;
            this.btnovo.Text = "Novo";
            this.btnovo.UseVisualStyleBackColor = false;
            this.btnovo.Click += new System.EventHandler(this.btnovo_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btsalvar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalvar.ForeColor = System.Drawing.Color.White;
            this.btsalvar.Location = new System.Drawing.Point(280, 436);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(118, 39);
            this.btsalvar.TabIndex = 16;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btexcluir.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.ForeColor = System.Drawing.Color.White;
            this.btexcluir.Location = new System.Drawing.Point(404, 436);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(118, 39);
            this.btexcluir.TabIndex = 17;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = false;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // bteditar
            // 
            this.bteditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.bteditar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditar.ForeColor = System.Drawing.Color.White;
            this.bteditar.Location = new System.Drawing.Point(528, 436);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(118, 39);
            this.bteditar.TabIndex = 18;
            this.bteditar.Text = "Editar";
            this.bteditar.UseVisualStyleBackColor = false;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // Frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btnovo);
            this.Controls.Add(this.tabDadosCliente);
            this.Controls.Add(this.panel1);
            this.Name = "Frmclientes";
            this.Text = "Frmclientes";
            this.Load += new System.EventHandler(this.Frmclientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabDadosCliente.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabconsulta.ResumeLayout(false);
            this.tabconsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TabControl tabDadosCliente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabconsulta;
        private System.Windows.Forms.Button btnovo;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbnomeconsulta;
        private System.Windows.Forms.Button btpesq;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.DataGridView dgClientes;
    }
}