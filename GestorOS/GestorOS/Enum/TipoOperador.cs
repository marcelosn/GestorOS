using System.ComponentModel.DataAnnotations;

namespace GestorOS.Enum
{
    public enum TipoOperador
    {
        [Display(Name ="Administrador")]
        administrador,
        [Display(Name = "Padrão")]
        padrao,
    }
}