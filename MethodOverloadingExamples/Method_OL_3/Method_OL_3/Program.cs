namespace Method_OL_3
{
    internal class Method_OL
    {
        // Method
        public void Identity(String name, int id)
        {
            Console.WriteLine("Name1 : " + name + ", "  + "Id1 : " + id);
        }
        // Method
        public void Identity(int id, String name)
        {
            Console.WriteLine("Name2 : " + name + ", " + "Id2 : " + id);
        }
        // Main Method
        public static void Main(String[] args)
        {
            // Creating Object
            Method_OL obj = new Method_OL();
            obj.Identity("Apple", 1);
            obj.Identity(2, "Samsung");
        }
    }
}
