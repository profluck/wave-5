using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Second.Task_2
{
    class Main_Task_2
    {
        public int arrayN { private get; set; }

        public void InitTask_2()
        {

            Console.WriteLine("\n\n TASK 2.2 \n");

            Console.WriteLine(" Укажите желаемую длину массива: ");
            do
            {
                try
                {
                    arrayN = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" Вы указали не верный символ! Допускаются только цыфры! ");
                }

            } while (arrayN == 0);
            
            // Init new array
            List<int> arrayPull = new List<int>();

            Random rand = new Random();

            // Add into array a random values from -500 to 500
            for(int i = 0; i < arrayN; i++)
            {
                arrayPull.Add(rand.Next(-500, 500));
            }

            // Sort array
            arrayPull.Sort();

            Console.WriteLine(new string('_',50) + "\n");
            Console.WriteLine(" Вывод заполненного отсортированного массива: ");
            Console.WriteLine("\n");

            for (int k = 0; k < arrayPull.Count; k = k + 1)
            {
                Console.Write(" {0} ", arrayPull[k]);
            }
            Console.WriteLine("\n");
        }
    }
}
