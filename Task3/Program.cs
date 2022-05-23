//ДЗ ЗАДАЧА 3. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

<<<<<<< HEAD
/*
void Method(int n)
=======
void ShowTrianglePascal(int n)
>>>>>>> 4cc90aee71d3f68a468d9c8b0780b722e7d6accc
{
    int i = 0;
    int b = 1;
    string d = " ";
    while (i < n)
    {
        if (i == 0) Console.WriteLine(d + d + d + d + d + $"{b}");
        if (i == 1) Console.WriteLine(d + d + d + d + $"{b}" + d + $"{b}");
        if (i == 2) Console.WriteLine(d + d + d + $"{b}" + d + "2" + d + $"{b}");
        if (i == 3) Console.WriteLine(d + d + $"{b}" + d + "3" + d + "3" + d + $"{b}");
        if (i == 4) Console.WriteLine(d + $"{b}" + d + "4" + d + "6" + d + "4" + d + $"{b}");
        if (i == 5) Console.WriteLine($"{b}" + d + "5" + d + d + "10" + d + "5" + d + $"{b}");
        if (i >= 6) Console.WriteLine("это уже много:)");
        i++;
    }
}
<<<<<<< HEAD
Method(7);
// Метод днище:)
*/


int row = 5; //строчки для треугольника
int[,] triangle = new int[row, row]; //Массив для треугольника
const int cellWidth = 3;//какое кол-во символов буду использовать для вывода данного треугольника
        
void FillTriagle() //Метод заполняющий треугольник
{
    for (int i = 0; i < row; i++)//пробегает по первому столбику и заполняет единицами
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }   
    for (int i = 2; i < row; i++)//заполняем треугольник паскаля, как и должен он быть заполнен
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];//формула паскаля
        }
    }
}

/*
void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0)
                Console.Write($"{triangle[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}
*/
void Magic()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidth}");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);

        Console.WriteLine();
    }
}
Console.Clear();
Console.WriteLine("clear");
FillTriagle();
//PrintTriangle();
Console.WriteLine(" ");
Magic();
=======
ShowTrianglePascal(7);
// Согласен метод так себе^(
>>>>>>> 4cc90aee71d3f68a468d9c8b0780b722e7d6accc
