int totalProcessors = int.Parse(Console.ReadLine());
int employees = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

decimal totalHours = employees * days * 8;
decimal amountOfProcessors = Math.Floor(totalHours / 3);

decimal moneyFromProcessors = amountOfProcessors * 110.10m;
decimal moneyFromProcessorsNeeded = totalProcessors * 110.10m;

if (moneyFromProcessorsNeeded > moneyFromProcessors)
{
    Console.WriteLine($"Losses: -> {moneyFromProcessorsNeeded - moneyFromProcessors:f2} BGN");
}
else
{ 
    Console.WriteLine($"Profit: -> {moneyFromProcessors - moneyFromProcessorsNeeded:f2} BGN");
}