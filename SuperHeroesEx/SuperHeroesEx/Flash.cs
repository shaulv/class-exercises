using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesEx
{
    class Flash : Human, IFlash
    {
        #region Properties
        public float Voltage { get; private set; }
        public override string Name { get; set; }
        #endregion

        #region Constructor
        public Flash(string name, int age, float volt) : base(name, age)
        {
            this.Name = name;
            this.SetAge(age);
            this.Voltage = volt;
        }
        #endregion

        #region Methods
        public void FireLightnings()
        {
            Console.WriteLine("Firing Lightning Attack!");
        }

        public void ActivateSuperPower()
        {
            FireLightnings();
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nVoltage: {this.Voltage}";
        }
        #endregion
    }
}
