namespace BIPCMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContribution : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contributions",
                c => new
                    {
                        ContributionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Category = c.String(),
                        TransactionType = c.Int(nullable: false),
                        TransactionMode = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        CheckNumber = c.String(),
                        TransactionDate = c.DateTime(nullable: false),
                        Note = c.String(),
                        Status = c.Int(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        DateChanged = c.DateTime(nullable: false),
                        ContributorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContributionId)
                .ForeignKey("dbo.Contributors", t => t.ContributorId, cascadeDelete: true)
                .Index(t => t.ContributorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contributions", "ContributorId", "dbo.Contributors");
            DropIndex("dbo.Contributions", new[] { "ContributorId" });
            DropTable("dbo.Contributions");
        }
    }
}
