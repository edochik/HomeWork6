// Составить частотный словарь элементов двумерного массива

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

void DictionaryForTwoArray(int[,] matr)
{
    int a = 0, b = 0, r = 0;
    while (r < 10)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] == b) a += 1;
            }

        }
        if (a == 2 ^ a == 3 ^ a == 4) Console.WriteLine($" {b} встречается {a} раза");
        else Console.WriteLine($" {b} встречается {a} раз");
        a = 0;
        r++;
        b++;
    }
}
// число 10 - надо сделать его автоматическим, определяющимся из максимального значения в индексе.
// так же не надо показывать того, чего нет, т.е если число ни разу не встретилось, то пропуск.

int[,] newMatrix = new int[5, 5];


CreateMatr(newMatrix);
PrintMatr(newMatrix);
DictionaryForTwoArray(newMatrix);




//================================Для одномерного массива=====================================================
/* int[] arraynew = { 1, 0, 1, 0, 1, 2, 1, 3, 3, 0, 3, 1, 3, 5, 6, 7, 8, 9, 6, 5, 4, 6, 8, 9, 3, 4, 6, 7, 3 };
void FindElement(int[] array)
{
    int i = 0;
    int a = 0;
    int c = 0;
    int j = 0;
    while (j < array.Length)
    {
        while (i < array.Length)
        {
            if (array[i] == a) c += 1;
            i++;
        }
        if (c > 1) Console.WriteLine($"{a} встречается {c} разa");
        else Console.WriteLine($"{a} встречается {c} раз");
        c = 0;
        i = 0;
        a++;
        if (j < 9) j += 1;
        else j = array.Length;
    }
}
//FindElement(arraynew);*/