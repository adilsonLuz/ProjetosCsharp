using MySql.Data.MySqlClient;
using Projeto_Vendas_FATEC.br.com.pdv.conexao;
using Projeto_Vendas_FATEC.br.com.pdv.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_FATEC.br.com.pdv.dao
{
    public class VendasDAO
    {
        private MySqlConnection conexao;
        public VendasDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region Método cadastrar venda
        public void cadastrarVendas(Vendas obj)
        {
            try
            {
                //1 Passo - Definir o comando sql
                string sql = @"insert into TB_Vendas (ID_Cliente, Dt_Venda, Qt_TotalVenda, Ds_Observacoes)
                               values (@cliente_id, @data_venda, @total_venda, @obs)";

                //2 Passo - Organizar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@cliente_id", obj.cliente_id);
                executacmd.Parameters.AddWithValue("@data_venda", obj.dada_venda);
                executacmd.Parameters.AddWithValue("@total_venda", obj.total_venda);
                executacmd.Parameters.AddWithValue("@obs", obj.obs);

                //3 Passo - Abrir a conexao e executa o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Venda realizada... Sucesso");
                //fecha a conexão
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu erro: " + erro);
            }
        }
        #endregion

        #region metodo que retorna o id da ultima venda
        public int retornaIdUltimaVenda()
        {
            try
            {
                int idVenda = 0;              
                //1 Passo - Criar SQL
                string sql = @"select max(ID) ID from TB_Vendas";

                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

                //3 Passo - Abrir conexao e executar comando
                conexao.Open();

                MySqlDataReader dr = executacmdsql.ExecuteReader();

                if (dr.Read())
                {
                    idVenda = dr.GetInt32("id");
                }

                conexao.Close();

                return idVenda;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu erro: " + erro);
                return 0;
            }
        } 
        #endregion
    }
}
