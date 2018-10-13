using System.Collections.Generic;
using AutoFixture;
using FluentAssertions;
using Jupiter.Api.Controllers;
using Jupiter.Api.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace Jupiter.Api.Tests.Controllers
{
    [TestFixture]
    public sealed class HumansControllerTests
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
        public void Get_WhenRequestValid_ReturnsList()
        {
            // Arrange.
            var dependencies = new Dependencies();
            var controller = dependencies.Create();

            // Act.
            OkObjectResult Request() => controller.Get() as OkObjectResult;

            // Assert.

            Request().Value.Should().BeOfType<List<Human>>();
        }

        private class Dependencies : DependenciesBase<HumansController>
        {
            public override HumansController Create() => new HumansController();
        }
    }
}
