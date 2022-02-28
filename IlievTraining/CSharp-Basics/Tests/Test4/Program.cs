int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int s = int.Parse(Console.ReadLine());

List<int> list = new List<int>();

for (int i = m ; i >= n; i--)
{
    if (i % 2 == 0 && i % 3 == 0)
    {
        if (i == s)
        {
            break;
        }
        list.Add(i);
    }
}

Console.WriteLine(string.Join(' ', list));