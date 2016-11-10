using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_fourth.Task_3
{
    class LuggageDepartment : IComparable<LuggageDepartment>
    {
        private string fioPassenger = string.Empty;
        private int countOfThings = 0;
        private double summaryWeightThings = 0;

        public string FioPassenger
        {
            get
            {
                return fioPassenger;
            }

            set
            {
                fioPassenger = value;
            }
        }

        public int CountOfThings
        {
            get
            {
                return countOfThings;
            }

            set
            {
                countOfThings = value;
            }
        }

        public double SummaryWeightThings
        {
            get
            {
                return summaryWeightThings;
            }

            set
            {
                summaryWeightThings = value;
            }
        }

        public int CompareTo(LuggageDepartment other)
        {
            return this.CountOfThings.CompareTo(other.countOfThings);
        }
    }
}
