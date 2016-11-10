using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_fourth.Task_3
{
    class InitLuggageDepartment
    {
        private double InputedMaxWeight { get; set; }

        public void Start()
        {

            List<LuggageDepartment> luggageBase = new List<LuggageDepartment>();
            luggageBase.Add(new LuggageDepartment() { FioPassenger = "Коваль Иван Пертович", CountOfThings = 12, SummaryWeightThings = 7.4 });
            luggageBase.Add(new LuggageDepartment() { FioPassenger = "Кравченко Инна Анатолиевна", CountOfThings = 5, SummaryWeightThings = 3.2 });
            luggageBase.Add(new LuggageDepartment() { FioPassenger = "Никифоров Алексей Петрович", CountOfThings = 8, SummaryWeightThings = 4.7 });
            luggageBase.Add(new LuggageDepartment() { FioPassenger = "Олефир Анна Сергеевна", CountOfThings = 3, SummaryWeightThings = 2.2 });
            luggageBase.Add(new LuggageDepartment() { FioPassenger = "Петров Максим Алексеевич", CountOfThings = 5, SummaryWeightThings = 13.8 });
            luggageBase.Add(new LuggageDepartment() { FioPassenger = "Бородин Сергей Вьячеславович", CountOfThings = 15, SummaryWeightThings = 22.1 });
            luggageBase.Add(new LuggageDepartment() { FioPassenger = "Малевска Екатерина Васильевна", CountOfThings = 7, SummaryWeightThings = 5.4 });
            luggageBase.Add(new LuggageDepartment() { FioPassenger = "Диденко Тарас Иванович", CountOfThings = 10, SummaryWeightThings = 8.8 });

            Console.WriteLine();
            Console.WriteLine(" Info list luggage of passengers: ");
            Console.WriteLine();

            foreach (LuggageDepartment passenger in luggageBase)
            {
                Console.WriteLine(" SFL: {0}, Count things: {1}, Summary weight: {2}", passenger.FioPassenger, passenger.CountOfThings, passenger.SummaryWeightThings);
            }

            Console.WriteLine();
            Console.WriteLine(" Limited weight things: ");
            Console.WriteLine("\nInput max allowed weight of luggage: ");

            do
            {
                try
                {
                    InputedMaxWeight = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\n You have to use only numbers!\n");
                }

            } while (InputedMaxWeight == 0);

            Console.WriteLine();

            List<LuggageDepartment> denyWeight = luggageBase.FindAll(luggage => luggage.SummaryWeightThings >= InputedMaxWeight);

            denyWeight.Sort();

            foreach (LuggageDepartment passenger in denyWeight)
            {
                Console.WriteLine(" SFL: {0}, Count of things: {1}, Summary weight: {2}", passenger.FioPassenger, passenger.CountOfThings, passenger.SummaryWeightThings);
            }

        }
    }
}
