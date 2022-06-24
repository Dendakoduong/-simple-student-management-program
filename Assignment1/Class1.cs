using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Student
    {
        public string studentID { get; set; }
        public string name { get; set; }
        public double score { get; set; }
        public string email { get; set; }

        public Student()

        {

        }
        public Student(string studentID, string name, double score, string email)


        {
            this.studentID = studentID;
            this.name = name;
            this.score = score;
            this.email = email;
        }

        public void Input()
        {
            Console.WriteLine("Enter student ID: ");
            studentID = Console.ReadLine();

            Console.WriteLine("Enter student name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter student score: ");
            score = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter student email: ");
            email = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("Student ID: " + studentID);
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Student score: " + score);
            Console.WriteLine("Student email: " + email);
            Console.WriteLine("Ranked academic: " + Getrank);
            Console.WriteLine("*********************************");
        }
        public string Getrank
        {
            get
            {
                if (score >= 85)
                {
                    return "High Distinction";
                }
                else if (score >= 75)
                {
                    return "Distinction";
                }
                else if (score >= 65)
                {
                    return "Credit";
                }
                else if (score >= 50)
                {
                    return "Pass";
                }
                else
                {
                    return "Fail";
                }
            }
        }

    }
}