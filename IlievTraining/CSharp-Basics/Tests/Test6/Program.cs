int locations = int.Parse(Console.ReadLine());

for (int i = 0; i < locations; i++)
{
    decimal gold = decimal.Parse(Console.ReadLine());
    decimal totalGold = 0m;
    int days = int.Parse(Console.ReadLine());

    for (int j = 0; j < days; j++)
    {
        totalGold += decimal.Parse(Console.ReadLine());
    }
    totalGold /= days;
    if (totalGold < gold)
    {
        Console.WriteLine($"You need {gold-totalGold:f2} gold.");
    }
    else
    {
        Console.WriteLine($"Good job! Average gold per day: {totalGold:f2}.");
    }
}