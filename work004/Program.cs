// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

void FillSpiral(int[,] array, int n)
{
    int i = 0;
    int j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++)
        {
            array[i++, j] = value++;
        }
        for (k = 0; k < n - 1; k++)
        {
            array[i, j--] = value++;
        }
        for (k = 0; k < n - 1; k++)
        {
            array[i--, j] = value++;
        }
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}



int[,] table = new int[4, 4];
FillSpiral(table, 4);
PrintArray(table);