using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        private string hairLength;
        private int height;
        private string runningSpeed;
        private int weight;

        public string RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public int Height //PASCAL CASE
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public Dog()
        {

        }

        public Dog(string hairLength, int height, string runningSpeed, int weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        public void Run()
            {
            Console.WriteLine("Slow down!");
            }

        public void Bark()
        {
            Console.WriteLine("\a");
        }

        public void Potty()
        {
            Console.WriteLine(weight - 1);

        }

        public void Cuddle()
        {
            Console.WriteLine("Come here doggie!");
        }

    }
}
