using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesEx
{
    class SpiderMan : Human, IClimb
    {
        #region Properties
        public float Speed { get; private set; }
        public override string Name { get; set; }
        #endregion

        #region Constructor
        public SpiderMan(string name, int age, float speed) : base(name, age)
        {
            this.Name = name;
            this.SetAge(age);
            this.Speed = speed;
        }
        #endregion

        #region Methods
        public void ActivateSuperPower()
        {
            Climb();
        }

        public void Climb()
        {
            Console.WriteLine("Climbing on a Building!");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nSpeed: {this.Speed}";
        }
        #endregion
    }
}
