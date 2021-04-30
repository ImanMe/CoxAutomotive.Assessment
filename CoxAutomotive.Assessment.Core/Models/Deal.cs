using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace CoxAutomotive.Assessment.Core.Models
{
    public class Deal
    {
        private static readonly Regex CsvSplitPattern
            = new Regex(@",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))");
        public Deal() { }

        public Deal(string csvLine)
        {
            var values = CsvSplitPattern.Split(csvLine);

            if (values.ElementAtOrDefault(0) != null) DealNumber = Convert.ToInt32(values[0]);
            if (values.ElementAtOrDefault(1) != null) CustomerName = values[1].Replace("\"", "");
            if (values.ElementAtOrDefault(2) != null) DealershipName = values[2].Replace("\"", "");
            if (values.ElementAtOrDefault(3) != null) Vehicle = values[3].Replace("\"", "");
            Price = GetPrice(values);
            Date = GetDate(values);
        }

        public long DealNumber { get; set; }
        public string CustomerName { get; set; }
        public string DealershipName { get; set; }
        public string Vehicle { get; set; }
        public string Price { get; set; }
        public string Date { get; set; }

        public string GetPrice(IReadOnlyList<string> values)
        {
            if (values.ElementAtOrDefault(4) == null) return null;

            var decimalPrice = decimal.Parse(values[4]
                .Replace("\"", ""), CultureInfo.GetCultureInfo("en-US"));

            return $"CAD$ {decimalPrice:n0}";
        }

        public string GetDate(IReadOnlyList<string> values)
        {
            if (values.ElementAtOrDefault(5) == null) return null;

            return DateTime.TryParse(values[5], out var temp)
                ? temp.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
                : null;
        }
    }
}