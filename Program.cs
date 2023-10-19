// Задача №2

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if ( a < b)
//     Console.WriteLine(b);
// else 
//      Console.WriteLine(a);

// Задача №4

//  Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max =a;
// if (max < b) max = b;
// if (max < c) max = c;
// Console.Write("Ответ: ");
// Console.WriteLine(max);

// Задача №6

//  Console.Write("Введите число: ");
//  int a = Convert.ToInt32(Console.ReadLine());

//  if (a % 2 == 0)
//     Console.WriteLine($"{a} является чётным ");
//  else
//     Console.WriteLine($"{a} не является чётным ");

//  Задача №8

//  Console.Write("Введите число: ");
//  int n = int.Parse(Console.ReadLine());
//  int i = 2;

// while (n >= i)
// {
//      Console.Write(i + " ");
//      i = i + 2;
// }

// Задача №10

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n3 = n % 100;
// int i = n3 / 10;
// Console.WriteLine(i);

// Задача № 13

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// while (n > 999)
// {
// n /= 10;
// }
// if (n < 100)
// {
//    n = 10;
//    Console.Write("Число не трёхзначное");
// }   
// else
// {
//    Console.Write(n % 10);
// }

// Задача №15
// Console.Write("Введите число: ");
// int day = Convert.ToInt32(Console.ReadLine());

//  if (day == 1)
//    Console.WriteLine("Будни");
//  else if (day == 2)
//      Console.WriteLine("Будни");
//  else if (day == 3)
//      Console.WriteLine("Будни");
//  else if (day == 4)
//      Console.WriteLine("Будни");
//  else if (day == 5)
//      Console.WriteLine("Будни");
//  else if (day == 6)
//      Console.WriteLine("Выходной");
//  else if (day == 7)
//      Console.WriteLine("Выходной");

// Задача №25
// Console.Write("Введите число: ");
// int n1 =Convert.ToInt32(Console.ReadLine();)
// Console.Write("Введите число: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// void f(int n, ref int res)
// {
    
//     for (int i = 1; i <= n; i ++)
//         res *= i;
    
// }
// Console.WriteLine()

// Задача №27

// int f(int n)
// {
//     int count = 0;
//     while (n > 0)
//     {
//         count += n % 10;
//         n = n / 10;
//     }
//     return count;
// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));

// Задача №29
// int m(int n)
// {
//     for (int f = 0; n < n - 1;n ++);
// }
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));

// Задача №41

// Console.Write("Введите массив: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] Array = new int[n];

// void mas(int n)
// {
// for (int i = 0; i < n; i++)
// {

// Console.WriteLine($"Введите {i+1} элемент массива ");
// Array[i] = Convert.ToInt32(Console.ReadLine());
// }

// }
// int kol(int[] Array)
// {
// int i=0;
// int sum = 0;
// while (i < Array.Length)
// {
// if(Array[i]>0)
// sum = sum + 1;
// i = i + 1;
// }
// return sum;
// }
// mas(n);
// Console.Write($"{kol(Array)}");

// задача №43

// Console.WriteLine("Введите переменную b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите переменную k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = -(b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;

// Console.Write($"Точка пересечения двух прямых: [{x},{y}]");

