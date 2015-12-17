namespace LincolnStars.Models
{
    public class Card
    {
        public int Id { get; set; }
        
        public virtual Player Player { get; set; }
        
        public virtual Picture Picture { get; set; }

        public virtual Season Season { get; set; }

        public virtual Team Team { get; set; }
    }

    public class CardDto
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public byte[] Picture { get; set; }

        public int SeasonId { get; set; }

        public int TeamId { get; set; }
    }
}