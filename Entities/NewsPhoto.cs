namespace KristalAbsheronAzAPI.Entities
{
    public class NewsPhoto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int NewsId { get; set; }
        public News News { get; set; }
    }
}
