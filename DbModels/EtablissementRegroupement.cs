using System;
using System.Collections.Generic;

namespace MiradorWebAPI.DbModels
{
    public partial class EtablissementRegroupement
    {
        public string CodeEtablissement { get; set; } = null!;
        public string CodeRegroupement { get; set; } = null!;

        public virtual Etablissement CodeEtablissementNavigation { get; set; } = null!;
    }
}
