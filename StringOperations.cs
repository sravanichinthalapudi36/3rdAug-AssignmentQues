using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2, opt;
            int ch, i, j;
            do
            {
                Console.Write("Enter the first String :");
                str1 = Convert.ToString(Console.ReadLine());
                Console.Write("Enter the second String :");
                str2 = Convert.ToString(Console.ReadLine());
                Console.Write("1-Concatenate Strings.\n");
                Console.WriteLine("2-Length of Two Strings.\n");
                Console.WriteLine("3-SubString.\n");
                Console.WriteLine("4-Replace.\n");
                Console.WriteLine("5-Upper case.\n");
                Console.WriteLine("6-Lower case.\n");
                Console.WriteLine("7-Trim.\n");
                Console.WriteLine("8-Split.\n");
                Console.WriteLine("9-Exit.\n");
                Console.WriteLine("Enter your choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Write("The Concatenation of  {0} and {1} is: {2}\n", str1, str2, str1 + str2);
                        break;
                    case 2:
                        Console.WriteLine("the length of two strings {0} and {1}", str1.Length, str2.Length);
                        break;
                    case 3:

                        string sub = str1.Substring(0, str1.Length - 5);
                        Console.WriteLine("Substring: {0}", sub);
                        string sub1 = str2.Substring(0, str2.Length - 5);
                        Console.WriteLine("Substring: {0}", sub1);
                        break;
                    case 4:
                        string output = str1.Replace("india ", "most powerful country in this world is india");
                        Console.WriteLine("the first string is: {0}", output);
                        string ou = str2.Replace("good ", "the most pleast morning ");
                        Console.WriteLine("the second String is: {0}", ou);
                        break;
                    case 5:
                        string upper = str1.ToUpper();
                        string upper1 = str2.ToUpper();
                        Console.WriteLine("the string is in upper case {0}", upper);
                        Console.WriteLine("the string is in upper case {0}", upper1);
                        break;
                    case 6:
                        string lower = str1.ToLower();
                        string lower1 = str2.ToLower();
                        Console.WriteLine("the string is in upper case {0}", lower);
                        Console.WriteLine("the string is in upper case {0}", lower1);
                        break;
                    case 7:
                        Console.WriteLine(str1.Trim());
                        Console.WriteLine(str2.Trim());
                        break;

                    case 8:
                        string[] array = str1.Split('$');
                        foreach (string value in array)
                        {
                            Console.WriteLine($"the split after string: {value}");
                        }
                        string[] array1 = str1.Split(',');
                        foreach (string value1 in array)
                        {
                            Console.WriteLine($"the split after string: {value1}");
                        }
                        break;
                    default:
                        Console.Write("Make the choice again Enter 9 to exit\n");
                        break;

                }
            } while (ch != 9);

        }
    }
}