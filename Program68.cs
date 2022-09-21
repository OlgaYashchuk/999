// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
using System;
					
public class Program
{
	public static void Main()
	{
        Console.WriteLine("Введите неотрицательное число m");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введитенеотрицательное число n");
        int n = Convert.ToInt32(Console.ReadLine());

		int AkkermanF(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkermanF(m - 1, 1);
			}
			return AkkermanF(m - 1, AkkermanF(m, n - 1));
		}
		
		Console.WriteLine(AkkermanF(m,n));
	}
}