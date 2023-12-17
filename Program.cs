using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lyalka07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1.
            //Даны два целых числа. Выведите в консоль большее из этих чисел.

            //Console.Write("enter the first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("enter the second number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //int a;
            //a = 0;
            //if(num1 > num2 )
            //{
            //a = num1;
            //}
            //else if(num2 > num1)
            //{
            //    a = num2;
            //}
            //Console.Write($"{a}");
            //Console.ReadKey();


            //task2
            //Дано целое число, содержащее номер месяца от 1 до 12.
            //Определите, в какую пору года попадает этот месяц.

            //Console.Write("enter the month number: ");
            //int months = int.Parse(Console.ReadLine());
            //switch(months)
            //{
            //    case 12: 
            //    case 1:
            //    case 2:
            //     Console.WriteLine("winter");
            //    break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("spring");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("summer");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("autumn");
            //        break;
            //    default: Console.WriteLine("error");
            //        break;
            //}

            // if (months == 12 | months == 1 | months == 2 ) 
            // {
            //     Console.WriteLine("winter");
            // }
            //else if (months <=5)
            // {
            //     Console.WriteLine("spring");
            // }
            //else if (months <= 8)
            // {
            //     Console.WriteLine("summer");
            // }
            //else if (months <= 11)
            // {
            //     Console.WriteLine("autumn");
            // }


            //task3
            //Дано двухзначное число. Узнайте вторая цифра больше первой?

            //Console.Write("enter a number: ");
            //double a = double.Parse(Console.ReadLine());
            //double mur, mur2;
            //mur = a % 10;
            //mur2 = a / 10;
            //if (mur > mur2)
            //{
            //    Console.WriteLine(mur);
            //}
            //else if (mur < mur2)
            //{
            //    Console.WriteLine(mur2);
            //}


            //task 3,4;
            //Даны три целых числа. Выведите в консоль большее из этих чисел

            //Console.Write("enter the first number: ");
            //int x = int.Parse(Console.ReadLine());
            //int x1, x2, x3;
            //x1 = x % 10;
            //x2 = x / 10 % 10;
            //x3 = x / 100;
            //int a;
            //a = 0;
            //if (x1 > x2 & x1 > x3)
            //{
            //    a = x1;
            //}
            //else if (x2 > x1 & x2 > x3)
            //{
            //    a = x2;
            //}
            //else if (x3 > x1 & x3 > x2) 
            //{
            //    a = x3;
            //}
            //Console.Write(a);


            // task5
            //Игральным картам условно присвоены следующие порядковые номера в зависимости от их достоинства: валету — 11, даме — 12, королю — 13, "тузу" — 14.
            //Порядковые номера остальных карт соответствуют их названиям ("шестерка", "девятка" и т.п.).
            //По заданному номеру карты k    (6 <= k <= 14) определить достоинство соответствующей карты

            //Console.Write("Введите номер от 6 до 14: ");
            //int a = int.Parse(Console.ReadLine());
            //switch(a)
            //{
            //    case 6:
            //        Console.WriteLine("шестёрка");
            //        break;
            //    case 7:
            //        Console.WriteLine("семёрка");
            //        break;
            //    case 8:
            //        Console.WriteLine("восьмёрка");
            //        break;
            //    case 9:
            //        Console.WriteLine("девятка");
            //        break;
            //    case 10:
            //        Console.WriteLine("десятка");
            //        break;
            //    case 11:
            //        Console.WriteLine("валет");
            //        break;
            //    case 12:
            //        Console.WriteLine("дама");
            //        break;
            //    case 13:
            //        Console.WriteLine("король");
            //        break;
            //    case 14:
            //        Console.WriteLine("туз");
            //        break;
            //}

            //task 6
            //Дано целое число n (1 <= n <= 99), определяющее возраст человека (в годах). Для этого числа напечатать фразу "мне n лет",
            //учитывая при этом, что при некоторых значениях n слово "лет" надо заменить на слово "год" или "года". '

            //Console.Write("введите ваш возраст: ");
            //int n = int.Parse(Console.ReadLine());
            
            //if (n % 10 == 1)
            //{
            //    Console.Write($"мне {n} год");
            //}
            //else if (n % 10 >= 2 & n % 10 <= 4)
            //{
            //    Console.Write($"мне {n} года");
            //}
            //else 
            //{
            //    Console.Write($"мне {n} лет");
            //}

            //task 7
            //Дано целое число k (1 <= k <= 365).
            //Определить,  каким днем недели (понедельником, вторником, субботой или воскресеньем)
            //является k-й день не високосного года, в котором 1 января — понедельник.

            Console.Write("введите любой день года: ");
            int k = int.Parse(Console.ReadLine());
            if (k % 7 == 1)
                Console.Write("понедельник");
            if (k % 7 == 2)
                Console.Write("вторник");
            if (k % 7 == 3)
                Console.Write("среда");
            if (k % 7 == 4)
                Console.Write("четверг");
            if (k % 7 == 5)
                Console.Write("пятница");
            if (k % 7 == 6)
                Console.Write("суббота");
            if (k % 7 == 0)
                Console.Write("воскресенье");

            










            Console.ReadKey();
            //карты, дурак!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }
    }
}
