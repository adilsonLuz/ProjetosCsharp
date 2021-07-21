using MySql.Data.MySqlClient;
using Projeto_Vendas_FATEC.br.com.pdv.conexao;
using Projeto_Vendas_FATEC.br.com.pdv.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas_FATEC.br.com.pdv.dao
{
    public class ItensVendasDAO
    {
        //Conexao com o banco de dados

        private MySqlConnection conexao;

        public ItensVendasDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }


        #region Método que cadastra um item de venda
        public void cadastrarItem(ItensVendas obj)
        {
            //1 Passo - Criar comando SQL
            string sql = @"insert into TB_ItensVendas (ID_Vendas, ID_Produtos, Qt_ItensVendas, Qt_SubTotal)
                           values (@venda_id, @produto_id, @qtd, @subtotal)";

            //2 Passo - Organizar e executar o comando SQL
            MySqlCommand executacmd = new MySqlCommand(sql, conexao);
            executacmd.Parameters.AddWithValue("@venda_id", obj.vendas_id);
            executacmd.Parameters.AddWithValue("@produto_id", obj.produto_id);
            executacmd.Parameters.AddWithValue("@qtd", obj.qtd);
            executacmd.Parameters.AddWithValue("@subtotal", obj.subtotal);

            //3 Passo - Abrir a conexao e executar o comando
            conexao.Open();
            executacmd.ExecuteNonQuery();

            conexao.Close();

        }
        #endregion
    }
}
