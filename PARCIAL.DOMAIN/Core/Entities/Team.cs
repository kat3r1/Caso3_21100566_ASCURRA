using System;
using System.Collections.Generic;

namespace PARCIAL.DOMAIN.Core.Entities;

public partial class Team
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? Country { get; set; }
}
