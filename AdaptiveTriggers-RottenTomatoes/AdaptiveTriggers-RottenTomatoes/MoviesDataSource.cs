using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AdaptiveTriggers_RottenTomatoes
{
    class MoviesDataSource : ObservableCollection<Movie>
    {
        public MoviesDataSource(string call)
        {
            LoadData(call);
        }

        //Load data from Rotten Tomatoes API
        async public void LoadData(string call)
        {
            var ws = new HttpClient();
            var uri = new Uri(call);
            var obstring = await ws.GetStringAsync(uri);
            var rt = JsonConvert.DeserializeObject<RottenTomatoes>(obstring);
            foreach (RottenTomatoes.RottenTomatoeMovie movie in rt.Movies)
            {
                var temp = new Movie(movie.Title, movie.MpaaRating, movie.Year, movie.Synopsis,
                    movie.Posters.Thumbnail);
                this.Add(temp);
            }
        }
    }
}
