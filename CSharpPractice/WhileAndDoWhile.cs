namespace CSharpPractice;

class WhileAndDoWhile
{
    static void Main(string[] args)
    {
        int tableOf = 2;

        Console.WriteLine("USING WHILE LOOP");
        Console.WriteLine("Printing table of 2 to 5");

        while(tableOf <= 5)
        {
            Console.WriteLine();
            Console.WriteLine($"Table Of : {tableOf}");
            for(int i = 1; i<= 10; i++)
            {
                Console.WriteLine($"{tableOf} * {i} = {tableOf * i}");
            }
            tableOf++;
        }

        Console.WriteLine();
        Console.WriteLine("USING DO WHILE LOOP");
        Console.WriteLine("Printing table as long as you want");

        do
        {
            Console.WriteLine();
            Console.WriteLine($"Table Of : {tableOf}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{tableOf} * {i} = {tableOf * i}");
            }
            tableOf++;
            Console.WriteLine("Press enter to continue...");
        } while (Console.ReadKey().Key == ConsoleKey.Enter);
    }
}