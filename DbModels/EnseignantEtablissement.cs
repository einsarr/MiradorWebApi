using System;
using System.Collections.Generic;

namespace MiradorWebAPI.DbModels
{
    public partial class EnseignantEtablissement
    {
        public int IdentifiantEnseignant { get; set; }
        public string CodeEtablissement { get; set; } = null!;
        public string? CodeAnnee { get; set; }
        public string? CodeSituation { get; set; }
        public int? NumeroOrdreEnseignant { get; set; }
        public bool? Temp { get; set; }
        public string? CreePar { get; set; }
        public DateTime? DateCreation { get; set; }
        public string? ModifiePar { get; set; }
        public DateTime? DateDerniereModification { get; set; }

        public virtual Etablissement CodeEtablissementNavigation { get; set; } = null!;
        public virtual Enseignant IdentifiantEnseignantNavigation { get; set; } = null!;
    }
}
