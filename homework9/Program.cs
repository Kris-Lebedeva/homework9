/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""*/

/*Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
if (M>N)
for (int i = N; i <= M; i++)
        Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.Write($" {i}");*/

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

/*Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int summa(int m, int n)
{
    if (m==n)
    return n;
else return m + summa(m + 1, n);
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {summa(m,n)}");*/

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29*/

/*Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}*/

        
    



