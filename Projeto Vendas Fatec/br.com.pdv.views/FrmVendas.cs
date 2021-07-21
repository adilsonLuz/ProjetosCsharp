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
    public partial class FrmVendas : Form
    {
        Helpers helpers = new Helpers();
        Clientes cliente = new Clientes();
        ClienteDAO dao_c = new ClienteDAO();
        Produtos p = new Produtos();
        ProdutosDAO dao_p = new ProdutosDAO();

        //variaveis globais
        int qtd;
        decimal preco, subtotal, total;

        //Carrinho
        DataTable carrinho = new DataTable();

        public FrmVendas()
        {
            InitializeComponent();

            //Monta o nosso carrinho visualmente
            //Define as colunas do seu Carrinho
            carrinho.Columns.Add("Código", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("SubTotal", typeof(decimal));

            //vincular o datagridview ao carrinho
            tabelaProdutos.DataSource = carrinho;
        }
        #region
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Botao que adiciona um item no carrinho
        private void btAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(txtquantidade.Text);
                preco = decimal.Parse(txtpreco.Text);

                //Calcular o subtotal
                subtotal = qtd * preco;

                total += subtotal;

                //Adicionar um produto no carrinho
                carrinho.Rows.Add(int.Parse(txtcodigo.Text), txtdescricao.Text, qtd, preco, subtotal);

                txttotal.Text = total.ToString();

                txtcodigo.Clear();
                txtdescricao.Clear();
                txtquantidade.Clear();
                txtpreco.Clear();

                txtcodigo.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }            
        }
        #endregion

        #region Botão que exclui um item do carrinho
        private void btExcluirItem_Click(object sender, EventArgs e)
        {
            decimal subproduto = decimal.Parse(tabelaProdutos.CurrentRow.Cells[4].Value.ToString());

            int indice = tabelaProdutos.CurrentRow.Index;
            DataRow linha = carrinho.Rows[indice];

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();

            total -= subproduto;

            txttotal.Text = total.ToString();

            MessageBox.Show("Item Removido do Carrinho com Sucesso!!!");
        }
        #endregion

        #region Método que carrega data atual a partir da data do sistema Evento load
        private void FrmVendas_Load(object sender, EventArgs e)
        {
            //Pegando a data atual
            txtdata.Text = DateTime.Now.ToShortDateString();
        }
        #endregion

        #region Botão pagamento
        private void btPagamento_Click(object sender, EventArgs e)
        {
            DateTime dataatual = DateTime.Parse(txtdata.Text);

            Frmpagamento telapagamento = new Frmpagamento(cliente, carrinho, dataatual, total);
            telapagamento.ShowDialog();


        }
        #endregion

        #region Evento que retorna um cliente atraves do cpf Keypress do cpf
        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                cliente = dao_c.retornaClientePorCpf(txtcpf.Text);

                if(cliente != null)
                {
                    txtnome.Text = cliente.nome;
                    lblTextId.Text = cliente.id.ToString();
                }
                else
                {
                    txtcpf.Clear();
                    txtcpf.Focus();
                }
            }
        }
        #endregion

        #region Evento que retorna um produto atraves do codigo Key Press do codigo
        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                //Se o usuario digitou a tecla enter
                p = dao_p.retornaProdutoPorCodigo(int.Parse(txtcodigo.Text));

                if (p != null)
                {
                    txtdescricao.Text = p.descricao;
                    txtpreco.Text = p.preco.ToString();
                }
                else
                {
                    txtcodigo.Clear();
                    txtcodigo.Focus();
                }
            }            
        }
        #endregion
    }
}
