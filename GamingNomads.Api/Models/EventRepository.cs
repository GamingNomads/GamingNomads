using GamingNomads.Shared.EventManager;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace GamingNomads.Api.Models
{
    public class EventRepository : IEventRepository
    {
        public Show AddEvent([FromBody] Show show)
        {
            throw new NotImplementedException();
        }

        public Show DeleteEvent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Show> GetAllEvents()
        {
            XElement EventsXML = GetEventsXML();
            IList<Show> result = new List<Show>();

            foreach (var data in EventsXML.Elements("Event"))
            {
                Show show = new Show();
                show.Id = int.Parse(data.Element("Id").Value);
                show.Name = data.Element("Name").Value;
                show.Year = int.Parse(data.Attribute("year").Value);
                show.Month = int.Parse(data.Attribute("month").Value);
                show.IsTentative = bool.Parse(data.Attribute("tentative").Value);
                show.URL = data.Element("URL").Value;
                show.DatesText = data.Element("Dates").Value;
                show.Games = XmlConvert.ToBoolean(data.Element("Games").Value);
                show.Artemis = XmlConvert.ToBoolean(data.Element("Artemis").Value);
                show.LaserTag = XmlConvert.ToBoolean(data.Element("LaserTag").Value);

                result.Add(show);
            }

            return result.AsEnumerable<Show>();
        }

        public Show GetEventById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEvent([FromBody] Show show)
        {
            throw new NotImplementedException();
        }

        private XElement GetEventsXML()
        {
            int index = 0;
            XElement result = new XElement("Events");

            result.Add(new XElement("Event",
                new XAttribute("year","2019"),
                new XAttribute("month","1"),
                new XAttribute("tentative","false"),
                new XElement("Id", (++index).ToString()),
                new XElement("Name", "Codemash V2.0.1.9"),
                new XElement("URL", "http://www.codemash.org"),
                new XElement("Dates", "January 8 - 11"),
                new XElement("Games", true),
                new XElement("Artemis", true),
                new XElement("LaserTag", true)));

            result.Add(new XElement("Event",
                new XAttribute("year", "2019"),
                new XAttribute("month", "1"),
                new XAttribute("tentative", "false"),
                new XElement("Id", (++index).ToString()),
                new XElement("Name", "AWH Teambuilding Event(Private)"),
                new XElement("URL", "http://awh.net"),
                new XElement("Dates", "January 14"),
                new XElement("Games", false),
                new XElement("Artemis", true),
                new XElement("LaserTag", false)));

            result.Add(new XElement("Event",
                new XAttribute("year", "2019"),
                new XAttribute("month", "3"),
                new XAttribute("tentative", "false"),
                new XElement("Id", (++index).ToString()),
                new XElement("Name", "Adepticon"),
                new XElement("URL", "http://www.adepticon.org"),
                new XElement("Dates", "March 27 - March 31"),
                new XElement("Games", true),
                new XElement("Artemis", true),
                new XElement("LaserTag", false)));

            result.Add(new XElement("Event",
                new XAttribute("year", "2019"),
                new XAttribute("month", "4"),
                new XAttribute("tentative", "false"),
                new XElement("Id", (++index).ToString()),
                new XElement("Name", "LexiCon"),
                new XElement("URL", "http://lexicongaming.com"),
                new XElement("Dates", "April 5 - 7"),
                new XElement("Games", true),
                new XElement("Artemis", true),
                new XElement("LaserTag", false)));

            result.Add(new XElement("Event",
                new XAttribute("year", "2019"),
                new XAttribute("month", "5"),
                new XAttribute("tentative", "true"),
                new XElement("Id", (++index).ToString()),
                new XElement("Name", "Rathacon"),
                new XElement("URL", "http://www.therathacon.com/"),
                new XElement("Dates", "May 12"),
                new XElement("Games", false),
                new XElement("Artemis", true),
                new XElement("LaserTag", false)));

            result.Add(new XElement("Event",
                new XAttribute("year", "2019"),
                new XAttribute("month", "6"),
                new XAttribute("tentative", "false"),
                new XElement("Id", (++index).ToString()),
                new XElement("Name", "Origins"),
                new XElement("URL", "http://www.originsgamefair.com"),
                new XElement("Dates", "June 12 - 16"),
                new XElement("Games", false),
                new XElement("Artemis", true),
                new XElement("LaserTag", true)));

            result.Add(new XElement("Event",
                new XAttribute("year", "2019"),
                new XAttribute("month", "7"),
                new XAttribute("tentative", "false"),
                new XElement("Id", (++index).ToString()),
                new XElement("Name", "Charcon"),
                new XElement("URL", "http://charcon.org"),
                new XElement("Dates", "July 20 - 22"),
                new XElement("Games", true),
                new XElement("Artemis", true),
                new XElement("LaserTag", false)));

            result.Add(new XElement("Event",
                new XAttribute("year", "2019"),
                new XAttribute("month", "7"),
                new XAttribute("tentative", "true"),
                new XElement("Id", (++index).ToString()),
                new XElement("Name", "WBC"),
                new XElement("URL", "https://www.boardgamers.org/wbcindex.html"),
                new XElement("Dates", "July 24 - 28"),
                new XElement("Games", true),
                new XElement("Artemis", false),
                new XElement("LaserTag", false)));

            result.Add(new XElement("Event",
                new XAttribute("year", "2019"),
                new XAttribute("month", "8"),
                new XAttribute("tentative", "false"),
                new XElement("Id", (++index).ToString()),
                new XElement("Name", "GenCon"),
                new XElement("URL", "http://www.gencon.com"),
                new XElement("Dates", "August 1 - 4"),
                new XElement("Games", false),
                new XElement("Artemis", false),
                new XElement("LaserTag", true)));

            result.Add(new XElement("Event",
                new XAttribute("year", "2019"),
                new XAttribute("month", "8"),
                new XAttribute("tentative", "false"),
                new XElement("Id", (++index).ToString()),
                new XElement("Name", "THAT Conference"),
                new XElement("URL", "http://www.thatconference.com/"),
                new XElement("Dates", "August 6 - 8"),
                new XElement("Games", false),
                new XElement("Artemis", true),
                new XElement("LaserTag", false)));

            result.Add(new XElement("Event",
                new XAttribute("year", "2019"),
                new XAttribute("month", "9"),
                new XAttribute("tentative", "false"),
                new XElement("Id", (++index).ToString()),
                new XElement("Name", "BGF"),
                new XElement("URL", "http://www.buckeyegamefest.com/"),
                new XElement("Dates", "September 12 - 15"),
                new XElement("Games", true),
                new XElement("Artemis", true),
                new XElement("LaserTag", false)));

            result.Add(new XElement("Event",
                new XAttribute("year", "2019"),
                new XAttribute("month", "9"),
                new XAttribute("tentative", "false"),
                new XElement("Id", (++index).ToString()),
                new XElement("Name", "GrandCon"),
                new XElement("URL", "http://www.grand-con.com/registration"),
                new XElement("Dates", "September 15 - 17"),
                new XElement("Games", true),
                new XElement("Artemis", true),
                new XElement("LaserTag", false)));

            result.Add(new XElement("Event",
                new XAttribute("year", "2019"),
                new XAttribute("month", "10"),
                new XAttribute("tentative", "false"),
                new XElement("Id", (++index).ToString()),
                new XElement("Name", "CinCityCon"),
                new XElement("URL", "http://cincitycon.com/"),
                new XElement("Dates", "October 11 - 13"),
                new XElement("Games", true),
                new XElement("Artemis", true),
                new XElement("LaserTag", false)));

            result.Add(new XElement("Event",
                new XAttribute("year", "2019"),
                new XAttribute("month", "11"),
                new XAttribute("tentative", "false"),
                new XElement("Id", (++index).ToString()),
                new XElement("Name", "AcadeCon"),
                new XElement("URL", "https://acadecon.com/"),
                new XElement("Dates", "November 8 - 10"),
                new XElement("Games", true),
                new XElement("Artemis", true),
                new XElement("LaserTag", false)));

            return result;
        }
    }
}
