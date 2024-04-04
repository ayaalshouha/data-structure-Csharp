using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //HashSet in C#
            HashSet<int> set1 = new HashSet<int>() {1,1,2,3 };
            HashSet<int> set2 = new HashSet<int> { 4,4,5,6};

            set1.UnionWith(set2);

            foreach (int i in set1)
            {
                Console.Write(i + " ");
            }

            /*int[] numbers = new int[] { 
                1,2,2,3,3,3,4,5,6,7,8,9,0,0,10,1,4,5,6,7,8,
            };

            for(int i =0; i< numbers.Length; i++)
            {
                Console.Write(numbers[i]+ " ");
            }
         
            Console.WriteLine();
            Console.WriteLine();

            HashSet<int> hashset1 = new HashSet<int>(numbers);*/

            /* foreach(int i in numbers){
                 hashset1.Add(i);
             }*/

           /* foreach (int i in hashset1) {
                Console.Write(i + " ");
            }
            */


            //Dictionary in C#
            /*Dictionary<string, string> fruitsBasket = new Dictionary<string, string>()
            {
                {"apple", "tree" },
                {"cherry", "tree" },
                {"banana", "herb" },
                {"strawberry", "bush" },
                {"blackberry", "bush" },
            };

            var groupfruits = fruitsBasket.GroupBy(x => x.Value);

            foreach (var group in groupfruits)
            {
                Console.WriteLine($"Category: {group.Key}");

                foreach(var item in group)
                {
                    Console.WriteLine($" - {item.Key}"); 
                }
                Console.WriteLine();
            }*/


            /*Dictionary<string, int> PersonAge = new Dictionary<string, int>()
            {
                { "Ahmad", 45},
                { "Mohammad", 55},
                { "Ali", 56 },
                { "Sami", 76}
            };
*/
            //sorting using LINQ 
            /*var person_age_pair = PersonAge.Select(x => new {x.Key, x.Value});
            foreach(var item in  person_age_pair)
            {
                Console.WriteLine("person " + item.Key + "'s age is " + item.Value);
            }*/

            //filtering using LINQ 
            /*var person_age_pair = PersonAge.Where(pa => pa.Value >= 55); 

            foreach(var item in  person_age_pair)
            {
                Console.WriteLine("person " + item.Key + "'s age is " + item.Value);
            }*/

            /* if(PersonAge.TryGetValue("Aya", out int returnedvalue))
                 Console.WriteLine("the returned value is " + returnedvalue.ToString());
             else
                 Console.WriteLine("no value returned");*/

            /*foreach (KeyValuePair<string, int> pair  in PersonAge)
            {
                Console.WriteLine(pair.Key + "'s age is " + pair.Value);
            }*/

            //HashTable in C# 

            /* Hashtable hashtable1 = new Hashtable();
             hashtable1.Add("key1", "value1");
             hashtable1.Add("key2", "value2");
             hashtable1.Add("key3", "value3");
             hashtable1.Add("key4", "value4");

             foreach (DictionaryEntry enrty in hashtable1)
             {
                 Console.WriteLine(enrty.Key + " / " + enrty.Value);
             }*/

            /*int[] arraynumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> list = new List<int>(arraynumbers);
            Console.WriteLine( "Elements that initialized from array in list : " + string.Join(", " , list)); 
*/
            //Lists using C# 
            //List<int> list1 = new List<int>() { 11, -20, 300, -450, 55, 610, -7, 358, 90, 3 };
            //List<string> fruits = new List<string>() { "apple", "banana", "strewberry", "pineapple", "watermelon", "blueberry"};

            //using lambda expression
            //list1.ForEach(number => Console.Write(number + " "));

            //using lambda expression

            //fruits.ForEach(element => Console.Write(element + "  "));

            Console.WriteLine();
            Console.WriteLine();

            //using Contains 
            //Console.WriteLine("if fruits contains apple : " + fruits.Contains("apple"));

            //using Exists 
            //Console.WriteLine("if >= 5 letters fruit exists : " + fruits.Exists(f => f.Length >= 5));

            //using FindAll
            //Console.WriteLine("return all >= 5 letters fruits : " + string.Join(", " , fruits.FindAll(f => f.Length >= 5)));

            //using Any
            //Console.WriteLine("if there is any number greater than 100 : " + list1.Any(n => n > 100));

            //using FindAll
            //Console.WriteLine("return all positive elements : " + string.Join(", ", list1.FindAll(n => n > 0)));

            //using Find 
            //Console.WriteLine("return first positive element : " + list1.Find(n => n > 0));

            //using Contains 
            //Console.WriteLine("if List Contains number 9 : " + list1.Contains(9));

            //using Exists 
            //Console.WriteLine("if any negative number exists : " + list1.Exists(n => n < 0));

            //sorting a list
            /*list1.Sort();
            Console.WriteLine(string.Join(", ", list1));

            list1.Reverse();
            Console.WriteLine(string.Join(", ", list1)); */

            //sorting a list using LINQ 
            /*  Console.WriteLine(string.Join(", ", list1.OrderBy(n=>n)));
              Console.WriteLine(string.Join(", ", list1.OrderByDescending(n => n)));*/

            //filtering a list using LINQ
            /* Console.WriteLine("Even Numbers : " + string.Join(", ", list1.Where(n => n % 2 == 0)));
             Console.WriteLine("Odd Numbers : " + string.Join(", ", list1.Where(n => n % 2 != 0)));
             Console.WriteLine("Numbers Greater Than 5 : " + string.Join(", ", list1.Where(n => n > 5)));
             Console.WriteLine("Numbers Between 3 and 8 : " + string.Join(", ", list1.Where(n => (n > 3 && n < 8))));
             Console.WriteLine("Every Second Number : " + string.Join(", ", list1.Where((n,index) => index % 2 == 1)));     */

            //looping through lists 
            /* foreach (int i in list1)
                 Console.Write(i + " ");*/

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
