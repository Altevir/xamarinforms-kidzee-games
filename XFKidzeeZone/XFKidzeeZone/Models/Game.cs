using System.Collections.Generic;

namespace XFKidzeeZone.Models
{
    public class Game
    {
        public string name { get; set; }
        public string image { get; set; }
        public double rating { get; set; }
        public string company { get; set; }
        public string backgroundStartColor { get; set; }
        public string backgroundEndColor { get; set; }
        public double install { get; set; }
        public string genre { get; set; }
        public string about { get; set; }
        public int reviewNumbers { get; set; }
        public List<Star> stars { get; set; }
        public List<Review> reviews { get; set; }
    }

    public class Star
    {
        public double number { get; set; }
    }

    public class Review
    {
        public int order { get; set; }
        public double percentual { get; set; }
        public double progress { get; set; }
    }
}
