namespace GastroWebsiteNew.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public List<Review> Reviews { get; set; }
        public List<string> ImagePaths { get; set; }
        public string Description { get; set; }
    }
}
