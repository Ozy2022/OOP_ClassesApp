namespace OOP_ClassesApp
{
    internal class Customer
    {


        //ID Key and ReadOnly
        //static fild to hold the next ID available
        //here we create the id 
        private static int nextId = 0;
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    _age = value;
                }
            }
        }


        //This is the unique identifier
        //And here we are assign the id
        //and it only can assign value ones
        private readonly int _id;


        //Backing field for wtite-only property
        private string _password;


        //#Having Multiple Consructors
        public string Name { get; set; }
        public string Adderss { get; set; }
        public string ContactNumber { get; set; }


        //Read only properties
        public int id { get { return _id; } }


        //Write only properties
        public string Password { set { _password = value; } }




        //1_Custom Consructor and you can use ctor for short cut
        //And if we have a lot of info we use this type Consructor
        public Customer(string name, string address, string contactNumber)
        {
            //Each time we get a new customer we have these 3 details
            _id = nextId++;

            Name = name;
            Adderss = address;
            ContactNumber = contactNumber;
        }


        //2_Custom Consructor
        //And if we have a few of info we use this type Consructor
        public Customer(string name)
        {
            _id = nextId++;

            Name = name;
        }

        //3_Default Consructor and Use Cases

        public Customer()
        {
            _id = nextId++;

            Name = "Default name - New Customer";
            Adderss = " No Address";
            ContactNumber = "No Contact Number";
        }



        //this method created to be used and give the its work
        //not during creating the object but after creating the object

        public void SetDetails(string name, string address, string contactNumber)
        {

            Name = name;
            Adderss = address;
            ContactNumber = contactNumber;
        }

        public void getReadDetails()
        {
            Console.WriteLine($"details about the customer: Name is {Name} and Id is: {_id}");
        }
    }
}



