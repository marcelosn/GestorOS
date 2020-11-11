using GestorOS.Enum;

namespace GestorOS.Models
{
    public class Empresa : EntityBase
    {
        public TipoDocumento TipoDocumento { get; set; }
        public string Documento { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string PathLogoMarca { get; set; }
        public bool ConfirmaImpressao { get; set; }
        public int QtdeImpressao { get; set; }
    }
}
