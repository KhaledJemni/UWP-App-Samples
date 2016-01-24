namespace TVMovieSample.Models.TV
{
    using System.Collections.Generic;

    using TVMovieSample.Enums;

    public class Show : TVBase
    {
        public Show()
        {
            this.Seasons = new List<Season>();
            this.Cast = new List<CastMember>();
        }

        public Genre Genre { get; set; }

        public List<Season> Seasons { get; private set; }

        public List<CastMember> Cast { get; private set; }
    }
}