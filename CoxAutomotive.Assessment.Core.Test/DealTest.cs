using System.Collections.Generic;
using Xunit;
using CoxAutomotive.Assessment.Core.Models;

namespace CoxAutomotive.Assessment.Core.Test
{
    public class DealTest
    {
        [Fact]
        public void ShouldGetAndFormatPriceFromRow()
        {
            var sut = new Deal();

            var values = new List<string>
            {
                "56421", "John Doe", "Sun of Ontario", "Ferrari", "\"429,987\"", "11/02/2019"
            };

            var actual = sut.GetPrice(values);

            Assert.Equal("CAD$ 429,987", actual);
        }

        [Fact]
        public void ShouldGetDateAsNullIfNotADate()
        {
            var sut = new Deal();

            var values = new List<string>
            {
                "56421", "John Doe", "Sun of Ontario", "Ferrari", "\"429,987\"", "NotADate"
            };

            var actual = sut.GetDate(values);

            Assert.Null(actual);
        }
    }
}
