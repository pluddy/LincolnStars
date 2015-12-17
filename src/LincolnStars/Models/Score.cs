namespace LincolnStars.Models
{
    public class Score
    {
        public int Id { get; set; }

        public virtual Player Player { get; set; }

        public ScoreType Type { get; set; }
        
        public virtual Game Game { get; set; }
    }

    public enum ScoreType
    {
        Goal,
        Assist,
        Shot,
        GameWinningGoal
    }

    public class ScoreDto
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }

        public ScoreType Type { get; set; }
    }
}