using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _VideoList;

        public VideoStore()
        {
            _VideoList = new List<Video>(); 
        }

        public void AddVideo(string title)
        {
            _VideoList.Add(new Video(title));
        }
        
        public void Checkout(string title)
        {
            foreach (var item in _VideoList)
            {
                if (item.Title == title)
                {
                    item.BeingCheckedOut();
                    break;
                }
            }
        }

        public void ReturnVideo(string title)
        {
            foreach (var item in _VideoList)
            {
                if (item.Title == title)
                {
                    item.BeingReturned();
                    break;
                }
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach (var item in _VideoList)
            {
                if (item.Title == title)
                {
                    item.ReceivingRating(rating);
                    break;
                }
            }
        }

        public void ListInventory()
        {
            foreach (Video film in _VideoList)
            {
                Console.WriteLine(film.ToString());
            }
        }
    }
}
