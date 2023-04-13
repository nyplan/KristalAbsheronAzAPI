using System.Reflection.Metadata.Ecma335;

namespace KristalAbsheronAzAPI.Entities
{
    public class PlanOfApartment
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public CompletedProject Project { get; set; }
        public string PlanName { get; set; }
        public int NumberOfRooms { get; set; }
        public double Area { get; set; }
        public int NumberOfWindows { get; set; }
        public bool Repaired { get; set; }
        public bool Parking { get; set; }
    }
}
