namespace TVMovieSample.Models.TV
{
    using System.Collections.Generic;

    public class Season : TVBase
    {
        public Season()
        {
            this.Episodes = new List<Episode>();
        }

        public List<Episode> Episodes { get; private set; } 

        public int Number { get; set; }
    }
}
