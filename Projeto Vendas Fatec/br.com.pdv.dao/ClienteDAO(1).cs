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
    class ClienteDAO
    {
        //Conexao com o banco de dados

        private MySqlConnection conexao;

        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();

           
            
        }

        #region Método para cadastrar clientes
        public void cadastrarCliente(Clientes obj)
        {

            try
            {

                //1 Passo - Definir o comando sql - insert into
                string sql = @"insert into TB_Clientes (Nm_Cliente, Nr_RG, Nr_CPF, Ds_Email, Nr_Telefone,
                             Nr_Celular, Ds_CEP, Ds_Endereco, Nr_Endereco, Ds_Complemento, Ds_Bairro,
                             Ds_Cidade, Ds_Estado) 
                             values (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @end, @numero,
                             @comp, @bairro, @cidade, @Estado)";

                //2 Passo - Organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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

                MessageBox.Show("Cliente cadastrado com Sucesso");

                //fecha a conexão
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o erro " + erro);
            }

        }//fecha metodo cadastrar
        #endregion

        #region Método para excluir um cliente
        public void excluirCliente(int id)
        {
            try
            {
                //1 Passo - Definir o comando sql
                string sql = @"delete from TB_Clientes where id = @id";

                // passo 2 - organizar o cmd
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);

                //3 Passo - Abrir conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Excluido com Sucesso!!!");
                //Fecha conexao
                conexao.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show("Ocorreu erro " + e);
            }
        }
        #endregion

        #region Método para alterar um cliente
        public void alterarCliente(Clientes obj)
        {
            try
            {
                //1 Passo - Definir o comando sql - insert into
                string sql = @"update TB_Clientes set Nm_Cliente = @nome, Nr_RG = @rg, Nr_CPF = @cpf, Ds_Email = @email, Nr_Telefone = @telefone,
                             Nr_Celular = @celular, Ds_CEP = @cep, Ds_Endereco = @end, Nr_Endereco = @numero, Ds_Complemento = @comp, Ds_Bairro = @bairro,
                             Ds_Cidade = @cidade, Ds_Estado = @Estado where id = @id";

                //2 Passo - Organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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

                MessageBox.Show("Cliente alterado com Sucesso");
                //fecha a conexão
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu erro: " + erro);
            }
        }
        #endregion

        #region Método que lista todos os clientes
        public DataTable listarClientes()
        {
            try
            {

                //1 Passo - Criar DataTable e o comando sql
                DataTable tabelaCliente = new DataTable();
                string sql = @"select * from TB_Clientes";

                //2 Passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //3 Passo - Abrir a conexao e executar o comando
                conexao.Open();

                //4 Passo - Preencher o DataTable com os dados
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente);

                conexao.Close();
                return tabelaCliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu erro: " + erro);
                return null;
            }
        }//fecha o metodo listarCliente

        #endregion

        #region Método que consulta um cliente por nome
        public DataTable consultarClientePorNome(string nome)
        {
            try
            {
                //1 Passo - Criar DataTable e o comando sql
                DataTable tabelaCliente = new DataTable();
                string sql = @"select * from TB_Clientes where Nm_Cliente = @nome";

                //2 Passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                //3 Passo - Abrir a conexao e executar o comando
                conexao.Open();

                //4 Passo - Preencher o DataTable com os dados
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente);

                conexao.Close();
                return tabelaCliente;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu erro: " + erro);
                return null;
            }
        }

        #endregion

        #region Método que lista clientes por nome
        public DataTable listarClientePorNome(string nome)
        {
            try
            {
                //1 Passo - Criar DataTable e o comando sql
                DataTable tabelaCliente = new DataTable();
                string sql = @"select * from TB_Clientes where Nm_Cliente like @nome";

                //2 Passo - Organizar o comando sql e executar
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);

                //3 Passo - Abrir a conexao e executar o comando
                conexao.Open();

                //4 Passo - Preencher o DataTable com os dados
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCliente);

                conexao.Close();
                return tabelaCliente;

            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu erro: " + erro);
                return null;
            }
        }
        #endregion

        #region Metodo para limpar campos
        

        #endregion

    }//fecha a classe
}
