using System;
using System.Collections.Generic;
using System.Linq;

namespace CoxAutomotive.Assessment.Core.Models
{
    public class Result
    {
        public Result() { }

        public Result(IList<string> rows)
        {
            var deals = GetDeals(rows);
            Headers = GetHeaders(rows);
            Deals = deals;
            MostSoldVehicle = GetMostSoldVehicle(deals);
        }

        private const string AcceptedExcelHeader = "DealNumber,CustomerName,DealershipName,Vehicle,Price,Date";
        public string MostSoldVehicle { get; set; }
        public IList<string> Headers { get; set; }
        public IList<Deal> Deals { get; set; }

        public static string GetMostSoldVehicle(IList<Deal> vehicleSales)
        {
            return vehicleSales.GroupBy(v => v.Vehicle)
                .OrderByDescending(s => s.Count())
                .SelectMany(x => x)
                .First()
                .Vehicle;
        }

        public IList<string> GetHeaders(IList<string> rows)
        {
            if (rows.First() != AcceptedExcelHeader)
                throw new ApplicationException("The file headers are not in as expected");

            return rows.First().Split(",").ToList();
        }


        public static IList<Deal> GetDeals(IEnumerable<string> rows)
        {
            return rows
                .Skip(1)
                .Select(x => new Deal(x)).ToList();
        }
    }
}
