using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas_FATEC.br.com.pdv.model
{
    public class Vendas
    {
        public int id { get; set; }

        public int cliente_id { get; set; }

        public DateTime dada_venda { get; set; }

        public decimal total_venda { get; set; }

        public string obs { get; set; }
    }
}
