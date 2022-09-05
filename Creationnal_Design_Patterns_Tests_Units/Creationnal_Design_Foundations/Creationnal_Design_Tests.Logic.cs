using Creationnal_Design_Patterns.CreationnalFoundations.Abstract_Factory.Application.ShipApplications;
using Creationnal_Design_Patterns.CreationnalFoundations.Abstract_Factory.Domain.Entities;
using Creationnal_Design_Patterns.CreationnalFoundations.Abstract_Factory.Domain.Enums.TypesOfShips;
using Creationnal_Design_Patterns.CreationnalFoundations.Prototype_Cloning.Entities;
using FluentAssertions;
using Xunit;

namespace Creationnal_Design_Patterns_Tests_Units.Creationnal_Design_Foundations
{
    public partial class Creationnal_Design_Tests
    {
        #region
        [Fact]
        public void ShouldRetrieveEnemyShipUFO()
        {
            // Arrange - Given
            var ufo =
                TypeOfShip.UFO;

            var expectedProperties =
                new UFO();

            // Act - When
            var actualProperties =
                EnemyShipFactory
                    .Create(ufo);


            // Assert - Then
            actualProperties.Should().BeEquivalentTo(expectedProperties);
        }

        [Fact]
        public void ShouldRetrieveEnemyShipRocket()
        {
            // Arrange - Given
            var rocket =
                TypeOfShip.Rocket;

            var expectedProperties =
                new Rocket();

            // Act - When
            var actualProperties =
                EnemyShipFactory
                    .Create(rocket);


            // Assert - Then
            actualProperties.Should().BeEquivalentTo(expectedProperties);
        }
        #endregion

        #region
        [Fact]
        public void ShouldCloneAnotherInstanceWithData()
        {
            // Arrange - Given
            var fadi = new Human { FirstName = "fadi", LastName = "dib" };
            var expectedHuman = new Human { FirstName = "mario", LastName = "dib" };

            // Act - When
            var actualHuman =
                fadi.Clone();

            actualHuman.FirstName = "mario";

            // Assert - Then
            actualHuman.Should().BeEquivalentTo(expectedHuman);
        }
        #endregion
    }
}
