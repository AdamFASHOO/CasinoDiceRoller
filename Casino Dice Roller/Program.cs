
public class Program
{
    public static void Main()
    {
        bool goAgain = true;
        while (goAgain)
        {
            RandomGenerator();
            goAgain = RunAgain();
        }
    }
    public static void RandomGenerator()
    {
        Random random = new Random();

        Console.WriteLine("Welcome to the Grand Circus Casino!");
        int diceSides;
        int.TryParse(GetUserInput("How many sides should each die have?"), out diceSides);
       
        Console.WriteLine("Your rolls are: ");
        int rollOne = RandomMethod(random, diceSides);
        int rollTwo = RandomMethod(random, diceSides);
        if (diceSides == 6)
        {
            RollDeterminer(rollOne, rollTwo);
        }
    }
    public static void RollDeterminer(int rollOne, int rollTwo)
    {
        if (rollOne == 1 && rollTwo == 1)
        {
            Console.WriteLine("Snake eyes!");
        }
        else if (rollOne == 1 && rollTwo == 2 || rollOne == 2 && rollTwo == 1)
        {
            Console.WriteLine("Ace Duece!");
        }
        else if (rollOne == 6 && rollTwo == 6)
        {
            Console.WriteLine("Box cars!");
        }
        else if (rollOne + rollTwo == 7 || rollOne + rollTwo == 11)
        {
            Console.WriteLine("Winner!");
        }
        else if (rollOne + rollTwo == 2 || rollOne + rollTwo == 3 || rollOne + rollTwo == 12)
        {
            Console.WriteLine("Craps!");
        }
    }
    private static int RandomMethod(Random random, int diceSides)
    {
        int roll = random.Next(1, diceSides + 1);
        Console.Write(roll + " ");
        return roll;
    }
    public static string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        return input;
    }
    public static bool RunAgain()
    {
        string answer = GetUserInput("\nWould you like to roll another pair of die? y/n").ToLower();
        if (answer == "y")
        {
            return true;
        }
        else if (answer == "n")
        {
            Console.WriteLine("Goodbye!");
            return false;
        }
        else
        {
            Console.WriteLine("\nI'm sorry, I didn't understand that.");
            return RunAgain();
        }
    }
}
