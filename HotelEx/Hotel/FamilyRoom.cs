using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class FamilyRoom : Room
    {
        public FamilyRoom(int roomNumber, float price) : base(roomNumber, price)
        {
        }

        protected override void SetPrice()
        {
            int basePrice = 100;
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
        protected override void SetFeatures()
        {
            this.features = "Family Room: TV, minibar...";
        }
    }
}
