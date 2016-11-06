using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Second.Task_1;
using Task_Second.Task_2;
using Task_Second.Task_3;

// 1.	Для структуры Student создать массив. Отсортировать массив по полю FirstName.
//          a) Используя перегруженный метод Sort(IComparer), реализовать сортировку по полю Age.
// 2.	Дан одномерный массив размерностью N.Необходимо заполнить его случайными числами в диапазоне 
//      от -500 до 500 и отсортировать.
// 3.	Дан двухмерный массив размерностью MxN.Необходимо заполнить его случайными числами в диапазоне 
//      от -500 до 500 и отсортировать столбцы матрицы по сумме элементов столбца.

namespace Task_second
{
    class Program
    {
        static void Main(string[] args)
        {

            // Start task 2.1
            Main_Task_1 init1 = new Main_Task_1();
            //init1.InitTask_1();

            // Start task 2.2
            Main_Task_2 init2 = new Main_Task_2();
            //init2.InitTask_2();

            // Start task 2.3
            Main_Task_3 init3 = new Main_Task_3();
            //init3.InitTask_3();

            Console.WriteLine(new string('_', 50));
            Console.WriteLine("\n Press key enter to exit.");
            Console.ReadLine();

        }
    }
}
