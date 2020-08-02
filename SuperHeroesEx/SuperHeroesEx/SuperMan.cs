using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesEx
{
    class SuperMan : Human, IFly
    {
        #region Properties
        public bool WebLeft { get; private set; }
        public override string Name { get; set; }
        #endregion

        #region Constructor
        public SuperMan(string name, int age, bool webleft) : base(name, age)
        {
            this.Name = name;
            this.SetAge(age);
            this.WebLeft = webleft;
        }
        #endregion

        #region Methods
        public void ActivateSuperPower()
        {
            Fly();
        }

        public void Fly()
        {
            Console.WriteLine("Fly Fly Away!");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nWeb Left: {this.WebLeft}";
        }
        #endregion
    }
}
