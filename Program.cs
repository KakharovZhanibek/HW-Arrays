using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*•	Напечатать весь массив целых чисел*/
            int x;
            Console.WriteLine("Введите размерность массива");
            x = Int32.Parse(Console.ReadLine());
            int[] mas = new int[x];
            fill(mas, x);
            print(mas, x);

            task10();
        }
        static int[] fill(int[] mas, int x)
        {
            Random rand = new Random();
            for (int i = 0; i < x; i++)
            {
                mas[i] = rand.Next(-10, 10);
            }
            return mas;
        }
        
        static  void print<T>(T[] mas, int x)
        {
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }

        static void task2(int[] mas, int x)
        {
            /*•	Найти индекс максимального значения в массиве*/
            int max = -50;
            print(mas, x);
            int j = 0;
            for (int i = 0; i < x; i++)
            {
                if (mas[i] > max)
                {

                    max = mas[i];
                    j = i;
                }
            }
            Console.WriteLine("Индекс самого максимального числа: " + j + "\t" + "Число: " + max);
        }
        static void task3(int[] mas, int x)
        {
            /*•	Найти индекс максимального четного значения в массиве*/
            int max = -50;
            print(mas, x);
            int j = 0; bool d = false;
            for (int i = 0; i < x; i++)
            {
                if (mas[i] % 2 == 0 && mas[i] > max)
                {
                    d = true;
                    max = mas[i];
                    j = i;
                }
            }
            if (d == true)
            {
                Console.WriteLine("Индекс самого максимального четного числа: " + j + "\t" + "Число: " + max);
            }
            else
            {
                Console.WriteLine("В массиве нет четноо числа");
            }
        }
        static void task4(int[] mas, int x)
        {
            /*•	Найти индекс максимального четного значения в массиве*/
            int index;
            Console.WriteLine("Введите индекс элемента, которую хотите удалить");
            index = Int32.Parse(Console.ReadLine());
            int[] temp = new int[x];
            for (int i = 0; i < x; i++)
            {
                temp[i] = mas[i];
            }
            for (int i = index; i < x - 1; i++)
            {
                temp[i] = temp[i + 1];
            }
            x--;
            mas = temp;
            print(mas, x);
        }
        static void task5(int[] mas, int x)
        {
            /*•	Найти индекс максимального четного значения в массиве*/
            int el; int[] temp = new int[x];
            Console.WriteLine("Введите значение, которую хотите удалить");
            el = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                temp[i] = mas[i];
            }
            for (int i = 0; i < x; i++)
            {
                if (temp[i] == el)
                {
                    for (int j = i; j < x - 1; j++)
                    {
                        temp[j] = temp[j + 1];
                    }
                    x--;
                    i = 0;
                }
            }
            mas = temp;
            print(mas, x);
        }
        static void task6(int[] mas, int x)
        {
            /*•	Найти индекс максимального четного значения в массиве*/
            int index, el; int[] temp = new int[x];
            Console.WriteLine("\nВведите индекс в которую хотите вставить элемент");
            index = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение");
            el = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                temp[i] = mas[i];
            }
            Array.Resize(ref temp, x + 1);
            if (index == x)
            {
                temp[index - 1] = el;
            }
            else if (index > x)
            {
                Console.WriteLine("Введенный вами индекс переходит границы массива");
            }
            else
            {
                for (int i = index; i < x - 1; i++)
                {
                    int h = temp[i + 1];
                    h = temp[i];
                }
                temp[index] = el;
            }
            mas = temp;
            print(mas, x);
        }
        static void task7(int[] mas, int x)
        {
            /*•	Удалить те элементы массива, которые встречаются в нем ровно два раза*/
            int[] temp = new int[x];
            for (int c = 0; c < x; c++)
            {
                temp[c] = mas[c];
            }
            int i, j;
            for (i = 0; i < x; i++)
            {
                for (j = 0; j < x; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (temp[i] == temp[j])
                    {
                        for (int g = i; g < x - 1; g++)
                        {
                            temp[g] = temp[g + 1];
                        }
                        j--;
                        for (int h = j; h < x-1; h++)
                        {
                            temp[h] = temp[h + 1];
                        }
                        x--;
                        x--;
                        i = -1;
                        break;
                    }
                }
            }
            mas = temp;
            Console.WriteLine();
            print(mas, x);
        }
        static void task8()
        {
            /*•	Удалить из строки слова, в которых есть буква 'a'*/
            Console.WriteLine("Введите размер массива строк");
            int x;
            x = Int32.Parse(Console.ReadLine());

            string[] Arr = new string[x];
            string[] TempArr = new string[x];
            Console.WriteLine("Заполните массив строк");
            for (int i = 0; i < x; i++)
            {
                Arr[i] = Console.ReadLine();
                TempArr[i] = Arr[i];
            }
            Console.WriteLine("Ваш массив");
            print(Arr, x);
            for (int i = 0; i < x; i++)
            {
                char[] temp = new char[TempArr[i].Length];
                temp = TempArr[i].ToCharArray();
                for (int j = 0; j < TempArr[i].Length; j++)
                {
                    if (temp[j]=='a')
                    {
                        for (int g = i; g < x - 1; g++)
                        {
                            TempArr[g] = TempArr[g + 1];
                        }
                        x--;
                        i = i - 1;
                        break;
                    }
                }
            }
            Arr = TempArr;
            Console.WriteLine("Результат");
            print(Arr, x);
        }
        static void task9()
        {
            /*•	Удалить из строки слова, в которых есть хоть одна буква последнего слова*/

            Console.WriteLine("Введите размер массива строк");
            int x;
            while (true)
            {
                x = Int32.Parse(Console.ReadLine());
                if (x == 1 || x <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Размер массива строк который был задан не соответствует задаче");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
            string[] Arr = new string[x];
            string[] TempArr = new string[x];
            Console.WriteLine("Заполните массив строк");
            for (int i = 0; i < x; i++)
            {
                Arr[i] = Console.ReadLine();
                TempArr[i] = Arr[i];
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ваш массив");
            print(Arr, x);
            string lastWord = Arr[x - 1];
            bool y = false;
            char[] temp2 = new char[Arr[x - 1].Length];
            temp2 = lastWord.ToCharArray();

            for (int i = 0; i < x-1; i++) 
            {
                char[] temp = new char[TempArr[i].Length];
                temp = TempArr[i].ToCharArray();

                for (int j = 0; j < temp.Length; j++)
                {
                    for (int g = 0; g < temp2.Length; g++)
                    {
                        if (temp[j] == temp2[g])
                        {
                            for (int h = i; h < x - 1; h++)
                            {
                                TempArr[h] = TempArr[h + 1];
                            }
                            x--;
                            i = i - 1;
                            y = true;
                            break;
                        }
                    }
                    if(y)
                    {
                        break;
                    }
                }
            }
            Arr = TempArr;
            Console.WriteLine("------------------------");
            Console.WriteLine("Результат");
            print(Arr, x);
            Console.WriteLine("------------------------");
        }
        static void task10()
        {
            Console.WriteLine("Введите размер массива строк");
            int x;
            while (true)
            {
                x = Int32.Parse(Console.ReadLine());
                if (x <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Размер массива должен бытьбольше чем 0");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
            string[] Arr = new string[x];

            Console.WriteLine("Заполните массив строк");
            for (int i = 0; i < x; i++)
            {
                Arr[i] = Console.ReadLine();
            }

            for (int i = 0; i < x; i++)
            {
                char[] temp = new char[Arr[i].Length];
                temp = Arr[i].ToCharArray();
                if (temp[temp.Length - temp.Length] == temp[temp.Length - 1])
                {
                    Console.Write(" [" + Arr[i] + "] ");
                }
                else
                {
                    Console.Write(" " + Arr[i] + " ");
                }
            }
        }
    }
}
