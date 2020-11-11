using System;
using System.Collections.Generic;

namespace GestorOS.Models
{
    public class OrdemServico : EntityBase
    {
        public int OperadorId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public int SituacaoOrdemServicoId { get; set; }

        public int? FormaPagamentoId { get; set; }

        public int ClienteId { get; set; }

        public int ObjetoId { get; set; }

        public string DescricaoProblema { get; set; }

        public string Observacoes { get; set; }

        public decimal ValorDesconto { get; set; }

        public decimal ValorAcrescimo { get; set; }

        public decimal ValorTotalServico { get; set; }

        public decimal ValorTotalProduto { get; set; }

        public decimal ValorTotal { get; set; }

        public Operador Operador { get; set; }
        public SituacaoOrdemServico SituacaoOrdemServico { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public Cliente Cliente { get; set; }
        public Objeto Objeto { get; set; }
        public IEnumerable<OrdemServicoItem> OrdemServicoItems { get; set; }
    }
}
