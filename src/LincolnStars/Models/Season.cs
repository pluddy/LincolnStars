using System.Collections.Generic;

namespace LincolnStars.Models
{
    public class Season
    {
        public int Id { get; set; }

        public int YearFrom { get; set; }

        public int YearTo { get; set; }

        public virtual League League { get; set; }

        public virtual ICollection<Game> Games { get; set; } 
    }

    public class SeasonDto
    {
        public int Id { get; set; }

        public int YearFrom { get; set; }

        public int YearTo { get; set; }

        public int LeagueId { get; set; }

        public ICollection<int> GameIds { get; set; }
    }
}