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
        public int numberOfPeople;
        public decimal costOfBevereagesPerPerson;
        public decimal costOfDecorations;

        public DinnerParty()
        {
        }

        public void CalculateCostOfDecoration(bool fancyDecoration)
        {
            if (fancyDecoration)
            {
                costOfDecorations = 50 + (numberOfPeople * 15);
            }
            else
            {
                costOfDecorations = 30 + (numberOfPeople * 7.5M);
            }

        }

        public void setHealthyOption(bool healthy)
        {
            if (healthy)
            {
                costOfBevereagesPerPerson = 5M;
            }
            else
            {
                costOfBevereagesPerPerson = 20M;
            }
        }

        public decimal CalculateCost()
        {
            decimal cost;

            cost = costOfFoodPerPerson * numberOfPeople;

            if (costOfBevereagesPerPerson == 5)
            {
                cost += costOfBevereagesPerPerson * numberOfPeople;
                cost = cost * 0.95M;
            }
            else
            {
                cost += costOfBevereagesPerPerson * numberOfPeople;
            }

            return cost;
        }
    }
}
