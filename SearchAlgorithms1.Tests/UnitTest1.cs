using Xunit;
using SearchAlgorithmsLibrary;

namespace SearchAlgorithms1.Tests
{
    public class AutomationCheck
    {
        [Fact]
        public void TestBinarySearch()
        {
            var bs = new BinarySearch();
            int[] arr = { 10, 20, 30, 40, 50 };
            int result = bs.search(40, arr);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Order_ShouldReturnInternationalExpress()
        {
            var order = new Order();
            string result = order.CheckShipping(10, true, true);
            Assert.Equal("International Express", result);
        }
    }
}