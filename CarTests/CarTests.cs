using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS; // name of class NS = name space

namespace CarTests
{
    [TestClass]//Let's program know that this whole class is unit testing
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        [TestMethod] // lets system know this method is a test case
        public void EmptyTest() // always public 
        {
            Assert.AreEqual(10, 10, .001);  //(Expected, actual,delta(variance)
        }
        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void TestInitialGasTank()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);//calls Car method from Car Class
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }
        Car test_car;
        [TestInitialize]
        public void CreateCarObject()
        {
           test_car = new Car("Toyota", "Prius", 10, 50);
        }
        //TODO: gasTankLevel is accurate after driving within tank range

        [TestMethod]
        public void GasLevelCorrect()
        {
            test_car.Drive(50); // using the Drive method
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestGasTankAfterDrivingPastRange()
        {
            test_car.Drive(875);
            Assert.AreEqual(0,test_car.GasTankLevel,0.01);
        }

        //TODO: can't have more gas than tank size, expect an exception

    }
}
