namespace KristalAbsheronAzAPI.Entities
{
    public class CompletedProject
    {
        public int Id { get; set; }
        public string TermsOfSale { get; set; }
        public int StatusId { get; set; }
        public EnumValue Status { get; set; }
        public string Address { get; set; }
        public string AboutTheProject { get; set; }
        public bool IsPremium { get; set; }
        public ICollection<PlanOfApartment> PlanOfApartments { get; set; }
        public ICollection<ProjectPhoto> PhotoGallery { get; set; }
    }
}
