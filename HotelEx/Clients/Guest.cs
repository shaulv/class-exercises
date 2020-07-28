using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    public class Guest
    {
        #region Properties
        int id;
        string name;
        #endregion

        #region Constructor
        public Guest(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        #endregion


        #region Methods
        public int GetID()
        {
            return this.id;
        }
        public string GetName()
        {
            return this.name;
        }
        public override string ToString()
        {
            return $"ID: {this.id}\nName: {this.name}";
        }
        #endregion
    }
}
