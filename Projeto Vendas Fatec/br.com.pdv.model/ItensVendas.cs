using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas_FATEC.br.com.pdv.model
{
    public class ItensVendas
    {
        public int id { get; set; }

        public int vendas_id { get; set; }

        public int produto_id { get; set; }

        public int qtd { get; set; }

        public decimal subtotal { get; set; }
    }
}
