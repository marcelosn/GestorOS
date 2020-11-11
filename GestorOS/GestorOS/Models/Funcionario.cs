using System.Collections.Generic;

namespace GestorOS.Models
{
    public class Funcionario : EntityBase
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Celular { get; set; }

        public IEnumerable<OrdemServicoItem> OrdemServicoItems { get; set; }
    }
}
