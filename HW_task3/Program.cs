//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int rows = SetNumber("m");

int column = SetNumber("n");

int[,] matrix1 = GetRandomMatrix(rows, column);

double[] arrayResult = ResultArray(matrix1);

System.Console.WriteLine();

PrintMatrix(matrix1);

System.Console.WriteLine();

PrintArray(arrayResult);


int SetNumber(string str) //метод "введите Х"
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}

int[,] GetRandomMatrix(int rowsMetod, int columnMetod, int maxValue = 9, int minValue = 0)
{
    int[,] matrixMetod = new int[rows, column];
    var random = new Random();
    for (int i = 0; i < matrixMetod.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMetod.GetLength(1); j++)
        {
            matrixMetod[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return matrixMetod;
}

double[] ResultArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];
        }
        result[i] = Math.Round(sum/array.GetLength(0), 2);
        
    }
    return result;
}

void PrintMatrix(int[,] matrixMetodPrint)
{
    for (int i = 0; i < matrixMetodPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMetodPrint.GetLength(1); j++)
        {
            System.Console.Write($"{matrixMetodPrint[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}
