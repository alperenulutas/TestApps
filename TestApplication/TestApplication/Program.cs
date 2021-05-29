using System;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal ani = new Animal();          
            
            ani.sound("Dog");
            ani.sound("Lion");
            ani.sound("Rabbit");

        }
        
    }
}
