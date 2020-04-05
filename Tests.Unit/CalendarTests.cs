using FluentAssertions;
using GamingNomads.Shared.EventManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;

namespace Tests.Unit
{
    [TestClass]
    public class CalendarTests
    {
        [TestMethod]
        public void GetCalendar_NoParameters_GoodCalendar()
        {
            // Arrange
            XElement xmlData = new XElement(
                new XElement("Events",
                    new XElement("Event",
                        new XElement("Name", "Event One"),
                        new XElement("URL", "http://www.EventUno.com"),
                        new XElement("Dates", "January 7-9"),
                        new XElement("Games", true),
                        new XElement("Artemis", true),
                        new XElement("LaserTag", true)
                    ),
                    new XElement("Event",
                        new XElement("Name", "Event Dos"),
                        new XElement("URL", "http://www.EventDos.org"),
                        new XElement("Dates", "February 17-19"),
                        new XElement("Games", false),
                        new XElement("Artemis", true),
                        new XElement("LaserTag", false)
                    )
                )
            );

            // Act
            var result = new EventCalendar(xmlData);

            // Assert
            result.Events.Should().NotBeNull();
            result.Events.Should().HaveCount(2);
            result.Events[0].Name.Should().Be("Event One");
            result.Events[0].URL.Should().Be("http://www.EventUno.com");
            result.Events[0].DatesText.Should().Be("January 7-9");
            result.Events[0].Games.Should().BeTrue();
            result.Events[0].Artemis.Should().BeTrue();
            result.Events[0].LaserTag.Should().BeTrue();
            result.Events[1].Name.Should().Be("Event Dos");
            result.Events[1].URL.Should().Be("http://www.EventDos.org");
            result.Events[1].DatesText.Should().Be("February 17-19");
            result.Events[1].Games.Should().BeFalse();
            result.Events[1].Artemis.Should().BeTrue();
            result.Events[1].LaserTag.Should().BeFalse();
        }
    }
}
