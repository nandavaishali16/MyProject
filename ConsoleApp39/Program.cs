using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp39
{
    class Program
    {
        delegate string IntToStringDelegate(int num);

        static void Main(string[] args)
        {
            IntToStringDelegate intToStringDelegate = new IntToStringDelegate(Convert.ToString);

            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> stringList = intList.Select(i => intToStringDelegate(i)).ToList();

            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }

            intToStringDelegate += PrintInt;
            intToStringDelegate += i => { Console.WriteLine(i); return i.ToString(); };

            intList.ForEach(i => intToStringDelegate(i));
        }

        static string PrintInt(int num)
        {
            Console.WriteLine(num);
            Console.Read();
            return num.ToString();
        }
    }
}