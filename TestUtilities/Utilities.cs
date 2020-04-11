using GamingNomads.Shared.EventManager;
using System.Collections.Generic;

namespace TestUtilities
{
    public static class Utilities
    {
        public static IEnumerable<Show> GetTestEvents()
        {
            int index = 0;
            IList<Show> result = new List<Show>();

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "January 8 - 11",
                Games = true,
                Id = ++index,
                IsTentative = false,
                LaserTag = true,
                Month = 1,
                Name = "Codemash V2.0.1.9",
                URL = "http://www.codemash.org",
                Year = 2019
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "January 14",
                Games = false,
                Id = ++index,
                IsTentative = false,
                LaserTag = false,
                Month = 1,
                Name = "AWH Teambuilding Event(Private)",
                URL = "http://awh.net",
                Year = 2019
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "March 27 - March 31",
                Games = true,
                Id = ++index,
                IsTentative = false,
                LaserTag = false,
                Month = 3,
                Name = "Adepticon",
                URL = "http://www.adepticon.org",
                Year = 2019
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "April 5 - 7",
                Games = true,
                Id = ++index,
                IsTentative = false,
                LaserTag = false,
                Month = 4,
                Name = "LexiCon",
                URL = "http://lexicongaming.com",
                Year = 2019
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "May 12",
                Games = false,
                Id = ++index,
                IsTentative = true,
                LaserTag = false,
                Month = 5,
                Name = "Rathacon",
                URL = "http://www.therathacon.com/",
                Year = 2019
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "June 12 - 16",
                Games = false,
                Id = ++index,
                IsTentative = false,
                LaserTag = true,
                Month = 6,
                Name = "Origins",
                URL = "http://www.originsgamefair.com",
                Year = 2019
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "July 20 - 22",
                Games = true,
                Id = ++index,
                IsTentative = false,
                LaserTag = false,
                Month = 7,
                Name = "Charcon",
                URL = "http://charcon.org",
                Year = 2019
            });

            result.Add(new Show
            {
                Artemis = false,
                DatesText = "July 24 - 28",
                Games = true,
                Id = ++index,
                IsTentative = true,
                LaserTag = false,
                Month = 7,
                Name = "WBC",
                URL = "https://www.boardgamers.org/wbcindex.html",
                Year = 2019
            });

            result.Add(new Show
            {
                Artemis = false,
                DatesText = "August 1 - 4",
                Games = false,
                Id = ++index,
                IsTentative = false,
                LaserTag = true,
                Month = 8,
                Name = "GenCon",
                URL = "http://www.gencon.com",
                Year = 2019
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "August 6 - 8",
                Games = false,
                Id = ++index,
                IsTentative = false,
                LaserTag = false,
                Month = 8,
                Name = "THAT Conference",
                URL = "http://www.thatconference.com/",
                Year = 2019
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "September 12 - 15",
                Games = true,
                Id = ++index,
                IsTentative = false,
                LaserTag = false,
                Month = 9,
                Name = "BGF",
                URL = "http://www.buckeyegamefest.com/",
                Year = 2019
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "September 15 - 17",
                Games = true,
                Id = ++index,
                IsTentative = false,
                LaserTag = false,
                Month = 9,
                Name = "GrandCon",
                URL = "http://www.grand-con.com/registration",
                Year = 2019
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "October 11 - 13",
                Games = true,
                Id = ++index,
                IsTentative = false,
                LaserTag = false,
                Month = 10,
                Name = "CinCityCon",
                URL = "http://cincitycon.com/",
                Year = 2019
            });

            result.Add(new Show
            {
                Artemis = true,
                DatesText = "November 8 - 10",
                Games = true,
                Id = ++index,
                IsTentative = false,
                LaserTag = false,
                Month = 11,
                Name = "AcadeCon",
                URL = "https://acadecon.com/",
                Year = 2019
            });

            return result;
        }
    }
}
