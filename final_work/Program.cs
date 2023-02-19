
using System.Linq.Expressions;

string[] Input()
{
    Console.WriteLine("Введите количество элементов");
    int length = int.Parse(Console.ReadLine()!);
    string[] mass = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Input[{i}]:");
        mass[i] = Console.ReadLine()!;
    }
    return mass;
}


string[] str = Input();
FindElementsLessThree(str);
void FindElementsLessThree(string[] str)
{
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            string[] str2 = new string[j + 1];
            str2[j] = str[i];
            Console.WriteLine($"This is elements less three: {str2[j]}");
            j++;
        }
    }
}