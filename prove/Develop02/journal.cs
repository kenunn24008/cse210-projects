using System;
using System.IO;
using System.Text;

class journal
{
    public static List<entry> _temp = [];

    public static void Display()
    {
        foreach (entry entry in _temp)
        {
            entry.Display();
        }
    }
            
        public static void saveEntry(string args)
        {
            string path = @"C:\Users\duhke\Desktop\CSE 210\cse210-projects\prove\Develop02\bin\Debug\net8.0\" + args + ".txt";
        
            using (StreamWriter tw = new StreamWriter(path, true))
            {
                foreach (entry entry in _temp)
                {
                    string line = entry.saving();
                    tw.WriteLine(line);
                }
            }
        }
            

    }
