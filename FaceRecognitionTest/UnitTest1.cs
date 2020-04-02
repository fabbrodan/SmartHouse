using NUnit.Framework;
using SmartHouseLibrary;
using SmartHouseLibrary.Structures;

namespace FaceRecognitionTest
{
    public class Tests
    {
        [Test]
        public void TestFacialRecognition()
        {
            // Arrange
            SmartHouse smartHouse = new SmartHouse("Best Street 123");
            smartHouse.AddDoor(new Door(smartHouse, "Front Door"));
            Resident Daniel = new Resident("Daniel");
            Daniel.SetFace(new Face(20, 15, new Colors("Blue"), new Colors("Brown")));
            smartHouse.AddResident(Daniel);

            // Act && Assert
            Assert.IsTrue(smartHouse.GetDoors()[0].UnlockDoor(Daniel.GetFace()));

        }
    }
}