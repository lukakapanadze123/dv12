using System;
using System.Collections.Generic;
using System.Text;

namespace dv12
{
    internal class Student : IComparable<Student>
    {
        public Student(string name, string surname, int age, int sore)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Sore = sore;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Sore { get; set; }

        public int CompareTo(Student? other)
        {
            return this.Sore.CompareTo(other.Sore);
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student
                && this.Name == student.Name
                && this.Surname == student.Surname
                && this.Age == student.Age
                && this.Sore == student.Sore;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}