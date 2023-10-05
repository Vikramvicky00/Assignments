using System;

namespace Assignments
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //swap(Problem-1)
            Console.WriteLine("=====================================");
            Console.WriteLine("Enter First Number :");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Before Swapping \n First Number: {firstNumber} \n Second Number: {SecondNumber}");
            swap(firstNumber, SecondNumber);
            Console.WriteLine("=====================================");

            //multiply(Problem-2)
            Console.WriteLine("Enter First Number to multiply:");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number to multiply :");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number to multiply :");
            int m3 = Convert.ToInt32(Console.ReadLine());
            multiply(m1, m2, m3);
            Console.WriteLine("=====================================");

            //add,mul,div,sub(Problem-3)
            Console.WriteLine("Enter First Number :");
            int firstnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :");
            int secondnum = Convert.ToInt32(Console.ReadLine());
            calculate(firstnum, secondnum);
            Console.WriteLine("=====================================");

            //program to calculate sop and pos (Problem-4)
            Console.WriteLine("Enter First Number :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number:");
            int z = Convert.ToInt32(Console.ReadLine());
            prodofNum(x, y, z);
            Console.WriteLine("=====================================");

            // space separation (Problem-5)
            Console.WriteLine("Enter a digit :");
            int d = Convert.ToInt32(Console.ReadLine());
            space(d);
            Console.WriteLine("=====================================");

            // Graades(Problem-6)
            Console.WriteLine("Enter First Subject Marks:");
            int mark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Subject Marks :");
            int mark2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Subject Marks :");
            int mark3 = Convert.ToInt32(Console.ReadLine());
            grade(mark1, mark2, mark3);
            Console.WriteLine("=====================================");
            
            // check max min (Problem-7)
            Console.WriteLine("Enter First Number :");
             int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
             int n2 = Convert.ToInt32(Console.ReadLine());
            checkMinMax(n1, n2);
            
            Console.WriteLine("=====================================");
            //celsius to kelvin and fahrenheit (Problem-8)
            Console.Write("Enter the amount of Celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            celsiusToKelvinFahrenheit(celsius);
            
            Console.WriteLine("=====================================");
            //sumof2integersTriple(Problem-9)
            Console.WriteLine("Enter First Number :");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            sumTrip(s1, s2);
            
            Console.WriteLine("=====================================");
            //ps-10difference btw absolute (Problem-10)
            Console.WriteLine("Enter First Absolute Number :");
            int abs1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Absolute Number:");
            int abs2 = Convert.ToInt32(Console.ReadLine());
            absDiff(abs1, abs2);
            
            Console.WriteLine("=====================================");
            //Convert to days,years,weeks (Problem-11)
            Console.WriteLine("Enter  days :");
            int days= Convert.ToInt32(Console.ReadLine());
            convertDays(days);
            Console.WriteLine("=======================================");

        }


        //problem-1
        public static void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"\n After Swapping \n First Number: {a}\n Second Number: {b}");
        }

        //problem-2
        public static void multiply(int a, int b, int c)
        {
            Console.WriteLine($"{a} x {b} x {c} = {a * b * c}");
        }

        //problem-3
        public static void prodofNum(int x, int y, int z)
        {
            int prod = (x + y) * z;
            int sumOfNum = ((x * y) + (y * z));
            Console.WriteLine($"Result of Specified numbers {z}, {y}  and {z}, (x+y).z is {prod} and x.y + y.z = {sumOfNum}");
        }

        //problem-4
        public static void calculate(int n1, int n2)
        {
            int add = n1 + n2;
            int sub = n1 - n2;
            int div = n1 / n2;
            int mul = n1 * n2;
            int mod = n1 % n2;
            Console.WriteLine($"{n1} + {n2} = {add}");
            Console.WriteLine($"{n1} - {n2} = {sub}");
            Console.WriteLine($"{n1} x {n2} = {mul}");
            Console.WriteLine($"{n1} / {n2} = {div}");
            Console.WriteLine($"{n1} mod {n2} = {mod}");
        }

        //problem-5
        public static void space(int n)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i%2 == 0)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("{0} ",n);
                    }
                      Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("{0}",n);
                    }
                        Console.WriteLine();
                }
            }

        }

        //problem-6
        public static void checkMinMax(int n1, int n2) 
        { 
           if(n1 < n2)
            {
                Console.WriteLine($"Maximum number : {n2}");
                Console.WriteLine($"Mininum number : {n1}");
            }
            else if(n2 < n1) 
             {
                 Console.WriteLine($"Maximum number : {n1}");
                 Console.WriteLine($"Mininum number : {n2}");
             }
            else
            {
                Console.WriteLine($"Both numbers are equal:{n1}");
            }

        }

        //problem-7
        public static void grade(int m1,int m2,int m3)
        {
            int total = m1 + m2 + m3;
            int avg = total / 3;
            Console.WriteLine($"The Total marks of Three subjects: {total}");
            Console.WriteLine();
            if (avg < 35)
            {
                Console.WriteLine(" Grade : fail");
            }
            else if (avg > 35 && avg <45)
            {
                Console.WriteLine(" Grade : Third");
            }
            else if (avg > 45 && avg < 60)
            {
                Console.WriteLine(" Grade : Second");
            }
            else
            {
                Console.WriteLine(" Grade : First");
            }
        }

        //problem-8
        public static void celsiusToKelvinFahrenheit(int c)
        {
            int f =  (c *18/10 )+ 32;
            int k = 273 + c;
            Console.WriteLine($"Fahrenheit = {f}");
            Console.WriteLine($"Kelvin = {k}");
        }

        //problem-9
        public static void sumTrip(int n1, int n2)
        {
            int s = 0;
            if (n1 == n2)
            {
                s = (n1 + n2)*3;
                Console.WriteLine("Both are Equal..");
                Console.WriteLine($"The Triple of their sum is: {s}");
            }
            else { 
                s = n1 + n2;
                Console.WriteLine("Both are Not Equal..");
                Console.WriteLine($"The sum is: {s}");
            }
        }

        //problem-10
        public static void absDiff(int n1, int n2)
        {
            if (n1 > n2)
            {
                Console.WriteLine("{0} is greater than {1}", n1, n2);
                Console.WriteLine("The Absolute Difference is {0}", (n1 - n2) * 2);
            }
            else
            {
                Console.WriteLine("The Absolute Difference is {0}", n2 - n1);
            }
        }

        //problem-11
        public static void convertDays(int d)
        {
            int y = (d / 365);
            int w = (d % 365) / 7;
            d =d - (y * 365) + (w * 7);

            Console.WriteLine("Years : " + y);
            Console.WriteLine("weeks : " + w);
            Console.WriteLine("Days : " + d);
        }
    }

 }
