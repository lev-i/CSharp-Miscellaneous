using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Hashtable
{
    class Program
    {
        // uses a hash table to store keys and values
        // in this example, used to store filetypes and a program that can be used to open that filetype
        // the user can then enter the item name of any item in the collection and the program will provide the description.

        public static void Main(string[] args)
        {
            // Creating the hash table
            Hashtable openWith = new Hashtable();

            // Add names/descriptions here:
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            // retrieve values by key
            // ask user for key
            Console.WriteLine("Enter filetype you want to open");
            // read user input, store the string they input
            string key = (Console.ReadLine());
            // search hash table for this key, and pull value if found
            if (openWith.ContainsKey(key))
            {
                Console.WriteLine("Filetype: " + key);
                Console.WriteLine("Open with: " + openWith[key]);
            }
        }
    }
}
