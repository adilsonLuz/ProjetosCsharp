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
    public partial class FrmFornecedores : Form
    {
        Helpers helpers = new Helpers();
        public FrmFornecedores()
        {
            InitializeComponent();
        }

        #region Botão Salvar
        private void btsalvar_Click(object sender, EventArgs e)
        {
            //Recebendo dados dentro do objeto de fornecedores
            Fornecedores obj = new Fornecedores();

            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numend = int.Parse(txtnumero.Text);
            obj.complemenmto = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbestado.Text;

            //Criando objeto para chamar o metodo castrar cliente
            FornecedorDAO dao = new FornecedorDAO();
            dao.cadastrarFornecedor(obj);

            //Atualiza o DataGridView
            dgFornecedor.DataSource = dao.listarFornecedor();
            helpers.limparCampos(this);
        }
        #endregion

        #region Botão Excluir
        private void btexcluir_Click(object sender, EventArgs e)
        {
            //recebe o ID que esta no campo código
            int id = int.Parse(txtcodigo.Text);

            //Cria objeto para chamar o metodo excluir Fornecedor
            FornecedorDAO dao = new FornecedorDAO();
            dao.excluirFornecedor(id);

            //Atualiza o DataGridView
            dgFornecedor.DataSource = dao.listarFornecedor();
            helpers.limparCampos(this);
        }
        #endregion

        #region Botão Editar
        private void bteditar_Click(object sender, EventArgs e)
        {
            //Recebe os dados do Frame para o objeto modelo
            Fornecedores obj = new Fornecedores();

            obj.nome = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numend = int.Parse(txtnumero.Text);
            obj.complemenmto = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbestado.Text;

            obj.id = int.Parse(txtcodigo.Text);

            //Criando objeto para chamar o metodo editar Fornecedor
            FornecedorDAO dao = new FornecedorDAO();
            dao.editarFornecedor(obj);

            //Atualiza o DataGridView
            dgFornecedor.DataSource = dao.listarFornecedor();
            helpers.limparCampos(this);
        }
        #endregion

        #region Botão Novo
        private void btnovo_Click(object sender, EventArgs e)
        {            
            helpers.limparCampos(this);
        }

        #endregion

        #region Botão Pesquisar CEP
        private void btpesquisar_Click(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var endereco = ws.consultaCEP(txtcep.Text);
                        txtendereco.Text = endereco.end;
                        txtcomplemento.Text = endereco.complemento2;
                        txtbairro.Text = endereco.bairro;
                        txtcidade.Text = endereco.cidade;
                        cbestado.Text = endereco.uf;
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, " ",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        #endregion

        #region Botão pesquisar por nome
        private void btpesq_Click(object sender, EventArgs e)
        {
            //Criando objeto para chamar o metodo de consultar por nome
            FornecedorDAO dao = new FornecedorDAO();
            string nome = txtpesqFornec.Text;

            //Chamando metodo e fazendo a busca no DataGridView
            dgFornecedor.DataSource = dao.consultarFornecedorPorNome(nome);

            //teste se o cliente não estiver em nenhuma linha
            if (dgFornecedor.Rows.Count == 0)
            {
                //Recarrega o DataGridView
                dgFornecedor.DataSource = dao.listarFornecedor();
                MessageBox.Show("Cliente não encontrado!!!");
            }
        }

        #endregion

        #region Evento CellClick, pega todos dados da linha selecionada
        private void dgFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Carregando os dados do DataGridView nos campos de texto do cadastro de fornecedores
            txtcodigo.Text = dgFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text = dgFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = dgFornecedor.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = dgFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = dgFornecedor.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = dgFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = dgFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = dgFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtcomplemento.Text = dgFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = dgFornecedor.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = dgFornecedor.CurrentRow.Cells[11].Value.ToString();
            cbestado.Text = dgFornecedor.CurrentRow.Cells[12].Value.ToString();

            //Mudando para tela de Cadastro
            tabDadosFornecedores.SelectedTab = tpFornecedor;
        }
        #endregion

        #region Evento KeyPress, Lista o Fornecedor conforme digita
        private void txtpesqFornec_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtpesqFornec.Text + "%";

            //Criando objeto que chama o método listar por nome
            FornecedorDAO dao = new FornecedorDAO();
            
            dgFornecedor.DataSource = dao.listarFornecedorPorNome(nome);

        }

        #endregion

        #region Evento Load, carrega a lista de fornecedores no DataGridView quando abre
        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            dgFornecedor.DataSource = dao.listarFornecedor();
        }
        #endregion
    }
}
