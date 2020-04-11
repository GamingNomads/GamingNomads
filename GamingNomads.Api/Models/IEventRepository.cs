using GamingNomads.Shared.EventManager;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GamingNomads.Api.Models
{
    public interface IEventRepository
    {
        IEnumerable<Show> GetAllEvents();
        Show GetEventById(int id);
        Show AddEvent([FromBody] Show show);
        void UpdateEvent([FromBody] Show show);
        Show DeleteEvent(int id);
    }
}
