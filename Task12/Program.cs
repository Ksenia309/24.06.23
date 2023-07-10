// 12. Напишите программу, которая будет 
// принимать на вход два числа и выводить, 
// является ли первое число кратным второму.
// Если первое число не кратно второму, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());
int multiplicity = firstDigit % secondDigit;
if (multiplicity == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine($"Первое число НЕ кратно второму, остаток -> {multiplicity}");
}