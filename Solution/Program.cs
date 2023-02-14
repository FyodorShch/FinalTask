Console.Clear();

Console.WriteLine("Введите строку");
string[] StringArray = CreateArray(Console.ReadLine());
Console.WriteLine();
ShowString(NewArray(StringArray));

string[] CreateArray(string ss)
{
    string[] words = ss.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string[] result = new string[words.Length];
    for (int i = 0; i < words.Length; i++)
    {
        result[i] = words[i];
    }
    return result;
}
void ShowString(string[] s)
{
    Console.Write("[");
    for (int j = 0; j < s.Length; j++)
    {
        Console.Write($"{s[j]}");
    }
    Console.Write("]");
}
string[] NewArray(string[] array)
{
    int w = 0;
    string[] s = new string[array.Length];
    for (int q = 0; q < s.Length; q++)
    {
        if (array[q].Length <= 3)
        {
            s[w] = array[q];
            w++;
        }
    }
    return s;
}