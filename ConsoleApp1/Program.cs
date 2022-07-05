// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string result = string.Empty;
string flower = Console.ReadLine();
int floweramnt = int.Parse(Console.ReadLine());
if (floweramnt < 10 || floweramnt > 1000)
{
    throw new ArgumentException("Invalid Amount");
}
int budget = int.Parse(Console.ReadLine());
if (budget < 50 || floweramnt > 2500)
{
    throw new ArgumentException("Invalid Budget");
}
double totalPrice = 0;
switch (flower)
{
    case "Roses":
        {
            totalPrice = floweramnt * 5;
            if (floweramnt > 80)
            {
                totalPrice *= 0.9;
            }
            if (budget >= totalPrice)
            {
                double leftbudget = budget - totalPrice;
                Console.WriteLine("Hey you have a great garden with {0} {1} and {3} leva left", floweramnt, flower, leftbudget);
            }
            else
            {
                double neededmoney = totalPrice - budget;
                Console.WriteLine("Not enough money you need {0} leva more", neededmoney);
            }
            break;
        }
        //TODO: make for homework
    case "Dhalias":
        {
            totalPrice = floweramnt * 5;
            if (floweramnt > 80)
            {
                totalPrice *= 0.85;
            }
            if (budget >= totalPrice)
            {
                double leftbudget = budget - totalPrice;
                Console.WriteLine("Hey you have a great garden with {0} {1} and {3} leva left", floweramnt, flower, leftbudget);
            }
            else
            {
                double neededmoney = totalPrice - budget;
                Console.WriteLine("Not enough money you need {0} leva more", neededmoney);
            }
            break;
        }
}
Console.WriteLine(result);
