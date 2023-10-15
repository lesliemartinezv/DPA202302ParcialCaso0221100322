using System;
using System.Collections.Generic;

namespace DPA202302ParcialCaso0221100322.Models;

public partial class Country
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int? Code { get; set; }

    public int? Currency { get; set; }
}
