using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Login";
            Console.Write("Sign In   \n");
            Console.Write("---------------\n");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            if (username == "admin")
            {
            }
            else
            {
                Console.WriteLine("Incorrect username. The program will automatically exit.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            Console.Write("Password: ");
            string password = Console.ReadLine();
            if (password == "admin")
            {
                Console.Clear();
                Console.WriteLine("Signing in...");
                Thread.Sleep(1000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Incorrect password. The program will automatically exit.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }

            while (true)
            {
                
                Console.Write("***** Welcome to Student Management System *****\n");
                Console.Write("           Please choose an action              \n");
                Console.Write("                      *                         \n");
                Console.Write("      [1] Add new student(s)                    \n");
                Console.Write("      [2] Search for student with Student ID    \n");
                Console.Write("      [3] Find students by score range          \n");
                Console.Write("      [4] Find students by ranked               \n");
                Console.Write("      [5] Sort students by score                \n");
                Console.Write("      [6] Show top 3 students                   \n");
                Console.Write("      [7] Change student information            \n");
                Console.Write("      [8] Exit                                  \n");
                Console.Write("Enter option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                ListofStudents listofStudents = new ListofStudents();

                if (option == 1)
                {
                    listofStudents.Input();
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Student added successfully!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("*******");
                    listofStudents.Output();
                }
                else if (option == 2)
                {
                    listofStudents.findStudentWithStudentID();
                }
                else if (option == 3)
                {
                    listofStudents.findStudentbyScoreRange();
                }
                else if (option == 4)
                {
                    listofStudents.findStudentbyRanked();
                }
                else if (option == 5)
                {
                    listofStudents.sortStudentbyScore();
                }
                else if (option == 6)
                {
                    listofStudents.showTop3();
                }
                else if (option == 7)
                {
                    listofStudents.findStudentWithStudentID();
                    listofStudents.Output();
                }
                else if (option == 8)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid option. The program will automatically exit.");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
                Console.WriteLine("-------");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }
        }
               
    }
           
             
}


