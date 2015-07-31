using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveTriggers_RottenTomatoes
{
    class Movie : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private string _name;
        private string _rating;
        private int _year;
        private string _description;
        private string _image;


        public Movie(string title, string mpaaRating, int year, string synopsis, string poster)
        {
            _name = title;
            _rating = mpaaRating;
            _year = year;
            _description = synopsis;
            _image = poster;
        }

        public string Image
        {
            get { return _image; }
            set
            {
                _image = value;
                NotifyPropertyChanged("Image");
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }
        public string Rating
        {
            get { return _rating; }
            set
            {
                _rating = value;
                NotifyPropertyChanged("Rating");
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                _year = value;
                NotifyPropertyChanged("Year");
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
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
