using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendas_FATEC.br.com.pdv.model
{
    public class Funcionario : Clientes
    {
        //Atributos Diferentes da Classe Cliente
        public string senha{ get; set; }
        public string cargo { get; set; }
        public string nivelAcesso { get; set; }

    }
}
