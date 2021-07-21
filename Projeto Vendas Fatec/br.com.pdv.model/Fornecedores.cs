using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas_FATEC.br.com.pdv.model
{
    public class Fornecedores : Clientes
    {
        //Atributos diferentes de Clientes
        public string cnpj { get; set; }
    }
}
