using Microsoft.VisualStudio.TestTools.UnitTesting;
using planetaryClasses.things;

namespace planetClass.Tests
{
    [TestClass]
    public class planetUnitTests
    {
        [TestMethod]
        public void CanInstantiatePlanetClass()
        {
            //arrange 
            Planet testPlanet = new Planet();
            
            //act

            //assert
            Assert.IsNotNull(testPlanet);
        }

        [TestMethod]
        public void CanSetPlanettoString()
        {
            //arrange 
            Planet testPlanet = new Planet();
            
            //act
            testPlanet.name = "testPlanet";

            //assert
            Assert.AreEqual(testPlanet.name, "testPlanet");
        }



    }
}
