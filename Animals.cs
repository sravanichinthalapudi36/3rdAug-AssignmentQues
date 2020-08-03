using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "Zebra", "Ant", "Owl", "Lion" };
            Console.WriteLine("-----------using ForEach loop------");
            Array.Sort(myArray);
            foreach (string i in myArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------using For loop-----");
            string[] myArray1 = { "Zebra", "Ant", "Owl", "Lion" };
            Array.Sort(myArray1);
            for (int l = 0; l < myArray1.Length; l++)
            {
                Console.WriteLine(myArray1[l]);
            }
            Console.WriteLine("-----using while loop------");
            string[] myArray2 = { "Zebra", "Ant", "Owl", "Lion" };
            Array.Sort(myArray2);
            int m = 0;
            while (m < myArray2.Length)
            {
                Console.WriteLine(myArray2[m]);
                m++;
            }
            Console.WriteLine("-------------using Do while loop--------");
            string[] myArray3 = { "Zebra", "Ant", "Owl", "Lion" };
            Array.Sort(myArray3);
            int j = 0;
            do
            {
                Console.WriteLine(myArray3[j]);
                j++;
            } while (j < myArray3.Length);
            Console.WriteLine("-------using more string Animals-----------");
            string[] arr = {"Zebra","Kiwi","Amazon Parraot","Tiger" };
            Array.Sort(arr);
            foreach (string p in arr)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("-----------------using places-----------------");
            string[] places = {"Africa","New Zealand","Jamaica","India" };
            Array.Sort(places);
            foreach (string q in places)
            {
                Console.WriteLine(q);
            }
            Console.Read();
        }
    }
}
