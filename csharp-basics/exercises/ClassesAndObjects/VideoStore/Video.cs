using System.Collections.Generic;
using System;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        public string _title { get; set; }
        public bool checked_out { get; private set; }
        private List<double> _rating { get; set; }
        public Video(string title, double average_user_rating)
        {
            _title = title;
            _rating = new List<double>{average_user_rating};
        }

        public Video(string title)
        {
            _title = title;
            _rating = new List<double>();
        }

        public void BeingCheckedOut()
        {
            checked_out = true;
        }

        public void BeingReturned()
        {
            checked_out = false;
        }

        public void ReceivingRating(double rating)
        {
            _rating.Add(rating);
        }

        public double AverageRating()
        {
            return _rating.Average();
        }

        public bool Available()
        {
            return checked_out;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
