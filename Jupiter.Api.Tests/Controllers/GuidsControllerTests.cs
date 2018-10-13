using System;
using AutoFixture;
using FluentAssertions;
using Jupiter.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace Jupiter.Api.Tests.Controllers
{
    [TestFixture]
    public sealed class GuidsControllerTests
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
        public void GetWithQuery_WhenValid_Returns200()
        {
            // Arrange.
            var dependencies = new Dependencies();
            var controller = dependencies.Create();

            // Act.
            OkObjectResult Request() => controller.GetWithQuery() as OkObjectResult;

            // Assert.
            Request().StatusCode.Should().Be(200);
        }

        [Test]
        public void GetWithQuery_WhenRequestValid_ReturnsGuid()
        {
            // Arrange.
            var dependencies = new Dependencies();
            var controller = dependencies.Create();

            // Act.
            OkObjectResult Request() => controller.GetWithQuery() as OkObjectResult;
            var result = Guid.TryParse(Request().Value.ToString(), out _);

            // Assert.

            result.Should().BeTrue();
        }

        private class Dependencies : DependenciesBase<GuidsController>
        {
            public override GuidsController Create() => new GuidsController();
        }
    }
}
