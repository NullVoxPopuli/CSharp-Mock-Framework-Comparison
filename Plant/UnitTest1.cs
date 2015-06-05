using System;
using Models;
using NUnit.Framework;
using Plant.Core;
using PlantDemo.Support.Blueprints;

namespace PlantDemo
{
    [TestFixture]
    public class UnitTest1
    {
        private VehicleModel vehicle;

        [SetUp]
        public void BeforeEach()
        {
            var plant = new BasePlant().WithBlueprintsFromAssemblyOf<VehicleModelBlueprint>();
            vehicle = plant.Create<VehicleModel>();
        }

        [Test]
        public void VehicleModel_Constructor_ReadOnlyFieldPopulation()
        {
            Assert.IsNotNull(vehicle.GrossVehicleWeight);
        }

        [Test]
        public void VehicleModel_Constructor_HasTire()
        {
            Assert.IsNotNull(vehicle.Tire);
        }
    }
}
