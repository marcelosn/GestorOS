using System.Collections.Generic;

namespace GestorOS.Models
{
    public class Produto : EntityBase
    {
        public string Nome { get; set; }

        public string DescricaoGeral { get; set; }
        
        public string CodigoBarra { get; set;}

        public decimal PrecoVenda { get; set; }

        public decimal PrecoCusto { get; set; }

        public string MargemLucro { get; set; }

        public int QtdeMinima { get; set; }

        public int QtdeMaxima { get; set; }

        public int QtdeEstoque { get; set; }

        public int UnidadeMedidaId { get; set; }

        public UnidadeMedida UnidadeMedida { get; set; }

        public IEnumerable<OrdemServicoItem> OrdemServicoItems { get; set; }
    }
}
