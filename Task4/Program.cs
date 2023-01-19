Console.Clear();
Console.WriteLine ("Введите последовательность натуральных чисел, заканчивающуюся 0: ");
int max = Convert.ToInt32(Console.ReadLine());
int n, max2 = Int32.MinValue;
do {
    n = Convert.ToInt32(Console.ReadLine()); 
    if (n != 0) 
{
if (n > max)
{
    max2 = max;
    max = n;
}
else if (n > max2)
    max2 = n;
}
} while (n != 0);
Console.WriteLine(max2);