using GenericRepository_Method.Models;
using GenericRepository_Method.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositoryManger manger = new RepositoryManger();
            var repoS = manger.Get<Student>();
            repoS.Add(new Student { Id = 1, Name = "Tarana S", BirthDate = new DateTime(2012, 11, 23), Semester = "Winter" });
            repoS.Add(new Student { Id = 2, Name = "Sumaia J", BirthDate = new DateTime(2003, 11, 23), Semester = "Spring" });
            repoS.Add(new Student { Id = 3, Name = "Farjana S", BirthDate = new DateTime(2011, 11, 23), Semester = "Winter" });
            Console.WriteLine("Read operation");
            repoS.GetAll()
                .ToList()
                .ForEach(s=> Console.WriteLine($"Id: {s.Id} Name: {s.Name} Semester: {s.Semester}"));
            Console.WriteLine("Get student with id 2");
            var st = repoS.Get(x => x.Id == 2);
            Console.WriteLine($"Id: {st.Id} Name: {st.Name} Semester: {st.Semester}");
            Console.WriteLine("Update student with id 2");
            repoS.Update(x => x.Id == 2, new Student { Id = 2, Name = "Sumaiya J", BirthDate = new DateTime(2013, 11, 23), Semester = "Spring" });
                repoS.GetAll()
                .ToList()
                .ForEach(s => Console.WriteLine($"Id: {s.Id} Name: {s.Name} Semester: {s.Semester}"));
            Console.WriteLine("Delete student with id 2");
            repoS.Delete(x => x.Id == 2);
            repoS.Update(x => x.Id == 2, new Student { Id = 2, Name = "Sumaiya J", BirthDate = new DateTime(2013, 11, 23), Semester = "Spring" });
            repoS.GetAll()
            .ToList()
            .ForEach(s => Console.WriteLine($"Id: {s.Id} Name: {s.Name} Semester: {s.Semester}"));
            Console.WriteLine();
            var repoT = manger.Get<Teacher>();
            Teacher t1 = new Teacher { Id = 101, Department = "CSE", Name = "Pavel I", Email = "p@gg.com" };
            Teacher t2 = new Teacher { Id = 102, Department = "EEE", Name = "Abdel H", Email = "a@gg.com" };
            Teacher t3 = new Teacher { Id = 103, Department = "MIS", Name = "Sazu M", Email = "s@gg.com" };
            repoT.Add(t1);
            repoT.Add(t2);
            repoT.Add(t3);
            Console.WriteLine("Read operation");
            repoT.GetAll()
                .ToList()
                .ForEach(t => Console.WriteLine($"Name: {t.Name}, Department: {t.Department}, Email: {t.Email}"));
            Console.WriteLine("Get teacher with id 102");
            var tt = repoT.Get(x => x.Id == 102);
            Console.WriteLine($"Name: {tt.Name}, Department: {tt.Department}, Email: {tt.Email}");
            Console.WriteLine("Update teacher with id 102");
            t2.Name = "Abdel K";
            repoT.Update(x => x.Id == 102, t2);
            repoT.GetAll()
                .ToList()
                .ForEach(t => Console.WriteLine($"Name: {t.Name}, Department: {t.Department}, Email: {t.Email}"));
            Console.WriteLine("Delete teacher with id 102");
            repoT.Delete(x => x.Id == 102);
            repoT.GetAll()
                .ToList()
                .ForEach(t => Console.WriteLine($"Name: {t.Name}, Department: {t.Department}, Email: {t.Email}"));
            Console.ReadLine();
        }
    }
}
