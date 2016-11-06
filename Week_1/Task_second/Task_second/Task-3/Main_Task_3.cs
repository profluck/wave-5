using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Second.Task_3
{
    class Main_Task_3
    {
        public int N { get; set; }
        public int M { get; set; }
        public int[] arrRowSumm;
        public int CountRows { get; set; }

        public void InitTask_3()
        {
            Console.WriteLine("\n\n TASK 2.3 \n");

            Console.WriteLine(" Укажите желаемую длину массива по вертикали: ");
            do
            {
                try
                {
                    N = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" Вы указали не верный символ! Допускаются только цыфры! " + ex);
                }

            } while (N == 0);

            Console.WriteLine(" Укажите желаемую длину массива по горизонтали: ");
            do
            {
                try
                {
                    M = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" Вы указали не верный символ! Допускаются только цыфры! " + ex);
                }

            } while (M == 0);


            int[,] arr = new int[N, M];

            Random rand = new Random();

            arrRowSumm = new int[M];

            for (int i = 0; i < N; i++)
            {
                if (CountRows != 0) CountRows = 0;

                for (int k = 0; k < M; k++)
                {   
                    arr[i, k] += rand.Next(-500, 500);

                    CountRows += arr[i, k];
                }

                arrRowSumm[i] += CountRows;
            }

            Array.Sort(arrRowSumm);

            Console.WriteLine("\n Result: \n");

            for (int b = 0; b < arrRowSumm.Length; b++)
            {
                for(int j = 0; j < M; j++)
                {
                    Console.Write(" {0} ", arr[b, j]);
                }

                Console.WriteLine(" || First N summ:  {0} ", arrRowSumm[b]);
                Console.WriteLine();
            }
            
            Console.WriteLine(new string('_', 50));

        }

    }
}
