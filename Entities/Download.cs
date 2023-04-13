namespace KristalAbsheronAzAPI.Entities
{
    public class Download
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Format> Formats { get; set; }
    }
}
