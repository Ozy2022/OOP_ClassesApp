using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ClassesApp
{
    /*
     its internal, which means that it can only
     be accessed from witin the same assembly
     */

    
    internal class Car
    {

        //Static filds
        public static int NymberOfCars = 0;


        //Backing Filed as Member Variable
        //private hides the variables from other classes
        //so you don't need to write Backing Filed if you're not
        //modfing the set, get like _model

        private string _model = "";
        private string _brand = "";
        private bool _isLuxury;


        //Propertie -> public string Brand {..}
        //Lambda Expressions
        //public string Model { get => _model; set => _model = value; }
        //or we can use it like this for simplcity
        public string Model { get; set; }


        public string Brand {


            /*
              In C#, get and set are part of properties, which 
              are used to encapsulate fields (variables) and provide 
              controlled access to them. They allow you to define how 
              a field is read (using get) and written (using set).
             
              Access:
                get is used for retrieving the value.
                set is used for assigning the value.
             
             */

            //here we are return variable 
            get
            {

                if (_isLuxury)
                {
                    return _brand + " - Luxury Edition";
                } else
                {
                    return _brand; 
                
                }
            
            }

            //here we are assign the variable 
            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You enterd Nothing!");
                    _brand = "Default Value";
                } else
                {
                    _brand = value;
                } 
            }    
        }

        //Custom Constructor
        public Car(string model, string brand, bool isLuxury)
        {
            NymberOfCars++;

            Model = model;
            Brand = brand;
            

            Console.WriteLine("A Car of the model "
                + model + " has been created!" + "\nand the brand is " +
                 brand);
            _isLuxury = isLuxury;
        }

        //Mehods in Clases for ex: what car could do,
        //it could derive!

        public void Drive()
        {
            Console.WriteLine($"I'm a {Model} and I'm driving");
        }

        public Car()
        {
            NymberOfCars++;
        }
        
    }
}
