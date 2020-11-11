using System;

namespace GestorOS.Models
{
    public abstract class EntityBase
    {
        public int Id { get; set; }

        public DateTime DataHoraCadastro { get; set; }
    }
}