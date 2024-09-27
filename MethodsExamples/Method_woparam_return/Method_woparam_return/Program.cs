namespace Method_woparam_return
{
    internal class Program
    {
        static int sum()
        {
            int a = 78, b = 70, add;
            add = a + b;
            return add;
        }

        // Main Method
        static void Main(string[] args)
        {

            // Here the calling variable 
            // is 'getresult'
            int getresult = sum();

            // Printing the value of 
            // 'getresult' variable
            Console.WriteLine(getresult);
        }
    }
}
