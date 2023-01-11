using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstProgram
    {
        class Program
        {
        static void Main(string[] args)
        {
            //object = a instance of class. class used as blueprint to create object(oop)
            //          object can have fields & method( characteristics & action)
            

             Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Aiman";
            human1.age = 24;

            human2.name = "Hazim";
            human2.age = 25 ;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();


            Console.ReadKey();  
    
        }
        
        }
    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping for {age}");
        }
    }


    }





   
