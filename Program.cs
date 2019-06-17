using System;

//In below example of inheritance, class ABC is a base class, class XYZ is a derived class which extends GFG class and class Program is a driver class to run program.
// C# program to illustrate the 
// concept of inheritance 

namespace inheritanceProject
{
    // Base class 
    class ABC
    {
        // data members 
        public string name;
        public string subject;

        // public method of base class  
        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }

    // inheriting the ABC class using :  
    class XYZ : ABC
    {

        // constructor of derived class 
        public XYZ()
        {
            Console.WriteLine("I am derived class Constructor");
        }
    }



    // Driver class
    class Program
    {
        // Main Method 
        static void Main(string[] args)
        {

            // creating object of derived class 
            XYZ g = new XYZ();

            // calling the method of base class  
            // using the derived class object 
            g.readers("Jatinder", "C#");
        }
    }
}
