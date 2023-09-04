// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int numberOfArms = random.Next(1, 5);
        int numberOfLegs = random.Next(1, 5);

        Mutant mutant = new Mutant(numberOfArms, numberOfLegs);

        Console.WriteLine("Mutant has " + numberOfArms + " arms and " + numberOfLegs + " legs.");

        foreach (var arm in mutant.Arms)
        {
            Console.WriteLine("Age of arms: " + arm.Age + " years");
        }

        foreach (var leg in mutant.Legs)
        {
            Console.WriteLine("Age of legs: " + leg.Age + " years");
        }

        Console.WriteLine("Average age of mutant: " + mutant.CalculateAverageAge() + " years");


        if (mutant.AverageAge > 33)
        {
            Console.WriteLine("Welcome to the themepark!");
        }
        else
        {
            Console.WriteLine("Access denied to the themepark.");
        }
        Console.ReadLine();
    }
}