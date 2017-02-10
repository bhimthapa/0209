namespace WebApi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addexceptiontable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MethodName = c.String(),
                        Type = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EventLogs");
        }
    }
}
