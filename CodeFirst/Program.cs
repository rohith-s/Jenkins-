using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var student = new Student() { Name = "Rohith" };
                var mathSubj = new Subject() { Name = "Mathematics" };
                var scienceSubj = new Subject() { Name = "Science" };
                student.Subjects.Add(mathSubj);
                student.Subjects.Add(scienceSubj);
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }
    public class Student
    { 
        public Student() {
            this.Subjects=new List<Subject>();
        }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime BirthofDate { get; set; }
        public virtual List<Subject> Subjects { get; set; }
    }
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public virtual Student student { get; set; }
    }

    class StudentContext : DbContext
    {
        public StudentContext()
            : base("name=Database") 
            {
            }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }
}
