using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please entre your name");
            //string Firstname = Console.ReadLine();
            //Console.WriteLine("Please entre you lastname");
            //String Lastname = Console.ReadLine();

            //Console.WriteLine("Fullname = {0} {1}", Firstname, Lastname);
            //Console.ReadLine();

            //string name;
            //int age;
            //Console.WriteLine("Please entre the name");
            //name = Console.ReadLine();
            //Console.WriteLine("Please entre the age");
            //age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" my name is " + name + " haveing age is " + age);
            //// Console.WriteLine(name + " is my name " + age + " is age ");
            //// Console.WriteLine(name + " is about " + age + " years old.");
            //Console.ReadLine();


            //const int i = 100;
            //Console.WriteLine(i);
            //Console.ReadLine();

            //const double PI = 3.14;
            //Console.WriteLine("Please entre the value of r");
            //int r = Convert.ToInt32(Console.ReadLine());
            //double area = PI * r * r;
            //Console.WriteLine(" area of circle is "+ area);
            //Console.ReadLine();


            //Console.WriteLine("Please entre the number");
            //int input = Convert.ToInt32(Console.ReadLine());
            //if (input == 10)
            //{
            //    Console.WriteLine("TEN");
            //}
            //Console.ReadLine();

            //Console.WriteLine("Please entre the number");
            //int input = Convert.ToInt32(Console.ReadLine());
            //if (input ==20)
            //{
            //    Console.WriteLine("TWENTY");
            //}
            //Console.ReadLine();


            ////Console.WriteLine("Please entre the number");
            ////int result = Convert.ToInt32(Console.ReadLine());
            ////if (result == 10)
            ////{
            ////    Console.WriteLine("TEN");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("NOT TEN");
            ////}
            ////Console.ReadLine();


            //Console.WriteLine("Please entre the number");
            //int input = Convert.ToInt32(Console.ReadLine());
            //if (input == 10)
            //{
            //    Console.WriteLine("TEN");
            //}
            //else if (input == 20)
            //{
            //    Console.WriteLine("TWENTY");
            //}
            //else
            //{
            //    Console.WriteLine("NOT TEN OR NOT TWENTY");
            //}
            //Console.ReadLine();

            //Console.WriteLine("please entre the number");
            //int input = Convert.ToInt32(Console.ReadLine());
            //string result = (input == 10) ? "TEN":
            //                (input == 20) ? "TWENTY":
            //                 "NOT TEN OR TWENTY";
            //Console.WriteLine(result);
            //Console.ReadLine();

            //Console.WriteLine("Please entre the number");
            //int input = Convert.ToInt32(Console.ReadLine());
            //switch (input)
            //{
            //    case 10:
            //        Console.WriteLine("TEN");
            //        break;

            //    case 20:
            //        Console.WriteLine("TWENTY");
            //        break;
            //    default:
            //        Console.WriteLine("not ten or twenty");
            //        break;
            //}
            //Console.ReadLine();


            //int i = 10;
            //while (i >=1)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}
            //Console.ReadLine();

            //int i = 1;
            //do
            //{
            //    Console.WriteLine("HEllo");
            //    i++;
            //}
            //while (i <= 10);
            //Console.ReadLine();

            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //////Array
            //int n;
            //Console.WriteLine("Entre the student number");
            //n = Convert.ToInt32(Console.ReadLine());
            //if (n > 0)
            //{
            //    //declare the array
            //    String[] name = new string[n];
            //    int[] marks = new int[n];
            //    String[] result = new string[n];

            //    //read student name
            //    //Console.WriteLine("\n Entre " + n + "student name");
            //    Console.WriteLine(" Entre " + n + " student name ");
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.WriteLine((i+1) + ":");
            //        name[i] = Console.ReadLine();
            //    }
            //    Console.WriteLine(" Entre " + n + " student marks ");
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.WriteLine((i + 1) + ":");
            //        marks[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    //calculate result
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (marks[i] >= 0 && marks[i] <= 100)
            //        {
            //            if (marks[i] >= 80)
            //                result[i] = "Distinction";
            //            else if (marks[i] >= 60)
            //                result[i] = "First Class";
            //            else if (marks[i] >= 50)
            //                result[i] = "Second Class";
            //            else if (marks[i] >= 35)
            //                result[i] = "Third Class";
            //            else
            //                result[i] = "Failed";
            //        }
            //        else
            //            result[i] = "Invalid";
            //    }
            //    // display student result
            //    Console.WriteLine("\n student details");
            //    for (int i = 0; i < n; i++)
            //        Console.WriteLine((i + 1) + ":" + name[i] + " - " + marks[i] + " - " +
            //            "" + result[i]);




            //}
            //else
            //    Console.WriteLine("N value cant be zero");
            //Console.ReadLine();



            //array
            int n;
            Console.WriteLine("Please entre the number");
            n = Convert.ToInt32(Console.ReadLine());


            if (n > 0)
            {
                string[] name = new string[n];
                int[] marks = new int[n];
                string[] result = new string[n];

                Console.WriteLine(" entre " + n + " Student name ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine((i + 1) + ":");
                    name[i] = Console.ReadLine();
                }
                Console.WriteLine(" entre " + n + " Student marks ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine((i + 1) + ":");
                    marks[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                    if (i >= 0 && i <= 100)
                    {
                        if (marks[i] >= 80)
                            result[i] = "Distinction";
                        else if (marks[i] >= 60)
                            result[i] = "First Class";
                        else if (marks[i] >= 50)
                            result[i] = "Second Class";
                        else if (marks[i] >= 35)
                            result[i] = "Third Class";

                        else
                            result[i] = "Failed";

                    }
                    else
                        result[i] = "Invalid";


                Console.WriteLine("Student Details");
                for (int i = 0; i < n; i++)
                    Console.WriteLine((i + 1) + ":" + name[i] + " - " + marks[i] + " - " + result[i]);

            }
            else
                Console.WriteLine("Value of N is invalid");

            Console.ReadLine();

        }
       
    }
    
}
