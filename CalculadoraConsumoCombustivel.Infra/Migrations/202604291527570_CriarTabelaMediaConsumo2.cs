namespace CalculadoraConsumoCombustivel.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarTabelaMediaConsumo2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "CALCULADORA_CONSUMO.MEDIA_CONSUMO_COMBUSTIVEL", name: "CONSUMO_MEDIO_TESTE", newName: "CONSUMO_MEDIO");
        }
        
        public override void Down()
        {
            RenameColumn(table: "CALCULADORA_CONSUMO.MEDIA_CONSUMO_COMBUSTIVEL", name: "CONSUMO_MEDIO", newName: "CONSUMO_MEDIO_TESTE");
        }
    }
}
