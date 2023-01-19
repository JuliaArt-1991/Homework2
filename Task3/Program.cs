Console.Clear();
Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
Console.Write("Вы ошиблись!\nВведите день недели: ");
n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
Console.WriteLine("Понедельник, будни");
else if (n == 2)
Console.WriteLine("Вторник, будни");
else if (n == 3)
Console.WriteLine("Среда, будни");
else if (n == 4)
Console.WriteLine("Четверг, будни");
else if (n == 5)
Console.WriteLine("Пятница, будни");
else if (n == 6)
Console.WriteLine("Суббота, выходной");
else if (n == 7)
Console.WriteLine("Воскресенье, выходной");