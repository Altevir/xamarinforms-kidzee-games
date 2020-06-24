using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using XFKidzeeZone.Models;

namespace XFKidzeeZone.Service
{
    public class DataService
    {
        public static ObservableCollection<Game> GetGames()
        {
            return new ObservableCollection<Game>()
            {
                new Game()
                {
                    name = "Super Mario Bros. 2",
                    company = "Nintendo Co. Ltd",
                    rating = 4.5,
                    image = "mario.png",
                    backgroundStartColor = "#EB507B",
                    backgroundEndColor = "#D92556",
                    genre = "Action",
                    install = 5.3,
                    reviewNumbers = 802,
                    about = "A new kind of Mario game that you can play with one hand. You control Mario by tapping as he constantly runs forward. You time yourtaps to pull off stylish jumps, midair spins, and wall jumps to gather coins and reach the goal!",
                    stars = new List<Star>()
                    {
                        new Star(){ number = 1 },
                        new Star(){ number = 2 },
                        new Star(){ number = 3 },
                        new Star(){ number = 4 },
                        new Star(){ number = 4.5 },
                    },
                    reviews = new List<Review>()
                    {
                        new Review() { order = 1, percentual = 5, progress = 0.05 },
                        new Review() { order = 2, percentual = 10, progress = 0.10 },
                        new Review() { order = 3, percentual = 20, progress = 0.20 },
                        new Review() { order = 4, percentual = 30, progress = 0.30 },
                        new Review() { order = 5, percentual = 48, progress = 0.40 }
                    }.OrderByDescending(p => p.order).ToList()
                },
                new Game()
                {
                    name = "Angry Bird Friends 2.0",
                    company = "Rovio Entertainment",
                    rating = 4,
                    image = "angry_birds.png",
                    backgroundStartColor = "#FBC25F",
                    backgroundEndColor = "#D99825",
                    genre = "Strategy",
                    install = 5.2,
                    reviewNumbers = 901,
                    about = "Play all of the classic bird-flinging, tower-crumbling and pig-popping of the original Angry Birds, condensed into bite-sized, competitive tournaments. Compete with your friends and players around the globe!",
                    stars = new List<Star>()
                    {
                        new Star(){ number = 1 },
                        new Star(){ number = 2 },
                        new Star(){ number = 3 },
                        new Star(){ number = 4 }
                    },
                    reviews = new List<Review>()
                    {
                        new Review() { order = 1, percentual = 4, progress = 0.04 },
                        new Review() { order = 2, percentual = 12, progress = 0.12 },
                        new Review() { order = 3, percentual = 25, progress = 0.25 },
                        new Review() { order = 4, percentual = 38, progress = 0.38 },
                        new Review() { order = 5, percentual = 50, progress = 0.5 }
                    }.OrderByDescending(p => p.order).ToList()
                },
                new Game()
                {
                    name = "Clash of Clans",
                    company = "Supercell",
                    rating = 4.5,
                    image = "clashofclans.png",
                    backgroundStartColor = "#71D7F6",
                    backgroundEndColor = "#13A1CC",
                    genre = "Strategy",
                    install = 7.1,
                    reviewNumbers = 892,
                    about = "Answer the call of the mustache! Join the international fray that is Clash of Clans. Customize your village, build an army and crush your opponents. Like using friendship to strike fear into your enemies? Join a Clan, or establish a Clashing legacy by creating your own. The choice is yours in this millions-strong community of Barbarians. Download for free and Clash on, Chief!",
                    stars = new List<Star>()
                    {
                        new Star(){ number = 1 },
                        new Star(){ number = 2 },
                        new Star(){ number = 3 },
                        new Star(){ number = 4 },
                        new Star(){ number = 4.5 },
                    },
                    reviews = new List<Review>()
                    {
                        new Review() { order = 1, percentual = 10, progress = 0.10 },
                        new Review() { order = 2, percentual = 20, progress = 0.20 },
                        new Review() { order = 3, percentual = 35, progress = 0.35 },
                        new Review() { order = 4, percentual = 45, progress = 0.45 },
                        new Review() { order = 5, percentual = 70, progress = 0.70 }
                    }.OrderByDescending(p => p.order).ToList()
                }
            };
        }

        public static ObservableCollection<BestOfWeek> GetBestOfWeeks()
        {
            return new ObservableCollection<BestOfWeek>()
            {
                new BestOfWeek()
                {
                    name = "Word Show - Legends",
                    company = "Etermax",
                    rating = 4.5,
                    image = "word.png"
                },
                new BestOfWeek()
                {
                    name = "Ludo Club",
                    company = "Moonfrog",
                    rating = 4.2,
                    image = "ludoclub"
                }
            };
        }
    }
}
