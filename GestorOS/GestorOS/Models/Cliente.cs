using GestorOS.Enum;
using System;
using System.Collections.Generic;

namespace GestorOS.Models
{
    public class Cliente : EntityBase
    {
        public string NomeFantasia { get; set; }

        public string RazaoSocial { get; set; }

        public TipoDocumento? TipoDocumento { get; set; }

        public string Documento { get; set; }

        public string RG { get; set; }

        public string OrgaoEmissor { get; set; }

        public DateTime? DataNascimento { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }

        public string Telefone { get; set; }

        public IEnumerable<OrdemServico> OrdemServicos { get; set; }
    }
}
