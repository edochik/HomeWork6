//ДЗ ЗАДАЧА 2. Найти произведение двух матриц

int[,] MatrixA = { {2,-2, 3},
             {0, 2 ,3},
             {1, 3 ,1},
                     };


int[,] MatrixB = {{ 2,-4, 3},
            { 0, 5 ,3},
            { 1, 6 ,1},
                    };

int i = 0;
while (i < MatrixA.GetLength(0))
{
    for (int k = 0; k < MatrixB.GetLength(0);)
    {
        for (int j = 0; j < MatrixB.GetLength(1); j++)
        {
            Console.Write($" {MatrixA[i, j] * MatrixB[i, j]}");
        }
        Console.WriteLine();
        break;
    }
    i++;
}
