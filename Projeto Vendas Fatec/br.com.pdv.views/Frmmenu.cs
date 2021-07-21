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
    public partial class Frmmenu : Form
    {
        public Frmmenu()
        {
            InitializeComponent();
        }
        #region
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Método Cadastrar clientes
        private void menu_cadastrarClientes_Click(object sender, EventArgs e)
        {
            Frmclientes clientes = new Frmclientes();
            clientes.ShowDialog();
        }
        #endregion

        #region Método Cadastrar funcionario
        private void menu_cadastrarFuncionarios_Click(object sender, EventArgs e)
        {       
                FrmFuncionario funcionario = new FrmFuncionario();
                funcionario.ShowDialog();
        }
        #endregion

        #region Método Cadastrar produtos
        private void menu_cadastrarProdutos_Click(object sender, EventArgs e)
        {
            FrmProdutos produtos = new FrmProdutos();
            produtos.ShowDialog();
        }
        #endregion

        #region método cadstrar fornecedores
        private void menu_CadastrarFornecedores_Click(object sender, EventArgs e)
        {
            FrmFornecedores fornecedores = new FrmFornecedores();
            fornecedores.ShowDialog();
        }

        #endregion

        #region Metodo abrir PDV
        private void menu_abrirPDV_Click(object sender, EventArgs e)
        {
            FrmVendas vendas = new FrmVendas();
            vendas.ShowDialog();
        }
        #endregion
    }
}
