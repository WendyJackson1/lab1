public class Program
{
    public static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            Console.WriteLine(i);
        }

        for (; ; )
        {
            Console.WriteLine("Hello World!");
            break;
        }

        int num = 0;

        while(num < 20)
        {
            Console.WriteLine(num);
            num++;
        }

        bool goON = true;
        int n = 0;
        while (goON == true)
        {

            Console.WriteLine(n);
            n++;
            if (n == 15)
            {
                goON = false;
            }
        }
        int timesRun = 0;   
        bool keepRunning = true;
        while (keepRunning == true)
        {
            Console.WriteLine("Hello there!");
            timesRun++;
            Console.WriteLine($"Times loop has run{timesRun}");

            while (true)
            {
                Console.WriteLine("Would you like to be greeted again? y/n");
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    break;
                }
                else if (input == "n")
                {
                    Console.WriteLine("Good bye");
                    keepRunning = false;
                    break;
                }
                else
                {
                    Console.WriteLine("I'm sorry I dont understand");
                    Console.WriteLine("lets try that again");
                }
            }
        }
    }
}