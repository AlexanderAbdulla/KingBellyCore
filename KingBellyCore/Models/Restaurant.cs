using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KingBellyCore.Models
{
    public class Restaurant
    {
        public int id { get; set; }
        public string Title { get; set; }
        public int Stars { get; set; }
        public DateTime ReviewDate { get; set; }
        public string MainPicturePath { get; set; }
        public string ReviewtText { get; set; }

        public Restaurant (string Title, int Stars, string MainPicturePath, string ReviewText)
        {
            this.Title = Title;
            this.Stars = Stars;
            this.MainPicturePath = MainPicturePath;
            this.ReviewtText = ReviewtText;
        }
    }
}
