using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GroupWork.Helper
{
    internal static class Helper
    {
        public static void GetPolidrom()
        {
            //Aytac
            string finale = string.Empty;
            Console.WriteLine("Enter text");
            string str = Console.ReadLine().Trim();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ' ' && str[i + 1] == ' ')
                {
                    str = str.Replace("  ", " ");
                    i = 0;
                }
            }
            string[] words = str.Split(" ");
            foreach (string word in words)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    sb.Append(word[i]);
                }
                if (word == sb.ToString()) finale = finale + word + " ";
            }
            Console.WriteLine(finale);
        }
        public static void SezarFoward()
        {
            //aytac
            StringBuilder sb = new StringBuilder();
            do
            {
                Console.WriteLine("Enter text");
                string text = Console.ReadLine();
                Console.WriteLine("Enter shift");
                int num;
                string str = Console.ReadLine().Trim();
                bool result = int.TryParse(str, out num);
                if (result == false) continue;
                for (int i = 0; i < text.Length - 1; i++)
                {
                    if (text[i] == ' ' && text[i + 1] == ' ')
                    {
                        text = text.Replace("  ", " ");
                        i = 0;
                    }
                }
                foreach (char c in text)
                {
                    if (char.IsDigit(c) || c == ' ') continue;
                    if (c + num > 90 || c + num < 122)
                    {
                        sb.Append((char)(c - 26 + num));
                    }
                    else
                    {
                        sb.Append((char)(c + num));
                    }
                }
                break;
            } while (true);
            Console.WriteLine(sb.ToString());
        }
        public static void SezarBack()
        {
            //aytac
            StringBuilder sb = new StringBuilder();
            do
            {
                Console.WriteLine("Enter text");
                string text = Console.ReadLine();
                Console.WriteLine("Enter shift");
                int num;
                string str = Console.ReadLine().Trim();
                bool result = int.TryParse(str, out num);
                if (result == false) continue;
                for (int i = 0; i < text.Length - 1; i++)
                {
                    if (text[i] == ' ' && text[i + 1] == ' ')
                    {
                        text = text.Replace("  ", " ");
                        i = 0;
                    }
                }
                foreach (char c in text)
                {
                    if (char.IsDigit(c) || c == ' ') continue;
                    if (c - num < 65 || c - num < 97)
                    {
                        sb.Append((char)(c + 26 - num));
                    }
                    else
                    {
                        sb.Append((char)(c - num));
                    }
                }
                break;
            } while (true);
            Console.WriteLine(sb.ToString());
        }
        public static void SumList()
        {
            //aytac
            Console.WriteLine("enter numbers with space in between");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == ' ' && str[i + 1] == ' ')
                {
                    str = str.Replace("  ", " ");
                    i = 0;
                }
            }
            string[] list = str.Split(" ");
            int sum = 0;
            int index = 0;
            Sum(list, ref sum, index);

        }
        private static void Sum(string[] list, ref int sum, int index)
        {
            if (index > list.Length - 1)
            {
                Console.WriteLine(sum);
                return;
            }
            int num;
            bool result = int.TryParse(list[index], out num);
            index++;
            if (result)
            {
                sum += num;
                Sum(list, ref sum, index);
            }
        }
        public static void Sum15()
        {
            //task 4 nazrin
            int[] arr = { 1, 5, 9, 6, 4, 6 };
            int sum = 15;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length - 2; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == sum)

                            Console.WriteLine($"[{arr[i]}, {arr[j]}, {arr[k]}]");
                    }

                }
            }
        }
        public static void Binary()
        {
            //16 nazrin
            int number = 10;
            string number2 = "";
            int temp = number;


            while (temp > 0)
            {
                int rem = temp % 2;
                number2 = rem + number2;
                temp = temp / 2;

            }
            Console.WriteLine(number2);

        }
        public static void Anaqram()
        {
            // 15)Verilmis iki sozu anaqram olub - olmadigini tapin. kutais

            string word = "listen";
            string word2 = "silent";
            string result = "True";
            if (word.Length != word2.Length)
            {
                Console.WriteLine("False");
            }
            else
            {
                char[] arr1 = new char[word.Length];
                char[] arr2 = new char[word2.Length];

                for (int i = 0; i < word.Length; i++)
                {
                    arr1[i] = word[i];
                }

                for (int i = 0; i < word2.Length; i++)
                {
                    arr2[i] = word2[i];
                }

                Array.Sort(arr1);
                Array.Sort(arr2);

                string sortWord1 = new string(arr1);
                string sortWord2 = new string(arr2);
                if (sortWord1 != sortWord2)
                {
                    Console.WriteLine("False");
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
        }
        public static void Factorial()
        {
            //kutais
            int n = 3;
            int hasil = Factorial(n);
            Console.WriteLine(hasil);
            static int Factorial(int n)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                if (n < 0)
                {
                    Console.WriteLine("Bu ededin factoriali hesablanmir.");
                }
                return n * Factorial(n - 1);
            }
        }
        public static void Difference(params int[]numbers) //2=>Elchin
        {

            //5 1 4 6 => 1 5 4 6 =>1 4 5 6
            int num = 0;
            int num2 = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {       //5              //1
                if (numbers[i] > numbers[i + 1])
                {    //5
                    num = numbers[i];
                    //1              //1
                    numbers[i] = numbers[i + 1];
                    //5           //5
                    numbers[i + 1] = num;
                    //4
                    i = 0;
                }
            }
            num2 = numbers[numbers.Length - 1] - numbers[0];
            Console.WriteLine(num2);
        }
        public static void IsOdd() //11=>Elchin
        {
            int num;
            Console.WriteLine("Enter number");
            int.TryParse(Console.ReadLine(), out num);
            if (num != 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Cut");
                }
                else
                {
                    Console.WriteLine("tekdir");
                }
            }
        }
        public static void CustomSum(params int[] num) //12=>Elchin
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine(sum);
        }
        public static int EvenOddDifference( params int[] arr)
        {
            int evenCount = 0;
            int oddCount = 0;

            foreach (int num in arr)
            {
                if (num % 2 == 0) evenCount++;
                else oddCount++;
            }

            if (evenCount > oddCount)
                return evenCount - oddCount;
            else
                return oddCount - evenCount;
        }

    }
}
