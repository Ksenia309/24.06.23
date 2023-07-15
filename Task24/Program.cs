// 24. Напишите программу, которая 
// 1. принимает на вход число (A) и 
// 2. выдаёт сумму чисел от 1 до A.

// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum = sum + i; //sum += i;
        }
    }
    return sum;
}
