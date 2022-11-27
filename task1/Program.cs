﻿// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int rows = SetNumber("m");

int column = SetNumber("n");

int[,] matrix = GetRandomMatrix(rows,column, 10, 1);

PrintMatrix(matrix);

int SetNumber(string str) //метод "введите Х"
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}

int[,] GetRandomMatrix(int rowsMetod, int columnMetod, int maxValue =100, int minValue = -100 )
{
    int[,] matrixMetod = new int[rows,column];
    var random = new Random();
    for (int i = 0; i < matrixMetod.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMetod.GetLength(1); j++)
        {
            matrixMetod[i,j] =random.Next(minValue,maxValue+  1);
        }
    }
    return matrixMetod;
}

void PrintMatrix(int[,] matrixMetod)
{
    for (int i = 0; i < matrixMetod.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMetod.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}