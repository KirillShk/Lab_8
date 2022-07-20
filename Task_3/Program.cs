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
            int sum_lines = 0;
            int sum_words = 0;
            int sum_symbols = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    string s = sr.ReadLine();
                    sum_lines++;
                    string[] slova = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string a in slova)
                    {
                        sum_words++;
                    }
                    sum_symbols += s.Length;                
                }
            }
            Console.WriteLine("Количество строк = {0}", sum_lines);
            Console.WriteLine("Количество слов = {0}", sum_words);
            Console.WriteLine("Количество символов = {0}", sum_symbols);
            Console.ReadLine(); 
        }
    }
}
