// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



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

void SortingArray(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = matrix[i, j];
            for (int s = 0; s < matrix.GetLength(1); s++)
            {
                if(max < matrix[i, s])
                {
                    int temp;
                    temp = matrix[i, s];
                    matrix[i, s] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) / 2; j++)
        {
            int temp;
            temp = matrix[i , j];
            matrix[i , j] = matrix[i , matrix.GetLength(1) - 1 - j];
            matrix[i , matrix.GetLength(1) - 1 - j] = temp;
        }
    }
}


int[, ] array = new int[4, 4];

FillArray(array, 1, 10);

PrintArray(array);

SortingArray(array);
Console.WriteLine();
PrintArray(array);








