using Dominio.Model;
using Microsoft.EntityFrameworkCore;

namespace Dominio.Repositorio
{
    public class SgecContext: DbContext
    {
        public SgecContext(DbContextOptions<SgecContext> options)
            : base(options)
        {
        }

        public DbSet<AuditoriaModel> auditoriaDB { get; set; }
        public DbSet<CertidaoCreditoModel> certidaoDB { get; set; }
        public DbSet<ContatoModel> contadoDB { get; set; }
        public DbSet<CreditoModel> creditoDB { get; set; }
        public DbSet<CreditoSituacaoModel> creditoSituacaoDB { get; set; }
        public DbSet<EnderecoModel> enderecoDB { get; set; }
        public DbSet<EstadoCreditoModel>  estadoCreditoDB { get; set; }
        public DbSet<HistoricoValorModel> historicoDB { get; set; }
        public DbSet<HonorarioModel> honorarioDB { get; set; }
        public DbSet<IndiceCorrecaoModel> IndiceCorrecaoDB { get; set; }
        public DbSet<NaturezaCreditoModel> naturezaCreditoDB { get; set; }
        public DbSet<ParteProcessoModel> parteProcessoDB { get; set; }
        public DbSet<PostoModel> postoDB { get; set; }
        public DbSet<SituacaoModel> situacaoDB { get; set; }
        public DbSet<VariacaoIndiceModel> variacaoIndiceDB { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CreditoModel>().ToTable("Credito");
            modelBuilder.Entity<HonorarioModel>().ToTable("Honorario");

            modelBuilder.Entity<HonorarioModel>()
                .HasOne<CreditoModel>()
                .WithOne()
                .HasForeignKey<HonorarioModel>(h => h.creditoID);

        }

    }
}
