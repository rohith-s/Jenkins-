namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        student_StudentId = c.Int(),
                    })
                .PrimaryKey(t => t.SubjectId)
                .ForeignKey("dbo.Students", t => t.student_StudentId)
                .Index(t => t.student_StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "student_StudentId", "dbo.Students");
            DropIndex("dbo.Subjects", new[] { "student_StudentId" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
        }
    }
}
