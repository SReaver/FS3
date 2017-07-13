using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FS3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\плотниковс\Documents\visual studio 2015\Projects\FS3\FS3\text.txt";

            using ( StreamReader str = new StreamReader(path))
            {
                Console.WriteLine(str.ReadToEnd());
            }

            Console.WriteLine("***Считываем построчно***");
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line=sr.ReadLine())!=null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("***Считываем блоками***");
            using (StreamReader sr = new StreamReader(path))
            {
                char[] arrray = new char[4];
                sr.Read(arrray, 0, 4);
                Console.WriteLine(arrray);
            }

        }
    }
}

