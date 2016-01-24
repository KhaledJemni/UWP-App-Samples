namespace TVMovieSample.Models.TV
{
    using System;

    public class TVBase
    {
        public string Title { get; set; }

        public string HeroImage { get; set; }

        public string Image { get; set; }

        public double Rating { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}