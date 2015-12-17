using System.Collections.Generic;

namespace LincolnStars.Models
{
    public class FantasyTeam
    {
        public int Id { get; set; }
        
        public virtual Game Game { get; set; }

        public virtual ApplicationUser User { get; set; }
        
        public virtual ICollection<Player> Players { get; set; }
    }

    public class FantasyTeamDto
    {
        public int Id { get; set; }

        public int GameId { get; set; }

        public int Points { get; set; }

        public ICollection<int> PlayerIds { get; set; }
    }
}