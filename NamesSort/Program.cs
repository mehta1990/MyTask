using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Testnames
{
    public class Sorting
    {

        public static void sortFile(string fname)
        {
            //Calling file using string parameter 
            string name = fname;
            if (fname.Equals("names.txt"))
            {
                ArrayList names = new ArrayList();

                ///Creating a new streamreader object to read the existing text file
                StreamReader sr;
                try
                {
                    sr = new StreamReader(name);

                    string line;
                    //Reading a file and putting the content in names ArrayList

                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        names.Add(line);
                    }
                    Console.WriteLine("sort-names" + " " + @"names.txt");
                    // Pause the application so the user can read the information on the screen
                    Console.ReadLine();

                    //Sorting Array
                    names.Sort();
                    string outfile = @"names-sorted.txt";
                    //Checking whether the file is already in the system
                    if (File.Exists(outfile))
                    {
                        System.IO.File.WriteAllText(outfile, string.Empty); //If there is already some content, clear it

                    }
                    //Creating new text file
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"names-sorted.txt", false))
                    {
                        foreach (string c in names)
                        {
                            Console.WriteLine(c);
                            //Writing to the new text file
                            file.WriteLine(c);
                        }
                    }
                    //Final output
                    Console.WriteLine("Finished: created names-sorted.txt");
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("Sorry! File Not Found");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Sorry! Please check file name");
                Console.ReadLine();
            }

        }

        static void Main(string[] args)
        {
            string filename = "names.txt";
            Sorting.sortFile(filename);
        }
    }
}