using System;
using System.IO;

namespace FileReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable to count lines
            int lineNumber = 1;
            try
            {
                // creates objects of StreamReader class to read from file name passed as 1st string argument passed from command line
                StreamReader fout = new StreamReader(args[0]);
                // creates objects of StreamWriter class to write to a file name passed as 2nd string argument passed from command line
                StreamWriter fin = new StreamWriter(args[1]);

                // varible for line
                string line;
                //reads file in fout 1 line at a time
                while ((line = fout.ReadLine()) != null)
                {
                    // writes into new file using fin with line number in front of every line read from fout
                    fin.WriteLine($"{lineNumber}{line}");
                    lineNumber++;
                }
                // closes both stream objects
                fout.Close();
                fin.Close();

            }
            // catches any exception within the try block and prints meaning ful message on console
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }
        }
    }
}
