namespace KristalAbsheronAzAPI.Entities
{
    public class OngoingProject : CompletedProject
    {
        public ICollection<ProjectPhoto> StatusOfConstruction { get; set; }
    }
}
