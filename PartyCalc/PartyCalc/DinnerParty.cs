using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyCalc
{
    public class DinnerParty
    {

        public const int costOfFoodPerPerson = 25;  
        protected bool healthy { get; set; }
        protected bool fancy { get; set; }
        protected int numberOfPeople { get; set; }

        public DinnerParty() { }

        public DinnerParty(int numberOfPeople, bool fancy, bool healthy)
        {
            this.fancy = fancy;
            this.healthy = healthy;
            this.numberOfPeople = numberOfPeople;
        }

        protected decimal CalculateCostOfDecoration()
        {
            decimal decorationTotalCost;
            
            if (this.fancy)
            {
                decorationTotalCost = 50 + (this.numberOfPeople * 15);
            }
            else
            {
                decorationTotalCost = 30 + (this.numberOfPeople * 7.5M);
            }

            return decorationTotalCost;

        }

        protected decimal setHealthyOption()
        {
            decimal costOfBevereagesPerPerson;
            if (this.healthy)
            {
                costOfBevereagesPerPerson = 5M;
            }
            else
            {
                costOfBevereagesPerPerson = 20M;
            }

            return costOfBevereagesPerPerson * this.numberOfPeople;
            
        }

        public decimal CalculateCost()
        {

            decimal cost;

            cost = costOfFoodPerPerson * this.numberOfPeople;
            cost += setHealthyOption();
            cost += CalculateCostOfDecoration();

            return cost;
        }

        
    }
}
