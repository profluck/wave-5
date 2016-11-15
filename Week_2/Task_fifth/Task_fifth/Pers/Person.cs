using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_fifth.Pers
{
    class Person : ICloneable
    {
        public virtual string FlName { get; set; }
        
        public Person() { }

        // Print
        public virtual void Print()
        {
            Console.WriteLine("Class Person.\n Name person: {0}, Group: {1}", FlName);
        }

        // ToString
        public override string ToString()
        {
            return "String person".ToString();
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

        // Random person
        public static object RandomPerson(List<Person> lPers)
        {
            Random rand = new Random();

            int randIndex;

            if (lPers != null)
                randIndex = rand.Next(0, lPers.Count);
            else
                randIndex = 0;

            return randIndex;
        }

        // Count Persons in List
        public int GetCountPersons(List<Person> persons, Person obj)
        {

            if (persons == null) return 0;
            int count = 0;

            if(obj is Person)
            {
                foreach (Person item in persons)
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

        // Global clone
        public object Clone()
        {
            return new Person {
                FlName = this.FlName
            };
        }


    }
}
