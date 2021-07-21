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
    public partial class Frmpagamento : Form
    {
        //objeto
        Helpers helpers = new Helpers();
        Clientes cliente = new Clientes();
        DataTable carrinho = new DataTable();
        DateTime dataatual;
        decimal total;

        public Frmpagamento(Clientes cliente, DataTable carrinho, DateTime dataatual, decimal total)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.dataatual = dataatual;
            this.total = total;

            InitializeComponent();

            txttotal.Text = total.ToString();

        }

        #region evento load 
        private void Frmpagamento_Load(object sender, EventArgs e)
        {
            txttroco.Text = "0,00";
            txtvista.Text = "0,00";
            txtcartao.Text = "0,00";
        }
        #endregion

        #region Botão finalizar venda
        private void btFinalizarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                decimal v_dinheiro, v_cartao, troco, totalpago;

                //recebendo valor dos campos de texto
                v_dinheiro = decimal.Parse(txtvista.Text);
                v_cartao = decimal.Parse(txtcartao.Text);

                //calculando valor pago
                totalpago = v_dinheiro + v_cartao;

                if(totalpago < total)
                {
                    MessageBox.Show("Saldo insuficiente para pagamento!!!");
                }
                else
                {
                    //calcular o troco
                    troco = totalpago - total;
                    txttroco.Text = troco.ToString();

                    //salvar dados da venda nbo bando de dados
                    Vendas venda = new Vendas();
                    venda.cliente_id = cliente.id;
                    venda.dada_venda = dataatual;
                    venda.total_venda = total;
                    venda.obs = txtobs.Text;

                    VendasDAO vdao = new VendasDAO();
                    vdao.cadastrarVendas(venda);                    

                    foreach(DataRow linha in carrinho.Rows)
                    {
                        ItensVendas item = new ItensVendas();

                        //montando objeto que será salvo no banco de dados
                        item.vendas_id = vdao.retornaIdUltimaVenda();
                        item.produto_id = int.Parse(linha["código"].ToString());
                        item.qtd = int.Parse(linha["Qtd"].ToString());
                        item.subtotal = decimal.Parse(linha["Subtotal"].ToString());

                        ItensVendasDAO itemdao = new ItensVendasDAO();
                        itemdao.cadastrarItem(item);
                    }

                    MessageBox.Show("Venda salva com sucesso!!!");                    
                }
            }
            catch (Exception)
            {
                throw;
            }
            helpers.limparCampos(this);
        }
        #endregion
    }
}
