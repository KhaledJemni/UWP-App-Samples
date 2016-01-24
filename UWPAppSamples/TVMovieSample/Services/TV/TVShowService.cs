namespace TVMovieSample.Services.TV
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using TVMovieSample.Enums;
    using TVMovieSample.Models.TV;

    public class TVShowService : ITVShowService
    {
        private readonly Random _rand = new Random();

        public TVShowService()
        {
            this.Shows = this.AcquireShows();
        }

        private List<Show> AcquireShows()
        {
            var shows = new List<Show>();

            // Fake data

            var showsToGenerate = this._rand.Next(50, 100);

            for (var i = 0; i < showsToGenerate; i++)
            {
                var show = new Show();

                // Generate show

                shows.Add(show);
            }

            return shows;
        }

        private List<Show> Shows { get; set; }

        public IEnumerable<Show> GetAllShows()
        {
            return this.Shows;
        }

        public IEnumerable<Show> GetShowsByGenre(Genre genre)
        {
            return this.Shows.Where(x => x.Genre.Equals(genre));
        }

        public IEnumerable<Show> GetShowsByCastMember(CastMember castMember)
        {
            return this.Shows.Where(x => x.Cast.Contains(castMember));
        }
    }
}