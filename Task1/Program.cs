// Составить частотный словарь элементов двумерного массива
/*
void CreateMatr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 9);
        }

    }
}

void PrintMatr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

int[,] newMatrix = new int[5, 5];


CreateMatr(newMatrix);
PrintMatr(newMatrix);
int result = 0;
for (int i = 0; i < newMatrix.GetLength(0); i++)
{
    for (int j = 0; j < newMatrix.GetLength(1); j++)
    {
        if (newMatrix[i, j] == 1) Console.WriteLine($"{result += 1} + кол=во");
    }
}

*/

int[] NewArray(int elements)
{
    int[] array = new int[elements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 9);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}

int[] array = NewArray(6);

PrintArray();