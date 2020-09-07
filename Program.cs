using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    


    class Program
    {
        public static string CheckIfEqual(int a, int b)
        {
            string result;
            result = a == b ? "Равенство верно. Две переменные равны" : "Две переменные не равны";

            return result;
        }
        public static string CheckIfNotEqual(int a, int b){
            string result;
            result = a != b ? "Неравенство верно. Две переменные не равны" : "Две переменные равны";
            return result;
        }
        public static string CheckIfHigher(int a, int b)
        {
            string result;
            if (a > b)
            {
                result = "Неравенство верно. Первая переменная больше";
            }
            else if (a < b)
            {
                result = "Вторая переменная больше";
            }
            else 
            {
                result = "Переменные равны";
            }

            return result;
        }
        public static string CheckIfLower(int a, int b)
        {
            string result;
            if (a < b)
            {
                result = "Неравенство верно. Первая переменная меньше";
            }
            else if (a > b)
            {
                result = "Вторая переменная меньше";
            }
            else
            {
                result = "Переменные равны";
            }

            return result;
        }
 

        static void Main(string[] args)
        {

            Console.WriteLine(Class1.MAIN);

            Boolean exit = false;
            while (exit == false)
            {
                Console.WriteLine("Введите два числа и знак сравнения(все через пробел");
                String s = Console.ReadLine();
                String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Просто дебаг
                Console.WriteLine("Дебаг");
                for (int i = 0; i < words.Length; i++)
                {
                    Console.WriteLine(Convert.ToString(i) + " - " + words[i]);
                }
                Console.WriteLine("Конец Дебага");
                int a = Convert.ToInt32(words[0]);
                string c = words[1];
                int b = Convert.ToInt32(words[2]);

                if (c == "=") { Console.WriteLine(CheckIfEqual(a, b)); }
                else if (c == "!=") { Console.WriteLine(CheckIfNotEqual(a, b)); }
                else if (c == ">") { Console.WriteLine(CheckIfHigher(a, b)); }
                else if (c == "<") { Console.WriteLine(CheckIfLower(a, b)); }

                switch (c)
                {
                    case "=":
                        Console.WriteLine(CheckIfEqual(a, b));
                        break;
                    case "!=":
                        Console.WriteLine(CheckIfNotEqual(a, b));
                        break;
                    case ">":
                        Console.WriteLine(CheckIfHigher(a, b)); 
                        break;
                    case "<":
                        Console.WriteLine(CheckIfLower(a, b));
                        break;
                }

            }
        }
    }
}
