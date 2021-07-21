using Projeto_Vendas_FATEC.br.com.pdv.dao;
using Projeto_Vendas_FATEC.br.com.pdv.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_FATEC.br.com.pdv.views
{
    public partial class Frmlogin : Form
    {
        Helpers helpers = new Helpers();
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btentrar_Click(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            dao.efetuarLogin(txtemail.Text, txtsenha.Text);

            this.Close();
            helpers.limparCampos(this);
        }
    }
}
