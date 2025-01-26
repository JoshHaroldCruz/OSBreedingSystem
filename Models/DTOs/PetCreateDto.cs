namespace OSBreedingSystem.Models.DTOs
{
    public class PetCreateDto
    {
        public string PetName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public DateTime? PetBirthdate { get; set; }
        public int BreedId { get; set; }
        public int CageId { get; set; }
        public string PetColor { get; set; } = string.Empty;
        public int? MotherPetId { get; set; }
        public int? FatherPetId { get; set; }
    }
}
