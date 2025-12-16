namespace TestxUnitBLOC2.AC03
{
    public class UnitTestBLOC2AC03
    {
        [Theory]
        [InlineData(2, 2, 2, 6)]
        [InlineData(2, 2, 0, 4)]
        [InlineData(2, 2, -1, 4)]
        [InlineData(2, 0, 0, 2)]
        [InlineData(2, -4, 0, 2)]
        [InlineData(2, 0, -1, 2)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(-1, 0, 0, 0)]
        [InlineData(0, -1, 0, 0)]
        [InlineData(0, -3, -1, 0)]
        [InlineData(-1, 0, -1, 0)]
        public void Test_NumberSum(int a, int b, int c, int result)
        {
            //Arrange

            //Act


            //Assert
            Assert.Equal(a + b + c, result);
            Assert.Equal(a + b, result);
            Assert.Equal(a, result);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(0)]
        [InlineData(-100)]
        [InlineData(1)]
        [InlineData(-1)]
        public void Test_MsgSum(int result)
        {
            //Arrange

            //Act


            //Assert
            Assert.InRange(result, 1, 100000000);
            Assert.Equal(0, result);
            Assert.InRange(result, -1, -100000000);
        }
    }
}
