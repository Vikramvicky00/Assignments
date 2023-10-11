using System;

namespace CSharpBasics
{
    internal class BasicDataType
    {
        static void Main(string[] args)
        {
            //int
            Console.WriteLine("Integer Type");
            Console.WriteLine("Enter First Integer number");
            int firstNoInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Integer number");
            int secondNoInt = Convert.ToInt32(Console.ReadLine());
            int ansInt = firstNoInt + secondNoInt;
            Console.WriteLine($"The answer of Integer Type {firstNoInt} + {secondNoInt} = {ansInt}");
            Console.ReadLine();


            //float
            Console.WriteLine("Float Type");
            Console.WriteLine("Enter First Float number");
            float firstNoFloat = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Second Float number");
            float secondNoFloat = Convert.ToSingle(Console.ReadLine());
            float ansFloat = firstNoFloat + secondNoFloat;
            Console.WriteLine($"The answer of Float Type {firstNoFloat} + {secondNoFloat} = {ansFloat}");
            Console.ReadLine();
            Console.WriteLine();

            //double
            Console.WriteLine("Double Type");
            Console.WriteLine("Enter first Double number");
            Double firstNoDoub = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second  Double number");
            Double secondNoDoub = Convert.ToDouble(Console.ReadLine());
            double ansDoub = firstNoDoub + secondNoDoub;
            Console.WriteLine($"The answer of Double Type {firstNoDoub} + {secondNoDoub} = {ansDoub}");
            Console.ReadLine();
            Console.WriteLine();

            //datetime
            Console.WriteLine("Date Type");
            Console.WriteLine($"Today date is {DateTime.Now}");
            DateTime d = new DateTime(2022, 4, 4);
            Console.WriteLine(d);

            Console.WriteLine("enter Birthdate");
            DateTime Birthdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(Birthdate);
            Console.WriteLine(Birthdate.Year);
            Console.WriteLine(Birthdate.Day);
            Console.WriteLine(Birthdate.DayOfWeek);
            Console.WriteLine();

            //Char
            Console.WriteLine("Char Type");
            Console.WriteLine("Enter Character:");
            char c1=Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Char is{c1}");
            Console.WriteLine();

            //bool
            Console.WriteLine("Boolean Type");
            Console.WriteLine("Enter True or false:");
            Boolean b = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"The Boolean value is : {b}");
            Console.WriteLine();

            //String
            Console.WriteLine("String Type");
            Console.WriteLine("Enter String:");
            String s1 = Console.ReadLine();
            Console.WriteLine($"String is { s1}");
            Console.WriteLine();


        }
    }
}
