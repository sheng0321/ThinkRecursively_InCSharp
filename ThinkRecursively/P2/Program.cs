namespace P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int sum = 0;
            for (int i = 1; i <= 1000; i++) {
                Console.WriteLine($"Collect one dollar from person {i}");
                sum += 1;
            }
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}