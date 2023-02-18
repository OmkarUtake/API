namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Std_id = c.Int(nullable: false, identity: true),
                        Std_Name = c.String(),
                        Std_LastName = c.String(),
                    })
                .PrimaryKey(t => t.Std_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
