namespace GestorOS.Models
{
    public class Lancamento : EntityBase
    {
        public int FornecedorId { get; set; }

        /*Entity Framework Relacionamento */
        public Fornecedor Fornecedor { get; set; }
    }
}
