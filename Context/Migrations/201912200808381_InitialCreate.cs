namespace Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddressEntities",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        AddressLine = c.String(),
                        City = c.String(),
                        Zipcode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressID);
            
            CreateTable(
                "dbo.DemographicsEntities",
                c => new
                    {
                        DemographicsID = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DemographicsID);
            
            CreateTable(
                "dbo.PersonEntities",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FamilyName = c.String(),
                        FirstName = c.String(),
                        Address_AddressID = c.Int(),
                        Demographics_DemographicsID = c.Int(),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.AddressEntities", t => t.Address_AddressID)
                .ForeignKey("dbo.DemographicsEntities", t => t.Demographics_DemographicsID)
                .Index(t => t.Address_AddressID)
                .Index(t => t.Demographics_DemographicsID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonEntities", "Demographics_DemographicsID", "dbo.DemographicsEntities");
            DropForeignKey("dbo.PersonEntities", "Address_AddressID", "dbo.AddressEntities");
            DropIndex("dbo.PersonEntities", new[] { "Demographics_DemographicsID" });
            DropIndex("dbo.PersonEntities", new[] { "Address_AddressID" });
            DropTable("dbo.PersonEntities");
            DropTable("dbo.DemographicsEntities");
            DropTable("dbo.AddressEntities");
        }
    }
}
