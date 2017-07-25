namespace BIPCMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateContributors : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Contributions", new[] { "ContributorId" });
            CreateIndex("dbo.Contributions", "ContributorID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Contributions", new[] { "ContributorID" });
            CreateIndex("dbo.Contributions", "ContributorId");
        }
    }
}
