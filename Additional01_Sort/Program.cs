/* 
Написать программу сортировки массива от большего к меньшему. 
Массив задается размерностью N с клавиатуры, далее заполняется случайными целыми числами.

*/

Console.Write("Please, enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-99, 100);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FillArray(array);
PrintArray(array);
Console.WriteLine();


void ArraySort(int[] arr)
{
    for (int j = 0; j < arr.Length - 1; j++)
    {
        int max = arr[j];
        int maxindex = j;
        for (int i = j + 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                maxindex = i;
            }
        }
        int temporary = arr[j];
        arr[j] = max;
        arr[maxindex] = temporary;
    }
}

ArraySort(array);
PrintArray(array);




