using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                                 //Intger
            //int a = 50;
            //int b = 30;
            //int c = a - b;
            //Console.WriteLine(c);

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

          

        }
        // * Return Type
        //public static int calc()
        //{
        //    int a = 10;
        //    int b = 10;
        //    int c = a + b;
        //    return c;
        //    Console.WriteLine(calc());//--> cut the parameter name and then paste inside the static void main 
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

        //                   //OPERATOR
        // * Assignment Operator - =
        // * Arithmetic Operator - + , - , * , / , %
        // * Relational Operator - == , < , > , <= , >= , !=
        // * Logical Operator    - &&(AND) , ||(OR) 
        // * Unary Operator      - + , - , ++ , --, !(Logical Negation)
        // * Ternary Operator    - Condition? True:False

        // * Code Resusability
        //public static void cal(string name)
        //{
        //    Console.WriteLine($"Hi, my name is {name}");
        //    cal("anbu");//--> cut the parameter name and then paste inside the static void main function
        //    cal("vicky");//--> cut the parameter name and then paste inside the static void main function
        //    cal("praveen");//--> cut the parameter name and then paste inside the static void main function
        //    cal("logesh");//--> cut the parameter name and then paste inside the static void main function
        //}

        // * Assignment Operator - =
        //public static int calc(int a,int b)
        //    {
        //    int c = a + b;
        //    return c;
        //    Console.WriteLine(calc(6, 3)); //--> cut the parameter name and then paste inside the static void main function
        //     }

        // * Arithmetic Operator - + , - , * , / , %
        //public static void calc(int a,int b)
        //{
        //    var result = a + b;
        //    Console.WriteLine($"Addition:{result}");
        //    result = a - b;
        //    Console.WriteLine($"Subtraction:{result}");
        //    result = a * b;
        //    Console.WriteLine($"Multiplication:{result}");
        //    result = a / b;
        //    Console.WriteLine($"Division:{result}");
        //    result = a % b;
        //    Console.WriteLine($"Modulus:{result}");
        //    calc(10, 5); //--> cut the parameter name and then paste inside the static void main function
        //}

        // *  Relational Operator - == , < , > , <= , >= , !=

        //                              DECISION MAKING
        // * If 
        // * If else
        // * Else if
        // * Nested if
        // * Switch Statement 

        // * If else -->cut and paste inside the static void main
        //int a = 20;
        //int b = 30;
        //if (a > b)
        //{
        //    Console.WriteLine("A lessthan B");
        //}
        //else {
        //    Console.WriteLine("A greaterthan B");
        //}

        // * Else if -->cut and paste inside the static void main
        //int a = 95;
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

        // * Nested if -->cut and paste inside the static void main
        // * Get Input
        //Console.WriteLine("Enter my age");
        //string myage = Console.ReadLine();
        //int age;
        //Boolean result = int.TryParse(myage, out age);

        //if (result) {
        //    if (age > 15)
        //    {
        //        if (age > 18)
        //        {
        //            Console.WriteLine("Go to movie");
        //            Console.WriteLine("Go to purchase");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Go to purchase only");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("you are below 15");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Please enter a valid input");
        //}

        // * Switch Statement -->cut and paste inside the static void main
        //string colours = Console.ReadLine();
        //switch (colours.ToLower())
        //{
        //    case "red":
        //        Console.WriteLine("You are select the red");
        //            break;
        //    case "green":
        //        Console.WriteLine("You are select the green");
        //            break;
        //    case "blue":
        //        Console.WriteLine("You are select the blue");
        //            break;
        //    default:
        //        Console.WriteLine("Invalid");
        //        break;
        //}

        //                                       LOOPS

        // * For
        // * While(check the run code block)
        // * Do while(run code block then it will check)
        // * Fore each(loop through array or list)

        //// * For -->cut and paste inside the static void main
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine(i);
        //}


        // * While (check the run code block)-->cut and paste inside the static void main
        //int num = 0;
        //while(num<10){
        //    Console.WriteLine(num);
        //    num++;
        //}

        // * Do while (run code block then it will check)-->cut and paste inside the static void main
        //int num = 0;
        //do {
        //    Console.WriteLine(num);
        //    num++;
        //} while (num<10);

        // * Fore each (loop through array or list)-->cut and paste inside the static void main
        //int[] num = new int[5];
        //num[0] = 1;
        //num[1] = 2;
        //num[2] = 3;
        //num[3] = 4;
        //num[4] = 5;
        //foreach(int i in num)
        //{
        //    Console.WriteLine(i);
        //}

        //                                      COLLECTIONS
        // * Array
        // * Types Of Collections
        //       *Generic Collection-Limited to one type of object
        //       *Non Generic Collection-Can store any type of object
        //*Generic Collection              |        *Non Generic Collection
        //*List,Dictionaries,Stack,Queue   |        *ArrayList,HashTable

        // * Non Generic Collection

        //* ArrayList       -->cut and paste inside the static void main
        //ArrayList data = new ArrayList();
        //data.Add(10);
        //    data.Add(10.5f);
        //    data.Add("anbu");
        //    data.Add(true);
        //    data.Add(100);

        //    // data.Remove(10);-->Remove = Remove by value
        //   // data.RemoveAt(3);-->RemoveAt = Remove by index number
        //    foreach (var item in data)
        //    {
        //        Console.WriteLine(item);
        //    }

        // * List --> cut the parameter name and then paste inside the static void main 
        //    List<int> number = new List<int>();
        //    number.Add(10);
        //        number.Add(20);
        //        number.Add(30);
        //        number.Add(40);
        //         // data.Remove(10);-->Remove = Remove by value
        //         // data.RemoveAt(3);-->RemoveAt = Remove by index number
        //        foreach (var item in number)
        //        {
        //            Console.WriteLine(item);
        //        }
        //List<string> name = new List<string>();
        //name.Add("anbu1");
        //        name.Add("anbu2");
        //        name.Add("anbu3");
        //        name.Add("anbu4");
        //        foreach (var item in name)
        //        {
        //            Console.WriteLine(item);
        //        }

        //// * Hashtable --> cut the parameter name and then paste inside the static void main 
        //Hashtable data = new Hashtable();
        //data.Add(0, "monday");
        //    data.Add(1, "tuesday");
        //    data.Add(2.5,"wednesday");
        //    data.Add("anbu", 100);
        //    Console.WriteLine(data["anbu"]); // --> enter key get value
        //   // data.Remove("anbu");--> (Key paired Values) remove by key
        //    // Loop with Hashtable
        //    foreach(DictionaryEntry item in data)
        //    {
        //        Console.WriteLine($"{item.Key}:{item.Value}"); //--> enter item.key - get all keys,enter item.value - get all value
        //    }

        //// * Dictionary --> cut the parameter name and then paste inside the static void main 
        ////Syntex-->Dictionary<keydatatype, valuedatatype> variablename = new Dictionary<keydatatype, valuedatatype>();
        //Dictionary<int, string> data = new Dictionary<int, string>();
        //data.Add(0, "jan");
        //    data.Add(1, "feb");
        //    data.Add(2, "mar");
        //   // data.Remove(2); -->(key paired values)-->remove by key
        //    for(int i=0;i<data.Count;i++)
        //    {
        //        Console.WriteLine($"{data.Keys.ElementAt(i)} : {data.Values.ElementAt(i)}");
        //    }

        //// * Stack  --> cut the parameter name and then paste inside the static void main 
        //Stack<int> stack = new Stack<int>();
        //stack.Push(100);
        //    stack.Push(200);
        //    stack.Push(300);
        //    stack.Push(400);
        //    //Console.WriteLine(stack.Pop());   //-->get out the value
        //    //Console.WriteLine(stack.Peek());  //--> first seeing value
        //    //Console.WriteLine(stack.Count()); //--> count the values
        //    while (stack.Count() > 0)
        //    {
        //        Console.WriteLine(stack.Pop());
        //    }

        //// * Queue --> cut the parameter name and then paste inside the static void main 
        //Queue<int> data = new Queue<int>();
        //data.Enqueue(10);
        //    data.Enqueue(20);
        //    data.Enqueue(30);
        //    data.Enqueue(40);
        //    data.Enqueue(50);
        //    //data.Dequeue();--> remove the first value
        //    // Console.WriteLine(data.Count());--> count the current count
        //    //Console.WriteLine(data.Peek());--> see the current first value
        //    while (data.Count > 0) 
        //    {
        //        Console.WriteLine(data.Dequeue());
        //    }
}
}

