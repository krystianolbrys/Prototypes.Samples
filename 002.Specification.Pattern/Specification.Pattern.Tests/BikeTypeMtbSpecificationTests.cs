using FluentAssertions;
using NUnit.Framework;
using Specification.Pattern.Models;
using Specification.Pattern.Models.Enums;
using Specification.Pattern.Specification;

namespace Specification.Pattern.Tests
{
    [TestFixture]
    public class BikeTypeMtbSpecificationTests
    {
        private int _validNumber;

        [SetUp]
        public void SetUp()
        {
            _validNumber = 1337;
        }

        [Test]
        public void BikeTypeMtbSpecification_GivenEnduroBike_ReturnsFalse()
        {
            // Arrange
            var sut = new Bike(BikeType.Enduro, _validNumber);
            var specification = new BikeTypeMtbSpecification();

            // Act
            var result = specification.IsSatisfiedBy(sut);

            // Assert
            result.Should().BeFalse();
        }

        [Test]
        public void BikeTypeMtbSpecification_GivenMtbBike_ReturnsTrue()
        {
            // Arrange
            var sut = new Bike(BikeType.Mtb, _validNumber);
            var specification = new BikeTypeMtbSpecification();

            // Act
            var result = specification.IsSatisfiedBy(sut);

            // Assert
            result.Should().BeTrue();
        }
    }
}
