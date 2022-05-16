//ДЗ ЗАДАЧА 2. Найти произведение двух матриц

int[,] FirstMatrix = { {2, -2, 3},
                        {0, 2, 6},
                        {5, 1, 0},
                                };


int[,] SecondMatrix = { {0, 2, 5},
                        {4, -1, 7},
                        {1, -2, 0},
                                };

/*

int h = 0;
int result = 0;
while (h < FirstMatrix.GetLength(0))
{
    for (int z = 0; z < FirstMatrix.GetLength(0); z++)
    {
        for (int k = 0; k < FirstMatrix.GetLength(1); k++)
        {
            result += (FirstMatrix.Length / FirstMatrix.Length);
        }

    }
    break;
    result = result / 3;
}
//Console.Write(result);



int i = 0;


while (i < FirstMatrix.GetLength(0))
{
    for (int k = 0; k < FirstMatrix.GetLength(0) / 3; k++)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
            Console.Write($" {FirstMatrix[i, j] * SecondMatrix[i, j]}");
        }
        Console.WriteLine();
    }
    i++;
}

*/
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
Console.WriteLine();




/*
static int[,] mult(int[,] ar1, int[,] ar2)
{
    int[,] m = new int[ar1.GetLength(0), ar2.GetLength(1)];

    for (int i = 0; i < ar1.GetLength(0); ++i)
        for (int j = 0; j < ar2.GetLength(0); ++j)
            for (int k = 0; k < ar2.GetLength(1); ++k)
                m[i, k] = m[i, k] + ar1[i, j] * ar2[j, k];
    return m;
}

static void Test1()
{
    int[,] ar1 ={ {2, -2, 3},
                  {0, 2, 6},
                  {5, 1, 0},
                          };
    int[,] ar2 = { {0, 2, 5},
                    {4, -1, 7},
                    {1, -2, 0},
                            };
    int[,] m = mult(ar1, ar2);

    for (int i = 0; i < ar1.GetLength(0); ++i)
    {
        for (int j = 0; j < ar2.GetLength(1); ++j)
        {
            Console.Write(m[i, j] + " ");
        }
        Console.WriteLine();
    }
}


Test1();

.

