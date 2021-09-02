using System;
using Shouldly;
using Xunit;

namespace DateRanges.Tests
{
    public class FindOverlapTests
    {
        private static DateTime Now = DateTime.Now;
        private static DateTime SevenDaysAgo = Now.AddDays(-7);
        private static DateTime SevenDaysFuture = Now.AddDays(7);
        private static DateTime FourteenDaysFuture = Now.AddDays(14);

        [Fact]
        public void TestRangeOneExtendsIntoRangeTwo()
        {
            var dateRange1 = new DateRange(SevenDaysAgo, SevenDaysFuture);
            var dateRange2 = new DateRange(Now, FourteenDaysFuture);
            var expected = new DateRange(Now, SevenDaysFuture);

            var actual = dateRange1.FindOverlap(dateRange2);

            actual.ShouldBe(expected);
        }

        [Fact]
        public void TestRangeTwoExtendsIntoRangeOne()
        {
            var dateRange2 = new DateRange(SevenDaysAgo, SevenDaysFuture);
            var dateRange1 = new DateRange(Now, FourteenDaysFuture);
            var expected = new DateRange(Now, SevenDaysFuture);

            var actual = dateRange1.FindOverlap(dateRange2);

            actual.ShouldBe(expected);
        }

        [Fact]
        public void TestRangeOneEndsWhenRangeTwoBegins()
        {
            var dateRange1 = new DateRange(SevenDaysAgo, Now);
            var dateRange2 = new DateRange(Now, FourteenDaysFuture);

            Should.Throw<Exception>(() => {
                var actual = dateRange1.FindOverlap(dateRange2);
            });
        }

        [Fact]
        public void TestRangeTwoEndsWhenRangeOneBegins()
        {
            var dateRange2 = new DateRange(SevenDaysAgo, Now);
            var dateRange1 = new DateRange(Now, FourteenDaysFuture);

            Should.Throw<Exception>(() => {
                var actual = dateRange1.FindOverlap(dateRange2);
            });
        }

        [Fact]
        public void TestRangeOneContainsRangeTwo()
        {
            var dateRange1 = new DateRange(SevenDaysAgo, FourteenDaysFuture);
            var dateRange2 = new DateRange(Now, SevenDaysFuture);
            var expected = new DateRange(Now, SevenDaysFuture);

            var actual = dateRange1.FindOverlap(dateRange2);

            actual.ShouldBe(expected);
        }

        [Fact]
        public void TestRangeTwoContainsRangeOne()
        {
            var dateRange2 = new DateRange(SevenDaysAgo, FourteenDaysFuture);
            var dateRange1 = new DateRange(Now, SevenDaysFuture);
            var expected = new DateRange(Now, SevenDaysFuture);

            var actual = dateRange1.FindOverlap(dateRange2);

            actual.ShouldBe(expected);
        }

        [Fact]
        public void TestRangeOneDoesNotOverlapWithRangeTwo()
        {
            var dateRange1 = new DateRange(SevenDaysAgo, Now);
            var dateRange2 = new DateRange(SevenDaysFuture, FourteenDaysFuture);

            Should.Throw<Exception>(() => {
                var actual = dateRange1.FindOverlap(dateRange2);
            });
        }

        [Fact]
        public void TestRangeTwoDoesNotOverlapWithRangeOne()
        {
            var dateRange2 = new DateRange(SevenDaysAgo, Now);
            var dateRange1 = new DateRange(SevenDaysFuture, FourteenDaysFuture);

            Should.Throw<Exception>(() => {
                var actual = dateRange1.FindOverlap(dateRange2);
            });
        }

        [Fact]
        public void TestRangeOneEqualsRangeTwo()
        {
            var dateRange1 = new DateRange(Now, SevenDaysFuture);
            var dateRange2 = new DateRange(Now, SevenDaysFuture);
            var expected = new DateRange(Now, SevenDaysFuture);

            var actual = dateRange1.FindOverlap(dateRange2);

            actual.ShouldBe(expected);
        }
    }
}
