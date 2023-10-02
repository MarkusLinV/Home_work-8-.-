// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] matrix,int min,int max) 
{
for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) -метод вывода кол-ва строк/стобцов массива; 0 обозначает строки
{
    for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(0) -метод вывода кол-ва строк/стобцов массива; 1 обозначает столбцы
    {
        matrix[i, j] = new Random().Next(min, max + 1); // new Random().Next(min, max + 1) - генератор псевдослучайных чисел , где min минимальное число в интервале рандомизации, а max граница максимального (само max не входит)
    }
}
}

void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) -метод вывода кол-ва строк/стобцов массива; 0 обозначает строки
{
    for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(0) -метод вывода кол-ва строк/стобцов массива; 1 обозначает столбцы
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}

int lineCount (int[, ] matrix)
{
    int MinCount = 0;
    int[] SummArr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int SummJ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            SummJ = SummJ + matrix[i, j];
        }
        SummArr[i] = SummJ;
    }
    int min = SummArr[0];
    for (int c = 0; c < SummArr.Length; c++)
    {
        if(min > SummArr[c])
        {
            min = SummArr[c];
            MinCount = c + 1;
        }
    }
    return MinCount;
}



int[, ] array = new int[3, 4];

FillArray(array, 1, 5);

PrintArray(array);
int resault = lineCount(array);
Console.WriteLine(resault);