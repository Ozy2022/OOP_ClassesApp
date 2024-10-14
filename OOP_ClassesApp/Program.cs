namespace OOP_ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Ex1//Creating an object/instance of the class Car
            Car audi = new Car("A3","Audi", false);
            Car bmw = new Car("I7", "BMW", true);

            *//*Console.WriteLine("Plese enter the Brand name: ");*//*
            // Here we are setting the Brand
            *//*audi.Brand = Console.ReadLine();*//*


            //Here we are getting the brand
            Console.WriteLine("Brand is " + audi.Brand);
            Console.WriteLine("Brand is " + bmw.Brand);*/

            //#Ex2

            //create a new object
            /*Customer osama = new Customer("Osama");
            Customer albaydhani = new Customer("Albaydhani", "Jeddah-23333", "+966 56 206 9776");

            Console.WriteLine("Name of the Customer is: " + osama.Name);
            Console.WriteLine("Full details of our new Customer is: " + osama.Name + " " + albaydhani.Name + ", " + albaydhani.Adderss + ", " + albaydhani.ContactNumber);

            //Default Cuustomer with no args
            Customer myCustomer = new Customer();

            Console.WriteLine("Please Enter the Customer Name: ");
            myCustomer.Name = Console.ReadLine();

            Console.WriteLine("details about Customer: " + myCustomer.Name + ", " + myCustomer.Adderss + ", " + myCustomer.ContactNumber);*/

            /*
             you basically know how to create instances of classes with 
             different initial states providing more flexibility for 
             the user when working with your software.
             */

            //===============================================================================

            //#Ex3 Methods in Classes

            /*Car myAudi = new Car("A3", "Audi", false);

            myAudi.Drive();

            Car myBmw = new Car("i7", "BMW", true);
            myBmw.Drive();*/

            /* Customer osama = new Customer("Osama");
             Customer ahemd = new Customer("Ahemd");


             //here is giving effect to the object after its creation,
             //which means we can modfiy it and play with it.
             Customer myCustomer = new Customer();
             myCustomer.SetDetails("Osama", "Alazizia, Jeddah, KSA", "+966 56 206 9776");


             Console.WriteLine($"The Customer is: {myCustomer.Name} " +
                 $"\nthe address is: {myCustomer.Adderss} \nphone number is: {myCustomer.ContactNumber}");

             Console.WriteLine($"My Customer is: {osama.Name} " +
                 $"\nthe address is: {osama.Adderss} \nphone number is: {osama.ContactNumber}");*/


            //===================================================================
            /*Ex4 -> Static methods keyword
             
                So in C sharp the static keyword is used to declare 
                members of a class that belong to the class itself,
                rather than to any specific instance 
                which is an object of the class.
             */

            //exmple of static
            /* int results = DoubleValue(10,10);
             Console.WriteLine(results);*/


            //===================================================================
            //#Ex5 -> Static filds knowing the total number of the cars
            /*Car car = new Car();
            Car car1 = new Car();
            Car car2 = new Car("A3", "Audi", false);

            Console.WriteLine("Number of car produced: " + Car.NymberOfCars);*/
            //===================================================================
            //#Ex6 -> Id and read only

            /*Customer customer = new Customer("Omar Idrss");
            //overload means there are more the one
            //constructor we can use
            Customer customer1 = new Customer("Osama Ahemd");

            Customer customer2 = new Customer();

            customer.getReadDetails();
            customer1.getReadDetails();
            customer2.getReadDetails();

            //now we can access by the customer id
            Console.WriteLine("Customer 2 id is: " + customer2.id);*/

            //=================================================================
            //Write-Only
            /*Customer customer2 = new Customer();

            customer2.getReadDetails();
            customer2.Password = "Os2635669#";*/

            //=================================================================
            //Rectangle Class -> Const and ReadOnly

            /*Rectangle rectangle3 = new Rectangle();

            rectangle3.Width = 5;
            rectangle3.Height = 5;
            Console.WriteLine("Area of rectangle is: " + rectangle3.Area);*/

            Rectangle rectangle1 = new Rectangle("Red");
            Rectangle rectangle2 = new Rectangle("blue");

            rectangle1.DisplayDetails();
            rectangle2.DisplayDetails();

            Console.ReadKey();
        }


        //exmple of static
        public static int DoubleValue(int number1, int number2)
        {
            // TODO: Implement the method to double the value
            return number1 + number2;
            
        }

    }
}
