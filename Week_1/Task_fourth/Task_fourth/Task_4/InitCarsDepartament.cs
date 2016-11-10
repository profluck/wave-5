using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_fourth.Task_4
{
    class InitCarsDepartament
    {
        private int InputedYearPurchase { get; set; }

        public void Start()
        {

            List<CarsDepartament> infoCars = new List<CarsDepartament>();

            infoCars.Add(new CarsDepartament() { CarBrand = "Chevrolet Aveo", CarOwner = "Васильков", CarYearPurchase = 2010, CarMileage = 240123});
            infoCars.Add(new CarsDepartament() { CarBrand = "Hundai i30", CarOwner = "Петров", CarYearPurchase = 2014, CarMileage = 121555 });
            infoCars.Add(new CarsDepartament() { CarBrand = "Honda Accord", CarOwner = "Моргулин", CarYearPurchase = 2014, CarMileage = 88954 });
            infoCars.Add(new CarsDepartament() { CarBrand = "Chevrolet Cruze", CarOwner = "Павлова", CarYearPurchase = 2016, CarMileage = 22654 });
            infoCars.Add(new CarsDepartament() { CarBrand = "Toyota Camry", CarOwner = "Алексеев", CarYearPurchase = 2013, CarMileage = 224265 });
            infoCars.Add(new CarsDepartament() { CarBrand = "Lada 2109", CarOwner = "Прытула", CarYearPurchase = 1997, CarMileage = 884165 });
            infoCars.Add(new CarsDepartament() { CarBrand = "Toyota Corola", CarOwner = "Кравченко", CarYearPurchase = 2015, CarMileage = 198446 });

            Console.WriteLine();
            Console.WriteLine(" Info cars in base:");
            Console.WriteLine();

            foreach (CarsDepartament carItem in infoCars)
            {
                Console.WriteLine(" Марка авто: {0}, Фамилия владельца: {1}, Год приобретения: {2}, Пробег: {3}", carItem.CarBrand, carItem.CarOwner, carItem.CarYearPurchase, carItem.CarMileage);
            }

            Console.WriteLine();
            Console.WriteLine("Input year:");
            
            point1:

            do
            {
                try
                {
                    InputedYearPurchase = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n You have to use only numbers!\n");
                    goto point1;
                }
                catch (Exception)
                {
                    goto point1;
                }

            } while (InputedYearPurchase == 0);

            Console.WriteLine();

            List<CarsDepartament> resultSearchList = infoCars.FindAll(cars => cars.CarYearPurchase < InputedYearPurchase);

            resultSearchList.Sort();

            if(resultSearchList.Count > 0)
            {
                Console.WriteLine(" Search result: ");
                Console.WriteLine();

                foreach (CarsDepartament carItem in resultSearchList)
                {
                    Console.WriteLine(" Марка авто: {0}, Фамилия владельца: {1}, Год приобретения: {2}, Пробег: {3}", carItem.CarBrand, carItem.CarOwner, carItem.CarYearPurchase, carItem.CarMileage);
                }

                goto point1;
            }
            else
            {
                Console.WriteLine(" Nothing is not found.");
                Console.WriteLine();

                goto point1;
            }
        }
        // The End.
    }
}