using System;
using System.Collections.Generic;

namespace OSBreedingSystem.Models;
public partial class Vet
{
    public int VetId { get; set; }

    public string? VetName { get; set; }

    public virtual ICollection<HealthRecord> HealthRecords { get; set; } = new List<HealthRecord>();
}
