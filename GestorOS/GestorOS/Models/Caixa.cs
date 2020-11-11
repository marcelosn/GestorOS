using System;

namespace GestorOS.Models
{
    public class Caixa : EntityBase
    {
        public DateTime? DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }
        public DateTime? DataReabertura { get; set; }
        public decimal? ValorInicial { get; set; }
        public decimal? ValorFinal { get; set; }
    }
}
