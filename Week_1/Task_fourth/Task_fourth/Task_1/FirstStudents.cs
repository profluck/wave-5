using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_fourth.Task_1
{
    class FirstStudents : IComparable<FirstStudents>
    {

        private string fioStudent = string.Empty;
        private int yearBirth = 0;
        private string homeAddress = string.Empty;
        private int finishedSchool = 0;

        public string FioStudent
        {
            get
            {
                return fioStudent;
            }

            set
            {
                fioStudent = value;
            }
        }

        public int YearBirth
        {
            get
            {
                return yearBirth;
            }

            set
            {
                yearBirth = value;
            }
        }

        public string HomeAddress
        {
            get
            {
                return homeAddress;
            }

            set
            {
                homeAddress = value;
            }
        }

        public int FinishedSchool
        {
            get
            {
                return finishedSchool;
            }

            set
            {
                finishedSchool = value;
            }
        }

        // Compare method of property "Year birth".
        public int CompareTo(FirstStudents other)
        {
            if (this.YearBirth > other.YearBirth)
                return 1;
            else if (this.YearBirth < other.YearBirth)
                return -1;
            else
                return 0;
        }

    }
}
