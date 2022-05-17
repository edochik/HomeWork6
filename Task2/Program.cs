//ДЗ ЗАДАЧА 2. Найти произведение двух матриц

int[,] A = { {2, -2}, //[0,0] [0,1]
                        {0, 2}, //[1,0] [1,1]
                            };


int[,] B = { {0, 2}, //[0,0] [0,1]
                        {4, -1},//[1,0] [1,1]
                            };

C[row, col] = 0;
for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
    {
        C[,]  = A[i, 0] * B[0, j];

    }

}



/*
int i = 0;
while (i < FirstMatrix.GetLength(0))
{
    for (int k = 0; k < FirstMatrix.GetLength(0);)
    {
        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
        {
            Console.Write($" {FirstMatrix[i, j] * SecondMatrix[i, j]}");
        }
        Console.WriteLine();
        break;
    }
    i++;
}
*/
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
Console.WriteLine();
*/



int[,] ar1 ={ {2, -2},
              {0, 2},
                    };
int[,] ar2 = { {0, 2},
               {4, -1},
                    };



int[,] FindMultipTwoMatrix(int[,] ar1, int[,] ar2)
{
    int[,] m = new int[ar1.GetLength(0), ar2.GetLength(1)];

    for (int i = 0; i < ar1.GetLength(0); ++i)
    {
        for (int j = 0; j < ar2.GetLength(0); ++j)
        {
            for (int k = 0; k < ar2.GetLength(1); ++k)
            {
                m[i, k] = m[i, k] + ar1[i, j] * ar2[j, k];
            }
        }
    }
    return m;
}


int[,] m = FindMultipTwoMatrix(ar1, ar2);
void PrintFindMultipTwoMatrix(int[,] m)
{
    for (int i = 0; i < ar1.GetLength(0); ++i)
    {
        for (int j = 0; j < ar2.GetLength(1); ++j)
        {
            Console.Write(m[i, j] + " ");
        }
        Console.WriteLine();
    }
}
PrintFindMultipTwoMatrix(FindMultipTwoMatrix(ar1, ar2));
