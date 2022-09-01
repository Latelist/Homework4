/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

try
{
    Console.Write("Please, enter number A: ");
    int A = int.Parse(Console.ReadLine());

    Console.Write("Please, enter number B: ");
    int B = int.Parse(Console.ReadLine());

    double result = Math.Pow(A, B);
    Console.WriteLine(result);
}
catch
{
    Console.WriteLine("Please, enter integers next time.");
}
