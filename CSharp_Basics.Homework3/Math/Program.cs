namespace Mathematics;

class Program
{
    static void Main(string[] args)
    {
        FourTransactions fourTransactions = new FourTransactions();
        fourTransactions.Sum(5, 6);
        fourTransactions.Sum(6, 9);
        Console.ReadLine();
    }
}

