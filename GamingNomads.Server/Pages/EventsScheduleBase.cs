using GamingNomads.Server.Services;
using GamingNomads.Shared.EventManager;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GamingNomads.Server.Pages
{
    public class EventsScheduleBase : ComponentBase
    {
        [Inject]
        public IEventDataService EventDataService { get; set; }

        public IEnumerable<Show> EventCalendar { get; set; }

        protected override async Task OnInitializedAsync()
        {
            EventCalendar = (await EventDataService.GetAllEvents()).ToList();
        }
    }
}
