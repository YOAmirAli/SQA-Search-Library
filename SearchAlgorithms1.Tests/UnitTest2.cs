using Xunit;
using SearchAlgorithmsLibrary;

namespace SearchAlgorithms1.Tests
{
    public class MCDC_Tests
    {
        [Fact]
        public void CheckShipping_MCDC_Requirement()
        {
            var order = new Order();
            Assert.Equal("International Express", order.CheckShipping(10, true, true));
            Assert.Equal("International Standard", order.CheckShipping(10, true, false));
            Assert.Equal("Domestic", order.CheckShipping(10, false, true)); 
            Assert.Equal("Invalid Weight", order.CheckShipping(0, true, true));
        }
        [Fact]
        public void Integration_SearchLibrary_Verification()
        {
            var ls = new LinearSearch();
            var js = new JumpSearch();
            var bs = new BinarySearch();
            int[] arr = { 10, 20, 30, 40, 50 };
            Assert.Equal(2, ls.search(30, arr)); 
            Assert.Equal(-1, ls.search(99, arr));
            Assert.Equal(4, js.search(50, arr)); 
            Assert.Equal(-1, js.search(45, arr)); 
            Assert.Equal(3, bs.search(40, arr)); 
            Assert.Equal(0, bs.search(10, arr)); 
            Assert.Equal(-1, bs.search(5, arr)); 
        }
    }
}