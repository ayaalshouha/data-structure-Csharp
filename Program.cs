using System;
using System.Collections.Generic;
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
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
                
            list.Add(3);
            list.Add(4);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
