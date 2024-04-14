using System;
using System.Collections.Generic;

namespace Saavadmyofos_Menejmenti.DbModels;

public partial class Wamlebi
{
    public int WamlisId { get; set; }

    public string? WamlisSaxeli { get; set; }

    public int? EqimisId { get; set; }

    public int? PacientisId { get; set; }

    public DateTime? Daemata { get; set; }
}
