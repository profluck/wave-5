using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_third.Task_3
{
    class Main_Task_3
    {
        private string pathToDir;

        // Create constructor
        public Main_Task_3(string dirPath)
        {
            this.pathToDir = dirPath;

            Console.Write("\n TASK 3.3 \n");
            Console.WriteLine(new string('_', 50) + "\n");
            Console.WriteLine(" Current directory: \n {0}", pathToDir);
        }

        // The method initialization program
        public void Init_task_3()
        {
            // Validation existing of directory
            if (Directory.Exists(pathToDir))
            {
                // Init current dir path
                DirectoryInfo dir = new DirectoryInfo(pathToDir);

                Console.WriteLine("\n This folder contains: \n");

                foreach (DirectoryInfo itemDir in dir.GetDirectories())
                {
                    // Show current subdirectories
                    Console.WriteLine(" * {0}", itemDir.Name);

                    var files = itemDir.GetFiles();

                    // Show files of subdirectories
                    if (files != null)
                    {
                        foreach(FileInfo subFileItem in files)
                        {
                            Console.WriteLine("\t{0}", subFileItem.Name);
                        }
                    }
                }

                Console.WriteLine("\n Files in current folder:\n");

                // Show files of current directory
                foreach (FileInfo fl in dir.GetFiles())
                {
                    Console.WriteLine(" {0}", fl.Name);
                }
            }
            else
            {
                Console.WriteLine("\n File is not exists \n");
            }
        }
        // The End.
    }
}
