// Задача 52: Задать двумерный массив из целых чисел. Найти средне арифметическое элементов в каждом столбце.
/* Например: задан массив:
1 4 7 2
5 9 3 2
8 4 2 4
Среднее арифметическое каждого столбца 4,6; 5,6; 3,6; 3. */
Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] num = new int[n, m];
FillArrayRandomNum(num);


for (int j = 0; j < num.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < num.GetLength(0); i++)
    {
        avarage = (avarage + num[i, j]);
    }
    avarage = avarage / n;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(avarage + "; ");
    Console.ResetColor();
    
}
Console.WriteLine();
PrintArray(num);



void FillArrayRandomNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
            Console.Write(array[i, j] + " ");
        }
        Console.Write("");
        Console.WriteLine("");
    }
}   