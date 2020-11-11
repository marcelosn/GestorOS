using System.ComponentModel.DataAnnotations;

namespace GestorOS.Enum
{
    public enum TipoDocumento
    {
        [Display(Name = "Pessoa Física")]
        fisica,
        [Display(Name = "Pessoa Jurídica")]
        juridica
    }
}
