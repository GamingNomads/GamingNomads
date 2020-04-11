using FluentAssertions;
using GamingNomads.Api.Controllers;
using GamingNomads.Api.Models;
using GamingNomads.Shared.EventManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace ApiTests.Unit
{
    [TestClass]
    public class TestEventsController
    {
        [TestMethod]
        public void GetEvents_NoParams_AllEvents()
        {
            // Arrange
            var testEvents = TestUtilities.Utilities.GetTestEvents();
            var eventRepo = new Mock<IEventRepository>();
            eventRepo.Setup(e => e.GetAllEvents()).Returns(testEvents);
            var controller = new EventsController(eventRepo.Object);
            int total = 14;

            // Act
            Microsoft.AspNetCore.Mvc.IActionResult result = controller.GetEvents();

            // Assert
            result.Should().NotBeNull();
            var events = ((Microsoft.AspNetCore.Mvc.ObjectResult)result).Value.As<List<Show>>();
            events.Should().HaveCount(total);
            events.Should().BeEquivalentTo(testEvents);
        }
    }
}
