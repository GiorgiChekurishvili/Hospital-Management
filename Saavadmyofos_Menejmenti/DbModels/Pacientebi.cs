using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saavadmyofos_Menejmenti.DbModels;

public partial class Pacientebi
{
    public int PacientisId { get; set; }

    public string Saxeli { get; set; } = null!;

    public string Gvari { get; set; } = null!;

    public long? PiradiNomeri { get; set; }

    public string Sqesi { get; set; } = null!;

    public int Asaki { get; set; }

    public string? Email { get; set; }

    public int MobilurisNomeri { get; set; }

    public string? SisxlisJgufi { get; set; }

    public int? Dazghveva { get; set; }

    public int GadasakhdeliTankha { get; set; }

    public int? GadasakhdeliDazghvevit { get; set; }

    public int? EqimisId { get; set; }

    public DateTime? Daemata { get; set; }

    [ForeignKey("EqimisId")]
    public Eqimebi eqimebi { get; set; }
}
