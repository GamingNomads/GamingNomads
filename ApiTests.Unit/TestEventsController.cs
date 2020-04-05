using AutoMoq;
using FluentAssertions;
using GamingNomads.Api.Controllers;
using GamingNomads.Api.Models;
using GamingNomads.Shared.EventManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ApiTests.Unit
{
    [TestClass]
    public class TestEventsController
    {
        [TestMethod]
        public void GetAllEvents_NoParams_AllEvents()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var testEvents = GetTestEvents();
            var eventRepo = mocker.Create<EventRepository>();
            var controller = new EventsController(eventRepo);
            int total = 14;

            // Act
            var result = controller.GetEvents();

            // Assert
            result.Should().NotBeNull();
            var events = ((Microsoft.AspNetCore.Mvc.ObjectResult)result).Value.As<List<Show>>();
            events.Should().HaveCount(total);
            events.Should().BeEquivalentTo(testEvents);
        }

        private IEnumerable<Show> GetTestEvents()
        {
            int index = 0;
            IList<Show> result = new List<Show>();

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "January 8 - 11",
                Games = true,
                Id = ++index,
                LaserTag = true,
                Name = "Codemash V2.0.1.9",
                URL = "http://www.codemash.org"
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "January 14",
                Games = false,
                Id = ++index,
                LaserTag = false,
                Name = "AWH Teambuilding Event(Private)",
                URL = "http://awh.net"
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "March 27 - March 31",
                Games = true,
                Id = ++index,
                LaserTag = false,
                Name = "Adepticon",
                URL = "http://www.adepticon.org"
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "April 5 - 7",
                Games = true,
                Id = ++index,
                LaserTag = false,
                Name = "LexiCon",
                URL = "http://lexicongaming.com"
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "May 12",
                Games = false,
                Id = ++index,
                LaserTag = false,
                Name = "Rathacon ?",
                URL = "http://www.therathacon.com/"
            }); 

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "June 12 - 16",
                Games = false,
                Id = ++index,
                LaserTag = true,
                Name = "Origins",
                URL = "http://www.originsgamefair.com"
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "July 20 - 22",
                Games = true,
                Id = ++index,
                LaserTag = false,
                Name = "Charcon",
                URL = "http://charcon.org"
            });

            result.Add(new Show
            {
                Artemis = false,
                DatesText = "July 24 - 28",
                Games = true,
                Id = ++index,
                LaserTag = false,
                Name = "WBC ?",
                URL = "https://www.boardgamers.org/wbcindex.html"
            });

            result.Add(new Show
            {
                Artemis = false,
                DatesText = "August 1 - 4",
                Games = false,
                Id = ++index,
                LaserTag = true,
                Name = "GenCon",
                URL = "http://www.gencon.com"
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "August 6 - 8",
                Games = false,
                Id = ++index,
                LaserTag = false,
                Name = "THAT Conference",
                URL = "http://www.thatconference.com/"
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "September 15 - 17",
                Games = true,
                Id = ++index,
                LaserTag = false,
                Name = "GrandCon",
                URL = "http://www.grand-con.com/registration"
            }); 

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "September 12 - 15",
                Games = true,
                Id = ++index,
                LaserTag = false,
                Name = "BGF",
                URL = "http://www.buckeyegamefest.com/"
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "October 11 - 13",
                Games = true,
                Id = ++index,
                LaserTag = false,
                Name = "CinCityCon",
                URL = "http://cincitycon.com/"
            }); 

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "November 8 - 10",
                Games = true,
                Id = ++index,
                LaserTag = false,
                Name = "AcadeCon",
                URL = "https://acadecon.com/"
            }); 

            return result;
        }
        //private XElement GetTestEvents()
        //{
        //    XElement result = new XElement("Events");

        //    result.Add(new XElement("Event",
        //        new XElement("Name", "Codemash V2.0.1.9"),
        //        new XElement("URL", "http://www.codemash.org"),
        //        new XElement("Dates", "January 8 - 11"),
        //        new XElement("Games", true),
        //        new XElement("Artemis", true),
        //        new XElement("LaserTag", true)));

        //    result.Add(new XElement("Event",
        //        new XElement("Name", "AWH Teambuilding Event(Private)"),
        //        new XElement("URL", "http://awh.net"),
        //        new XElement("Dates", "January 14"),
        //        new XElement("Games", false),
        //        new XElement("Artemis", true),
        //        new XElement("LaserTag", false)));

        //    result.Add(new XElement("Event",
        //        new XElement("Name", "Adepticon"),
        //        new XElement("URL", "http://www.adepticon.org"),
        //        new XElement("Dates", "March 27 - March 31"),
        //        new XElement("Games", true),
        //        new XElement("Artemis", true),
        //        new XElement("LaserTag", false)));

        //    result.Add(new XElement("Event",
        //        new XElement("Name", "LexiCon"),
        //        new XElement("URL", "http://lexicongaming.com"),
        //        new XElement("Dates", "April 5 - 7"),
        //        new XElement("Games", true),
        //        new XElement("Artemis", true),
        //        new XElement("LaserTag", false)));

        //    result.Add(new XElement("Event",
        //        new XElement("Name", "Rathacon ?"),
        //        new XElement("URL", "http ://www.therathacon.com/"),
        //        new XElement("Dates", "May 12"),
        //        new XElement("Games", false),
        //        new XElement("Artemis", true),
        //        new XElement("LaserTag", false)));

        //    result.Add(new XElement("Event",
        //        new XElement("Name", "Origins"),
        //        new XElement("URL", "http://www.originsgamefair.com"),
        //        new XElement("Dates", "June 12 - 16"),
        //        new XElement("Games", false),
        //        new XElement("Artemis", true),
        //        new XElement("LaserTag", true)));

        //    result.Add(new XElement("Event",
        //        new XElement("Name", "Charcon"),
        //        new XElement("URL", "http://charcon.org"),
        //        new XElement("Dates", "July 20 - 22"),
        //        new XElement("Games", true),
        //        new XElement("Artemis", true),
        //        new XElement("LaserTag", false)));

        //    result.Add(new XElement("Event",
        //        new XElement("Name", "WBC ?"),
        //        new XElement("URL", "https ://www.boardgamers.org/wbcindex.html"),
        //        new XElement("Dates", "July 24 - 28"),
        //        new XElement("Games", true),
        //        new XElement("Artemis", false),
        //        new XElement("LaserTag", false)));

        //    result.Add(new XElement("Event",
        //        new XElement("Name", "GenCon"),
        //        new XElement("URL", "http://www.gencon.com"),
        //        new XElement("Dates", "August 1 - 4"),
        //        new XElement("Games", false),
        //        new XElement("Artemis", false),
        //        new XElement("LaserTag", true)));

        //    result.Add(new XElement("Event",
        //        new XElement("Name", "THAT Conference"),
        //        new XElement("URL", "http://www.thatconference.com/"),
        //        new XElement("Dates", "August 6 - 8"),
        //        new XElement("Games", false),
        //        new XElement("Artemis", true),
        //        new XElement("LaserTag", false)));

        //    result.Add(new XElement("Event",
        //        new XElement("Name", "GrandCon"),
        //        new XElement("URL", "http://www.grand-con.com/registration"),
        //        new XElement("Dates", "September 15 - 17"),
        //        new XElement("Games", true),
        //        new XElement("Artemis", true),
        //        new XElement("LaserTag", false)));

        //    result.Add(new XElement("Event",
        //        new XElement("Name", "BGF"),
        //        new XElement("URL", "http://www.buckeyegamefest.com/"),
        //        new XElement("Dates", "September 12 - 15"),
        //        new XElement("Games", true),
        //        new XElement("Artemis", true),
        //        new XElement("LaserTag", false)));

        //    result.Add(new XElement("Event",
        //        new XElement("Name", "CinCityCon"),
        //        new XElement("URL", "http://cincitycon.com/"),
        //        new XElement("Dates", "October 11 - 13"),
        //        new XElement("Games", true),
        //        new XElement("Artemis", true),
        //        new XElement("LaserTag", false)));

        //    result.Add(new XElement("Event",
        //        new XElement("Name", "AcadeCon"),
        //        new XElement("URL", "https://https://acadecon.com/"),
        //        new XElement("Dates", "November 8 - 10"),
        //        new XElement("Games", true),
        //        new XElement("Artemis", true),
        //        new XElement("LaserTag", false)));

        //    return result;
        //}
    }
}
