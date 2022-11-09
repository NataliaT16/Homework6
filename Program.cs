// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("введите числа");

string str = Console.ReadLine();

var arrStr = str.Split(" ");

int[] arr = Array.ConvertAll(arrStr, int.Parse);

 int count = 0;
for (int i = 0; i < arr.Length; i++)
{
   
    if (arr[i] > 0)
    {
        count++;
    }

}

System.Console.WriteLine($"Элемнетов больше 0 {count}");





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("введите число b1");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число b2");
int b2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("введите число k1");
int k1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("введите число k2");
int k2 = Convert.ToInt32(Console.ReadLine());


double x = (b1-b2)/(k1-k2);
double y = k2 * x + b2;


System.Console.WriteLine($"точка пересечения {x} {y}");
