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
            List<int> list1 = new List<int>() { 11, -20, 300, -450, 55, 610, -7, 358, 90, 3 };

            //using lambda expression
            list1.ForEach(number => Console.Write(number + " "));
            Console.WriteLine();

            //sorting a list
            list1.Sort();
            Console.WriteLine(string.Join(", ", list1));
            list1.Reverse();
            Console.WriteLine(string.Join(", ", list1)); 


           /* Console.WriteLine("Even Numbers : " + string.Join(", ", list1.Where(n => n % 2 == 0)));
            Console.WriteLine("Odd Numbers : " + string.Join(", ", list1.Where(n => n % 2 != 0)));
            Console.WriteLine("Numbers Greater Than 5 : " + string.Join(", ", list1.Where(n => n > 5)));
            Console.WriteLine("Numbers Between 3 and 8 : " + string.Join(", ", list1.Where(n => (n > 3 && n < 8))));
            Console.WriteLine("Every Second Number : " + string.Join(", ", list1.Where((n,index) => index % 2 == 1)));     */


            //looping through lists 
            /* foreach (int i in list1)
                 Console.Write(i + " ");*/

            Console.WriteLine();

           





            /*Console.WriteLine("list : " + string.Join(" ", list1));

              list1.RemoveAll(n => n % 2 == 0);
               Console.WriteLine();
               Console.WriteLine("new list (Odd Numbers): " + string.Join(" ", list1));

              List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

              list.RemoveAll(x => x % 2 != 0);
              Console.WriteLine();
              Console.WriteLine("new list (Even Numbers): " + string.Join(" ", list));*/

            Console.ReadLine();
        }
    }
}
