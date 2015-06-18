using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using Newtonsoft.Json;

namespace Uni_RT_SharedStyles
{
    class MoviesDataSource:ObservableCollection<Movie>
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
				var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
				RottenTomatoes rt = (RottenTomatoes)JsonConvert.DeserializeObject<RottenTomatoes>(obstring, settings);
				foreach (RottenTomatoes.RottenTomatoeMovie movie in rt.movies)
				{
					Movie temp = new Movie(movie.title,movie.mpaa_rating, movie.year, movie.synopsis,
						movie.posters.thumbnail);
					this.Add(temp);
				}
			//else
			//{
			//	for(int i = 0; i < 15; i++)
			//	{
			//		RottenTomatoes.RottenTomatoeMovie temp = new RottenTomatoes.RottenTomatoeMovie();
			//		temp.title = "Lily"+ i;
			//		temp.mpaa_rating = "PG";
			//		temp.posters = new RottenTomatoes.Posters();
			//		Uri uri = new Uri("test.jpg", UriKind.Relative);
			//		temp.posters.detailed ="test.jpg" ;
			//		this.Add(temp);
			//	}
			//}
           
        }
    }
}
