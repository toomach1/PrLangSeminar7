// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.

int rows = SetNumber("m");

int column = SetNumber("n");

int[,] matrixMN = GetMatrixMN(rows,column);

PrintMatrix(matrixMN);

int SetNumber(string str) //метод "введите Х"
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}

int[,] GetMatrixMN(int rowsMetod, int columnMetod)
{
    int[,] matrixMetod = new int[rows,column];
   
    for (int i = 0; i < matrixMetod.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMetod.GetLength(1); j++)
        {
            matrixMetod[i,j] =i+j;
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
            System.Console.Write($"{matrixMN[i,j]} ");
        }
        System.Console.WriteLine();
    }
}