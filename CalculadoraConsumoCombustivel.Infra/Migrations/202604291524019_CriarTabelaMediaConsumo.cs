namespace CalculadoraConsumoCombustivel.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarTabelaMediaConsumo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "CALCULADORA_CONSUMO.MEDIA_CONSUMO_COMBUSTIVEL",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        VEICULO = c.String(nullable: false, maxLength: 100),
                        COMBUSTIVEL = c.Decimal(nullable: false, precision: 10, scale: 0),
                        QUANTIDADE = c.Decimal(nullable: false, precision: 10, scale: 0),
                        CONSUMO_MEDIO = c.Decimal(nullable: false, precision: 10, scale: 0),
                        DISTANCIA_PERCORRIDA = c.String(nullable: false, maxLength: 50),
                        CRIADO_EM = c.DateTime(nullable: false),
                        MODIFICADO_EM = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("CALCULADORA_CONSUMO.MEDIA_CONSUMO_COMBUSTIVEL");
        }
    }
}
