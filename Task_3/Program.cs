using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\BIM\csharp\Lab_8\Files\List_words.txt";
            string[] filetext = File.ReadAllText(path);
            int k=0;
            int z = filetext.Length;
           /* foreach (char ch in filetext)
            {
                k++;
            }    */    
           Console.WriteLine(z);
            Console.WriteLine("Количество символов = {0}", k);
            Console.ReadLine(); 
        }
    }
}
