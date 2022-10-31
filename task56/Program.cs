/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

using static System.Console;
Clear();
Write("Введите размер матрицы с min и max значением через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);
int[] sumrows= RowsSum(matrix);
NumberOfRowMinSum(sumrows);





int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return resultMatrix;
}

void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]} ");
        }
        WriteLine();
    }
}

int[] GetArrayFromString(string parameters)
{
    string[] param = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parameterNum = new int[param.Length];
    for (int i = 0; i < parameterNum.Length; i++)
    {
        parameterNum[i] = int.Parse(param[i]);
    }
    return parameterNum;
}

int[] RowsSum(int [,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       sum[i]= 0;
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
        sum[i]=sum[i]+matrix[i,j];
       } 
    }
    return sum;
}

void NumberOfRowMinSum (int[] array)
{
    int min = array[0];
    int index = 1;
    for (int i = 1; i < array.Length; i++)
    {
     if (array[i]<min)   
     {
        min = array[i];
        index=i+1;
     }
    }
    WriteLine($"Строка с минимальной суммой: {index}");
}