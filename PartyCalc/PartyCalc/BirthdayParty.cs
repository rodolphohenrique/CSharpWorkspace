using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyCalc
{
    class BirthdayParty : DinnerParty
    {
       
        public int cakeSize { get; set; }
        public string cakeWriting { get; set; }
        public bool cakeWritingTooLong { get; set; }
        private double costOfFoodPerPerson;



        private double CalculateCakeSize()
        {
            if (base.numberOfPeople <= 4)
                cakeSize = 8;
            else
                cakeSize = 16;

            return cakeSize;
        }

        private int MaxWritingLength()
        {
            if (CalculateCakeSize() == 8)
                return 16;
            else
                return 40;
        }

        private int MaxStringLength()
        {
            if (cakeWriting.Length > MaxStringLength())
                return MaxWritingLength();
            else
                return cakeWriting.Length;
        }

        private double CakeCost()
        {
            double CakeCost;
            CakeCost = MaxWritingLength() * 25;
            if (CalculateCakeSize() == 16)
                CakeCost += 40;
            else
                CakeCost += 75;

            return CakeCost;
        }

        override
        public decimal CalculateCost() 
        {
            double cost;
            cost = (double) base.CalculateCostOfDecoration();
            cost += CakeCost();
            cost += numberOfPeople * costOfFoodPerPerson;
            
            

            return (decimal)cost;
        }


    }
}
