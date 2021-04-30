using System;
using System.Collections.Generic;
using CoxAutomotive.Assessment.Core.Models;
using CoxAutomotive.Assessment.Core.Test.Seeds;
using Xunit;

namespace CoxAutomotive.Assessment.Core.Test
{
    public class ResultTest
    {
        [Fact]
        public void ShouldGetMostSoldVehicle()
        {
            var deals = DealSeed.GetDeals();

            var sut = new Result();

            var actual = sut.GetMostSoldVehicle(deals);

            Assert.Equal("Ferrari", actual);
        }

        [Fact]
        public void ShouldThrowExceptionIfHeadersAreNotValid()
        {
            var sut = new Result();

            var headers = new List<string>
            {
                "InvalidColumn,CustomerName,DealershipName,Vehicle,Price,Date"
            };

            Assert.Throws<ApplicationException>(() => sut.GetHeaders(headers));
        }

        [Fact]
        public void ShouldGenerateHeaderFromRows()
        {
            var sut = new Result();

            var rows = new List<string>
            {
                "DealNumber,CustomerName,DealershipName,Vehicle,Price,Date",
                "56421, John Doe, Sun of Ontario, Ferrari, 873200, 11/02/2019"
            };

            var actual = sut.GetHeaders(rows);

            var expected = new List<string>
            {
                "DealNumber","CustomerName","DealershipName","Vehicle","Price","Date"
            };

            Assert.Equal(expected, actual);
        }
    }
}
