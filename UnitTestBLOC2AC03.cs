using Utils;
namespace TestxUnitBLOC2AC03
{
    public class UnitTestBLOC2AC03
    {
        [Theory]
        [InlineData(5,15,10, true)]
        [InlineData(3, 25, 2, true)]
        [InlineData(3, 25, 0, true)]
        [InlineData(3, 0, 0, true)]
        public void Test_PositiveNumberSum(int numOne, int numTwo, int numThree, bool isPositive)
        {
            //Arrange

            //Act
            isPositive = Tools.IsPositive(numOne, numTwo, numThree);

            //Assert
            Assert.True(isPositive);
        }

        [Theory]
        [InlineData(0, 0, 0, false)]
        [InlineData(0, 2, 0, false)]
        [InlineData(0, 2, 3, false)]
        [InlineData(0, -2, -1, false)]
        public void Test_NotPositiveSum(int numOne, int numTwo, int numThree, bool isPositive)
        {
            //Arrange

            //Act
            isPositive = Tools.IsPositive(numOne, numTwo, numThree);

            //Assert
            Assert.False(isPositive);
        }
    }
}
