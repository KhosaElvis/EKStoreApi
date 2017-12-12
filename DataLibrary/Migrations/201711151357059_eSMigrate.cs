namespace DataLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eSMigrate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblADDRESS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(),
                        Street = c.String(),
                        Town = c.String(),
                        City = c.String(),
                        Area = c.String(),
                        AreaCode = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tlbUSER", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.tblDELIVERY",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DriverId = c.Int(),
                        CustomerId = c.Int(),
                        AddressId = c.Int(),
                        GpsLoationId = c.Int(),
                        OrderId = c.Int(),
                        Date = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblADDRESS", t => t.AddressId)
                .ForeignKey("dbo.tblCUSTOMER", t => t.CustomerId)
                .ForeignKey("dbo.tblDRIVER", t => t.DriverId)
                .ForeignKey("dbo.tblGPSLOCATION", t => t.GpsLoationId)
                .ForeignKey("dbo.tblORDER", t => t.OrderId)
                .Index(t => t.DriverId)
                .Index(t => t.CustomerId)
                .Index(t => t.AddressId)
                .Index(t => t.GpsLoationId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.tblCUSTOMER",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(),
                        DateSignUp = c.String(),
                        LastTimeLoggedIn = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tlbUSER", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.tblGPSLOCATION",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(),
                        Latitude = c.String(),
                        Longitude = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblCUSTOMER", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.tblORDER",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(),
                        ProductId = c.Int(),
                        DeliveryCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.String(),
                        GrandPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblCUSTOMER", t => t.CustomerId)
                .ForeignKey("dbo.tblPRODUCT", t => t.ProductId)
                .Index(t => t.CustomerId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.tblPAY",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(),
                        DeliveryId = c.Int(),
                        CustomerId = c.Int(),
                        Date = c.String(),
                        Payed = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblCUSTOMER", t => t.CustomerId)
                .ForeignKey("dbo.tblDELIVERY", t => t.DeliveryId)
                .ForeignKey("dbo.tblORDER", t => t.OrderId)
                .Index(t => t.OrderId)
                .Index(t => t.DeliveryId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.tblPRODUCT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(),
                        Name = c.String(),
                        Description = c.String(),
                        Image = c.String(),
                        Barcode = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblCATEGORY", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.tblAD",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(),
                        Description = c.String(),
                        StartDate = c.String(),
                        EndDate = c.String(),
                        IsSpecial = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblPRODUCT", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.tblCATEGORY",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblREPORT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(),
                        SalesYear = c.String(),
                        SalesDateFrom = c.String(),
                        SalesDateTo = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblORDER", t => t.OrderId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.tlbUSER",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        Name = c.String(),
                        Surname = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblDEPARTMENT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Position = c.String(),
                        ManagerId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tlbUSER", t => t.ManagerId)
                .Index(t => t.ManagerId);
            
            CreateTable(
                "dbo.tblEMPLOYEE",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(),
                        UserId = c.Int(),
                        Age = c.Int(nullable: false),
                        StartDate = c.String(),
                        EndDate = c.String(),
                        EmployeeNumber = c.String(),
                        HighestQualification = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblDEPARTMENT", t => t.DepartmentId)
                .ForeignKey("dbo.tlbUSER", t => t.UserId)
                .Index(t => t.DepartmentId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.tblDRIVER",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(),
                        LicenseNumber = c.String(),
                        LicenseType = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblEMPLOYEE", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.tblPROFILE",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(),
                        Image = c.String(),
                        IDNumber = c.String(),
                        DateOfBirth = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tlbUSER", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.tblNEWSLETTER",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblSUBSCRIPTION",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(),
                        NewsLetterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblNEWSLETTER", t => t.NewsLetterId, cascadeDelete: true)
                .ForeignKey("dbo.tlbUSER", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.NewsLetterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblSUBSCRIPTION", "UserId", "dbo.tlbUSER");
            DropForeignKey("dbo.tblSUBSCRIPTION", "NewsLetterId", "dbo.tblNEWSLETTER");
            DropForeignKey("dbo.tblADDRESS", "UserId", "dbo.tlbUSER");
            DropForeignKey("dbo.tblDELIVERY", "OrderId", "dbo.tblORDER");
            DropForeignKey("dbo.tblDELIVERY", "GpsLoationId", "dbo.tblGPSLOCATION");
            DropForeignKey("dbo.tblDELIVERY", "DriverId", "dbo.tblDRIVER");
            DropForeignKey("dbo.tblDELIVERY", "CustomerId", "dbo.tblCUSTOMER");
            DropForeignKey("dbo.tblCUSTOMER", "UserId", "dbo.tlbUSER");
            DropForeignKey("dbo.tblPROFILE", "UserId", "dbo.tlbUSER");
            DropForeignKey("dbo.tblDEPARTMENT", "ManagerId", "dbo.tlbUSER");
            DropForeignKey("dbo.tblEMPLOYEE", "UserId", "dbo.tlbUSER");
            DropForeignKey("dbo.tblDRIVER", "EmployeeId", "dbo.tblEMPLOYEE");
            DropForeignKey("dbo.tblEMPLOYEE", "DepartmentId", "dbo.tblDEPARTMENT");
            DropForeignKey("dbo.tblREPORT", "OrderId", "dbo.tblORDER");
            DropForeignKey("dbo.tblORDER", "ProductId", "dbo.tblPRODUCT");
            DropForeignKey("dbo.tblPRODUCT", "CategoryId", "dbo.tblCATEGORY");
            DropForeignKey("dbo.tblAD", "ProductId", "dbo.tblPRODUCT");
            DropForeignKey("dbo.tblPAY", "OrderId", "dbo.tblORDER");
            DropForeignKey("dbo.tblPAY", "DeliveryId", "dbo.tblDELIVERY");
            DropForeignKey("dbo.tblPAY", "CustomerId", "dbo.tblCUSTOMER");
            DropForeignKey("dbo.tblORDER", "CustomerId", "dbo.tblCUSTOMER");
            DropForeignKey("dbo.tblGPSLOCATION", "CustomerId", "dbo.tblCUSTOMER");
            DropForeignKey("dbo.tblDELIVERY", "AddressId", "dbo.tblADDRESS");
            DropIndex("dbo.tblSUBSCRIPTION", new[] { "NewsLetterId" });
            DropIndex("dbo.tblSUBSCRIPTION", new[] { "UserId" });
            DropIndex("dbo.tblPROFILE", new[] { "UserId" });
            DropIndex("dbo.tblDRIVER", new[] { "EmployeeId" });
            DropIndex("dbo.tblEMPLOYEE", new[] { "UserId" });
            DropIndex("dbo.tblEMPLOYEE", new[] { "DepartmentId" });
            DropIndex("dbo.tblDEPARTMENT", new[] { "ManagerId" });
            DropIndex("dbo.tblREPORT", new[] { "OrderId" });
            DropIndex("dbo.tblAD", new[] { "ProductId" });
            DropIndex("dbo.tblPRODUCT", new[] { "CategoryId" });
            DropIndex("dbo.tblPAY", new[] { "CustomerId" });
            DropIndex("dbo.tblPAY", new[] { "DeliveryId" });
            DropIndex("dbo.tblPAY", new[] { "OrderId" });
            DropIndex("dbo.tblORDER", new[] { "ProductId" });
            DropIndex("dbo.tblORDER", new[] { "CustomerId" });
            DropIndex("dbo.tblGPSLOCATION", new[] { "CustomerId" });
            DropIndex("dbo.tblCUSTOMER", new[] { "UserId" });
            DropIndex("dbo.tblDELIVERY", new[] { "OrderId" });
            DropIndex("dbo.tblDELIVERY", new[] { "GpsLoationId" });
            DropIndex("dbo.tblDELIVERY", new[] { "AddressId" });
            DropIndex("dbo.tblDELIVERY", new[] { "CustomerId" });
            DropIndex("dbo.tblDELIVERY", new[] { "DriverId" });
            DropIndex("dbo.tblADDRESS", new[] { "UserId" });
            DropTable("dbo.tblSUBSCRIPTION");
            DropTable("dbo.tblNEWSLETTER");
            DropTable("dbo.tblPROFILE");
            DropTable("dbo.tblDRIVER");
            DropTable("dbo.tblEMPLOYEE");
            DropTable("dbo.tblDEPARTMENT");
            DropTable("dbo.tlbUSER");
            DropTable("dbo.tblREPORT");
            DropTable("dbo.tblCATEGORY");
            DropTable("dbo.tblAD");
            DropTable("dbo.tblPRODUCT");
            DropTable("dbo.tblPAY");
            DropTable("dbo.tblORDER");
            DropTable("dbo.tblGPSLOCATION");
            DropTable("dbo.tblCUSTOMER");
            DropTable("dbo.tblDELIVERY");
            DropTable("dbo.tblADDRESS");
        }
    }
}
