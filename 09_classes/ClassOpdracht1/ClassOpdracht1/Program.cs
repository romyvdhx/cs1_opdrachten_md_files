using System;

namespace ClassOpdracht1
{
     //???
    //Schrijf met commentaar(//dit is commentaar) in deze file de naam bij elk onderdeel 
    internal class ClassStructureExercise //class
    {
        private readonly string accountName; //string

        internal ClassStructureExercise(string accountName) //class
        {
            this.accountName = accountName; //string
        }

        internal void ShowGreetingInConsole() //function
        {
            string greeting = "hello"; //string
            Console.WriteLine(greeting + " " + accountName); //constructor
        }

        internal void Show1To10() //function
        {
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(i.ToString()); //constructor
            }
        }

        internal double DistBetweenPoints(int x1, int y1, int x2, int y2) //double
        {

            int dx = x2 - x1; //integer
            int dy = y2 - y1; //integer

            double lengthSquared = (dx * dx) + (dy * dy); //double

            double length = Math.Sqrt(lengthSquared); //double
            return length;

        }
        internal int MultiplyToPower2(int value) //integer
        {
            int result = value * value; //integer
            return result;
        }


        static void Main(string[] args) //function
        {
            Console.WriteLine("Hello, World!"); //constructor

        }
    }
}