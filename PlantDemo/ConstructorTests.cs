using Models;
using NUnit.Framework;
using Plant.Core;
using PlantDemo.Support.Blueprints;

namespace PlantDemo
{
    [TestFixture]
    public class ConstructorTests
    {
        private VehicleModel vehicle;

        [SetUp]
        public void BeforeEach()
        {
            var plant = new BasePlant().
                WithBlueprintsFromAssemblyOf<VehicleModelBlueprint>();

            vehicle = plant.Create<VehicleModel>(new
                {
                    NumberOfWheels = 5, 
                    NumberOfTires = 6
                });

        }



        [Test]
        public void VehicleModel_Constructor_HasTire()
        {
            Assert.IsNotNull(vehicle.Tire);
        }

        [Test]
        public void VehicleModel_Constructor_ReadOnlyFieldPopulation()
        {
            Assert.IsNotNull(vehicle.GrossVehicleWeight);
        }

        [Test]
        public void VehicleModel_Constructor_DefaultsCanBeOverridden()
        {
            Assert.AreEqual(vehicle.NumberOfWheels, 5);
            Assert.AreEqual(vehicle.NumberOfTires, 6);
        }
    }
}