using System;
using System.Collections.Generic;

namespace OSBreedingSystem.Models;
public partial class Conception
{
    public int ConceptionId { get; set; }

    public int? PetId { get; set; }

    public string? Status { get; set; }

    public string? Notes { get; set; }

    public virtual Pet? Pet { get; set; }
}
