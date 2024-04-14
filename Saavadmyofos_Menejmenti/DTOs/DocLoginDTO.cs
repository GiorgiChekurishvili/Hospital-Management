using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saavadmyofos_Menejmenti.DTOs
{
    internal class DocLoginDTO
    {
        public int EqimisId { get; set; }

        public string Saxeli { get; set; } = null!;

        public string Gvari { get; set; } = null!;

        public long? PiradiNomeri { get; set; }

        public int Asaki { get; set; }

        public string Profesia { get; set; } = null!;

        public int GamocdilebaWeli { get; set; }

        public string? Email { get; set; }

        public int MobilurisNomeri { get; set; }

        public string? MomkhmareblisSaxeli { get; set; }

        public string? Paroli { get; set; }

        public DateTime? Daemata { get; set; }
    }
}
