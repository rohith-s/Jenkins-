namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateofBirthNameChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "BirthofDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Students", "BirthDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "BirthDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Students", "BirthofDate");
        }
    }
}
