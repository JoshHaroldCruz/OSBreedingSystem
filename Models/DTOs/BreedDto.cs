using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSBreedingSystem.Models.DTOs
{
    public class BreedDto
    {
        public int BreedId { get; set; }
        public string BreedName { get; set; }
        public int SpeciesId { get; set; }
    }
}
