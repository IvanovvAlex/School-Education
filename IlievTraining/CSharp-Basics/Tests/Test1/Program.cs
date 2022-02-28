int boya = int.Parse(Console.ReadLine());
int tapeti = int.Parse(Console.ReadLine());
double cenaRakavici = double.Parse(Console.ReadLine());
double cenaChetka = double.Parse(Console.ReadLine());

double rakavici = Math.Ceiling(tapeti * 0.35) * cenaRakavici;
double chetki = Math.Floor(boya * 0.48) * cenaChetka;

double sum = boya * 21.50 + tapeti * 5.20 + rakavici + chetki;
double delivery = sum / 15;
Console.WriteLine($"This delivery will cost {delivery:f2} lv.");