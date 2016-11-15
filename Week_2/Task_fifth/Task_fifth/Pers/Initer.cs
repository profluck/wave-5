using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_fifth.Pers
{
    class Initer
    {

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("STUDENTS:");
            Console.WriteLine();

            Student st = new Student();
            Teacher tc = new Teacher();

            foreach (Student item in st.ListStudents())
            {
                Console.WriteLine(" NAME: {0}, GROUP: {1}, COURSE: {2}", item.FlName, item.Group, item.Course);
            }

            Console.WriteLine();
            Console.WriteLine("TEACHERS:");
            Console.WriteLine();

            foreach (Teacher tcItem in tc.ListTeachers())
            {
                Console.WriteLine(" NAME: {0}, GROUP: {1}", tcItem.FlName, tcItem.GroupStudents);
            }

            Console.WriteLine(new string('_', 50));

            Console.WriteLine();
            Console.WriteLine("TEACHERS GROUP:");
            
            foreach (Teacher tcItem in tc.ListTeachers())
            {

                Console.WriteLine("\nTEACHER: {0}\n", tcItem.FlName);

                foreach (Student stItem in st.ListStudents())
                {
                    if (stItem.Group == tcItem.GroupStudents)
                    {
                        tc.student.Add(new Student() { FlName = stItem.FlName, Group = stItem.Group, Course = stItem.Course });
                    }
                }

                foreach (Student t in tc.student)
                {
                    Console.WriteLine(" NAME: {0}, GROUP: {1}", t.FlName, t.Group);
                }

                tc.student.Clear();

            }

            Console.WriteLine(new string('_', 50));

            Console.WriteLine();
            Console.WriteLine("STUDENT TEACHER:");

            foreach (Student stItem in st.ListStudents())
            {

                Console.WriteLine("\nSTUDENT: {0}, GROUP: {1}", stItem.FlName, stItem.Group);

                foreach (Teacher tcItem in tc.ListTeachers())
                {
                    if (tcItem.GroupStudents == stItem.Group)
                    {
                        st.teacher.Add(new Teacher() { FlName = tcItem.FlName });
                        Console.WriteLine("TEACHER: {0}\n", tcItem.FlName);
                    }
                }

            }

            Console.WriteLine(new string('_', 50));

            Console.WriteLine();
            Console.WriteLine("TEST METHODS ToString OF CLASSES:");
            Console.WriteLine();

            Person pers = new Person();
            Console.WriteLine(" Test string Person: {0}", pers.ToString());
            Console.WriteLine(" Test string Student: {0}", st.ToString());
            Console.WriteLine(" Test string Teacher: {0}", tc.ToString());

            Console.WriteLine(new string('_', 50));

            Console.WriteLine();
            Console.WriteLine("TEST METHODS GetHash OF CLASSES:");
            Console.WriteLine();

            Console.WriteLine(" Test GetHash Person sting: {0}", pers.GetHashCode());
            Console.WriteLine(" Test GetHash Student sting: {0}", st.GetHashCode());
            Console.WriteLine(" Test GetHash Teacher sting: {0}", tc.GetHashCode());

            Console.WriteLine(new string('_', 50));

            Console.WriteLine();
            Console.WriteLine("TEST METHODS Equals OF CLASSES:");
            Console.WriteLine();

            Console.WriteLine(" Equals test of Person class: {0}", pers.Equals(pers));
            Console.WriteLine(" Equals test of Person class: {0}", st.Equals(st));
            Console.WriteLine(" Equals test of Person class: {0}", tc.Equals(tc));

            Console.WriteLine(new string('_', 50));

            Console.WriteLine();
            Console.WriteLine("Random user OF CLASSES:");
            Console.WriteLine();

            var personsArray = new List<Person>(){
                                new Person() { FlName = "Алексеев Андрей" },
                                new Person() { FlName = "Король Иван" },
                                new Person() { FlName = "Семенов Максим" },
                                new Person() { FlName = "Прыходько Виталий"},
                                new Person() { FlName = "Кравченко Наталия"},
                                new Person() { FlName = "Василькова Анна"},
                                new Person() { FlName = "Невербалов Анатолий"},
                                new Person() { FlName = "Акимова Екатерина"},
                                new Person() { FlName = "Невесолов Роман"},
                                new Person() { FlName = "Ефримов Алексей"},
                            };

            var prand = Person.RandomPerson(personsArray);

            Console.WriteLine(" Random Person index: {0}", prand);

            var srand = Student.RandomStudent(st.ListStudents());

            Console.WriteLine(" Random Student index: {0}", srand);

            var trand = Teacher.RandomTeacher(tc.ListTeachers());

            Console.WriteLine(" Random Teacher index: {0}", trand);


            Console.WriteLine(new string('_', 50));

            Console.WriteLine();
            Console.WriteLine("Count user in the classes and enrolling students on the next course:");
            Console.WriteLine();

            st.GetCountStudents(st);

            Console.WriteLine(" Count persons: {0}", pers.GetCountPersons(personsArray, pers));

            Console.WriteLine(" Count teachers: {0}", tc.GetCountTeachers(tc));

            Console.WriteLine(new string('_', 50));

            Console.WriteLine();
            Console.WriteLine("Global Cloning Class Person.");
            Console.WriteLine();

            Person originPers = new Person() { FlName = "Красовская Анна" };
            Person clonnedPers = (Person)originPers.Clone();
            clonnedPers.FlName = "Никитчук Андрей";

            Console.WriteLine("Origin Person say: {0}", originPers.FlName);
            Console.WriteLine("Clonned Person say: {0}", clonnedPers.FlName);


            // The End.
        }

    }
}
