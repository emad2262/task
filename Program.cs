namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int small = 25;
            int large = 35;
            double tax = 6.6;
            int smallCarbet = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine($"number of small carpets: {smallCarbet}");
           
            int largeCarbet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"number of large carpets: {largeCarbet}");

            Console.WriteLine("price per small : 25$");
            Console.WriteLine("price per large is : 35$");
            Console.WriteLine($"cost : {smallCarbet * small + largeCarbet * large}$");
            Console.WriteLine($"tax is: {tax}$");
            Console.WriteLine($"total estmate is: {smallCarbet * small + largeCarbet * large + tax}$");
            Console.WriteLine("this estimate is valid for 30 days ");

        }
    }
}
