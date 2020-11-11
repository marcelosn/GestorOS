using GestorOS.Enum;
using System.Collections.Generic;

namespace GestorOS.Models
{
    public class Operador : EntityBase
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public TipoOperador TipoOperador { get; set; }//ADMINISTRADOR - OPERADOR
        public IEnumerable<OrdemServico> OrdemServicos { get; set; }
    }
}
