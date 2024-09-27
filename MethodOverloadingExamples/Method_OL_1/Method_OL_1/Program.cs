namespace Method_OL_1
{
    //Method Overloading by changing the number of parameters
    internal class Method_OL
    {
        // adding two integer values.
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        // adding three integer values.
        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        // Main Method
        public static void Main(String[] args)
        {
            // Creating Object
            Method_OL ob = new Method_OL();
            int sum1 = ob.Add(1, 2);
            Console.WriteLine("sum of the two " + "integer value : " + sum1);
            int sum2 = ob.Add(1, 2, 3);
            Console.WriteLine("sum of the three " + "integer value : " + sum2);
        }
    }
}
