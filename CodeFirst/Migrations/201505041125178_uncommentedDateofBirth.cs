namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uncommentedDateofBirth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "BirthofDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "BirthofDate");
        }
    }
}
