using MySql.Data.MySqlClient;
using Projeto_Vendas_FATEC.br.com.pdv.conexao;
using Projeto_Vendas_FATEC.br.com.pdv.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_FATEC.br.com.pdv.dao
{
    public class ProdutosDAO
    { 
        private MySqlConnection conexao;

        public ProdutosDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método que cadastra um produto
        public void cadastrarProduto(Produtos obj)
        {
            try
            {
                //1 passo - Criar comando SQL
                string sql = @"insert into TB_Produtos (Ds_Produto, Ds_Preco, Qt_Estoque, For_ID)
                                values (@descricao, @preco, @qtd_estoque, @for_id)";

                //2 Passo - organizar e executar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtd_estoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                conexao.Open();

                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu erro: " + erro);
            }
        }
        #endregion

        #region Método que altera um produto
        public void alterarProduto(Produtos obj)
        {
            try
            {
                //1 passo - Criar comando SQL
                string sql = @"update TB_Produtos set Ds_Produto = @descricao, Ds_Preco = @preco,
                             Qt_Estoque = @qtd_estoque, For_ID = @for_id where id = @id";

                //2 Passo - organizar e xecutar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtd_estoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                conexao.Open();

                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu erro: " + erro);
            }
        }
        #endregion

        #region Metodo que exclui um produto
        public void excluirProduto(int id)
        {
            try
            {
                //1 passo - Criar comando SQL
                string sql = @"delete from TB_Produtos where id = @id)";

                //2 Passo - organizar e xecutar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);
               

                conexao.Open();

                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluído com sucesso");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu erro: " + erro);
            }
        }
        #endregion

        #region Método que lista todos os Produtos
        public DataTable listarProdutos()
        {
            try
            {
                //1 Passo - Criar DataTable e o comando sql
                DataTable tabelaProduto = new DataTable();
                string sql = @"select * from vlistaprodutos";

                //2 Passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //3 Passo - Abrir a conexao e executar o comando
                conexao.Open();

                //4 Passo - Preencher o DataTable com os dados
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                conexao.Close();
                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu erro: " + erro);
                return null;
            }
        }//fecha o metodo listarFornecedor
        #endregion

        #region Metodo que lista um produto por sua descricao
        public DataTable listarProdutoPorDescricao(string descricao)
        {
            try
            {
                //1 Passo - Criar DataTable e o comando sql
                DataTable tabelaProduto = new DataTable();
                string sql = @"select * from TB_Produtos where Ds_Produto like @descricao";

                //2 Passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", descricao);

                //3 Passo - Abrir a conexao e executar o comando
                conexao.Open();

                //4 Passo - Preencher o DataTable com os dados
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                conexao.Close();
                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Metodo que consulta um Produto por sua descricao
        public DataTable consultarProdutoPorDescricao(string descricao)
        {
            try
            {
                DataTable tabelaProduto = new DataTable();
                string sql = @"select * from TB_Produtos where Ds_Produto = @descricao";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", descricao);

                conexao.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProduto);

                conexao.Close();
                return tabelaProduto;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Metodo limpa campo

        #endregion
    }
}


