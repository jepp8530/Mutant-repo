class Mutant
{
    public Arm[] Arms { get; }
    public Leg[] Legs { get; }
    public double AverageAge { get; }

    public Mutant(int numberOfArms, int numberOfLegs)
    {
        Random random = new Random();
        Arms = new Arm[numberOfArms];
        Legs = new Leg[numberOfLegs];

        for (int i = 0; i < numberOfArms; i++)
        {
            Arms[i] = new Arm();
        }

        for (int i = 0; i < numberOfLegs; i++)
        {
            Legs[i] = new Leg();
        }

        AverageAge = CalculateAverageAge();
    }

    public double CalculateAverageAge()
    {
        int totalAge = 0;
        foreach (var arm in Arms)
        {
            totalAge += arm.Age;
        }
        foreach (var leg in Legs)
        {
            totalAge += leg.Age;
        }
        return (double)totalAge / (Arms.Length + Legs.Length);
    }
}