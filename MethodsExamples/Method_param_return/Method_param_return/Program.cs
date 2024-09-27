namespace Method_param_return
{
    internal class Program
    {
        static int Sum(int x, int y)
        {
            // there are two local variables 
            // 'a' and 'b' where 'a' is assigned 
            // the value of parameter 'x' and 
            // 'b' is assigned the value of
            // parameter 'y'
            int a = x;
            int b = y;

            // The local variable calculates
            // the sum of 'a' and 'b'
            // and returns the result
            // which is of 'int' type.
            int result = a + b;

            return result;
        }

        // Main Method
        static void Main(string[] args)
        {
            int a = 12;
            int b = 23;

            // Method Sum() is invoked and 
            // the returned value is stored 
            // in the local variable say 'c'
            int c = Sum(a, b);

            // Display Result
            Console.WriteLine("The Value of the sum is " + c);
        }
    }
}
