// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

System.Console.WriteLine("Укажите размер массива");
int rows = SetNumber("m");

int column = SetNumber("n");

System.Console.WriteLine("Укажите адрес элемента");

int numI = SetNumber("i");

int numJ = SetNumber("j");

System.Console.WriteLine();

int[,] matrix1 = GetRandomMatrix(rows, column);

PrintMatrix(matrix1);

System.Console.WriteLine();

int value = 0;

if (numI < rows && numJ < column)
{
    value = ElementValue(matrix1, numI, numJ);
    System.Console.WriteLine($"значение элемента [{numI},{numJ}] = {value}");
}
else
{
    System.Console.WriteLine($"Элемента с адресом [{numI},{numJ}] не существует");

}

int SetNumber(string str) //метод "введите Х"
{

    System.Console.WriteLine($"Введите {str}");
    int num = int.Parse(Console.ReadLine());

    return num;
}

int[,] GetRandomMatrix(int rowsMetod, int columnMetod, int maxValue = 9, int minValue = 0)
{
    int[,] matrixMetod = new int[rowsMetod, columnMetod];
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

int ElementValue(int[,] matrixMetodRet, int MetodNumI, int MetodNumJ)
{
    int element = 0;

    for (int i = 0; i < matrixMetodRet.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMetodRet.GetLength(1); j++)
        {
            if (i == MetodNumI && j == MetodNumJ)
            {
                element = matrixMetodRet[i, j];
            }

        }
    }

    return element;

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

