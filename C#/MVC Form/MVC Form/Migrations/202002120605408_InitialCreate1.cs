namespace MVC_Form.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Employee_Title", c => c.String());
            DropColumn("dbo.Employees", "Employee_Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Employee_Password", c => c.String());
            DropColumn("dbo.Employees", "Employee_Title");
        }
    }
}
