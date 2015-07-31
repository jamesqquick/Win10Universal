using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveTriggers_RottenTomatoes
{
    //Rotten Tomatoes Object Model
    class RottenTomatoes
    {

        public int Total { get; set; }
        public List<RottenTomatoeMovie> Movies { get; set; }
        public Links2 links { get; set; }
        public string LinkTemplate { get; set; }

        public class ReleaseDates
        {
            public string Theater { get; set; }
        }

        public class Ratings
        {
            public string CriticsRating { get; set; }
            public int CriticsScore { get; set; }
            public string AudienceRating { get; set; }
            public int AudienceScore { get; set; }
        }

        public class Posters
        {
            public string Thumbnail { get; set; }
            public string Profile { get; set; }
            public string Detailed { get; set; }
            public string Original { get; set; }
        }

        public class AbridgedCast
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public List<string> Characters { get; set; }
        }

        public class AlternateIds
        {
            public string Imdb { get; set; }
        }

        public class Links
        {
            public string Self { get; set; }
            public string Alternate { get; set; }
            public string Cast { get; set; }
            public string Clips { get; set; }
            public string Reviews { get; set; }
            public string Similar { get; set; }
        }

        public class RottenTomatoeMovie
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public int Year { get; set; }
            public string MpaaRating { get; set; }
            public int Runtime { get; set; }
            public string CriticsConsensus { get; set; }
            public ReleaseDates ReleaseDates { get; set; }
            public Ratings Ratings { get; set; }
            public string Synopsis { get; set; }
            public Posters Posters { get; set; }
            public List<AbridgedCast> AbridgedCast { get; set; }
            public AlternateIds AlternateIds { get; set; }
            public Links Links { get; set; }
        }

        public class Links2
        {
            public string Self { get; set; }
            public string Next { get; set; }
            public string Alternate { get; set; }
        }


    }
}
