using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._12._2022_homeWork.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool IsStudent { get; set; }

        public Person(string name, string surname, int age, bool isStudent)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IsStudent = isStudent;  
        }
    }
}
