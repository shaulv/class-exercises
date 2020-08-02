using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 3 super heroes
            ISuperHero[] superHeroes = new ISuperHero[3];

            superHeroes[0] = new SuperMan("Clark", 32, true);
            superHeroes[1] = new SpiderMan("Peter", 16, 20.19f);
            superHeroes[2] = new Flash("Berry", 23, 12767.62f);

            Console.WriteLine("\n//// Activate powers ////\n");

            foreach (var hero in superHeroes)
            {
                ActivateHero(hero);
            }

            Console.WriteLine("\n//// Identify Heroes ////\n");

            foreach (var hero in superHeroes)
            {
                IdentifyHero(hero);
            }

            Console.WriteLine("\n//// Get More Hero Data ////\n");

            foreach (var hero in superHeroes)
            {
                GetMoreHeroData(hero);
            }

            //create heroes
            var newHero1 = CreateHero("spiderman", "tomi", 31, true);

            var newHero2 = CreateHero("spiderman", "tomi", 31, 8383.99f);

            var newHero3 = CreateHero("superman", "sam", 22, 3939f);

            var newHero4 = CreateHero("superman", "sam", 22, true);

            var newHero5 = CreateHero("flash", "john", 53, true);

            var newHero6 = CreateHero("flash", "john", 53, 4848.20f);

        }

        #region Methods
        static void ActivateHero(ISuperHero superHero)
        {
            superHero.ActivateSuperPower();
        }

        static void IdentifyHero(ISuperHero superHero)
        {
            if (superHero is SuperMan)
            {
                Console.WriteLine("Superman detected!");
            }
            else if (superHero is SpiderMan)
            {
                Console.WriteLine("Spiderman detected!");
            }
            else if (superHero is Flash)
            {
                Console.WriteLine("Flash detected!");
            }
        }

        static void GetMoreHeroData(ISuperHero superHero)
        {
            if (superHero is SuperMan)
            {
                SuperMan trueHero = superHero as SuperMan;
                Console.WriteLine("\n"+trueHero.ToString());
            }
            else if (superHero is SpiderMan)
            {
                SpiderMan trueHero = superHero as SpiderMan;
                Console.WriteLine("\n"+trueHero.ToString()); 
            }
            else if (superHero is Flash)
            {
                Flash trueHero = superHero as Flash;
                Console.WriteLine("\n"+trueHero.ToString());
            }
        }

        static ISuperHero CreateHero(string heroType, string name, int age, float voltageOrSpeed)
        {
            if (heroType.ToLower() == "flash")
            {
                return (ISuperHero)new Flash(name, age, voltageOrSpeed);
            }
            else if (heroType.ToLower() == "spiderman")
            {
                return (ISuperHero)new SpiderMan(name, age, voltageOrSpeed);
            }
            return null;
        }

        static ISuperHero CreateHero(string heroType, string name, int age, bool webLeft)
        {
            if (heroType.ToLower() == "superman")
            {
                return (ISuperHero)new SuperMan(name, age, webLeft);
            }
            return null;
        }
        #endregion
    }
}
