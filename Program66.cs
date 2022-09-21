internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 66: Задайте значения M и N. Напишите программу, 
        //которая найдёт сумму натуральных элементов в промежутке от M до N.
        // M = 1; N = 15 -> 120
        // M = 4; N = 8. -> 30
        string SequenceRec(int N)
        {
            if (N == 0) return "";
            return SequenceRec(N - 1) + " " + Convert.ToString(N);
        }
        string SequenceSegmentRec(int M, int N)
        {
            if (N == M - 1) return "";
            return SequenceSegmentRec(M, N - 1) + " " + Convert.ToString(N);
        }
        int SumRes(int M, int N)
        {
            if (M > N) return 0;
            return (N + M) * (N - M + 1) / 2;
        }
        try
        {
            Console.WriteLine("Введите натуральные числа");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SequenceSegmentRec(m, n));
            Console.WriteLine(SumRes(m, n));
        }
        catch
        {
            Console.WriteLine("Введите НАТУРАЛЬНОЕ число");
        }
    }
}