using System;
using System.Collections.Generic;

namespace Saavadmyofos_Menejmenti.DbModels;

public partial class Simptomebi
{
    public int SimptomisId { get; set; }

    public string? Simptomi { get; set; }

    public int? PacientisId { get; set; }

    public DateTime? Daemata { get; set; }
}
