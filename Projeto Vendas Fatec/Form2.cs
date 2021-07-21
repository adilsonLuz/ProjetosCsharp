using MySql.Data.MySqlClient;
using Projeto_Vendas_FATEC.br.com.pdv.conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Vendas_FATEC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao;

                    conexao = new ConnectionFactory().getconnection();

                    conexao.Open();

                MessageBox.Show("Conectado com sucesso!");
            }

            catch (MySqlException erro)
            {
                MessageBox.Show("Desconectado! Erro: " + erro);
            }
        }

    }
}
