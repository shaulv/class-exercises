using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clients;

namespace Hotel
{
    public abstract class Room
    {
        #region Properties
        protected int roomNumber;
        protected float price = 0;
        protected Guest guest;
        protected bool isClean;
        public bool SetIsClean
        {
            get { return isClean; }
            set { isClean = value; }
        }

        protected string features;
        #endregion

        #region Constructors
        public Room(int roomNumber, float price)
        {
            if (price == 0 || this.price == 0)
            {
                SetPrice();
            }
            SetFeatures();
        }
        #endregion

        #region Methods
        internal void SetGuest(Guest guest)
        {
            this.guest = guest;
        }
        protected virtual void SetPrice()
        {
            int basePrice = 50;
            int extraPrice = 25;
            int currentMonth = Convert.ToInt32(DateTime.Now.ToString("MM"));

            if (currentMonth == 7 || currentMonth == 8)
            {
                this.price = basePrice + extraPrice;
            }
            else
            {
                this.price = basePrice;
            }
        }
        protected abstract void SetFeatures();
        public int GetRoomNumber()
        {
            return this.roomNumber;
        }

        public float GetPrice()
        {
            return this.price;
        }

        public Guest GetGuest()
        {

            return guest;
        }

        public bool IsClean()
        {
            return isClean;
        }

        public string GetFeatures()
        {
            return this.features;
        }

        public override string ToString()
        {
            return $"Room Number: {this.roomNumber}\nPrice: {this.price}\nGuest Name: {this.guest.GetName()}\nClean: {this.isClean}\nFeatures: {this.features}";
        }

        #endregion
    }
}
