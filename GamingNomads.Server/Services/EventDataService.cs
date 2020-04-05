using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using GamingNomads.Shared.EventManager;

namespace GamingNomads.Server.Services
{
    public class EventDataService : IEventDataService
    {
        private readonly HttpClient _httpClient;

        public EventDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<Show> AddEvent(Show show)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEvent(int eventId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Show>> GetAllEvents()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Show>>
                (await _httpClient.GetStreamAsync($"api/events"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public Task<Show> GetEventDetails(int eventId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEvent(Show show)
        {
            throw new NotImplementedException();
        }
    }
}
