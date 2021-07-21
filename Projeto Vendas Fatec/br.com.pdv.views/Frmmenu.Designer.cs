
namespace Projeto_Vendas_FATEC.br.com.pdv.views
{
    partial class Frmmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cadastrarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_consultarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_funcionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cadastrarFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.consFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Fornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_CadastrarFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ConsultarFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_cadastrarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_consultarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_abrirPDV = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_historicoVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_relatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_relatorioVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_imprimirRelatório = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_clientes,
            this.menu_funcionarios,
            this.menu_Fornecedores,
            this.menu_produtos,
            this.menu_vendas,
            this.menu_relatorio});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_clientes
            // 
            this.menu_clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadastrarClientes,
            this.menu_consultarClientes});
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(61, 20);
            this.menu_clientes.Text = "Clientes";
            // 
            // menu_cadastrarClientes
            // 
            this.menu_cadastrarClientes.Name = "menu_cadastrarClientes";
            this.menu_cadastrarClientes.Size = new System.Drawing.Size(170, 22);
            this.menu_cadastrarClientes.Text = "Cadastrar Clientes";
            this.menu_cadastrarClientes.Click += new System.EventHandler(this.menu_cadastrarClientes_Click);
            // 
            // menu_consultarClientes
            // 
            this.menu_consultarClientes.Name = "menu_consultarClientes";
            this.menu_consultarClientes.Size = new System.Drawing.Size(170, 22);
            this.menu_consultarClientes.Text = "Consultar Clientes";
            // 
            // menu_funcionarios
            // 
            this.menu_funcionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadastrarFuncionarios,
            this.consFunc});
            this.menu_funcionarios.Name = "menu_funcionarios";
            this.menu_funcionarios.Size = new System.Drawing.Size(87, 20);
            this.menu_funcionarios.Text = "Funcionários";
            // 
            // menu_cadastrarFuncionarios
            // 
            this.menu_cadastrarFuncionarios.Name = "menu_cadastrarFuncionarios";
            this.menu_cadastrarFuncionarios.Size = new System.Drawing.Size(196, 22);
            this.menu_cadastrarFuncionarios.Text = "Cadastrar Funcionarios";
            this.menu_cadastrarFuncionarios.Click += new System.EventHandler(this.menu_cadastrarFuncionarios_Click);
            // 
            // consFunc
            // 
            this.consFunc.Name = "consFunc";
            this.consFunc.Size = new System.Drawing.Size(196, 22);
            this.consFunc.Text = "Consultar Funcionarios";
            // 
            // menu_Fornecedores
            // 
            this.menu_Fornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_CadastrarFornecedores,
            this.menu_ConsultarFornecedores});
            this.menu_Fornecedores.Name = "menu_Fornecedores";
            this.menu_Fornecedores.Size = new System.Drawing.Size(90, 20);
            this.menu_Fornecedores.Text = "Fornecedores";
            // 
            // menu_CadastrarFornecedores
            // 
            this.menu_CadastrarFornecedores.Name = "menu_CadastrarFornecedores";
            this.menu_CadastrarFornecedores.Size = new System.Drawing.Size(199, 22);
            this.menu_CadastrarFornecedores.Text = "Cadastrar Fornecedores";
            this.menu_CadastrarFornecedores.Click += new System.EventHandler(this.menu_CadastrarFornecedores_Click);
            // 
            // menu_ConsultarFornecedores
            // 
            this.menu_ConsultarFornecedores.Name = "menu_ConsultarFornecedores";
            this.menu_ConsultarFornecedores.Size = new System.Drawing.Size(199, 22);
            this.menu_ConsultarFornecedores.Text = "Consultar Fornecedores";
            // 
            // menu_produtos
            // 
            this.menu_produtos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_cadastrarProdutos,
            this.menu_consultarProdutos});
            this.menu_produtos.Name = "menu_produtos";
            this.menu_produtos.Size = new System.Drawing.Size(67, 20);
            this.menu_produtos.Text = "Produtos";
            // 
            // menu_cadastrarProdutos
            // 
            this.menu_cadastrarProdutos.Name = "menu_cadastrarProdutos";
            this.menu_cadastrarProdutos.Size = new System.Drawing.Size(176, 22);
            this.menu_cadastrarProdutos.Text = "Cadastrar Produtos";
            this.menu_cadastrarProdutos.Click += new System.EventHandler(this.menu_cadastrarProdutos_Click);
            // 
            // menu_consultarProdutos
            // 
            this.menu_consultarProdutos.Name = "menu_consultarProdutos";
            this.menu_consultarProdutos.Size = new System.Drawing.Size(176, 22);
            this.menu_consultarProdutos.Text = "Consultar Produtos";
            // 
            // menu_vendas
            // 
            this.menu_vendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_abrirPDV,
            this.menu_historicoVendas});
            this.menu_vendas.Name = "menu_vendas";
            this.menu_vendas.Size = new System.Drawing.Size(56, 20);
            this.menu_vendas.Text = "Vendas";
            // 
            // menu_abrirPDV
            // 
            this.menu_abrirPDV.Name = "menu_abrirPDV";
            this.menu_abrirPDV.Size = new System.Drawing.Size(180, 22);
            this.menu_abrirPDV.Text = "Abrir PDV";
            this.menu_abrirPDV.Click += new System.EventHandler(this.menu_abrirPDV_Click);
            // 
            // menu_historicoVendas
            // 
            this.menu_historicoVendas.Name = "menu_historicoVendas";
            this.menu_historicoVendas.Size = new System.Drawing.Size(180, 22);
            this.menu_historicoVendas.Text = "Histórico de Vendas";
            // 
            // menu_relatorio
            // 
            this.menu_relatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_relatorioVendas,
            this.menu_imprimirRelatório});
            this.menu_relatorio.Name = "menu_relatorio";
            this.menu_relatorio.Size = new System.Drawing.Size(66, 20);
            this.menu_relatorio.Text = "Relatório";
            // 
            // menu_relatorioVendas
            // 
            this.menu_relatorioVendas.Name = "menu_relatorioVendas";
            this.menu_relatorioVendas.Size = new System.Drawing.Size(182, 22);
            this.menu_relatorioVendas.Text = "Relatórios de Vendas";
            // 
            // menu_imprimirRelatório
            // 
            this.menu_imprimirRelatório.Name = "menu_imprimirRelatório";
            this.menu_imprimirRelatório.Size = new System.Drawing.Size(182, 22);
            this.menu_imprimirRelatório.Text = "Imprimir Relatório";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbLogado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel1.Text = "Logado como:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // lbLogado
            // 
            this.lbLogado.Name = "lbLogado";
            this.lbLogado.Size = new System.Drawing.Size(68, 17);
            this.lbLogado.Text = "Adilson Luz";
            // 
            // Frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmmenu";
            this.Text = "Frmmenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_clientes;
        private System.Windows.Forms.ToolStripMenuItem menu_cadastrarClientes;
        private System.Windows.Forms.ToolStripMenuItem menu_consultarClientes;
        private System.Windows.Forms.ToolStripMenuItem menu_funcionarios;
        private System.Windows.Forms.ToolStripMenuItem menu_cadastrarFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menu_produtos;
        private System.Windows.Forms.ToolStripMenuItem menu_vendas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem menu_abrirPDV;
        public System.Windows.Forms.ToolStripStatusLabel lbLogado;
        public System.Windows.Forms.ToolStripMenuItem menu_historicoVendas;
        public System.Windows.Forms.ToolStripMenuItem menu_relatorioVendas;
        private System.Windows.Forms.ToolStripMenuItem menu_cadastrarProdutos;
        private System.Windows.Forms.ToolStripMenuItem menu_consultarProdutos;
        private System.Windows.Forms.ToolStripMenuItem menu_imprimirRelatório;
        private System.Windows.Forms.ToolStripMenuItem menu_Fornecedores;
        private System.Windows.Forms.ToolStripMenuItem menu_CadastrarFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menu_ConsultarFornecedores;
        public System.Windows.Forms.ToolStripMenuItem consFunc;
        public System.Windows.Forms.ToolStripMenuItem menu_relatorio;
    }
}