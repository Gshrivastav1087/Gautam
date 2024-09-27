namespace DogClass_SetterMethod
{
    using System;

    // Class Declaration
    public class Car
    {

        // Instance Variables
        String make;
        String model;
        int capacity;
        String color;



        // Constructor Declaration of Class
        public Car(String make, String model,
                      int capacity, String color)
        {
            this.make = make;
            this.model = model;
            this.capacity = capacity;
            this.color = color;
        }
        public Car()
        {
        }

        // Property 1
        public String GetMake()
        {
            return make;
        }

        // Property 2
        public String GetModel()
        {
            return model;
        }

        // Property 3
        public int GetCapacity()
        {
            return capacity;
        }

        // Property 4
        public String GetColor()
        {
            return color;
        }
        public void SetMake(string newMake)   // This is the setter, new value
        {
            make = newMake;
        }


        // Property 2
        public void SetModel(string newModel)
        {
            model = newModel;
        }

        // Property 3
        public void SetCapacity(int newCapacity)
        {
            capacity = newCapacity;
        }

        // Property 4
        public void SetColor(string newColor)
        {
            color = newColor;
        }

        // Main Method
        public static void Main(String[] args)
        {

            // Creating object
            Car car1 = new Car("Audi", "Q7", 5, "white");
            Console.WriteLine("The Car's Make is " + car1.GetMake()
                    + ".\nmodel, capacity and color are " + car1.GetModel()
                    + ", " + car1.GetCapacity() + ", " + car1.GetColor());


            //Creating another object
            Car car2 = new Car();

            Console.WriteLine("Enter the Car's Make: ");
            String carMake1 = Console.ReadLine();
            car2.SetMake(carMake1);
                
            Console.WriteLine("Enter Car's Model: ");
            String carModel1 = Console.ReadLine();
            car2.SetModel(carModel1);

            Console.WriteLine("Enter Car's capacity: ");
            int carCapacity = int.Parse(Console.ReadLine());
            car2.SetCapacity(carCapacity);

            Console.WriteLine("Enter Car's color: ");
            String carColor = Console.ReadLine();
            car2.SetColor(carColor);

            Console.WriteLine("Hi, the thirdDog's name, breed, age and color are "
                + car2.GetMake() + "," + car2.GetModel() + "," + car2.GetCapacity()
                + "," + car2.GetColor());



        }
    }
}





