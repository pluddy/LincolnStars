using System;
using System.Collections.Generic;

namespace LincolnStars.Models
{
    public class Game
    {
        public int Id { get; set; }
        
        public DateTime Date { get; set; }
        
        public virtual Team TeamHome { get; set; }
        
        public virtual Team TeamAway { get; set; }

        public virtual ICollection<Score> Scores { get; set; } 

        public virtual ICollection<FantasyTeam> FantasyTeams { get; set; } 
    }

    public class GameDto
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int Team1Id { get; set; }

        public int Team2Id { get; set; }

        public ICollection<ScoreDto> Scores { get; set; } 

        public ICollection<int> FantasyTeamIds { get; set; } 
    }
}