/*
Задача 36. 
Задаnm одномерный массив, заполненный случайными числами. 
Найnb сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void FillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(-100,100);
        }
}

void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.WriteLine();
}

Console.Write("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
Console.WriteLine("Created array: ");
PrintArray(numbers);
int sum = 0;

for (int j = 0; j < numbers.Length; j+=2)
    sum = sum + numbers[j];

Console.WriteLine($"Total numbers in the array: {numbers.Length}");
Console.WriteLine($"Sum of odd numbers: {sum}");