string input = Console.ReadLine();

int adults = 0;
int kids = 0;

while (input.ToLower() != "christmas")
{
    int age = int.Parse(input);
    if (1 <= age && age <= 16)
    {
        kids++;
    }
    else if (17 <= age && age <= 130)
    {
        adults++;
    }
    input = Console.ReadLine();
}

decimal priceOfToys = kids * 5m;
decimal priceOfSweaters = adults * 15m;

Console.WriteLine($"Number of adults: {adults}");
Console.WriteLine($"Number of kids: {kids}");
Console.WriteLine($"Money for toys: {priceOfToys}");
Console.WriteLine($"Money for sweaters: {priceOfSweaters}");