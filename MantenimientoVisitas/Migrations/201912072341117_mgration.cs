namespace MantenimientoVisitas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mgration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Persona",
                c => new
                    {
                        PersonaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Identificacion = c.String(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PersonaID);
            
            CreateTable(
                "dbo.Visita",
                c => new
                    {
                        VisitaID = c.Int(nullable: false, identity: true),
                        Motivo = c.String(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        HoraEntrada = c.Time(nullable: false, precision: 7),
                        HoraSalida = c.Time(nullable: false, precision: 7),
                        PersonaID = c.Int(nullable: false),
                        Usuario = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.VisitaID)
                .ForeignKey("dbo.Persona", t => t.PersonaID, cascadeDelete: true)
                .Index(t => t.PersonaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Visita", "PersonaID", "dbo.Persona");
            DropIndex("dbo.Visita", new[] { "PersonaID" });
            DropTable("dbo.Visita");
            DropTable("dbo.Persona");
        }
    }
}
