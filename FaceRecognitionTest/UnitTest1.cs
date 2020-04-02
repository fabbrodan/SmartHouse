using NUnit.Framework;
using SmartHouseLibrary;

namespace FaceRecognitionTest
{
    public class Tests
    {
        [Test]
        public void TestFacialRecognition()
        {
            // Arrange
            SmartHouse smartHouse = new SmartHouse();
            Resident Daniel = new Resident("Daniel");
            Daniel.SetFace(new Face(20, 15, new Colors("Blue"), new Colors("Brown")));
            smartHouse.AddResident(Daniel);

            // Act && Assert
            Assert.IsTrue(smartHouse.UnlockDoor(Daniel.GetFace()));

        }
    }
}