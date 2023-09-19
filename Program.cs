//проверить является ли число степенью 3
while (true)
{
    int n, i;
    n = int.Parse(Console.ReadLine());
    i = 1;
    while (i < n)
    {
        i = i * 3;
    }
    if (n == i)
    {
        Console.WriteLine("True");
    }
    else { Console.WriteLine("False"); }
}