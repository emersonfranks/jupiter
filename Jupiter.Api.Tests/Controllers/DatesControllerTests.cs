using System;
using AutoFixture;
using FluentAssertions;
using Jupiter.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace Jupiter.Api.Tests.Controllers
{
    [TestFixture]
    public sealed class DatesControllerTests
    {
        private readonly Fixture fixture = new Fixture();

        [Test]
        public void Ctor_WhenInstantiated_Succeeds()
        {
            // Arrange, Act.
            var dependencies = new Dependencies();
            var controller = dependencies.Create();

            // Assert.
            controller.Should().NotBeNull();
        }

        [Test]
        public void Get_WhenValid_Returns200()
        {
            // Arrange.
            var dependencies = new Dependencies();
            var controller = dependencies.Create();

            // Act.
            OkObjectResult Request() => controller.Get() as OkObjectResult;

            // Assert.
            Request().StatusCode.Should().Be(200);
        }

        [Test]
        public void GetDayNumberFromDateTime_WhenGivenValidDateTime_Returns200()
        {
            // Arrange.
            var dependencies = new Dependencies();
            var controller = dependencies.Create();
            var dateTime = fixture.Create<DateTime>();

            // Act.
            OkObjectResult Request() => controller.GetDayNumberFromDateTime(dateTime) as OkObjectResult;

            // Assert.
            Request().StatusCode.Should().Be(200);
        }

        [Test]
        public void GetDayNumberFromDateTime_WhenGivenValidDateTime_ReturnsCorrectDay()
        {
            // Arrange.
            var dependencies = new Dependencies();
            var controller = dependencies.Create();
            var dateTime = fixture.Create<DateTime>();

            // Act.
            OkObjectResult Request() => controller.GetDayNumberFromDateTime(dateTime) as OkObjectResult;

            // Assert.
            Request().Value.Should().Be(dateTime.DayOfYear);
        }

        [Test]
        public void GetUtcDateTime_WhenRequestValid_Returns200()
        {
            // Arrange.
            var dependencies = new Dependencies();
            var controller = dependencies.Create();

            // Act.
            OkObjectResult Request() => controller.GetUtcDateTime() as OkObjectResult;

            // Assert.
            Request().StatusCode.Should().Be(200);
        }

        private class Dependencies : DependenciesBase<DatesController>
        {
            public override DatesController Create() => new DatesController();
        }
    }
}
