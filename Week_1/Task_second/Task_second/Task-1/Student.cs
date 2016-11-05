using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Second.Task_1
{
    struct Student
    {
        public string[] FirstName;
        public int[] Age;

        public Student(string[] firstName, int[] age)
        {
            this.FirstName = firstName;
            this.Age = age;
        }
    }

    class Compares : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(x, y);
        }
    }
}
