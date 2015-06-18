using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveTriggers_RottenTomatoes
{
    class MoviesDataSource : ObservableCollection<Movie>
    {
        public MoviesDataSource(string call)
        {
            loadData(call);
        }

        //Load data from Rotten Tomatoes API
        async public void loadData(string call)
        {

            HttpClient ws = new HttpClient();
            var uri = new Uri(call);
            string obstring = await ws.GetStringAsync(uri);
            RottenTomatoes rt = JsonConvert.DeserializeObject<RottenTomatoes>(obstring);
            foreach (RottenTomatoes.RottenTomatoeMovie movie in rt.movies)
            {
                Movie temp = new Movie(movie.title, movie.mpaa_rating, movie.year, movie.synopsis,
                    movie.posters.thumbnail);
                this.Add(temp);
            }

            //Offline Testing

            //else
            //{
            //	for(int i = 0; i < 15; i++)
            //	{
            //		RottenTomatoes.RottenTomatoeMovie temp = new RottenTomatoes.RottenTomatoeMovie();
            //		temp.title = "Example"+ i;
            //		temp.mpaa_rating = "PG";  
            //		temp.posters = new RottenTomatoes.Posters();
            //		temp.posters.detailed ="test.jpg" ;   //Grab a local image to test with
            //		this.Add(temp);
            //	}
            //}

        }
    }
}
