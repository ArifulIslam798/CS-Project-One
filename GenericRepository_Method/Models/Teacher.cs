using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository_Method.Models
{
    public class Teacher
    {
        public Teacher() { }
        public Teacher(int id, string name, string department, string email)
        {
            Id = id;
            Name = name;
            Department = department;
            Email = email;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
    }
}
