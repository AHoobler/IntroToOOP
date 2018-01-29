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


        private string name;        // can only be accessed here
        private int age;
        private string furColor;
        private bool isHungry = true;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        // I need behaviors

        // constuctor
        public Cat()
        {
            // default constuctor, takes no parameters (nothing in the parenthesis)

        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }


        //methods
        public void Eat() 
        {
            if (isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry" + isHungry);
        }
    }
}
