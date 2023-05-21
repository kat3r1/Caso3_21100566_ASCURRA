using System;
using System.Collections.Generic;

namespace PARCIAL.DOMAIN.Core.Entities;

public partial class Player
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public bool? Dorsal { get; set; }
}
