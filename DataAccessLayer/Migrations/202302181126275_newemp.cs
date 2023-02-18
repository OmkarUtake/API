namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newemp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Std_FirstName", c => c.String());
            DropColumn("dbo.Students", "Std_Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Std_Name", c => c.String());
            DropColumn("dbo.Students", "Std_FirstName");
        }
    }
}
