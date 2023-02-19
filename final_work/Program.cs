using System.Linq.Expressions;

string[] Input() //ввод значений в массив
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
void PrintArray(string[] array)  //Метод вывода массива
{
    Console.WriteLine("\nNew array data");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" [{array[i]}] ");
    }
    Console.Write("]");
Console.WriteLine();
}
void FindElementsLessThree(string[] str)  // Ищем элементы меньше трех и создаем из них новый массив
{
    int count = 0;

    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            count++;
        }

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
        else
        {
                
        }
    }
    PrintArray(mass);
}

// Начало программы

string[] str = Input();
FindElementsLessThree(str);
