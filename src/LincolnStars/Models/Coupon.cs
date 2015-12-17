namespace LincolnStars.Models
{
    public class Coupon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public virtual Picture Picture { get; set; }
    }

    public class CouponDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }
    }
}