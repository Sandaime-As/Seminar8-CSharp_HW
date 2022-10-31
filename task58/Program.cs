/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

using static System.Console;
Clear();
Write("Введите размер матрицы с min и max значением через пробел: ");
int[] parameters1 = GetArrayFromString(ReadLine()!);
Write("Введите размер матрицы с min и max значением через пробел: ");
int[] parameters2 = GetArrayFromString(ReadLine()!);
if (parameters1[1]!= parameters2[0]) 
{
    WriteLine("Умножение этих матриц невозможен");
    return;
}

int[,] matrix1 = GetMatrixArray(parameters1[0], parameters1[1], parameters1[2], parameters1[3]);
int[,] matrix2 = GetMatrixArray(parameters2[0], parameters2[1], parameters2[2], parameters2[3]);
PrintMatrix(matrix1);
PrintMatrix(matrix2);
int[,] resultmatrix = MultOfMatrix(matrix1,matrix2);
PrintMatrix(resultmatrix);




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
    string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parameterNum = new int[parames.Length];
    for (int i = 0; i < parameterNum.Length; i++)
    {
        parameterNum[i] = int.Parse(parames[i]);
    }
    return parameterNum;
}


int[,] MultOfMatrix(int[,] matrix1, int[,] matrix2)
{
    int [,] result = new int[matrix1.GetLength(0),matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
              result[i,j]+=matrix1[i,k]*matrix2[k,j];
            }
        }   
    }
return result;
}