//ДЗ ЗАДАЧА 3. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

void ShowTrianglePascal(int n)
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
ShowTrianglePascal(7);
// Согласен метод так себе^(
