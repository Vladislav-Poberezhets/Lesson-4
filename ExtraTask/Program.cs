Console.WriteLine("Введіть строку!");
string str = Console.ReadLine();
Console.WriteLine("Введіть кількість строк!");
int num = int.Parse(Console.ReadLine());
Method(str, num);

void Method(string str, int num)
{
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{str}_");
    }
}
