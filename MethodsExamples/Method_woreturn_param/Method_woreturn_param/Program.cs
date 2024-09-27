namespace Method_woreturn_param
{
    internal class Program
    {
        // This method take the side of 
        // the square as a parameter and 
        // after obtaining the result,
        // it simply print it without 
        // returning anything..
        static void perimeter(int p)
        {

            // Displaying the perimeter 
            // of the square
            Console.WriteLine("Perimeter of the Square is " + 4 * p);
        }

        // Main  Method
        static void Main(string[] args)
        {

            // side of square
            int p = 5;

            // Method invoking
            perimeter(p);
        }
    }
}
