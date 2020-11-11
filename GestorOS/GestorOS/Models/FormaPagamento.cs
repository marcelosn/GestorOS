using System.Collections.Generic;

namespace GestorOS.Models
{
    public class FormaPagamento : EntityBase
    {
        public string Nome { get; set; }
        public IEnumerable<OrdemServico> OrdemServicos { get; set; }
    }
}
