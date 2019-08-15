using System;
using System.Collections.Generic;

namespace StateCinema
{
    class TicketCalculator
    {
        public double adultAfter5price { get; set; }
        public double adultBefore5Price { get; set; }
        public double adultPrice { get; set; }

        public TicketCalculator()
        {

        }


        public void ChildPrice(int quantity, double totalPrice, double childPrice, string person)
        {
            if (quantity > 0 && person == "child")
            {
                childPrice = 12;
                totalPrice = quantity * childPrice;
            }
        }

        public void StudentPrice(int quantity, double totalPrice, double studentPrice, string person)
        {
            if (quantity > 0 && person == "student")
            {
                studentPrice = 13;
                totalPrice = quantity * studentPrice;
            }
        }

        public void AdultBefore5Price(int quantity, double totalPrice, string person)
        {
            if (quantity > 0 && person == "adult")
            {
                adultAfter5price = 14.50;
                totalPrice = adultAfter5price * quantity;
            }
        }

        public void AdultAfter5Price(int quantity, double totalPrice, string person)
        {
            if (quantity > 0 && person == "adult")
            {
                adultAfter5price = 17.50;
                totalPrice = adultAfter5price * quantity;
            }
        }
        public void AdultPrice(int quantity, string person, string day, double time)
        {

            if (day == "tuesday" && person == "adult")
            {
                adultPrice = quantity * 13;
            }
            else if (time >= 0100 && time < 0500)
            {
                adultPrice = adultBefore5Price * quantity;
            }
            else
            {
                adultPrice = adultAfter5price * quantity;
            }
        }

        public void SeniorPrice(int quantity, double totalPrice, double seniorPrice, string person)
        {
            if (quantity > 0 && person == "senior")
            {
                seniorPrice = 12.50;
                totalPrice = quantity * seniorPrice;
            }
        }


        static void Main(string[] args)
        {

        }



    }
}
