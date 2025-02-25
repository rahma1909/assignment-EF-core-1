using assignment.Data;
using assignment.Models;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext context = new ITIDbContext();

            #region crud operations on student class
            //crud operations on student class

            //insert - create

            //var student = new Student()
            //{
            //    //Id = 1,
            //    FName = "ali",
            //    LName = "mohamed",
            //    Dep_ID = 2,
            //    Age = 20,
            //    Adress = "cairo"
            //};


            //context.students.Add(student);
            //context.SaveChanges();

            //retrive - select

            //var res = context.students.FirstOrDefault(s=>s.Id==1);
            //Console.WriteLine(res.FName);


            //update
            //var student01 = new Student()
            //{
            //    //Id = 1,
            //    FName = "ali",
            //    LName = "mohamed",
            //    Dep_ID = 2,
            //    Age = 20,
            //    Adress = "cairo"
            //};
            //var res = context.students.FirstOrDefault(s => s.Id == 1);
            //res.FName = "roma";
            //context.students.Update(student01);
            //context.SaveChanges(); 



            //delete
            //var res = context.students.FirstOrDefault(s => s.Id == 1);
            //context.students.Remove(res);
            //context.SaveChanges();
            #endregion

            #region crud operations on course
            //create - add
            //var courses = new List<course>()
            //{
            //    new course{Topic_ID=2,Name="linq",Description="vvvv"},
            //    new course{Topic_ID=3,Name="ef",Description="vvvv"},
            //    new course{Topic_ID=4,Name="asp.net",Description="vvvv"},
            //};

            //context.courses.AddRange(courses);
            //context.SaveChanges();


            //retrive 

            //var res=  context.courses.FirstOrDefault(c => c.Id == 2);
            //Console.WriteLine(res.Name);
            //Console.WriteLine(res.Id);
            //Console.WriteLine(res.Topic_ID);


            //update
            //var res = context.courses.FirstOrDefault(c => c.Id == 2);
            //res.Name = "c# advanced";
            //context.courses.Update(res);
            //context.SaveChanges();

            //delete
            //var res = context.courses.FirstOrDefault(c => c.Id == 2);
            //context.courses.Remove(res);
            //context.SaveChanges();
            #endregion

            #region crud operation on the department
            //create-insert

            //var departments = new List<Department>()
            //{
            //    new Department{Name="hr",HiringDate=new DateOnly(2000,1,1),Ins_ID=2 },
            //    new Department{Name="pr",HiringDate=new DateOnly(2000,1,1),Ins_ID=3 },
            //    new Department{Name="hh",HiringDate=new DateOnly(2000,1,1),Ins_ID=4 },

            //};


            //context.Departments.AddRange(departments);
            //context.SaveChanges();


            //retrive
            //var res=  context.Departments.FirstOrDefault(d => d.Id == 2);
            //  Console.WriteLine(res.Name);

            //update
            // var res=  context.Departments.FirstOrDefault(d => d.Id == 2);
            //res.Name = "hr";
            // context.Departments.Update(res);
            // context.SaveChanges();


            //delete
            // var res=  context.Departments.FirstOrDefault(d => d.Id == 3);
            //context.Departments.Remove(res);
            //context.SaveChanges();

            #endregion

            #region crud operation on the topic

            //var topics = new List<Topic>()
            //{
            //   new Topic{Name="parameters"},
            //   new Topic{Name="functions"},

            //};


            //context.Topics.AddRange(topics);
            //context.SaveChanges();

            //retrive
            //var res = context.Topics.Where(t => t.Id == 1).FirstOrDefault();
            //Console.WriteLine(res.Name);

            //update
            //var res = context.Topics.Where(t => t.Id == 1).FirstOrDefault();
            //res.Name = "data seeding";
            //context.Topics.Update(res);
            // context.SaveChanges();


            //delete
            //var res = context.Topics.Where(t => t.Id == 1).FirstOrDefault();
            //context.Topics.Remove(res);
            // context.SaveChanges();
            #endregion

            #region crud operation on the instructors
            //create
       //     var insructors = new List<Instructor>()
       //     {
       //new Instructor{Name="mohamed",address="cairo",bouns=120,salary=1200,HourRate=30},
     
       //     };
            //context.Instructors.AddRange(insructors);
            //context.SaveChanges();


            //retrive
            //var res = context.Instructors.FirstOrDefault(i => i.Id == 1);
            //Console.WriteLine(res.address);


            //update
            //var res = context.Topics.Where(t => t.Id == 1).FirstOrDefault();
            //res.Name = "mo";
            //context.Topics.Update(res);
            //context.SaveChanges();


            //delete
            //var res = context.Topics.Where(t => t.Id == 1).FirstOrDefault();
            //context.Topics.Remove(res);
            // context.SaveChanges();
            #endregion
        }
    }
}
