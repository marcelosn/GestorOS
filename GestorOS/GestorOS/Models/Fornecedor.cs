using GestorOS.Enum;
using System.Collections.Generic;

namespace GestorOS.Models
{
    public class Fornecedor : EntityBase
    {
        public TipoDocumento TipoDocumento { get; set; }

        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public string Documento { get; set; }

        /*Entity Framework Relacionamento*/
        public IEnumerable<Lancamento> Lancamentos { get; set; }
    }
}
