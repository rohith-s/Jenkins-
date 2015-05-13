namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedDateofBirth : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "BirthofDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "BirthofDate", c => c.DateTime(nullable: false));
        }
    }
}
