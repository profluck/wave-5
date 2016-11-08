using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_third.Task_1;
using Task_third.Task_2;

//  3.4.	В текстовом файле записаны вещественные числа (на каждой строчке - несколько, 
//          разделены несколькими пробелами) и что-то ещё. Найти сумму чисел, игнорируя неверные лексемы.
//  3.2.	Создать типизированный файл целых, затем модифицировать его, возведя все элементы в квадрат.
//  3.3.	Для данной директории рекурсивно выдать список её файлов и поддиректорий.

namespace Task_third
{
    class Program
    {
        static void Main(string[] args)
        {

            /** TASK 3.1 **/
            Main_Task_1 init1 = new Main_Task_1();
            //init1.Init_task_1();

            /** TASK 3.2 **/
            Main_Task_2 init2 = new Main_Task_2(@"D:\projects_C#\Wave-5\Week_1\Task_third\Task_third\Task-2\CurrentXFile.txt");
            init2.Init_task_2();


            Console.WriteLine("\n "+ new string('_', 50) +"\n");
            Console.WriteLine(" Press key enter to exit.");
            Console.ReadLine();
        }
    }
}
