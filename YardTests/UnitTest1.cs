using NUnit.Framework;
using SmartHouseLibrary;

namespace YardTests
{
    public class Tests
    {
        [Test]
        public void TestGetYardSize()
        {
            // Arrange
            Yard yard = new Yard(50, 50);

            // Act
            double result = yard.GetYardSize();

            // Assert
            Assert.AreEqual(2500d, result);
        }
    }
}