// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии.
// Даны два неотрицательных числа n и m.
// n = 2, m = 3 -> A(n, m) = 9.

Console.Write("Введите целое число A: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanRec(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return AkkermanRec(m - 1, 1);
    else return (AkkermanRec(m - 1, AkkermanRec(m, n - 1)));
}
Console.Write($"Значение функции Аккермана для чисел {m} и {n} равно: ");
Console.Write(AkkermanRec(m, n));