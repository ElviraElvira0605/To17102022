// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число больше, а какое - меньше

// a = 5; b = 7 -> max = 7;
// a = 2; b = 10 -> max = 10;
// a =-3; b = -9 -> max = -3;

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");
Console.WriteLine(a < b ? "Первое число меньше второго" : "Второе число меньше первого");

