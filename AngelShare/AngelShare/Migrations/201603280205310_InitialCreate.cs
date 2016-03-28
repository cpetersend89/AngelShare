namespace AngelShare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MembershipName = c.String(),
                        MembershipDescription = c.String(),
                        MembershipPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        SurveyId = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        CoffeeQuestionResponse = c.String(),
                        NoseQuestionResponse = c.String(),
                        WhiskeyDrinkResponse = c.String(),
                        TypeOfWhiskyResponse = c.String(),
                        AbvPreferenceResponse = c.String(),
                        NewSpiritsResponse = c.String(),
                    })
                .PrimaryKey(t => t.SurveyId);
            
            CreateTable(
                "dbo.WhiskeyBoxes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WhiskeyID = c.Int(nullable: false),
                        MembershipID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Memberships", t => t.MembershipID, cascadeDelete: true)
                .ForeignKey("dbo.Whiskeys", t => t.WhiskeyID, cascadeDelete: true)
                .Index(t => t.WhiskeyID)
                .Index(t => t.MembershipID);
            
            CreateTable(
                "dbo.Whiskeys",
                c => new
                    {
                        WhiskeyID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        ProductName = c.String(),
                        Description = c.String(),
                        Proof = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Age = c.Int(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.WhiskeyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WhiskeyBoxes", "WhiskeyID", "dbo.Whiskeys");
            DropForeignKey("dbo.WhiskeyBoxes", "MembershipID", "dbo.Memberships");
            DropIndex("dbo.WhiskeyBoxes", new[] { "MembershipID" });
            DropIndex("dbo.WhiskeyBoxes", new[] { "WhiskeyID" });
            DropTable("dbo.Whiskeys");
            DropTable("dbo.WhiskeyBoxes");
            DropTable("dbo.Surveys");
            DropTable("dbo.Memberships");
        }
    }
}
