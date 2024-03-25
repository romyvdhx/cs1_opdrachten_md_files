using System;

namespace FunctionOpdracht5
{
    internal class Program
    { 
        string heroName;
        int heroStrength;
        int health;
        Random rnd = new Random();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }


        private void Run()
        {

            Console.WriteLine("choose your hero's name");
            heroName = GetHeroName(); //heroName zit op Program (this)

            Console.WriteLine($"your hero is called {heroName}");

            SetHeroStrength(9999);//super sterk natuurlijk

            //1) roep hier de SetHealth aan met een 1000;
            SetHealth(1000);

            while(IsHeroDead())//4) maak deze function, deze geeft een true  terug als health <= 0, anders geeft deze false terug
            {
                //fight!

               	int dam = RollDamage();//5) maak deze function, je mag een random gebruiken of een vast getal
              
            	Console.WriteLine($"your hero takes {dam} damage");
				DoDamageToHero(dam);//6) maak deze function, deze haalt dam af van de health (op program)

            	Console.WriteLine($"your hero has {health} health");
            }

            Console.WriteLine("oefening compleet!");
        }

        //2) maak hier een function GetHeroName die met Console.ReadLine() een helden naam vraagt
        private string GetHeroName()
        {
            Console.WriteLine("What is your hero name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Your hero name is {name}");
            return name;
        }

        //3) maak hier een function SetHeroStrength met 1 argument  van type 'int'
        //in de body van de function zet de waarde van heroStrength (van program) het 
        private void SetHeroStrength(int heroStrength)
        {
            this.heroStrength = heroStrength;
        }

        //
        private void SetHealth(int health)
        {
            this.health = health;
        }

        private bool IsHeroDead()
        {
            return health <= 0;
           }

        private int RollDamage()
        {
            int roll = this.rnd.Next(1, 7);
            return roll;
        }

        private void DoDamageToHero(int dam)
        {
            health -= dam;
        }
    }
}