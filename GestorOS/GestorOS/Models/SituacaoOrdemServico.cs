using System.Collections.Generic;

namespace GestorOS.Models
{
    public class SituacaoOrdemServico : EntityBase
    {
        public string Nome { get; set; }
        public IEnumerable<OrdemServico> OrdemServicos { get; set; }
    }
}
