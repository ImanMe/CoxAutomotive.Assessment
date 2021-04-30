using System.Collections.Generic;
using CoxAutomotive.Assessment.Core.Models;

namespace CoxAutomotive.Assessment.Core.Test.Seeds
{
    public static class DealSeed
    {
        public static IList<Deal> GetDeals()
        {
            var deals = new List<Deal>
            {
                new Deal
                {
                    DealNumber = 51234,
                    CustomerName = "Milli Fulton",
                    DealershipName = "Sun of BC",
                    Vehicle = "Ferrari",
                    Price = "429987",
                    Date = "19/02/2016"
                },
                new Deal
                {
                    DealNumber = 73123,
                    CustomerName = "John Doe",
                    DealershipName = "Sun of Saskatoon",
                    Vehicle = "BMW",
                    Price = "429987",
                    Date = "19/02/2018"
                },
                new Deal
                {
                    DealNumber = 98213,
                    CustomerName = "Jane Doe",
                    DealershipName = "Sun of Ontario",
                    Vehicle = "Ferrari",
                    Price = "429987",
                    Date = "13/06/2018"
                },
            };

            return deals;
        }
    }
}
