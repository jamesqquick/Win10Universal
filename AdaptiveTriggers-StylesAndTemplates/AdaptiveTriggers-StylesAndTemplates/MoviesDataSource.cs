using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Uni_RT_SharedStyles
{
    class MoviesDataSource:ObservableCollection<RottenTomatoes.RottenTomatoeMovie>
    {
        public MoviesDataSource(string call)
        {
            loadData(call);
        }

        //Load data from Rotten Tomatoes API
        async public void loadData(string call)
        {
			//if internet connection
			if (true == false)
			{
				//HttpClient ws = new HttpClient();
				//var uri = new Uri(call);
				//string obstring = await ws.GetStringAsync(uri);
				// var settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
				//RottenTomatoes rt = (RottenTomatoes)JsonConvert.DeserializeObject<RottenTomatoes>(obstring, settings);
				//foreach (RottenTomatoes.RottenTomatoeMovie movie in rt.movies)
				//{
				//	//High Res Images have been deprecated
				//	//Manually alter url to get Detailed Image
				//	movie.posters.detailed = movie.posters.detailed.Replace("tmb", "det");
				//	this.Add(movie);
				//}
			}
			else
			{
				for(int i = 0; i < 15; i++)
				{
					RottenTomatoes.RottenTomatoeMovie temp = new RottenTomatoes.RottenTomatoeMovie();
					temp.title = "Lily"+ i;
					temp.mpaa_rating = "PG";
					temp.posters = new RottenTomatoes.Posters();
					Uri uri = new Uri("test.jpg", UriKind.Relative);
					temp.posters.detailed ="test.jpg" ;
					this.Add(temp);
				}
			}
           
        }
    }
}
