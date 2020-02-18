namespace MVC_Form.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Employee_ID = c.Int(nullable: false, identity: true),
                        Employee_Name = c.String(),
                        Employee_Password = c.String(),
                    })
                .PrimaryKey(t => t.Employee_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
