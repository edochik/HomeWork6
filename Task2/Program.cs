//ДЗ ЗАДАЧА 2. Найти произведение двух матриц
int[,] FirstMatrix = { {2, -2, 3},
                        {0, 2, 6},
                        {5, 1, 0},
                                };


int[,] SecondMatrix = { {0, 2, 5},
                        {4, -1, 7},
                        {1, -2, 0},
                                };

int i = 0;
while (i < FirstMatrix.GetLength(0))
{
    for (int k = 0; k < FirstMatrix.GetLength(0); k++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
        Console.Write($" {FirstMatrix[i, j] + FirstMatrix[i, j]}");
        }
        Console.WriteLine();
    }
    i++;
}


/*
Console.Write($"{FirstMatrix[0, 0] * SecondMatrix[0, 0] + FirstMatrix[0, 1] * SecondMatrix[1, 0] + FirstMatrix[0, 2] * SecondMatrix[2, 0]} ");
Console.Write($"{FirstMatrix[0, 0] * SecondMatrix[0, 1] + FirstMatrix[0, 1] * SecondMatrix[1, 1] + FirstMatrix[0, 2] * SecondMatrix[2, 1]} ");
Console.Write($"{FirstMatrix[0, 0] * SecondMatrix[0, 2] + FirstMatrix[0, 1] * SecondMatrix[1, 2] + FirstMatrix[0, 2] * SecondMatrix[2, 2]} ");
Console.WriteLine();
Console.Write($"{FirstMatrix[1, 0] * SecondMatrix[0, 0] + FirstMatrix[1, 1] * SecondMatrix[1, 0] + FirstMatrix[1, 2] * SecondMatrix[2, 0]} ");
Console.Write($"{FirstMatrix[1, 0] * SecondMatrix[0, 1] + FirstMatrix[1, 1] * SecondMatrix[1, 1] + FirstMatrix[1, 2] * SecondMatrix[2, 1]} ");
Console.Write($"{FirstMatrix[1, 0] * SecondMatrix[0, 2] + FirstMatrix[1, 1] * SecondMatrix[1, 2] + FirstMatrix[1, 2] * SecondMatrix[2, 2]} ");
Console.WriteLine();
Console.Write($"{FirstMatrix[2, 0] * SecondMatrix[0, 0] + FirstMatrix[2, 1] * SecondMatrix[1, 0] + FirstMatrix[2, 2] * SecondMatrix[2, 0]} ");
Console.Write($"{FirstMatrix[2, 0] * SecondMatrix[0, 1] + FirstMatrix[2, 1] * SecondMatrix[1, 1] + FirstMatrix[2, 2] * SecondMatrix[2, 1]} ");
Console.Write($"{FirstMatrix[2, 0] * SecondMatrix[0, 2] + FirstMatrix[2, 1] * SecondMatrix[1, 2] + FirstMatrix[2, 2] * SecondMatrix[2, 2]} ");
*/