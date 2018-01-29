using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        // I need states

        // fields
        private string name;        // can only be accessed in this class. private cannot be printed in another class (ie program class)
        private int age;
        private string furColor;
        private bool isHungry = true;


        // properties. can only interact with field through the properties. limits interaction
        public string Name // can access from other classes
        {
            get { return this.name; } // get(keyword) shows the value of name. GET from the private. 
            set { this.name = value; } // set(keyword) changes the value(keyword) of name
                                        // *this* allows for specifies the object that it's in
        }
        
        
        // behaviors
        // constuctor
        public Cat()  // public constructor lets us access the private ones 
        {
            // default constuctor, takes no parameters (nothing in the parenthesis)

        }

        public Cat(string name, int age, string furColor) // constructor with parameters. when you use parameters the characteristics get set automatically. 
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }


        //methods BEHAVIORS
        public void Eat() 
        {
            if (isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry " + isHungry);
        }

        public void Meow()
        {
            Console.WriteLine("\a");
        }


    }
}
