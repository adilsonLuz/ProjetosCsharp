
namespace Projeto_Vendas_FATEC.br.com.pdv.views
{
    partial class Frmlogin
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btentrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo.Location = new System.Drawing.Point(42, 12);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(401, 39);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Autenticação do Sistema";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 70);
            this.panel1.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(99, 101);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(338, 23);
            this.txtemail.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(53, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // txtsenha
            // 
            this.txtsenha.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(99, 150);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(338, 23);
            this.txtsenha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(49, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha";
            // 
            // btentrar
            // 
            this.btentrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btentrar.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btentrar.ForeColor = System.Drawing.Color.White;
            this.btentrar.Location = new System.Drawing.Point(188, 197);
            this.btentrar.Name = "btentrar";
            this.btentrar.Size = new System.Drawing.Size(118, 39);
            this.btentrar.TabIndex = 3;
            this.btentrar.Text = "Entrar";
            this.btentrar.UseVisualStyleBackColor = false;
            this.btentrar.Click += new System.EventHandler(this.btentrar_Click);
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 297);
            this.Controls.Add(this.btentrar);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Frmlogin";
            this.Text = "Frmlogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btentrar;
    }
}