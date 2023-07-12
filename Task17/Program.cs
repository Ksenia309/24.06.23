// 17. Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится 
// эта точка.

Console.WriteLine("Введите координаты точки: ");
Console.WriteLine("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

if (xCoordinate > 0 && yCoordinate > 0)
{
    Console.WriteLine("Указанные координаты соответствуют четверти 1");
}
else if (xCoordinate < 0 && yCoordinate > 0)
{
    Console.WriteLine("Указанные координаты соответствуют четверти 2");
}
else if (xCoordinate < 0 && yCoordinate < 0)
{
    Console.WriteLine("Указанные координаты соответствуют четверти 3");
}
else if (xCoordinate > 0 && yCoordinate < 0)
{
    Console.WriteLine("Указанные координаты соответствуют четверти 4");
}
else
{
    Console.WriteLine("Введены некорректные координаты");
}