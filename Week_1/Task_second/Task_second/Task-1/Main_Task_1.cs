using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Second.Task_1
{
    class Main_Task_1
    {

        public void InitTask_1()
        {
            // Init Struct Student
            Student studentGroup = new Student(
                                                new string[] { "John", "Anna", "Katya", "Petro", "Avril" },
                                                new int[] { 22, 33, 44, 62, 28 }
                                              );

            // Sort array by field FirstName
            Array.Sort(studentGroup.FirstName);

            Console.WriteLine("\n TASK 2.1 \n\n *** Sort by name of student *** \n");

            foreach (string studNames in studentGroup.FirstName)
            {
                Console.WriteLine("\t Name of student: {0}", studNames);
            }

            Console.WriteLine(new string('_', 50) + "\n");

            IComparer compare = new Compares();

            // Sort array by field Age, use case intensive Сomparer
            Array.Sort(studentGroup.Age, compare);

            Console.WriteLine(" *** Sort by age of student *** \n");

            foreach (int studAges in studentGroup.Age)
            {
                Console.WriteLine("\t Age of student: {0}", studAges.ToString());
            }
        }

    }
}
