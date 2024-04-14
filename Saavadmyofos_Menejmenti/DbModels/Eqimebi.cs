using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saavadmyofos_Menejmenti.DbModels;

public partial class Eqimebi
{
    public int EqimisId { get; set; }

    public string Saxeli { get; set; }

    public string Gvari { get; set; }

    public long? PiradiNomeri { get; set; }

    public int Asaki { get; set; }

    public string Profesia { get; set; }

    public int GamocdilebaWeli { get; set; }

    public string? Email { get; set; }

    public int MobilurisNomeri { get; set; }

    public int? WvdomisId { get; set; }

    public DateTime? Daemata { get; set; }

    [ForeignKey("WvdomisId")]
    public Wvdoma? wvdoma { get; set; }
}
