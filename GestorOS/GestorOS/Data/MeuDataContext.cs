using GestorOS.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GestorOS.Data
{
    public class MeuDataContext : DbContext
    {
        public MeuDataContext()
            :base("name=MinhaStringConexaoBanco")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Servico> Servicos { get; set; }

        public DbSet<Objeto> Objetos { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<UnidadeMedida> UnidadeMedidas { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<OrdemServico> OrdemServicos { get; set; }

        public DbSet<OrdemServicoItem> OrdemServicoItems { get; set; }

        public DbSet<FormaPagamento> FormaPagamentos { get; set; }

        public DbSet<SituacaoOrdemServico> SituacaoOrdemServicos { get; set; }

        public DbSet<Operador> Operadores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
