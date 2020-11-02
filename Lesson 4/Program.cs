using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void Homework_01()
        {
            for (int i = 1; i <= 4; i++)
            {
                int n = 4;
                for (int j = 1; j <= n - 1; j++)
                {
                    Console.Write("");
                }
                for (int k = i; k >= 1; k--)
                {
                    Console.Write(k);

                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write(1);
                }
                Console.WriteLine();
            }

            for (int i = 3; i >= 1; i--)
            {
                int n = 3;
                for (int j = 0; j <= n - i; j++)
                {
                    Console.Write("");


                }
                for (int k = i; k >= 1; k--)
                {
                    Console.Write(k);
                }
                for (int l = 2; l <= i; l++)
                {
                    Console.Write(1);

                }
                Console.WriteLine();


            }
            Console.ReadKey();
        }
        private static void Task_02()
        {
            Console.Write("String to encode: ");
            string stringToEncode = Console.ReadLine();

            string encodedString = Encode(stringToEncode);
            Console.WriteLine($"Encoded string: {encodedString}");

            string decodedString = Decode(encodedString);
            Console.WriteLine($"Decoded string: {decodedString}");
        }

        private static char[] alpha = { 'a', 'b', 'c' };
        private static char[] secret = { 'x', 'w', 'z' };

        private static string Encode(string inputString)
        {
            string result = "";
            foreach (char character in inputString)
            {
                int index = IndexOf(character, alpha);
                result += secret[index];
            }
            return result;
        }

        private static string Decode(string encodedString)

        {
            string result = "";
            foreach (char character in encodedString)
            {
                int index = IndexOf(character, secret);
                result += alpha[index];

            }
            return result;
        }

        private static int IndexOf(char letter, char[] array)
        {
            for (int i = 0; i < alpha.Length; i++)
            {
                if (array[i] == letter)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
