// Write a program which has a class of Student with Id, Name and Date of Birth. 
// You can set the Date of birth at the time of Admission (object creation),  and have a property which calculates the age.
// (use property  get accessors ) and can be accessed from the client / main program. 
// Also ensure user can not enter the Dob or Age at a later point of time in the program
// Hint - Make use of Date time , time span we learnt on Day 5.  
using System;

namespace StudentProject
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DOB { get; }

        public int Age { get; }

        public Student(int id, string name, string dob)
        {
            string[] date;
            date = dob.Split(":");

            this.StudentId = id;
            this.StudentName = name;
            this.DOB = new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]), 0, 0, 0); ;

            var today = DateTime.Now;
            this.Age = today.Year - this.DOB.Year;

            Console.WriteLine($"Admission for {name} was successfull");
        }
        public void StudentDetail()
        {
            Console.WriteLine($"Student Name:{this.StudentName}, Student Age:{this.Age}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student(1, "Samuel", "1999:10:31");
            student1.StudentDetail();

        }
    }
}
