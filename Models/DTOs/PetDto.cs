namespace OSBreedingSystem.Models.DTOs
{
    public class PetDto
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        public string Gender { get; set; }
        public DateTime? PetBirthdate { get; set; }
        public string CageNumber { get; set; }
        public string BreedName { get; set; }
        public string SpeciesName { get; set; }
    }
}
