namespace PicturesAPI.Models
{
    public class Photo
    {
        public string Id { get; set; }
        public DateTime PostDate { get; set; }
        public string Description { get; set; }
        public bool AllowComments { get; set; }
        public int Likes { get; set; }
        public string Comments { get; set; }
        public string UserId { get; set; }
    }
}
