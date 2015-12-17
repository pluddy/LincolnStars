using System.Collections.Generic;

namespace LincolnStars.Models
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string WebsiteUrl { get; set; }

        public virtual Picture Logo { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        
        public virtual ICollection<Season> Seasons { get; set; }
        
        public virtual ICollection<ApplicationUser> Users { get; set; } 
    }

    public class TeamDto
    {
        public int TeamId { get; set; }

        public string Name { get; set; }

        public byte[] Logo { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string WebsiteUrl { get; set; }

        public ICollection<int> PlayerIds { get; set; }

        public ICollection<int> SeasonIds { get; set; }
    }
}
