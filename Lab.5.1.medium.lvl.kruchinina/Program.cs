// 10  var
Console.Write("Введите символы(без пробелов): ");
char[] ch = Console.ReadLine().ToCharArray();
Console.WriteLine("Различные символы в массиве:");
for (int i = 0; i < ch.Length; i++)
{
    char ch1 = ch[i];
    bool f = true;
    for (int j = 0; j < i; j++)
    {
        if (ch[j] == ch1)
        {
            f = false;
            break;
        }
    }
    if (f)
    {
        Console.WriteLine(ch1);
    }
}
