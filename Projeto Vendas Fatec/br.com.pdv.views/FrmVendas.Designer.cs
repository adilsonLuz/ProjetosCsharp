
namespace Projeto_Vendas_FATEC.br.com.pdv.views
{
    partial class FrmVendas
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAdicionarItem = new System.Windows.Forms.Button();
            this.btExcluirItem = new System.Windows.Forms.Button();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTextId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabelaProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btPagamento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(289, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela Vendas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 70);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btAdicionarItem);
            this.groupBox2.Controls.Add(this.btExcluirItem);
            this.groupBox2.Controls.Add(this.txtquantidade);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtpreco);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtdescricao);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 172);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // btAdicionarItem
            // 
            this.btAdicionarItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btAdicionarItem.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarItem.ForeColor = System.Drawing.Color.White;
            this.btAdicionarItem.Location = new System.Drawing.Point(17, 123);
            this.btAdicionarItem.Name = "btAdicionarItem";
            this.btAdicionarItem.Size = new System.Drawing.Size(133, 39);
            this.btAdicionarItem.TabIndex = 19;
            this.btAdicionarItem.Text = "Adicionar Item";
            this.btAdicionarItem.UseVisualStyleBackColor = false;
            this.btAdicionarItem.Click += new System.EventHandler(this.btAdicionarItem_Click);
            // 
            // btExcluirItem
            // 
            this.btExcluirItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btExcluirItem.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirItem.ForeColor = System.Drawing.Color.White;
            this.btExcluirItem.Location = new System.Drawing.Point(172, 123);
            this.btExcluirItem.Name = "btExcluirItem";
            this.btExcluirItem.Size = new System.Drawing.Size(141, 39);
            this.btExcluirItem.TabIndex = 26;
            this.btExcluirItem.Text = "Excluir Item";
            this.btExcluirItem.UseVisualStyleBackColor = false;
            this.btExcluirItem.Click += new System.EventHandler(this.btExcluirItem_Click);
            // 
            // txtquantidade
            // 
            this.txtquantidade.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantidade.Location = new System.Drawing.Point(259, 89);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(54, 23);
            this.txtquantidade.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(220, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Qtd";
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco.Location = new System.Drawing.Point(83, 89);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(121, 23);
            this.txtpreco.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Preço R$";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(83, 60);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(230, 23);
            this.txtdescricao.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(13, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Desc.";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(83, 31);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(121, 23);
            this.txtcodigo.TabIndex = 17;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(6, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data";
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Location = new System.Drawing.Point(61, 19);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(121, 23);
            this.txtdata.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(14, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "CPF";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(61, 48);
            this.txtcpf.Mask = "###,###,###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(253, 23);
            this.txtcpf.TabIndex = 10;
            this.txtcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcpf_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(1, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(61, 77);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(253, 23);
            this.txtnome.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(209, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID: ";
            // 
            // lblTextId
            // 
            this.lblTextId.AutoSize = true;
            this.lblTextId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextId.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTextId.Location = new System.Drawing.Point(236, 23);
            this.lblTextId.Name = "lblTextId";
            this.lblTextId.Size = new System.Drawing.Size(18, 19);
            this.lblTextId.TabIndex = 15;
            this.lblTextId.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTextId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcpf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtdata);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(11, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tabelaProdutos
            // 
            this.tabelaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProdutos.Location = new System.Drawing.Point(339, 79);
            this.tabelaProdutos.Name = "tabelaProdutos";
            this.tabelaProdutos.Size = new System.Drawing.Size(496, 298);
            this.tabelaProdutos.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttotal);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(339, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 60);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(84, 19);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(406, 23);
            this.txttotal.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(7, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Total R$";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btCancelar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(184, 395);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(118, 39);
            this.btCancelar.TabIndex = 19;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // btPagamento
            // 
            this.btPagamento.BackColor = System.Drawing.Color.DodgerBlue;
            this.btPagamento.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPagamento.ForeColor = System.Drawing.Color.White;
            this.btPagamento.Location = new System.Drawing.Point(44, 395);
            this.btPagamento.Name = "btPagamento";
            this.btPagamento.Size = new System.Drawing.Size(118, 39);
            this.btPagamento.TabIndex = 18;
            this.btPagamento.Text = "Pagamento";
            this.btPagamento.UseVisualStyleBackColor = false;
            this.btPagamento.Click += new System.EventHandler(this.btPagamento_Click);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btPagamento);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabelaProdutos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVendas";
            this.Text = "FrmVendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTextId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btExcluirItem;
        private System.Windows.Forms.Button btAdicionarItem;
        private System.Windows.Forms.DataGridView tabelaProdutos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btPagamento;
    }
}