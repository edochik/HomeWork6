//ДЗ ЗАДАЧА 3. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

/*
int PascalTriangle(int n, int k)
{
    if (k == 0 || n == k) return 1;
    else return PascalTriangle(n - k, k - 1) + PascalTriangle(n - 1, k);

}
for (int i = 1; i < 50; i++)
{
    Console.Write($"{PascalTriangle(i, i)}");
    Console.WriteLine();
}
*/
int a = 1;
int b = 1;
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"{a - b}  {b - 1} {a - 1}");
}

/*
     1
    1 1
   1 2 1
  1 3 3 1
 1 4 6 4 1 
*/
/*
int b = 5;

Console.WriteLine(PascalTriangle(b));

int i = 0;
int b = 1;
int a = 1;
int c = 0;
while (i < 5)
{
    c = a + b;
    Console.WriteLine();
    i++;
}
     a
    a  b
   a a+b b
 a a+b a+b b


     1
    1 1
   1 2 1
  1 3 3 1
 1 4 6 4 1 
*/
/*
int c = 0;
int b = 0;
int a = 1;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        c = + c +(a+b);
        Console.WriteLine(c);
    }
    Console.WriteLine();
}
*/
/*
Console.Write("Введите высоту треугольника:");


for (int i = 0; i < height; i++)
{

    for (int j = 0; j < i; j++)
    {

        Console.Write("*");

    }

    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < height; i++)
{

    for (int j = height; j > i; j--)
    {

        Console.Write("*");

    }

    Console.WriteLine();
}
Console.WriteLine();
*/

/*
int height = 10;
for (int i = 0; i < height; i++)
{

    for (int j = height; j > i; j--)
    {

        Console.Write(" ");

    }
    for (int j = 0; j < i; j++)
    {

        Console.Write("*");

    }
     for (int j = 0; j < i; j++)
    {

        Console.Write("*1");

    }

    Console.WriteLine();
}
Console.WriteLine();
*/