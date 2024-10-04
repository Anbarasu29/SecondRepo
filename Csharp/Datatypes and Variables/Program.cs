using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                                 //Intger
            int a = 50;
            int b = 30;
            int c = a - b;
            Console.WriteLine(c);

            //                                 //Long
            //long a = 1500000000;
            //long b = 25000000000;
            //long c = a + b;
            //Console.WriteLine(c);

            //                                  //Float
            //float num1 = 1.25f;
            //float num2 = 1.75f;
            //float num3 = num1 + num2;
            //Console.WriteLine(num3);

            //                                     //Double
            //double num1 = 5.5680;
            //double num2 = 6.4320;
            //double num3 = num1 + num2;
            //Console.WriteLine(num3);

            //                             //Explicit Conversation--->  float to int [(int)num]   
            //float num = 2.585f;
            //int a = (int)num;
            //Console.WriteLine(a);

            //              //Implicit Conversation---> small to large [int to long / float to double]

            //int a = 10;
            //Console.WriteLine(a);
            //Console.WriteLine(a.GetType());
            //long num1 = a;
            //Console.WriteLine(num1);
            //Console.WriteLine(num1.GetType());

            //                          //Type Conversion
            // int to string
            //int a = 20;
            //Console.WriteLine(a);
            //Console.WriteLine(a.GetType());
            //string num1 = a.ToString();
            //Console.WriteLine(num1);
            //Console.WriteLine(num1.GetType());

            // float to string
            //float a = 2.5f;
            //Console.WriteLine(a);
            //Console.WriteLine(a.GetType());
            //string num1 = a.ToString();
            //Console.WriteLine(num1);
            //Console.WriteLine(num1.GetType());

            // double to string
            //double a = 1.5867;
            //Console.WriteLine(a);
            //Console.WriteLine(a.GetType());
            //string num1 = a.ToString();
            //Console.WriteLine(num1);
            //Console.WriteLine(num1.GetType());

            // bool to string
            //bool a = true;
            //Console.WriteLine(a);
            //Console.WriteLine(a.GetType());
            //string num1 = a.ToString();
            //Console.WriteLine(num1);
            //Console.WriteLine(num1.GetType());

            // string to int
            //Console.WriteLine("Emter a two Number");
            //string a = Console.ReadLine();
            //string b = Console.ReadLine();

            //int num1 = Int32.Parse(a);
            //int num2 = Int32.Parse(b);
            //int c = num1 + num2;
            //Console.WriteLine(c);

            //                 // STRING AND ITS METHODS

            // String Manipulation

            // * Concatenation +
            //string  name = "anbu";
            //int age = 23;
            //string location = "kallakurichi";
            //Console.WriteLine("Hi am " + name + " my age is " + age + " from " + location);

            // * Formatting {0},{1},a,b;
            //string name = "anbu";
            //int age = 23;
            //string location = "kallakurichi";
            //Console.WriteLine("Hi am {0} my age is {1} from {2}", name, age, location);

            // * Interpolation $ {a} {b}
            //string name = "anbu";
            //int age = 23;
            //string location = "kallakurichi";
            //Console.WriteLine($"Hi am {name} /n my age is {age} from {location}");

            // * Verbatim @[/n and raw space]
            //string name = "anbu";
            //int age = 23;
            //string location = "kallakurichi";
            //Console.WriteLine(@"Hi am {0} /n my age is {1} from {2}", name, age, location);

            //                  //STRING METHODS
            // * Uppercase and Lowercase
            //string firstName = "anbu";
            //string lastName = "c";
            //Console.WriteLine(firstName.ToLower() + " " + lastName.ToUpper());

            // * SubString
            //string firstName = "anbu";
            //string lastName = "c";
            //Console.WriteLine(firstName.Substring(2));

            // * Trim
            //string firstName = "anbu";
            //string lastName = "c";
            //string fullName = string.Concat (" " + firstName, lastName + "");
            //Console.WriteLine(fullName.Trim());

            //                    //STRING OPERATIONS
            // * IndexOf
            //string firstName = "anbu";
            //string lastName = "c";
            //Console.WriteLine(firstName.IndexOf('n'));

            // * IsNullOrWhiteSpace-null or blank true else false
            //string firstName = "anbu";
            //string lastName = "c";
            //string fullName = string.Concat(" " + firstName, lastName);
            //bool data =string. IsNullOrWhiteSpace(fullName);
            //Console.WriteLine(data);

            //                      //CONSOLE METHODS
            // * Console.Write(); - Same Line
            // * Console.WriteLine(); -New Line

            // * Console.Read(); - ASCII //to right click the solution name and then click open folder in file explorer->bin->datatypes->debug->.net8->datatypes
            //int data = Console.Read();
            //Console.WriteLine(data);
            // * Console.ReadKey(); - Hold to Read
            //int data = Console.Read();
            //Console.WriteLine(data);
            //Console.ReadKey();

            // * Console.ReadLine(); - Raw Input


            //                      // TYPES OF DATATYPES
            // * Value Type
            // Int,Float,Long,Double,Boolean,Char
            // * Reference Type
            // String,Array and Class

            //                      //SYNTEX FOR METHODS
            //<Access Specifier> <Return Type> <Method Name> (Parameter List)
            //    { 
            //     Method Body
            //}

            //                      // TYPES OF METHODS
            // *Non Return Type--> using void
            // * Return Type--> using string,float,double,boolean

            // * If else
            //int a = 20;
            //int b = 30;
            //if (a > b)
            //{
            //    Console.WriteLine("A lessthan B");
            //}
            //else {
            //    Console.WriteLine("A greaterthan B");
            //}

            // * Else if
            //string a = 95;
            //if (a > 70 && a <= 80)
            //{
            //    Console.WriteLine("Grade B");
            //}
            //else if (a > 80 && a <= 90)
            //{
            //    Console.WriteLine("Grade B");
            //}
            //else if (a > 90 && a <= 100)
            //{
            //    Console.WriteLine("Grade A");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}

            // * Nested if
            //string age = 19;
            //string height = 176;
            //if (age > 18)
            //{
            //    if (height > 175)
            //    {
            //        Console.WriteLine("you are eligible");
            //    }
            //    else {
            //        Console.WriteLine("you are below 175");
            //    }
            //}
            //else {
            //    Console.WriteLine("you are below 18");
            //}

        }
        // * Return Type
        //public static int calc()
        //{
        //    int a = 10;
        //    int b = 10;
        //    int c = a + b;
        //    return c;
        //    Console.WriteLine(calc());//--> cut the parameter name and then paste inside the static void main function
        //}

        // *Non Return Type         //
        ////(Access Specifier) (static) (Return Type) (Method Name)
        //// void --> Non Return Type Function
        ///
        //public static void printer()
        //{

        //    Console.WriteLine("hi am anbu");
        //    Console.ReadKey();
        //    printer();   //--> cut the parameter name and then paste inside the static void main function
        //}

    }
}

