using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task_third.Task_1
{
    class Main_Task_1
    {

        public int CountSummNumbers { get; set; }

        public void Init_task_1()
        {
            try
            {
                StreamReader readFile = new StreamReader(@"D:\projects_C#\Wave-5-tasks\Task_third\Task_third\Task-1\TextFile.txt", false);

                string str_line;
                char delimiter = ' ';

                Console.Write("\n TASK 3.1 \n");
                Console.Write("\n Найденые числа в файле:\n\n");

                while ((str_line = readFile.ReadLine()) != null)
                {
                    string[] str_array = str_line.Split(delimiter);

                    foreach (string substring in str_array)
                    {
                        try
                        {
                            string regString = Regex.Replace(substring, @"[^0-9]", "", RegexOptions.Compiled);

                            if (regString != null && regString != "")
                            {
                                Console.Write(" {0} ", regString);

                                CountSummNumbers += Int32.Parse(regString);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n Ошибка чтения строк файла! \n");
                            Console.WriteLine(e.Message);
                        }
                    }
                }

                readFile.Close();

                Console.WriteLine("\n\n Сумма чисел в данном текстовом файле: {0}", CountSummNumbers);

            }
            catch(Exception e)
            {
                Console.WriteLine("\n Ошибка чтения файла! \n");
                Console.WriteLine(e.Message);
            }

        }

    }
}
