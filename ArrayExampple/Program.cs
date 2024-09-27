namespace ArrayExampple
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // declares an Array of integers.
           int [] intArray = new int[20];
           
            // accessing the elements using for loop
            Console.WriteLine("The Elements of Array are :");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * 5;
                Console.WriteLine(intArray[i]);
            }
        }
    }
}



