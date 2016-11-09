using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_fourth.Task_1;

namespace Task_fourth.Task_1
{
    class InitFirstStudents
    {
        private int InputedSchoolNumber { get; set; }

        public void Start()
        {

            // Create new list students
            List<FirstStudents> studList = new List<FirstStudents>();

            // Add new object items to list
            studList.Add(new FirstStudents() { FioStudent = "Петров Алексей Анатолиевич", YearBirth = 1994, HomeAddress = "Киев, ул.Шевченка, 24, кв.2", FinishedSchool = 5 });
            studList.Add(new FirstStudents() { FioStudent = "Дмитриев Сергей Петрович", YearBirth = 1995, HomeAddress = "Львов, ул.Ленина, 87, кв.44", FinishedSchool = 5 });
            studList.Add(new FirstStudents() { FioStudent = "Семенов Владимир Евгениевич", YearBirth = 1993, HomeAddress = "Одесса, ул.Кирова, 7, кв.97", FinishedSchool = 5 });
            studList.Add(new FirstStudents() { FioStudent = "Скварцов Иван Андреевич", YearBirth = 1996, HomeAddress = "Николаев, ул.Тараса Шевченка, 10, кв.32", FinishedSchool = 2 });
            studList.Add(new FirstStudents() { FioStudent = "Перепелкина Мария Степановна", YearBirth = 1995, HomeAddress = "Чернигов, ул.Швалова, 71, кв.60", FinishedSchool = 12 });
            studList.Add(new FirstStudents() { FioStudent = "Свиридов Роман Андреевич", YearBirth = 1995, HomeAddress = "Львов, ул.Толстого, 7/2, кв.55", FinishedSchool = 5 });
            studList.Add(new FirstStudents() { FioStudent = "Крамаренко Игорь Петрович", YearBirth = 1996, HomeAddress = "Донецк, ул.Леси Украинки, 69, кв.8", FinishedSchool = 15 });
            studList.Add(new FirstStudents() { FioStudent = "Королев Андрей Леонидович", YearBirth = 1991, HomeAddress = "Кривой Рог, ул.Маяковского, 18, кв.25", FinishedSchool = 15 });
            studList.Add(new FirstStudents() { FioStudent = "Шумовской Егор Павлович", YearBirth = 1991, HomeAddress = "Львов, ул.Бреста, 55, кв.17", FinishedSchool = 2 });
            studList.Add(new FirstStudents() { FioStudent = "Черкасов Игорь Владимирович", YearBirth = 1995, HomeAddress = "Полтава, ул.Тараса Бульбы, 44, кв.88", FinishedSchool = 2 });

            // Get default list of students
            Console.WriteLine();
            Console.WriteLine("All students in the list: ");
            Console.WriteLine();

            foreach (FirstStudents st in studList)
            {
                Console.WriteLine(" FLS: {0}, Year birth: {1}, Home address: {2}, Finished school: #{3}; ", st.FioStudent, st.YearBirth, st.HomeAddress, st.FinishedSchool);
            }

            // Get from console value for search of matching
            Console.WriteLine("\nInput number of school:");
            do
            {
                try
                {
                    InputedSchoolNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    //Console.WriteLine("\n You have to use only numbers! Exception message: \n {0}", ex);
                    Console.WriteLine("\n You have to use only numbers!\n");
                }

            } while (InputedSchoolNumber == 0);

            // Find in list match items with inputed value and create new list matched items
            List<FirstStudents> studMatchesList = studList.FindAll( studen => studen.FinishedSchool == InputedSchoolNumber);

            Console.WriteLine();

            if(studMatchesList.Count > 0)
            {
                Console.WriteLine("\n We have result: \n");

                foreach (FirstStudents st in studMatchesList)
                {
                    Console.WriteLine(" FLS: {0}, Year birth: {1}, Home address: {2}, Finished school: #{3}; ", st.FioStudent, st.YearBirth, st.HomeAddress, st.FinishedSchool);
                }
            }
            else
            {
                Console.WriteLine("Nothing is not found.");
            }

            Console.WriteLine();
            Console.WriteLine(" And after sorting: ");
            Console.WriteLine();

            studMatchesList.Sort();
            
            foreach (FirstStudents st in studMatchesList)
            {
                Console.WriteLine(" FLS: {0}, Year birth: {1}, Home address: {2}, Finished school: #{3}; ", st.FioStudent, st.YearBirth, st.HomeAddress, st.FinishedSchool);
            }

            Console.WriteLine();

        }

    }
}
