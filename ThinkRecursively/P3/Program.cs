namespace P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int target = 1000; //if the target%10 ==0, the program will not stop and then stack overflow.
            int result = Collect(target);
            Console.WriteLine($"The last result is : {result}");


        }
        static int Collect(int N)
        {
            int sum = 0;
            if (N == 1)
            {
                //contribute the dollar directly              
                sum += 1;
                Console.WriteLine( $"Get one dollar from one person.");
                
            }
            else
            {
                 //find 10 people
                for (int i = 1; i <= 10; i++)
                {
                    //Have each collect N/10 dollars
                    int collect = Collect(N / 10); ;
                    //Return the money to your superior
                    sum += collect;
                    Console.WriteLine($"The sum is {sum}");
                }
                Console.WriteLine($"The superior sum is {sum}");               
            }
            return sum;
        }
    }
}