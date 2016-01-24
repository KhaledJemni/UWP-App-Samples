namespace TVMovieSample.Services.TV
{
    using System.Collections.Generic;

    using TVMovieSample.Enums;
    using TVMovieSample.Models.TV;

    public interface ITVShowService
    {
        IEnumerable<Show> GetAllShows();

        IEnumerable<Show> GetShowsByGenre(Genre genre);

        IEnumerable<Show> GetShowsByCastMember(CastMember castMember);
    }
}
