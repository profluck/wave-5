using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_fourth.Task_2
{
    class InitSecondStudents
    {

        public void Start()
        {

            // Create new list students
            List<SecondStudents> studList = new List<SecondStudents>();

            // Add new object items to list
            studList.Add(new SecondStudents() { FioStudent = "Петров Алексей Анатолиевич", GroupNO = 1001, ResultTests = new int[3] { 1, 0, 1 } });
            studList.Add(new SecondStudents() { FioStudent = "Дмитриев Сергей Петрович", GroupNO = 1501, ResultTests = new int[3] { 1, 1, 1 } });
            studList.Add(new SecondStudents() { FioStudent = "Семенов Владимир Евгениевич", GroupNO = 3210, ResultTests = new int[3] { 0, 0, 1 } });
            studList.Add(new SecondStudents() { FioStudent = "Скварцов Иван Андреевич", GroupNO = 3210, ResultTests = new int[3] { 1, 1, 1 } });
            studList.Add(new SecondStudents() { FioStudent = "Перепелкина Виктория Викторовна", GroupNO = 1001, ResultTests = new int[3] { 1, 1, 1 } });
            studList.Add(new SecondStudents() { FioStudent = "Свиридов Роман Андреевич", GroupNO = 3210, ResultTests = new int[3] { 1, 0, 1 } });
            studList.Add(new SecondStudents() { FioStudent = "Крамаренко Игорь Петрович", GroupNO = 1508, ResultTests = new int[3] { 1, 1, 1 } });
            studList.Add(new SecondStudents() { FioStudent = "Королев Андрей Леонидович", GroupNO = 3210, ResultTests = new int[3] { 0, 0, 0 } });
            studList.Add(new SecondStudents() { FioStudent = "Шумовской Егор Павлович", GroupNO = 1508, ResultTests = new int[3] { 0, 0, 1 } });
            studList.Add(new SecondStudents() { FioStudent = "Черкасова Елена Владимировна", GroupNO = 1001, ResultTests = new int[3] { 1, 1, 1 } });

            // Get default list of students
            Console.WriteLine();
            Console.WriteLine(" All students in the list: ");
            Console.WriteLine();

            foreach(SecondStudents student in studList)
            {
                Console.WriteLine(" SLF: {0}, Group number: {1}", student.FioStudent, student.GroupNO);
            }

            // Get all who completed tests successful
            Console.WriteLine();
            Console.WriteLine(" All students who completed tests successful: ");
            Console.WriteLine();

            // Search all students which successful completed tests
            List<SecondStudents> goodSesionList = studList.FindAll(sec => !sec.ResultTests.Contains(0));

            if(goodSesionList.Count > 0)
            {
                goodSesionList.Sort();

                foreach (SecondStudents goodStudent in goodSesionList)
                {
                    Console.WriteLine(" SLF: {0}, Group number: {1}", goodStudent.FioStudent, goodStudent.GroupNO);
                }
            }
            else
            {
                Console.WriteLine(" Im so sorry. But all failed tests!");
            }

        }
    }
}