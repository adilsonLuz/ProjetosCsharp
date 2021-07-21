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
    public partial class FrmProdutos : Form
    {
        //Objetos DAO
        FornecedorDAO f_dao = new FornecedorDAO();
        ProdutosDAO p_dao = new ProdutosDAO();
        Helpers helpers = new Helpers();

        public FrmProdutos()
        {
            InitializeComponent();
        }
        
        #region Evento load que carrega o nome dos fornecedores na Combobox
        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            //Carrega o ComboBox de fornecedores            
            cbfornecedor.DataSource = f_dao.listarFornecedor();

            //Valor que sera exibido no combo box
            cbfornecedor.DisplayMember = "Nm_Fornecedor";

            //valor que sera utilizado do banco de dados
            cbfornecedor.ValueMember = "id";

            //carregar o DataGridView com os produtos
            dgProdutos.DataSource = p_dao.listarProdutos();
        }
        #endregion

        #region Botão de adicionar produto
        private void btsalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //1Passo - Pegar os dados da View
                Produtos obj = new Produtos();
                obj.descricao = txtdescricao.Text;
                obj.preco = decimal.Parse(txtpreco.Text);
                obj.qtd_estoque = int.Parse(txtqtd_Estoque.Text);
                obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());

                //2 Passo - Criar o objeto DAO de produto               
                p_dao.cadastrarProduto(obj);


            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos corretamente");
            }
            //Atualiza o DataGridView
            dgProdutos.DataSource = p_dao.listarProdutos();
            helpers.limparCampos(this);
        }
        #endregion

        #region Botão Alterar Produto
        private void bteditar_Click(object sender, EventArgs e)
        {
            //1 Passo - Receber os dados dentro de um objeto modelo de Funcionario
            Produtos obj = new Produtos();

            obj.descricao = txtdescricao.Text;
            obj.preco = decimal.Parse(txtpreco.Text);
            obj.qtd_estoque = int.Parse(txtqtd_Estoque.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString());


            //Recebendo ID
            obj.id = int.Parse(txtcodigo.Text);

            // 2 Passo - Criar objeto FuncionarioDAO para chamar o metodo editarFuncionario
            
            p_dao.alterarProduto(obj);
            //Atualiza o DataGridView
            dgProdutos.DataSource = p_dao.listarProdutos();
            helpers.limparCampos(this);
        }

        #endregion

        #region Botão Excluir Produto
        private void btexcluir_Click(object sender, EventArgs e)
        {
            //recebe o ID que esta no campo código
            int id = int.Parse(txtcodigo.Text);

            //Cria objeto para chamar o metodo excluir Fornecedor
            
            p_dao.excluirProduto(id);

            //Atualiza o DataGridView
            dgProdutos.DataSource = p_dao.listarProdutos();
            helpers.limparCampos(this);
        }
        #endregion

        #region Botão Novo
        private void btnovo_Click(object sender, EventArgs e)
        {            
            helpers.limparCampos(this);
        }
        #endregion

        #region Botao pesquisar por descricao
        private void btpesq_Click(object sender, EventArgs e)
        {
            //Criando objeto para chamar o metodo de consultar por nome
            string descricao = txtdescriçãopesq.Text;

            //Chamando metodo e fazendo a busca no DataGridView
            dgProdutos.DataSource = p_dao.consultarProdutoPorDescricao(descricao);

            //teste se o cliente não estiver em nenhuma linha
            if (dgProdutos.Rows.Count == 0)
            {
                //Recarrega o DataGridView
                dgProdutos.DataSource = p_dao.listarProdutos();
                MessageBox.Show("Cliente não encontrado!!!");
            }
        }

        #endregion

        #region Evento CellClick, pega todos os dados da linha selecionada
        private void dgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgProdutos.CurrentRow.Cells[0].Value.ToString();
            txtdescricao.Text = dgProdutos.CurrentRow.Cells[1].Value.ToString();
            txtpreco.Text = dgProdutos.CurrentRow.Cells[2].Value.ToString();
            txtqtd_Estoque.Text = dgProdutos.CurrentRow.Cells[3].Value.ToString();
            cbfornecedor.Text = dgProdutos.CurrentRow.Cells[4].Value.ToString();

            //Mudando para tela de Cadastro
            tabProdutos.SelectedTab = tabPageProdutos;
        }

        #endregion

        #region Evento KeyPress, lista conforme digita
        private void txtdescriçãopesq_KeyPress(object sender, KeyPressEventArgs e)
        {
            string descricao = "%" + txtdescriçãopesq.Text + "%";

            //Criando objeto que chama o método listar por nome
          
            dgProdutos.DataSource = p_dao.listarProdutoPorDescricao(descricao);
        }
        #endregion
        
    }
}
