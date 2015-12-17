using System.Collections.Generic;

namespace LincolnStars.Models
{
    public class Player
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public int GamesPlayed { get; set; }

        public int PlusMinus { get; set; }

        public double PenaltyMinutes { get; set; }

        public virtual Team Team { get; set; }

        public virtual Picture Picture { get; set; }

        public virtual Card Card { get; set; }

        public virtual ICollection<Score> Scores { get; set; } 
    }

    public class PlayerDto
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte[] Picture { get; set; }

        public int CardId { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public int GamesPlayed { get; set; }

        public int Goals { get; set; }

        public int Assists { get; set; }

        public int Points { get; set; }

        public int PlusMinus { get; set; }

        public double PenaltyMinutes { get; set; }

        public int Shots { get; set; }

        public int GameWinningGoals { get; set; }

        public int TeamId { get; set; }
    }
}
