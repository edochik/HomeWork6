// Составить частотный словарь элементов двумерного массива

void CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 9);
        }

    }
}

void PrintMatrix(int[,] matrix)
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

void DictionaryForMatrix(int[,] matrix)
{
    int a = 0, b = 0, r = 0;
    while (r < 10)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == b) a += 1;
            }

        }
        if (a == 2 ^ a == 3 ^ a == 4) Console.WriteLine($" {b} встречается {a} раза");
        else Console.WriteLine($" {b} встречается {a} раз");
        a = 0;
        r++;
        b++;
    }
}

int[,] newMatrix = new int[5, 5];


CreateMatrix(newMatrix);
PrintMatrix(newMatrix);
DictionaryForMatrix(newMatrix);

// число 10 - надо сделать его автоматическим, перебираем все индексы и сравниваем друг с другом, определяем максимальное.
// так же не надо показывать того, чего нет, т.е если число ни разу не встретилось, то пропуск, а не 0 раз.