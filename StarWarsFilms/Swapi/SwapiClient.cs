using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using StarWarsFilms.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;

namespace StarWarsFilms
{
    public class SwapiClient
    {
        private ILogger _logger;
        public SwapiClient(ILogger logger)
        {
            _logger = logger;
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        static HttpClient client; 

        public async Task<IEnumerable<FilmViewModel>> GetFilmsAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://swapi.dev/api/films/");
                var result = await GetResponse<SwapiResult>(response);
                return result?.Films;
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
                return null;
            }
        }

        private static async Task<T> GetResponse<T>(HttpResponseMessage response)
        {
            var responseStringContent = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseStringContent);
        }
    }
}
