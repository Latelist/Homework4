/*
 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Please, enter number: ");
//int numbercheck = Convert.ToInt32(Console.ReadLine());
string number = Console.ReadLine();

int[] digits = new int[number.Length];
int sum = 0;
for (int i = 0; i < number.Length; i++)
{
    digits[i] = (int)char.GetNumericValue(number[i]);
    if (digits[i] == -1)
    {
        Console.WriteLine("Please, enter integer next time");
        break;
    }
    Console.Write($"{digits[i]} ");
    sum = sum + digits[i];
}
Console.WriteLine();
Console.WriteLine(sum);