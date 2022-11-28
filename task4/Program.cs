//задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали

int rows = SetNumber("m");

int column = SetNumber("n");

int[,] matrix1 = GetRandomMatrix(rows, column);

System.Console.WriteLine();

PrintMatrix(matrix1);

System.Console.WriteLine();

int summ = SummIJ(matrix1);

System.Console.WriteLine($"сумма элементов главной диагонали = {summ}");


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

int SummIJ(int[,] matrixMetodRet)
{
    int SummMetod = 0;
    for (int i = 0; i < matrixMetodRet.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMetodRet.GetLength(1); j++)
        {
            if (i == j)
            {
                SummMetod = SummMetod + matrixMetodRet[i,j];
            }
           
        }
    }
    return SummMetod;
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
