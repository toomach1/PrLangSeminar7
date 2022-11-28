//задайте двумерный массив. Найдите элементы, у которых оба индекса четные, замените эти элементы на их квадраты

int rows = SetNumber("m");

int column = SetNumber("n");

int[,] matrix1 = GetRandomMatrix(rows, column);

PrintMatrix(matrix1);

System.Console.WriteLine();

int[,] NewMatrix = ReternNewMatrix(matrix1);

PrintMatrix(NewMatrix);

int SetNumber(string str) //метод "введите Х"
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}

int[,] GetRandomMatrix(int rowsMetod, int columnMetod, int maxValue = 10, int minValue = 0)
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

int[,] ReternNewMatrix(int[,] matrixMetodRet)
{
    int[,] matrixRet = new int[matrixMetodRet.GetLength(0), matrixMetodRet.GetLength(1)];
    for (int i = 0; i < matrixMetodRet.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMetodRet.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrixRet[i, j] = matrixMetodRet[i, j] * matrixMetodRet[i, j];
            }
            else
            {
                matrixRet[i, j] = matrixMetodRet[i, j];
            }
        }
    }
    return matrixRet;
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