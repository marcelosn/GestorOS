using System.Collections.Generic;

namespace GestorOS.Models
{
    public class Servico : EntityBase
    {
        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public string PercentualComissao { get; set; }

        public decimal? PercentualValorComissão { get; set; }

        public int UnidadeMedidaId { get; set; }

        public UnidadeMedida UnidadeMedida { get; set; }

        public IEnumerable<OrdemServicoItem> OrdemServicoItems { get; set; }
    }
}
