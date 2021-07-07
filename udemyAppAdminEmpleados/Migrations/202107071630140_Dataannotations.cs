namespace udemyAppAdminEmpleados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dataannotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empleadoes", "Nombre", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empleadoes", "Nombre", c => c.String());
        }
    }
}
