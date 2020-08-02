using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesEx
{
    abstract class Human
    {
        #region Properties
        public abstract string Name { get; set; }
        private int age;
        #endregion

        #region Constructor
        public Human(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }
        #endregion

        #region Methods
        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}\nAge: {this.age}";
        }
        #endregion

    }
}
