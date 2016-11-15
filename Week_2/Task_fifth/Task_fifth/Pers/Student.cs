using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_fifth.Pers
{
    class Student : Person
    {
        public override string FlName { get; set; }
        public string Group { get; set; }
        public int Course { get; set; }
        public List<Teacher> teacher = new List<Teacher>();


        public List<Student> ListStudents()
        {

            List<Student> stud = new List<Student>()
            {
                new Student() { FlName = "Алексеев Андрей", Group = "MK-09-16", Course = 2 },
                new Student() { FlName = "Король Иван", Group = "MK-09-16", Course = 2 },
                new Student() { FlName = "Семенов Максим", Group = "MK-09-16", Course = 2 },
                new Student() { FlName = "Прыходько Виталий", Group = "MK-09-16", Course = 2 },
                new Student() { FlName = "Кравченко Наталия", Group = "DK-22-16", Course = 3 },
                new Student() { FlName = "Акимова Екатерина", Group = "DK-22-16", Course = 3 },
                new Student() { FlName = "Невесолов Роман", Group = "DK-22-16", Course = 3 },
                new Student() { FlName = "Ефримов Алексей", Group = "DK-22-16", Course = 3 },
            };

            return stud;
        }

        // Print
        public override void Print()
        {
            Console.WriteLine("Student FL name: {0}, Student group: {1}, Student course: {2}", FlName, Group, Course);
        }

        // ToString
        public override string ToString()
        {
            return "String student".ToString();
        }

        // GetHash
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        // Equals
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (obj.GetType() != this.GetType()) return false;

            Person pers = (Person)obj;

            if ((Person)obj == null) return false;
            else
                return this.FlName == pers.FlName;
        }

        // Random student
        public static object RandomStudent(List<Student> lPers)
        {
            Random rand = new Random();

            int randIndex;

            if (lPers != null)
                randIndex = rand.Next(0, lPers.Count);
            else
                randIndex = 0;

            return randIndex;
        }

        // Count Students in List
        public void GetCountStudents(Student obj)
        {
            int count = 0;

            if (obj is Student)
            {
                foreach (Student item in this.ListStudents())
                {
                    if (item.GetType() == obj.GetType())
                        count += 1;

                    if (item.Course != 0 && item.Course != 5)
                        item.Course += 1;

                    Console.WriteLine("{0}, was enrolled to {1} course.", item.FlName, item.Course);
                }
            }
            else
            {
                Console.WriteLine(" Is not correc object: {0}", obj);
            }

            Console.WriteLine(" Count students: {0}", count);
        }

    }
}
