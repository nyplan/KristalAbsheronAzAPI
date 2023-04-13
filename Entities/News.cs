namespace KristalAbsheronAzAPI.Entities
{
    public class News
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public ICollection<NewsPhoto> Photos { get; set; }
    }
}
