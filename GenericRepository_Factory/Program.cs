using GenericRepository_Factory.Factories;
using GenericRepository_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EntityFactory ef = new EntityFactory();
            RepositoryFactory rf = new RepositoryFactory();
            var s1 = ef.Create<Student>(1, "Tarana S", new DateTime(2012, 11, 23), "Winter");
            var s2 = ef.Create<Student>(2, "Sumaiya J", new DateTime(2003, 11, 23), "Spring");
            var s3 = ef.Create<Student>(3, "Farjana S", new DateTime(2013, 11, 23), "Winter");
            var repoS = rf.Create<Student>();
            repoS.Add(s1);
            repoS.Add(s2);
            repoS.Add(s3);
            Console.WriteLine("Read operation");
            repoS.GetAll()
                .ToList()
                .ForEach(s => Console.WriteLine($"Id: {s.Id} Name: {s.Name} Semester: {s.Semester}"));
            Console.WriteLine("Get student with id 2");
            var st = repoS.Get(2);
            Console.WriteLine($"Id: {st.Id} Name: {st.Name} Semester: {st.Semester}");
            Console.WriteLine("Update student with id 2");
            s2.Name = "S Jui";
            repoS.Update(s2);
            repoS.GetAll()
            .ToList()
            .ForEach(s => Console.WriteLine($"Id: {s.Id} Name: {s.Name} Semester: {s.Semester}"));
            Console.WriteLine("Delete student with id 2");
            repoS.Delete(2);
            repoS.GetAll()
            .ToList()
            .ForEach(s => Console.WriteLine($"Id: {s.Id} Name: {s.Name} Semester: {s.Semester}"));
            Console.WriteLine();
            Teacher t1 = ef.Create<Teacher>(101, "Pavel I", "CSE", "p@gg.com");
            Teacher t2 = ef.Create<Teacher>(102, "Abdel H", "EEE", "a@gg.com");
            Teacher t3 = ef.Create<Teacher>(103, "Sazu M", "MIS", "s@gg.com");
            var repoT = rf.Create<Teacher>();
            repoT.Add(t1);
            repoT.Add(t2);
            repoT.Add(t3);
            Console.WriteLine("Read operation");
            repoT.GetAll()
                .ToList()
                .ForEach(t => Console.WriteLine($"Name: {t.Name}, Department: {t.Department}, Email: {t.Email}"));
            Console.WriteLine("Get teacher with id 102");
            var tt = repoT.Get(102);
            Console.WriteLine($"Name: {tt.Name}, Department: {tt.Department}, Email: {tt.Email}");
            Console.WriteLine("Update teacher with id 102");
            t2.Name = "Abdel K";
            repoT.Update(t2);
            repoT.GetAll()
                .ToList()
                .ForEach(t => Console.WriteLine($"Name: {t.Name}, Department: {t.Department}, Email: {t.Email}"));
            Console.WriteLine("Delete teacher with id 102");
            repoT.Delete(102);
            repoT.GetAll()
                .ToList()
                .ForEach(t => Console.WriteLine($"Name: {t.Name}, Department: {t.Department}, Email: {t.Email}"));
            Console.ReadLine();
        }
    }
}
