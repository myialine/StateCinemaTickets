using System;
using System.Collections.Generic;

namespace StateCinemaTickets
{
    public class TicketCalculator
    {
        public double TadultAfter5price { get; set; }
        public double TadultBefore5Price { get; set; }
        public double TadultPrice { get; set; }
        public double totalPrice;
        public double result;
      
        public TicketCalculator()
        {

        }


        public double ChildPrice(int quantity, double childPrice, string person)
        {
            if (quantity > 0 && person == "child")
            {
                childPrice = 12;
                this.totalPrice = quantity * childPrice;
            }
            return this.totalPrice;
        }

        public double StudentPrice(int quantity, double studentPrice, string person)
        {
            if (quantity > 0 && person == "student")
            {
                studentPrice = 13;
                this.totalPrice = quantity * studentPrice;
            }
            return this.totalPrice;
        }

        public double AdultBefore5Price(int quantity, string person, int time)
        {
          
            if (quantity > 0 && person == "adult" && time < 0500 && time > 0100)
            {
                TadultAfter5price = 14.50;
                this.totalPrice = TadultAfter5price * quantity;
            }
            return this.totalPrice;
        }

        public double AdultAfter5Price(int quantity, string person, int time)
        {
            if (quantity > 0 && person == "adult" && time >= 0500 && time < 1100)
            {
                TadultAfter5price = 17.50;
                this.totalPrice = TadultAfter5price * quantity;
            }
            return this.totalPrice;
        }
        public double AdultPrice(int quantity, string person, string day, int time)
        {

            if (day == "tuesday" && person == "adult")
            {
                TadultPrice = quantity * 13;
            }
            else if (time >= 0100 && time < 0500)
            {
                TadultPrice = TadultBefore5Price * quantity;
            }
            else
            {
                TadultPrice = TadultAfter5price * quantity;
            }

            return TadultPrice;
        }

        public double SeniorPrice(int quantity, double seniorPrice, string person)
        {
            if (quantity > 0 && person == "senior")
            {
                seniorPrice = 12.50;
                this.totalPrice = quantity * seniorPrice;
            }
            return this.totalPrice;
        }


        static void Main(string[] args)
        {
            
        }



    }
}
