namespace GastroWebsiteNew.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public int PlaceId { get; set; }
        public Place Place { get; set; }
    }
}
