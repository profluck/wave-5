using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_fourth.Task_4
{
    class CarsDepartament : IComparable<CarsDepartament>
    {
        private string carBrand = string.Empty;
        private string carOwner = string.Empty;
        private int carYearPurchase = 0;
        private int carMileage = 0;

        public string CarBrand
        {
            get
            {
                return carBrand;
            }

            set
            {
                carBrand = value;
            }
        }

        public string CarOwner
        {
            get
            {
                return carOwner;
            }

            set
            {
                carOwner = value;
            }
        }

        public int CarYearPurchase
        {
            get
            {
                return carYearPurchase;
            }

            set
            {
                carYearPurchase = value;
            }
        }

        public int CarMileage
        {
            get
            {
                return carMileage;
            }

            set
            {
                carMileage = value;
            }
        }

        public int CompareTo(CarsDepartament obj)
        {
            if (CarMileage > obj.CarMileage)
                return 1;
            else if (CarMileage < obj.CarMileage)
                return -1;
            else
                return 0;
        }
    }
}
