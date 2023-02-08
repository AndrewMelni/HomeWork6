/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите числа через запятую:");
string n = Console.ReadLine();
string[] num = n.Split(',', StringSplitOptions.RemoveEmptyEntries);
int [] numbers = new int [num.Length];
for (int i = 0; i < num.Length; i++) 
{ 
    numbers[i] = int.Parse(num[i]); 
}
foreach  (int j in numbers) 
{
Console.Write($"{j} ");
}

Console.WriteLine();

int result = 0;
foreach (int i in numbers) 
{
    if (i>0)
    result++;
}
Console.WriteLine($"Чисел больше 0: {result}");

