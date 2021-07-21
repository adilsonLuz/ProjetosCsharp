
namespace Projeto_Vendas_FATEC.br.com.pdv.views
{
    partial class FrmProdutos
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
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabPageProdutos = new System.Windows.Forms.TabPage();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.cbfornecedor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtqtd_Estoque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabConsultaProdutos = new System.Windows.Forms.TabPage();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.lbnomeconsulta = new System.Windows.Forms.Label();
            this.btpesq = new System.Windows.Forms.Button();
            this.txtdescriçãopesq = new System.Windows.Forms.TextBox();
            this.bteditar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.btnovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabProdutos.SuspendLayout();
            this.tabPageProdutos.SuspendLayout();
            this.tabConsultaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
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
            this.panel1.TabIndex = 1;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo.Location = new System.Drawing.Point(192, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(426, 55);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cadastro Produtos";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabPageProdutos);
            this.tabProdutos.Controls.Add(this.tabConsultaProdutos);
            this.tabProdutos.Location = new System.Drawing.Point(9, 76);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(783, 310);
            this.tabProdutos.TabIndex = 2;
            // 
            // tabPageProdutos
            // 
            this.tabPageProdutos.Controls.Add(this.txtpreco);
            this.tabPageProdutos.Controls.Add(this.cbfornecedor);
            this.tabPageProdutos.Controls.Add(this.label14);
            this.tabPageProdutos.Controls.Add(this.txtqtd_Estoque);
            this.tabPageProdutos.Controls.Add(this.label4);
            this.tabPageProdutos.Controls.Add(this.label3);
            this.tabPageProdutos.Controls.Add(this.txtdescricao);
            this.tabPageProdutos.Controls.Add(this.label2);
            this.tabPageProdutos.Controls.Add(this.txtcodigo);
            this.tabPageProdutos.Controls.Add(this.label1);
            this.tabPageProdutos.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageProdutos.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tabPageProdutos.Location = new System.Drawing.Point(4, 22);
            this.tabPageProdutos.Name = "tabPageProdutos";
            this.tabPageProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProdutos.Size = new System.Drawing.Size(775, 284);
            this.tabPageProdutos.TabIndex = 0;
            this.tabPageProdutos.Text = "Dados Produtos";
            this.tabPageProdutos.UseVisualStyleBackColor = true;
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco.Location = new System.Drawing.Point(571, 62);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(121, 26);
            this.txtpreco.TabIndex = 3;
            // 
            // cbfornecedor
            // 
            this.cbfornecedor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbfornecedor.FormattingEnabled = true;
            this.cbfornecedor.Location = new System.Drawing.Point(120, 146);
            this.cbfornecedor.Name = "cbfornecedor";
            this.cbfornecedor.Size = new System.Drawing.Size(165, 27);
            this.cbfornecedor.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label14.Location = new System.Drawing.Point(24, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 19);
            this.label14.TabIndex = 28;
            this.label14.Text = "Fornecedor";
            // 
            // txtqtd_Estoque
            // 
            this.txtqtd_Estoque.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqtd_Estoque.Location = new System.Drawing.Point(120, 103);
            this.txtqtd_Estoque.Name = "txtqtd_Estoque";
            this.txtqtd_Estoque.Size = new System.Drawing.Size(338, 26);
            this.txtqtd_Estoque.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(19, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Qtd Estoque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(493, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço R$";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(121, 65);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(338, 26);
            this.txtdescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(120, 27);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(121, 26);
            this.txtcodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // tabConsultaProdutos
            // 
            this.tabConsultaProdutos.Controls.Add(this.dgProdutos);
            this.tabConsultaProdutos.Controls.Add(this.lbnomeconsulta);
            this.tabConsultaProdutos.Controls.Add(this.btpesq);
            this.tabConsultaProdutos.Controls.Add(this.txtdescriçãopesq);
            this.tabConsultaProdutos.Location = new System.Drawing.Point(4, 22);
            this.tabConsultaProdutos.Name = "tabConsultaProdutos";
            this.tabConsultaProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultaProdutos.Size = new System.Drawing.Size(775, 284);
            this.tabConsultaProdutos.TabIndex = 1;
            this.tabConsultaProdutos.Text = "Consulta Produtos";
            this.tabConsultaProdutos.UseVisualStyleBackColor = true;
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(18, 68);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.Size = new System.Drawing.Size(737, 210);
            this.dgProdutos.TabIndex = 24;
            this.dgProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProdutos_CellClick);
            // 
            // lbnomeconsulta
            // 
            this.lbnomeconsulta.AutoSize = true;
            this.lbnomeconsulta.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnomeconsulta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbnomeconsulta.Location = new System.Drawing.Point(21, 36);
            this.lbnomeconsulta.Name = "lbnomeconsulta";
            this.lbnomeconsulta.Size = new System.Drawing.Size(62, 15);
            this.lbnomeconsulta.TabIndex = 23;
            this.lbnomeconsulta.Text = "Descrição";
            // 
            // btpesq
            // 
            this.btpesq.BackColor = System.Drawing.Color.DodgerBlue;
            this.btpesq.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesq.ForeColor = System.Drawing.Color.White;
            this.btpesq.Location = new System.Drawing.Point(304, 28);
            this.btpesq.Name = "btpesq";
            this.btpesq.Size = new System.Drawing.Size(89, 30);
            this.btpesq.TabIndex = 22;
            this.btpesq.Text = "Pesquisar";
            this.btpesq.UseVisualStyleBackColor = false;
            this.btpesq.Click += new System.EventHandler(this.btpesq_Click);
            // 
            // txtdescriçãopesq
            // 
            this.txtdescriçãopesq.Location = new System.Drawing.Point(88, 34);
            this.txtdescriçãopesq.Name = "txtdescriçãopesq";
            this.txtdescriçãopesq.Size = new System.Drawing.Size(210, 20);
            this.txtdescriçãopesq.TabIndex = 1;
            this.txtdescriçãopesq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescriçãopesq_KeyPress);
            // 
            // bteditar
            // 
            this.bteditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.bteditar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditar.ForeColor = System.Drawing.Color.White;
            this.bteditar.Location = new System.Drawing.Point(532, 392);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(118, 39);
            this.bteditar.TabIndex = 9;
            this.bteditar.Text = "Editar";
            this.bteditar.UseVisualStyleBackColor = false;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btexcluir.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.ForeColor = System.Drawing.Color.White;
            this.btexcluir.Location = new System.Drawing.Point(408, 392);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(118, 39);
            this.btexcluir.TabIndex = 8;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = false;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btsalvar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalvar.ForeColor = System.Drawing.Color.White;
            this.btsalvar.Location = new System.Drawing.Point(284, 392);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(118, 39);
            this.btsalvar.TabIndex = 7;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // btnovo
            // 
            this.btnovo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnovo.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnovo.ForeColor = System.Drawing.Color.White;
            this.btnovo.Location = new System.Drawing.Point(160, 392);
            this.btnovo.Name = "btnovo";
            this.btnovo.Size = new System.Drawing.Size(118, 39);
            this.btnovo.TabIndex = 6;
            this.btnovo.Text = "Novo";
            this.btnovo.UseVisualStyleBackColor = false;
            this.btnovo.Click += new System.EventHandler(this.btnovo_Click);
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btnovo);
            this.Controls.Add(this.tabProdutos);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProdutos";
            this.Text = "FrmProdutos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabProdutos.ResumeLayout(false);
            this.tabPageProdutos.ResumeLayout(false);
            this.tabPageProdutos.PerformLayout();
            this.tabConsultaProdutos.ResumeLayout(false);
            this.tabConsultaProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TabControl tabProdutos;
        private System.Windows.Forms.TabPage tabPageProdutos;
        private System.Windows.Forms.ComboBox cbfornecedor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtqtd_Estoque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabConsultaProdutos;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.Label lbnomeconsulta;
        private System.Windows.Forms.Button btpesq;
        private System.Windows.Forms.TextBox txtdescriçãopesq;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Button btnovo;
    }
}