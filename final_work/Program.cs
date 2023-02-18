

string[] str = { "1234", "123", "12345", "12", "34" };
//Console.WriteLine(str[0].Length);
int j = 0;
for (int i = 0; i < str.Length; i++)
{

    Console.WriteLine(j);
    if (str[i].Length <= 3)
    {
        string[] str2 = new string[j + 1];
        str2[j] = str[i];
        Console.WriteLine(str2[j]);
        j++;

    }

}