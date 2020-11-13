namespace GestorOS.Models
{
    public class FormaPagamentoOrdemServico : EntityBase
    {
        public int OrdemServicoId { get; set; }

        public int TipoFormaPagamentoId { get; set; }

        public decimal Valor { get; set; }

        public TipoFormaPagamento TipoFormaPagamento { get; set; }

        public OrdemServico OrdemServico { get; set; }
    }
}
