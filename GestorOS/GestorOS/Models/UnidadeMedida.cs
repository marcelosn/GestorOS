using System.Collections.Generic;

namespace GestorOS.Models
{
    public class UnidadeMedida : EntityBase
    {
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
        public IEnumerable<Servico> Servicos { get; set; }
    }
}
