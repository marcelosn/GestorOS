using System.ComponentModel.DataAnnotations;

namespace GestorOS.Enum
{
    public enum TipoLancamento
    {
        [Display(Name ="Despesa")]
        despesa,
        [Display(Name = "Receita")]
        receita
    }
}
