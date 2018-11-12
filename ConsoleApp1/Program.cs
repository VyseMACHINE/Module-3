using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1.Написать программу, которая считывает символы с клавиатуры, 
            //пока не будет введена точка.Программа должна сосчитать количество 
            //введенных пользователем пробелов.

            Console.WriteLine("Введите  ");
            char input;
            int spaceCount = 0;
            do
            {
                input = Console.ReadKey().KeyChar;             
                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');

            Console.WriteLine("Quantity of spaces: " + spaceCount);
            */

            /*
            //2.Ввести с клавиатуры номер трамвайного билета(6 - значное число) 
            //и про-верить является ли данный билет счастливым
            //(если на билете напечатано шестизначное число, и сумма первых трёх цифр 
            //равна сумме последних трёх, то этот билет считается счастливым).

            Console.Write("Введите номер трамвайного билета:  ");
            string str = Console.ReadLine();
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int[] ticketNumber = ch.Select(s => Convert.ToInt32(s)).ToArray();
            if (ch.Length == 6)
            {
                int leftNumber = 0;
                int rightNumber = 0;

                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                    {
                        leftNumber += ticketNumber[i];
                    }

                    else rightNumber += ticketNumber[i];
                }

                if (leftNumber == rightNumber)
                {
                    Console.WriteLine("У вас счастливый билет: {0} = {1}", leftNumber, rightNumber);
                }

                else Console.WriteLine("У вас не счастливый билет: {0} != {1}", leftNumber, rightNumber);
            }

            else Console.WriteLine("Число введено не правильно!");

            Console.Read();
            */

            /*
            //3.Числовые значения символов нижнего регистра в коде ASCII отличаются от
            // значений символов верхнего регистра на величину 32.Используя эту информацию,
            // написать программу, которая считывает с клавиатуры и конвертирует 
            //все символы нижнего регистра в символы верхнего регистра и наоборот.
            int e, count = 0;
            char i;
            do
            {
                Console.WriteLine("Введите символ");
                do
                {
                    e = Console.Read();
                    i = (char)e;
                } while (i == '\n' | i == '\r');



                if (e >= 65 && e <= 90)
                {
                    e += 32;
                    i = (char)e;
                    Console.WriteLine(i);
                    count++;

                }
                else if (e >= 97 && e <= 122)
                {
                    e -= 32;
                    i = (char)e;
                    Console.WriteLine(i);
                    count++;
                }
                else if (e == 46)
                {
                    break;
                }
                else
                {
                    i = (char)e;
                    Console.WriteLine(i);
                }


            } while (e != 46);
            Console.WriteLine("Всего введено " + count + " символов");
            */

            
            //4.Даны целые положительные числа A и B(A<B). Вывести все целые числа от A до B 
            // включительно; каждое число должно выводиться на новой строке; при этом 
            //каждое число должно выводиться количество раз, равное его значению.
            //Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
            //3 3 3
            //4 4 4 4
            //5 5 5 5 5
            //6 6 6 6 6 6
            //7 7 7 7 7 7 7

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (a <= b)
            {
                for (int i = 1; i <= a; i++)
                    Console.Write("{0}", a);
                a++;
                Console.WriteLine();
            }
            Console.ReadKey();
            

            /*
            // 5.Дано целое число N(> 0), найти число, полученное при прочтении числа N
            //справа налево. Например, если было введено число 345,
            //то программа должна вывести число 543.
            int n = int.Parse(Console.ReadLine());
            int res = 0;
            while (n > 0)
            {
                res *= 10;
                res += n % 10;
                n /= 10;
            }
            Console.WriteLine(res);
            Console.ReadKey();
            */

        }
    }
}
