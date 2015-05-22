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

        public Movie(string Name, string Rating, int Year)
        {
            name = "Name";
            rating = "Rating";
            year = 1991;
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

        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
