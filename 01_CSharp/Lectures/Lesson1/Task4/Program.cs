// Задача 4
// Даны две целых числа. Вывести на экран большее из них

// В каталог вставил блок-схему для решения данной задачи (Flowchart_4.png)

// Решение

int a = 1;
int b = 7;
int c = 9;
int d = 4;
int e = 10;

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
if (d > max)
{
    max = d;
}
if (e > max)
{
    max = e;
}
Console.WriteLine(max);
