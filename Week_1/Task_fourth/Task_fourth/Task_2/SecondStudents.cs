using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_fourth.Task_2
{
    class SecondStudents : IComparable<SecondStudents>
    {
        private string fioStudent = string.Empty;
        private int groupNO = 0;
        private int[] resultTests;

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

        public int GroupNO
        {
            get
            {
                return groupNO;
            }

            set
            {
                groupNO = value;
            }
        }

        public int[] ResultTests
        {
            get
            {
                return resultTests;
            }

            set
            {
                resultTests = value;
            }
        }

        // The method for comparing propery "GroupNO"
        public int CompareTo(SecondStudents other)
        {
            if (this.GroupNO > other.GroupNO)
                return 1;
            else if (this.GroupNO < other.GroupNO)
                return -1;
            else
                return 0;
        }
    }
}
