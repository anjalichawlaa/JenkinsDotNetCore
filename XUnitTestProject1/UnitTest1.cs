using System;
using Xunit;
using WebApplication1.BL;
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2)]
        public void Test1(int x,int y)
        {
            BL obj = new BL();
            int r=obj.add(x, y);
            Assert.Equal(3, r);
        }
    }
}
