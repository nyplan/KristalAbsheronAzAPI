using KristalAbsheronAzAPI.Entities;

namespace KristalAbsheronAzAPI.DTOs.ProjectDTOs
{
    public record ProjectToAddDto
    {
        public string TermsOfSale { get; set; }
        public int StatusId { get; set; }
        public string Address { get; set; }
        public string AboutTheProject { get; set; }
        public bool IsPremium { get; set; }
        public ICollection<PlanOfApartment> PlanOfApartments { get; set; }
        public ICollection<ProjectPhoto> PhotoGallery { get; set; }
        public ICollection<ProjectPhoto> StatusOfConstruction { get; set; }
    }
}
