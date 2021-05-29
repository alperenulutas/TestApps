using System;
using System.Collections.Generic;
using System.Text;

namespace TestApplication
{
    public class Animal
    {
        public void sound(string animalType)
        {
            if (animalFamily(animalType) == "Vahşi")
            {
                Console.WriteLine("Warning !! It can be dangerous !!");
            }

            if (animalType == "Dog")
            {
                Console.WriteLine("Bark");
            }
            else if (animalType == "Cat")
            {
                Console.WriteLine("Miav");
            }
            else if (animalType == "Bird")
            {
                Console.WriteLine("Cik");
            }
            else if (animalType == "Lion")
            {
                Console.WriteLine("Hırr");
            }
            else
            {
                Console.WriteLine("undefined");
            }               
        }
        public int numberOfLegs(string animalType)
        {
            int leg = 0;
            if (animalType == "Dog")
            {
                leg = 4;
            }
            else if (animalType == "Cat")
            {
                leg = 4;
            }
            else if (animalType == "Bird")
            {
                leg = 2;
            }
            else
            {
                leg = -1;
            }
            return leg;
        }
        private string animalFamily(String animalType)
        {
            string family;

            if (animalType == "Dog")
            {
                family = "Evcil";
            }
            else if (animalType == "Cat")
            {
                family = "Evcil";
            }
            else if (animalType == "Lion")
            {
                family = "Vahşi";
            }
            else
            {
                family = "undefined";
            }
            return family;
        }
    }
}
