
using System;
namespace CSharpPartySupplyPlannerConsoleApp
{
    public class PartyPlanner
    {
        public int qtyNeeded { get; set; }
        public int peopleAttending { get; set; }
        public int totalQtyNeeded { get; set; }

        public int TotalSupplyCalc()
        {
            return totalQtyNeeded = qtyNeeded * peopleAttending;
        }
    }
}