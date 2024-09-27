namespace Method_OL_4
{
    internal class Method_OL
    {
        // adding two integer value.
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        // adding three integer value.
        public double Add(int a, int b)
        {
            double sum = a + b + 0.0;
            return sum;
        }
        // Main Method
        public static void Main(String[] args)
        {
            // Creating Object
            Method_OL ob = new Method_OL();
            int sum1 = ob.Add(1, 2);
            Console.WriteLine("sum of the two " + "integer value :" + sum1);

            int sum2 = ob.Add(1, 2); 
            Console.WriteLine("sum of the three " + "integer value :" + sum2);
        }
    }
}
