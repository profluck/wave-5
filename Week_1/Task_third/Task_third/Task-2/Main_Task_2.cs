using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task_third.Task_2
{
    class Main_Task_2
    {
        private string CurrentFilePath { get; set; }
        private StreamReader currentFileReadIn;
        private StreamWriter currentFileWriteOut;
        private string readLine;
        private List<string> dataWritingArr = new List<string>();

        public Main_Task_2(string puthToFile)
        {
            this.CurrentFilePath = puthToFile;
        }

        public void Init_task_2()
        {

            Console.Write("\n TASK 3.2 \n");
            Console.WriteLine(new string('_', 50) + "\n");
            Console.WriteLine(" Result program:");
            Console.WriteLine(new string('_', 50) + "\n");

            // Read current file
            try
            {
                currentFileReadIn = new StreamReader(CurrentFilePath, Encoding.GetEncoding(1251));

                while ((readLine = currentFileReadIn.ReadLine()) != null)
                {
                    try
                    {
                        // Replace all symbol which is not the numbers
                        string clearNumberString = Regex.Replace(readLine, @"[^0-9]", " ", RegexOptions.Compiled).Trim(' ');

                        // Create iteration variables
                        int i = 1;
                        string IterationLineNumber = string.Empty;

                        foreach (string strItem in clearNumberString.Split(' '))
                        {
                            // + 1
                            i++;

                            // Conver string item to double type // Can wrong Exeption!
                            double newNumberFromString = Convert.ToDouble(strItem);

                            // Make from item a square value
                            string squaredValue = Convert.ToString(Math.Pow(newNumberFromString, i));

                            Console.WriteLine(" Number: {0} = {1}", strItem, squaredValue + "\n");

                            // Reset increment == 1
                            i = 1;

                            // Gluing a squared number to one line
                            IterationLineNumber += squaredValue + " ";
                        }

                        // if we have two or more iteration lines, then add this one to new item in array
                        dataWritingArr.Add(IterationLineNumber);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(" Error parsing file. Crash program with message: {0} ", "\n\n" + "Not correct parse value!");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error opening file. Crash program with message: {0} ", "\n\n" + ex);
            }
            finally
            {
                // Closing current thread reading file.
                if(currentFileReadIn != null)
                    currentFileReadIn.Close();
            }

            // Writing new data to current file.
            try
            {
                currentFileWriteOut = new StreamWriter(CurrentFilePath, false);
                for(int j = 0; j < dataWritingArr.Count; j++)
                    currentFileWriteOut.WriteLine(dataWritingArr[j]); // Adding new array item data lines to current file
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error writing file. Crash program with message: {0} ", "\n\n" + ex);
            }
            finally
            {
                // Closing current thread writing file.
                if(currentFileWriteOut != null)
                    currentFileWriteOut.Close();

                // Output result writing new data.
                Console.WriteLine(new string('_', 50));
                Console.WriteLine(" \n The file modified with next new data: \n");
                foreach (string item in dataWritingArr)
                {
                    Console.WriteLine(" {0}", item);
                }
            }

            // The End.
        }

    }
}
