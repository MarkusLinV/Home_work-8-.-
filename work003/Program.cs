﻿// Задача 60. ...Сформируйте трёхмерный массив . Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArray(int[,,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) -метод вывода кол-ва строк/стобцов массива; 0 обозначает строки
{
    for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(0) -метод вывода кол-ва строк/стобцов массива; 1 обозначает столбцы
    {
        for (int t = 0; t < matrix.GetLength(2); t++)
        {
            Console.WriteLine($"{matrix[i, j, t]}({i},{j},{t})");
        }
    }
}
}

void FillArray(int[,,] matrix,int min,int max) 
{
for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) -метод вывода кол-ва строк/стобцов массива; 0 обозначает строки
{
    for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(0) -метод вывода кол-ва строк/стобцов массива; 1 обозначает столбцы
    {
        for (int t = 0; t < matrix.GetLength(2); t++)
        {
            matrix[i, j, t] = new Random().Next(min, max + 1); // new Random().Next(min, max + 1) - генератор псевдослучайных чисел , где min минимальное число в интервале рандомизации, а max граница максимального (само max не входит)
        }
    }
}
}










int[, , ] array = new int[2 , 2 , 2];

FillArray(array, 1 , 9);



PrintArray(array);