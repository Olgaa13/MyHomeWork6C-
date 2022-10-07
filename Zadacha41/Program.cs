// Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 5
// 0
// 7
// 8
// -2
// -2 -> 2

// 5
// 1
// -7
// 567
// 89
// 223-> 3

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите {m} чисел через ENTER: ");
int[] array = new int[m];
int counter = 0;
for (int i = 0; i < m; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        counter++;
    }
}
Console.WriteLine("Пользователь ввел " + counter + " чисел, значение которых больше нуля!");