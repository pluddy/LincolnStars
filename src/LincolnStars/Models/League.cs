using System.Collections.Generic;

namespace LincolnStars.Models
{
    public class League
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public virtual ICollection<Team> Team { get; set; }
        
        public virtual ICollection<Season> Seasons { get; set; } 
    }
}