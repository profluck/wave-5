using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_fifth.Pers
{
    class Teacher : Person
    {
        public override string FlName { get; set; }
        public string GroupStudents { get; set; }
        public List<Student> student = new List<Student>();

        public List<Teacher> ListTeachers()
        {
            List<Teacher> teach = new List<Teacher>()
            {
                new Teacher() { FlName = "Баракуев Олександр", GroupStudents = "DK-22-16" },
                new Teacher() { FlName = "Моргунова Елизавета", GroupStudents = "MK-09-16" },
            };

            return teach;
        }

        // Print
        public override void Print()
        {
            Console.WriteLine("Teacher name: {0}, Group of sudents: {1}");
        }

        // ToString
        public override string ToString()
        {
            return "String teacher".ToString();
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

        // Random teacher
        public static object RandomTeacher(List<Teacher> lPers)
        {
            Random rand = new Random();

            int randIndex;

            if (lPers != null)
                randIndex = rand.Next(0, lPers.Count);
            else
                randIndex = 0;

            return randIndex;
        }

        // Count Teachers in List
        public int GetCountTeachers(Teacher obj)
        {

            if (obj == null) return 0;
            int count = 0;

            if (obj is Teacher)
            {
                foreach (Teacher item in this.ListTeachers())
                {
                    if (item.GetType() == obj.GetType())
                        count += 1;
                }
            }
            else
            {
                return 0;
            }

            return count;
        }

    }
}
