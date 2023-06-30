/*
Задача 38. 
Задать массив вещественных чисел. Найти разницу 
между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

void FillArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.WriteLine();
}

Console.Write("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArray(numbers);
Console.WriteLine("Created array: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] > max)
        {
            max = numbers[j];
        }
    if (numbers[j] < min)
        {
            min = numbers[j];
        }
}
double diff = max - min;
diff = Math.Round (diff,2);

Console.WriteLine($"Max number: {max}, min number: {min}");
Console.WriteLine($"The difference between max number and min number: {diff}");