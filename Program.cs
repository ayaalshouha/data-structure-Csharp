using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lists using C# 
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("list : " + string.Join(" ", list1));

            list1.RemoveAll(n => n % 2 == 0);
             Console.WriteLine();
             Console.WriteLine("new list (Odd Numbers): " + string.Join(" ", list1));

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            list.RemoveAll(x => x % 2 != 0);
            Console.WriteLine();
            Console.WriteLine("new list (Even Numbers): " + string.Join(" ", list));


            Console.ReadLine();
        }
    }
}
