using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ListofStudents
    {
        private List<Student> listofStudents = new List<Student>();

        public void Input()
        {
            do
            {
                Student stu = new Student();
                stu.Input();
                
                listofStudents.Add(stu);
                
                Console.Write("Continue? (y/n): ");
                string cont = Console.ReadLine();
                if (cont.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                } 

            } while (true);
        }

        public void Output()
        {
            foreach (var item in listofStudents)
            {
                item.Output();
            }
        }
        
        public void findStudentbyScoreRange()
        {
            float min, max;
            
            Console.WriteLine("Enter the start score: ");
            string start = Console.ReadLine();
            min = Convert.ToSingle(start);
            
            Console.WriteLine("Enter the end score: ");
            string end = Console.ReadLine();
            max = Convert.ToSingle(end);

            Console.WriteLine("Here's the list of students:");

            foreach (var item in listofStudents)
            {
                if (item.score >= min && item.score <= max)
                {
                    item.Output();
                }
            }
    
        }
        public void findStudentbyRanked()
        {
            Console.WriteLine("Enter the students' ranked: ");
            string rank = Console.ReadLine();
            Console.WriteLine("Here's the list of students:");
            foreach (var item in listofStudents)
            {
                if (item.Getrank.Equals(rank, StringComparison.OrdinalIgnoreCase))
                {
                    item.Output();
                }
            }


        }
        
        public void findStudentWithStudentID()
        {
            Console.WriteLine("Enter the student's ID you want to search: ");
            string id = Console.ReadLine();
            
            foreach (var item in listofStudents)
            {
                if (item.studentID == id)
                {
                    item.Output();
                    break;
                }
                else if (item.studentID != id)
                {
                    Console.WriteLine("No student with this ID.");
                }
            }
        }

        public void sortStudentbyScore()
        {
            listofStudents.Sort((x, y) => x.score.CompareTo(y.score));
        }

        public void showTop3()
        {
            listofStudents.Sort((x, y) => x.score.CompareTo(y.score));
            for (int i = 0; i < 3 && i < listofStudents.Count; i++)
            {
                listofStudents[i].Output();
            }
        }

      

    }
}   
