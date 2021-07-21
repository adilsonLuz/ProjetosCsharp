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
    public partial class Frmclientes : Form
    {
        #region FrmClientes
        public Frmclientes()
        {
            InitializeComponent();
        }
        #endregion
        #region Dados cliente
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region lb1
        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region txt1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Botão salvar
        private void btsalvar_Click(object sender, EventArgs e)
        {
            //Botao Salvar

            //1 Passo - Receber os dados dentro do objeto modelo de cliente
            Clientes obj = new Clientes();

            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
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

            //2 Passo - Criar objeto ClienteDAO para chamar o metodo cadastrarCliente
            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            //Recarrega o DataGridView
            dgClientes.DataSource = dao.listarClientes();

         
        }
        #endregion

        #region Botão Excluir
        private void btexcluir_Click(object sender, EventArgs e)
        {
            //Botão Excluir

            //1 Passo - Receber Dados
            int id = int.Parse(txtcodigo.Text);

            //2 passo - Criar objeto ClienteDAO para chamar o metodo excluirCliente
            ClienteDAO dao = new ClienteDAO();
            dao.excluirCliente(id);

            //Recarrega o DataGridView
            dgClientes.DataSource = dao.listarClientes();
        }
        #endregion

        #region Botão Pesquisar CEP
        private void btpesquisar_Click(object sender, EventArgs e)
        {
            //Botãopesquisa cep
            try
            {
                string cep = txtcep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();
                dados.ReadXml(xml);

                //Exibir dados nos campos de texto
                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtcomplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbestado.Text = dados.Tables[0].Rows[0]["uf"].ToString();



            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");
            }


        }
        #endregion

        #region Botão editar
        private void bteditar_Click(object sender, EventArgs e)
        {
            //Botao Editar
            //1 Passo - Receber os dados dentro do objeto modelo de cliente
            Clientes obj = new Clientes();

            obj.nome = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numend = int.Parse(txtnumero.Text);
            obj.complemenmto = txtnumero.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = cbestado.Text;

            //receber id
            obj.id = int.Parse(txtcodigo.Text);

            //2 Passo - Criar objeto ClienteDAO para chamar o metodo editarCliente
            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            //Recarrega o DataGridView
            dgClientes.DataSource = dao.listarClientes();
        }
        #endregion

        #region Evento load listarClientes
        private void Frmclientes_Load(object sender, EventArgs e)
        {
            //Evento load do formulario
            ClienteDAO dao = new ClienteDAO();

            dgClientes.DataSource = dao.listarClientes();
        }

        #endregion

        #region Botão pesquisar pornome
        private void btpesq_Click(object sender, EventArgs e)
        {
            string nome = txtpesquisa.Text;
            ClienteDAO dao = new ClienteDAO();

            dgClientes.DataSource = dao.consultarClientePorNome(nome);

            if(dgClientes.Rows.Count == 0)
            {
                //Recarregar o DataGridView
                dgClientes.DataSource = dao.listarClientes();
                MessageBox.Show("Cliente não encontrado!");
            }
            
        }
        #endregion

        #region Evento KeyPress
        private void txtpesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evento KeyPress
            string nome = "%" + txtpesquisa.Text + "%";

            ClienteDAO dao = new ClienteDAO();
            dgClientes.DataSource = dao.listarClientePorNome(nome);
        }



        #endregion

        #region CellClick pegar linha selecionada
        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da linha selecionada
            txtcodigo.Text = dgClientes.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = dgClientes.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = dgClientes.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = dgClientes.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dgClientes.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text = dgClientes.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text = dgClientes.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text = dgClientes.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text = dgClientes.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text = dgClientes.CurrentRow.Cells[9].Value.ToString();
            txtcomplemento.Text = dgClientes.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text = dgClientes.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text = dgClientes.CurrentRow.Cells[12].Value.ToString();
            cbestado.Text = dgClientes.CurrentRow.Cells[13].Value.ToString();


            //Alterar para a guia dados pessoais
            tabDadosCliente.SelectedTab = tabPage1;
        }
        #endregion

        #region Botão Novo
        private void btnovo_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtrg.Clear();
            txtcpf.Clear();
            txtemail.Clear();
            txtendereco.Clear();
            txtnumero.Clear();
            txtcomplemento.Clear();
            txtbairro.Clear();
            txtcidade.Clear();
            txtcep.Clear();
            txttelefone.Clear();
            txtcelular.Clear();
            cbestado.SelectedIndex = -1;
        }
        #endregion


    }//Fim da classe
}
