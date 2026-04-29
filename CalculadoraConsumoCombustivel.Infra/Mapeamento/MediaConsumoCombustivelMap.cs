using CalculadoraConsumoCombustivel.Infra.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace CalculadoraConsumoCombustivel.Data.Mapping
{
    public class MediaConsumoCombustivelMap
        : EntityTypeConfiguration<MediaConsumoCombustivel>
    {
        public MediaConsumoCombustivelMap()
        {
            // Nome da tabela
            ToTable("MEDIA_CONSUMO_COMBUSTIVEL", "CALCULADORA_CONSUMO");

            // Chave primária
            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("ID");

            Property(x => x.CriadoEm)
                .HasColumnName("CRIADO_EM")
                .IsRequired();

            Property(x => x.ModificadoEm)
                .HasColumnName("MODIFICADO_EM");

            // Veículo
            Property(x => x.Veiculo)
                .HasColumnName("VEICULO")
                .HasMaxLength(100)
                .IsRequired();

            // Combustível (Enum)
            Property(x => x.Combustivel)
                .HasColumnName("COMBUSTIVEL")
                .IsRequired();

            // Quantidade
            Property(x => x.Quantidade)
                .HasColumnName("QUANTIDADE")
                .IsRequired();

            // Consumo Médio
            Property(x => x.ConsumoMedio)
                .HasColumnName("CONSUMO_MEDIO_TESTE")
                .IsRequired();

            // Distância Percorrida
            Property(x => x.DistanciaPercorrida)
                .HasColumnName("DISTANCIA_PERCORRIDA")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}