﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Work
{
    class Teacher:Person
    {
        public int salary;
        public Teacher()
        {

        }

        public Teacher(string name)
        {
            this.name = name;
        }
        public Teacher(string name, string surname) : this(name)
        {
            this.surname = surname;
        }

        public Teacher(string name, string surname, int age) : this(name, surname)
        {
            this.age = age;
        }

        public Teacher(string name, string surname, int age,int salary):this(name,surname,age)
        {
            this.salary = salary;
        }

        public void GetInfoTeacher()
        {
            Console.WriteLine($"Ad:{name} Soyad:{surname} Yash:{age} Maaş{salary}");
        }
    }
}
