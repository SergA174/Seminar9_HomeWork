// // Задача 66: Задайте значения M и N. Напишите программу, 
// // которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30


Console.Write("Введите целое число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumRec(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;            
    else if (n == 0) return (m * (m + 1)) / 2;       
    else if (m == n) return m;                       
    else if (m < n) return n + SumRec(m, n - 1); 
    else return n + SumRec(m, n + 1);            
}

Console.Write($"Cумма чисел в промежутке от {m} до {n} равна: ");
Console.WriteLine(SumRec(m, n));




