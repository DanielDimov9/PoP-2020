using System;

namespace Homework_Pop
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void MyName()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Daniel Dimov!");




        }
        private static void SumofTwo()
        {
            Console.WriteLine(18 + 23);
        }
        private static void Exerciese3()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }
        private static void Exercises4()
        {
            int num1, num2, num3;

            Console.WriteLine("Input the first number to multiply");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number to mltiply");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input third number to multiply");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3} ", num1, num2, num3, result);

        }
        private static void Exercises5()

        {
            int x;
            int result;
            Console.WriteLine("Enter number");
            x = Convert.ToInt32(Console.ReadLine());

            result = x * 1;
            Console.WriteLine("The table is : {0},{1} = {2}", x, 1, result);
            result = x * 2;
            Console.WriteLine("The table is : {0},{1} = {2}", x, 2, result);
            result = x * 3;
            Console.WriteLine("The table is : {0},{1} = {2}", x, 3, result);
            result = x * 4;
            Console.WriteLine("The table is : {0},{1} = {2}", x, 4, result);
            result = x * 5;
            Console.WriteLine("The table is : {0},{1} = {2}", x, 5, result);
            result = x * 6;
            Console.WriteLine("The table is : {0},{1} = {2}", x, 6, result);
            result = x * 7;
            Console.WriteLine("The table is : {0},{1} = {2}", x, 7, result);
            result = x * 8;
            Console.WriteLine("The table is : {0},{1} = {2}", x, 8, result);
            result = x * 9;
            Console.WriteLine("The table is : {0},{1} = {2}", x, 9, result);
            result = x * 10;
            Console.WriteLine("The table is : {0},{1} = {2}", x, 10, result);

        }
        private static void Exercises6()
        {
            double number1, number2, number3, number4;

            Console.WriteLine("Enter the first number");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the fourht number");
            number4 = Convert.ToDouble(Console.ReadLine());

            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average result of {0},{1},{2},{3} is {4}", number1, number2, number3, number4, result);






        }
        public static void Exercises8()
        {
            DateTime date = DateTime.Now;
            DateTime time = DateTime.Now;
            DateTime year = DateTime.Now;

            Console.WriteLine("Current date:");
            Console.WriteLine(date.ToShortDateString());

            Console.WriteLine("Current time:");
            Console.WriteLine(time.ToShortTimeString());
            Console.WriteLine("Current year:");
            Console.WriteLine(year.ToString());


            Console.ReadKey();


        }
        private static void Exercises9()
        {
            Console.WriteLine("Current age:");
            int currentAge = int.Parse(Console.ReadLine());

            Console.WriteLine(" Bday day :");
            int currentBday = int.Parse(Console.ReadLine());
            Console.Write("BDay month : ");
            int bdayDay = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
        public static void Exercises10()
        {
            int number1, number2, number3;
            Console.WriteLine("Enter first number -");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second -");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number-");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n", number1, number2, number3, ((number1 + number2) * number3), (number1 * number2 + number2 * number3));
        }


















    }
}

    

