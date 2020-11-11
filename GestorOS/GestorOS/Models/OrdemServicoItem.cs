namespace GestorOS.Models
{
    public class OrdemServicoItem : EntityBase
    {
        public int OrdemServicoId { get; set; }

        public int? ServicoId { get; set; }

        public int? ProdutoId { get; set; }

        public int FuncionarioId { get; set; }

        public int Item { get; set; }

        public int Qtde { get; set; }

        public string Observacao { get; set; }

        public decimal ValorDesconto { get; set; }

        public decimal ValorUnitario { get; set; }

        public decimal ValorSubTotal { get; set; }

        public decimal ValorTotal { get; set; }

        public Servico Servico { get; set; }
        public OrdemServico OrdemServico { get; set; }
        public Produto Produto { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
