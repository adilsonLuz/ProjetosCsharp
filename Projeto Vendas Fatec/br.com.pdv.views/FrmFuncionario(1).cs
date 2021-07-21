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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        #region cbuf
        private void cbEstadoFunc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Botão Cadastrar Funcionario
        private void btSalvarFunc_Click(object sender, EventArgs e)
        {
            //Botao Salvar

            //1 Passo - Receber os dados dentro do objeto modelo de cliente
            Funcionario obj = new Funcionario();

            obj.nome = txtNomeFunc.Text;
            obj.rg = txtRgFunc.Text;
            obj.cpf = txtCpfFunc.Text;
            obj.email = txtEmailFunc.Text;
            obj.senha = txtSenhaFunc.Text;
            obj.cargo = cbCargoFunc.Text;
            obj.nivelAcesso = txtNivelAcessoFunc.Text;
            obj.telefone = txtTelefoneFunc.Text;
            obj.celular = txtCelularFunc.Text;
            obj.cep = txtCepFunc.Text;
            obj.endereco = txtEnderecoFunc.Text;
            obj.numend = int.Parse(txtNumeroFunc.Text);
            obj.complemenmto = txtComplementoFunc.Text;
            obj.bairro = txtBairroFuncFunc.Text;
            obj.cidade = txtCidadeFunc.Text;
            obj.estado = cbEstadoFunc.Text;

            //2 Passo - Criar objeto ClienteDAO para chamar o metodo cadastrarCliente
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarFuncionario(obj);

            //Recarrega o DataGridView
            dgFuncionarios.DataSource = dao.listarFuncionario();
        }
        #endregion

        #region Botão Excluir Funcionario
                private void btExcluirFunc_Click(object sender, EventArgs e)
                {
                    //1 Passo - Receber dados
                    int id = int.Parse(txtCodigoFunc.Text);

                    //2Passo - Criar objeto FuncionarioDAO para chamar o método Excluir Funcionario
                    FuncionarioDAO dao = new FuncionarioDAO();
                    dao.excluirFuncionario(id);

                    //Recarrega o DataGridView
                    dgFuncionarios.DataSource = dao.listarFuncionario();
                }

        #endregion

        #region Botão Editar
        private void btEditarFunc_Click(object sender, EventArgs e)
        {
            //1 Passo - Receber os dados dentro de um objeto modelo de Funcionario
            Funcionario obj = new Funcionario();

            obj.nome = txtNomeFunc.Text;
            obj.rg = txtRgFunc.Text;
            obj.cpf = txtCpfFunc.Text;
            obj.email = txtEmailFunc.Text;
            obj.senha = txtSenhaFunc.Text;
            obj.cargo = cbCargoFunc.Text;
            obj.nivelAcesso = txtNivelAcessoFunc.Text;
            obj.telefone = txtTelefoneFunc.Text;
            obj.celular = txtCelularFunc.Text;
            obj.cep = txtCepFunc.Text;
            obj.endereco = txtEnderecoFunc.Text;
            obj.complemenmto = txtComplementoFunc.Text;
            obj.bairro = txtBairroFuncFunc.Text;
            obj.cidade = txtCidadeFunc.Text;
            obj.estado = cbEstadoFunc.Text;
            //Recebendo ID
            obj.id = int.Parse(txtCodigoFunc.Text);

            // 2 Passo - Criar objeto FuncionarioDAO para chamar o metodo editarFuncionario
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.editarFuncionario(obj);

            //Recarrega o DataGridView
            dgFuncionarios.DataSource = dao.listarFuncionario();
        }
        #endregion

        #region Botao Novo
        private void btNovoFunc_Click(object sender, EventArgs e)
        {
            txtCodigoFunc.Clear();
            txtNomeFunc.Clear();
            txtRgFunc.Clear();
            txtCpfFunc.Clear();
            txtEmailFunc.Clear();
            txtSenhaFunc.Clear();
            cbCargoFunc.SelectedIndex = -1;
            txtNivelAcessoFunc.Clear();
            txtTelefoneFunc.Clear();
            txtCelularFunc.Clear();
            txtCepFunc.Clear();
            txtEnderecoFunc.Clear();
            txtNumeroFunc.Clear();
            txtComplementoFunc.Clear();
            txtBairroFuncFunc.Clear();
            txtCidadeFunc.Clear();
            cbEstadoFunc.SelectedIndex = -1;
            
        }
        #endregion

        #region Botão pesquisar CEP
        private void btPesquisaCepFunc_Click(object sender, EventArgs e)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var endereco = ws.consultaCEP(txtCepFunc.Text);
                    txtEnderecoFunc.Text = endereco.end;
                    txtComplementoFunc.Text = endereco.complemento2;
                    txtBairroFuncFunc.Text = endereco.bairro;
                    txtCidadeFunc.Text = endereco.cidade;
                    cbEstadoFunc.Text = endereco.uf;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, " ",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Botão pesquisar no grid
        private void btpesqFunc_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisaFunc.Text;
            FuncionarioDAO dao = new FuncionarioDAO();

            dgFuncionarios.DataSource = dao.consultarFuncionarioPorNome(nome);

            if(dgFuncionarios.Rows.Count == 0)
            {
                //Recarregar o DataGridView
                dgFuncionarios.DataSource = dao.listarFuncionario();
                MessageBox.Show("Funcionario não Encontrado!!!");
            }
        }
        #endregion

        #region Evento Listar conforme digita a pesquisa
        private void txtpesquisaFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evento KeyPress
            string nome = "%" + txtpesquisaFunc.Text +"%";

            FuncionarioDAO dao = new FuncionarioDAO();
            dgFuncionarios.DataSource = dao.listarFuncionarioPorNome(nome);
        }
        #endregion

        #region Retornar linha selecionada
        private void dgFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoFunc.Text = dgFuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtNomeFunc.Text = dgFuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtRgFunc.Text = dgFuncionarios.CurrentRow.Cells[2].Value.ToString();
            txtCpfFunc.Text = dgFuncionarios.CurrentRow.Cells[3].Value.ToString();
            txtEmailFunc.Text = dgFuncionarios.CurrentRow.Cells[4].Value.ToString();
            txtSenhaFunc.Text = dgFuncionarios.CurrentRow.Cells[5].Value.ToString();
            cbCargoFunc.Text = dgFuncionarios.CurrentRow.Cells[6].Value.ToString();
            txtNivelAcessoFunc.Text = dgFuncionarios.CurrentRow.Cells[7].Value.ToString();
            txtTelefoneFunc.Text = dgFuncionarios.CurrentRow.Cells[8].Value.ToString();
            txtCelularFunc.Text = dgFuncionarios.CurrentRow.Cells[9].Value.ToString();
            txtCepFunc.Text = dgFuncionarios.CurrentRow.Cells[10].Value.ToString();
            txtEnderecoFunc.Text = dgFuncionarios.CurrentRow.Cells[11].Value.ToString();
            txtNumeroFunc.Text = dgFuncionarios.CurrentRow.Cells[12].Value.ToString();
            txtComplementoFunc.Text = dgFuncionarios.CurrentRow.Cells[13].Value.ToString();
            txtBairroFuncFunc.Text = dgFuncionarios.CurrentRow.Cells[14].Value.ToString();
            txtCidadeFunc.Text = dgFuncionarios.CurrentRow.Cells[15].Value.ToString();
            cbEstadoFunc.Text = dgFuncionarios.CurrentRow.Cells[16].Value.ToString();

            //Voltar para tela de cadastro de funcionario
            tabDadosFuncionario.SelectedTab = tabPageFuncionario;
        }



        #endregion

        #region Evento que lê a lista de Funcionarios 
        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            //Criando o load do formulario
            FuncionarioDAO dao = new FuncionarioDAO();

            dgFuncionarios.DataSource = dao.listarFuncionario();
        }
        #endregion

        
    }
}
