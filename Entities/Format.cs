namespace KristalAbsheronAzAPI.Entities
{
    public class Format
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public ICollection<Download> Downloads { get; set; }
    }
}
