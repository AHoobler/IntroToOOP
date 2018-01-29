using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat(); //using the defualt 
            firstCat.Name = "Mr. Fuzzy"; // name property, accessing the set

            Cat secondCat = new Cat("Midnight", 14, "black");

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);

            firstCat.Eat(); // calling the method on the first cat object 

            secondCat.Meow();

            Dog firstDog = new Dog();
            firstDog.RunningSpeed = "Very Fast";

            Dog secondDog = new Dog("Long hair", 12, "very slow", 90);

            Console.WriteLine(firstDog.RunningSpeed);
            Console.WriteLine(secondDog.RunningSpeed);

            firstDog.Bark();
            secondDog.Cuddle();


            


        }
    }
}
