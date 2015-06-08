using System;
using Models;
using NUnit.Framework;
using Plant.Core;
using PlantDemo.Support.Blueprints;

namespace MoqDemo
{
    [TestFixture]
    public class ConstructorTestsWithPlant
    {
        private VehicleModel vehicle;

        [SetUp]
        public void BeforeEach()
        {
            var plant = new BasePlant().
                WithBlueprintsFromAssemblyOf<VehicleModelBlueprint>();

            vehicle = plant.Create<VehicleModel>();
        }


        [Test]
        public void VehicleModel_PropertyCanBeStubbed()
        {
            //var fakedVehicle = Fake<VehicleModel>(x => x.Wrapping(vehicle));
            
            // there is no interface for a vehicleModel
            //var mock = new Moq.Mock<VehicleModel>();
            //mock.Setup(m => m.FrontalArea(ref vehicle)).Returns(0);

            //vehicle = mock.Object;

            //Assert.AreEqual(vehicle.FrontalArea, 0);

        }

    }
}
