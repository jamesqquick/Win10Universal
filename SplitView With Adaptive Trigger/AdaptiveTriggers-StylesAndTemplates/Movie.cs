using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Uni_RT_SharedStyles
{
    class Movie : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private string name;
        private string rating;
        private int year;
		private string description;
		private string image;


        public Movie(string Title, string MPAA_Rating, int Year, string synopsis, string poster)
        {
			name = Title;
			rating = MPAA_Rating;
			year = Year;
			description = synopsis;
			image = poster;
        }

		public string Image
		{
			get { return image; }
			set
			{
				image = value;
				NotifyPropertyChanged("Image");
			}
		}
		
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }
        public string Rating
        {
            get { return rating; }
            set
            {
                rating = value;
                NotifyPropertyChanged("Rating");
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                year = value;
                NotifyPropertyChanged("Year");
            }
        }

		public string Description
		{
			get { return description; }
			set
			{
				description = value;
				NotifyPropertyChanged("Description");
			}
		}

		protected virtual void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
