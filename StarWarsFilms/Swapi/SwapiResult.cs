using System;
using System.Collections.Generic;

namespace StarWarsFilms
{
    public class SwapiResult
    {
        [Newtonsoft.Json.JsonProperty("count")]
        public int Count { get; set; }

        [Newtonsoft.Json.JsonProperty("results")]
        public IEnumerable<Models.FilmViewModel> Films { get; set; }
    }
}
