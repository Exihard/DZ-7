// Задача 50: Написать программу, которая на вход принимает позиции элемнта в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
/* Пример: задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет! */

Console.WriteLine("Введите количество строк");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());

int [,] num = new int [line,column];
FillArrayRandomNumbers(num);

if (n > num.GetLength(0) || m > num.GetLength(1))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Такого элемента нет!");
    Console.ResetColor();
}
else
{
    Console.Write($"Значение {n}-го элемента строки и {m}-го столбца равно: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{num[n-1,m-1]}");
    Console.ResetColor();
}

PrintArray(num);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("");
        Console.WriteLine(""); 
    }
}
