
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

void PrintArray(string[] array)
{
    Console.WriteLine("New array data");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] str = Input();
FindElementsLessThree(str);
void FindElementsLessThree(string[] str)
{
int count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            count++;
        }
        //Console.WriteLine($"This is elements less three: {str2[j]}");
     }

 string[] mass = new string[count];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            mass[j] = str[i];
            j++;
        }
    }
    PrintArray(mass);
}