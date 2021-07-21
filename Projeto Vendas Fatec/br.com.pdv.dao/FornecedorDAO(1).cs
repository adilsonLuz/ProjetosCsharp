using MySql.Data.MySqlClient;
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
    public class FornecedorDAO
    {
        //Conexao com o banco de dados

        private MySqlConnection conexao;

        public FornecedorDAO()
        {
            this.conexao = new conexao.ConnectionFactory().getconnection();

            //Abre uyma conexao
        }


        #region Metodo para cadastrar um Fornecedor
        public void cadastrarFornecedor(Fornecedores obj)
        {
            try
            {
                //1 Passo - Definir o comando sql - insert into
                string sql = @"insert into TB_Fornecedores (Nm_Fornecedor, Nr_CNPJ, Ds_Email,
                             Nr_Telefone, Nr_Celular, Ds_CEP, Ds_Endereco, Nr_Endereco,
                             Ds_Complemento, Ds_Bairro, Ds_Cidade, Ds_Estado) 
                             values (@nome, @cnpj, @email, @telefone, @celular, @cep, @end, 
                             @numero, @comp, @bairro, @cidade, @Estado)";

                //2 Passo - Organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@end", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numend);
                executacmd.Parameters.AddWithValue("@comp", obj.complemenmto);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                //3 Passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com Sucesso");

                //fecha a conexão
                conexao.Close();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu o erro " + erro);
            }
        }//Fecha o metodo cadastrar
        #endregion

        #region Método para excluir um Fornecedor
        public void excluirFornecedor(int id)
        {
            try
            {
                //1 Passo - Definir o comando sql
                string sql = @"delete from TB_Fornecedores where id = @id";

                // passo 2 - organizar o cmd
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);

                //3 Passo - Abrir conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor Excluido com Sucesso!!!");
                //Fecha conexao
                conexao.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show("Ocorreu erro " + e);
            }
        }
        #endregion

        #region Método para Editar Fornecedor
        public void editarFornecedor(Fornecedores obj)
        {
            try
            {
                //1 Passo - Definir o comando sql - insert into
                string sql = @"update TB_Fornecedores set Nm_Fornecedor = @nome, Nr_CNPJ = @cnpj, Ds_Email = @email,
                             Nr_Telefone = @telefone, Nr_Celular = @celular, Ds_CEP = @cep, Ds_Endereco = @end, Nr_Endereco = @numero,
                             Ds_Complemento = @comp, Ds_Bairro = @bairro, Ds_Cidade = @cidade, Ds_Estado = @Estado where id = @id";

                //2 Passo - Organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@end", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numend);
                executacmd.Parameters.AddWithValue("@comp", obj.complemenmto);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                //Passando o id
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //3 Passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor alterado com Sucesso");

                //fecha a conexão
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu erro: " + erro);
            }
        }
        #endregion

        #region Método que lista todos os Fornecedores
        public DataTable listarFornecedor()
        {
            try
            {
                //1 Passo - Criar DataTable e o comando sql
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select * from TB_Fornecedores";

                //2 Passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //3 Passo - Abrir a conexao e executar o comando
                conexao.Open();

                //4 Passo - Preencher o DataTable com os dados
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);

                conexao.Close();
                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu erro: " + erro);
                return null;
            }
        }//fecha o metodo listarFornecedor
        #endregion

        #region Método que lista Fornecedor por nome
        public DataTable listarFornecedorPorNome(string nome)
        {
            try
            {
                //1 Passo - Criar DataTable e o comando sql
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select * from TB_Fornecedores where Nm_Fornecedor like @nome";

                //2 Passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                //3 Passo - Abrir a conexao e executar o comando
                conexao.Open();

                //4 Passo - Preencher o DataTable com os dados
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);

                conexao.Close();
                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Método que consulta um Fornecedor por nome
        public DataTable consultarFornecedorPorNome(string nome)
        {
            try
            {
                //1 Passo - Criar DataTable e o comando sql
                DataTable tabelaFornecedor = new DataTable();
                string sql = @"select * from TB_Fornecedores where Nm_Fornecedor = @nome";

                //2 Passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                //3 Passo - Abrir a conexao e executar o comando
                conexao.Open();

                //4 Passo - Preencher o DataTable com os dados
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFornecedor);

                conexao.Close();
                return tabelaFornecedor;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Metodo Limpar Campos


        #endregion
    }
}
