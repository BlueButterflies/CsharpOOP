using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class PriceCalculator
    {
        private decimal pricePerDay;
        private int numberOfDay;
        private Season season;
        private Discount discount;

        public PriceCalculator(string[] infoReservation)
        {
            this.pricePerDay = decimal.Parse(infoReservation[0]);
            this.numberOfDay = int.Parse(infoReservation[1]);
            this.season = Enum.Parse<Season>(infoReservation[2]);
            this.discount = Discount.None;

            if (infoReservation.Length == 4)
            {
               this.discount = Enum.Parse<Discount>(infoReservation[3]);
            }
        }

        public decimal GetTotalPrice()
        {
            int seasonMultiply = (int)this.season;

            decimal discountPrecent = (decimal)this.discount / 100;

            decimal priceBeforeDiscount = this.pricePerDay * this.numberOfDay * seasonMultiply;

            decimal amountDiscount = priceBeforeDiscount * discountPrecent;

            decimal finalPrice = priceBeforeDiscount - amountDiscount;

            return finalPrice;
        }
    }
}
