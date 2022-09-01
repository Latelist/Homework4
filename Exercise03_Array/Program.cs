/*

Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/

//Если честно, не очень поняла соотношение условия и примеров

int[] array = new int[8];
Random rand = new Random();
for (int i = 0; i<array.Length; i++)
{
    array[i] = rand.Next(-99, 100);
    if (i == 0) Console.Write($"[ {array[i]}, ");
    if (i == array.Length-1) Console.WriteLine($"{array[i]} ]");
    else Console.Write($"{array[i]}, ");
}