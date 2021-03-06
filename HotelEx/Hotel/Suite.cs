﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Suite : Room
    {
        public Suite(int roomNumber, float price) : base(roomNumber, price)
        {
        }

        protected override void SetPrice()
        {
            int basePrice = 150;
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
            this.features = "Suite: TV, minibar...";
        }
    }
}
