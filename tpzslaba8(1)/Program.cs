using System;
using System.IO;
using System.Linq;
using System.Text;

namespace tpzslaba8_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader file = new StreamReader("input.txt", Encoding.UTF8))
            {
                string text = file.ReadToEnd();

                int count = text.Count(p => p == '(' || p == ')');
                Console.WriteLine($"В этом выражении {count} скобок");
            }
            Console.ReadKey();
        }
    }
}
