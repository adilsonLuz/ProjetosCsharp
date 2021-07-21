
namespace Projeto_Vendas_FATEC.br.com.pdv.views
{
    partial class Frmpagamento
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
            this.txtvista = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcartao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btFinalizarVenda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagamento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 70);
            this.panel1.TabIndex = 2;
            // 
            // txtvista
            // 
            this.txtvista.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvista.Location = new System.Drawing.Point(106, 86);
            this.txtvista.Name = "txtvista";
            this.txtvista.Size = new System.Drawing.Size(190, 23);
            this.txtvista.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(21, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "A Vista R$";
            // 
            // txtcartao
            // 
            this.txtcartao.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcartao.Location = new System.Drawing.Point(106, 118);
            this.txtcartao.Name = "txtcartao";
            this.txtcartao.Size = new System.Drawing.Size(190, 23);
            this.txtcartao.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(23, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Cartão R$";
            // 
            // txttroco
            // 
            this.txttroco.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroco.Location = new System.Drawing.Point(106, 150);
            this.txttroco.Name = "txttroco";
            this.txttroco.Size = new System.Drawing.Size(190, 23);
            this.txttroco.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(29, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Troco R$";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(106, 182);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(190, 23);
            this.txttotal.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(35, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Total R$";
            // 
            // txtobs
            // 
            this.txtobs.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobs.Location = new System.Drawing.Point(106, 214);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(190, 78);
            this.txtobs.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(65, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Obs";
            // 
            // btFinalizarVenda
            // 
            this.btFinalizarVenda.BackColor = System.Drawing.Color.DodgerBlue;
            this.btFinalizarVenda.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizarVenda.ForeColor = System.Drawing.Color.White;
            this.btFinalizarVenda.Location = new System.Drawing.Point(127, 301);
            this.btFinalizarVenda.Name = "btFinalizarVenda";
            this.btFinalizarVenda.Size = new System.Drawing.Size(140, 51);
            this.btFinalizarVenda.TabIndex = 34;
            this.btFinalizarVenda.Text = "Finalizar Venda";
            this.btFinalizarVenda.UseVisualStyleBackColor = false;
            this.btFinalizarVenda.Click += new System.EventHandler(this.btFinalizarVenda_Click);
            // 
            // Frmpagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 362);
            this.Controls.Add(this.btFinalizarVenda);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttroco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcartao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "Frmpagamento";
            this.Text = "Frmpagamento";
            this.Load += new System.EventHandler(this.Frmpagamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtvista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcartao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btFinalizarVenda;
    }
}