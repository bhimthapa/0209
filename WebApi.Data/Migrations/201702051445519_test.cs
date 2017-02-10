namespace WebApi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Property = c.Int(nullable: false),
                        Address = c.String(),
                        PhoneNo = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.Employments",
                c => new
                    {
                        EmploymentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Salary = c.Int(nullable: false),
                        Address = c.String(),
                        PhoneNo = c.String(),
                    })
                .PrimaryKey(t => t.EmploymentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employments");
            DropTable("dbo.Companies");
        }
    }
}
