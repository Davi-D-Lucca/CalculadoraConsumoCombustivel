using System.Data.Entity;
using CalculadoraConsumoCombustivel.Data.Mapping;
using CalculadoraConsumoCombustivel.Infra.Entidades;

public class AppDbContext : DbContext
{
    public AppDbContext()
        : base("name=OracleDbContext")
    {
    }

    public DbSet<MediaConsumoCombustivel> MediasConsumo { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        // Schema padrão Oracle
        modelBuilder.HasDefaultSchema("CALCULADORA_CONSUMO");

        modelBuilder.Configurations.Add(new MediaConsumoCombustivelMap());

        base.OnModelCreating(modelBuilder);
    }

}