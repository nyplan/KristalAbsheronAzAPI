namespace KristalAbsheronAzAPI.Entities
{
    public class ProjectPhoto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int ProjectId { get; set; }
        public CompletedProject Project { get; set; }
    }
}
