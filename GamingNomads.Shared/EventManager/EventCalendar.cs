using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace GamingNomads.Shared.EventManager
{
    public class EventCalendar
    {
        public List<Show> Events { get; set; }

        public EventCalendar(XElement xmlData)
        {
            Events = new List<Show>();

            foreach (var data in xmlData.Elements("Event"))
            {
                Show show = new Show()
                {
                    Name = data.Element("Name").Value,
                    URL = data.Element("URL").Value,
                    DatesText = data.Element("Dates").Value,
                    Games = XmlConvert.ToBoolean(data.Element("Games").Value),
                    Artemis = XmlConvert.ToBoolean(data.Element("Artemis").Value),
                    LaserTag = XmlConvert.ToBoolean(data.Element("LaserTag").Value)
                };

                Events.Add(show);
            }
        }
    }
}
