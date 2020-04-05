using GamingNomads.Shared.EventManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamingNomads.Server.Services
{
    public interface IEventDataService
    {
        Task<IEnumerable<Show>> GetAllEvents();
        Task<Show> GetEventDetails(int eventId);
        Task<Show> AddEvent(Show show);
        Task UpdateEvent(Show show);
        Task DeleteEvent(int eventId);
    }
}
