// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int rows = SetNumber("m");

int column = SetNumber("n");

double[,] matrix = GetRandomMatrix(rows,column);

PrintMatrix(matrix);

int SetNumber(string str) //метод "введите Х"
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}

double[,] GetRandomMatrix(int rowsMetod, int columnMetod, int maxValue =10, int minValue = -10 )
{
    double[,] matrixMetod = new double[rows,column];
    var random = new Random();
    for (int i = 0; i < matrixMetod.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMetod.GetLength(1); j++)
        {
            matrixMetod[i,j] =random.Next(minValue,maxValue+  1) + random.NextDouble();
        }
    }
    return matrixMetod;
}

void PrintMatrix(double[,] matrixMetod)
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