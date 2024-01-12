using System;
using System.Collections.Generic;

namespace MiradorWebAPI.DbModels
{
    public partial class Etablissement
    {
        public Etablissement()
        {
            EnseignantEtablissements = new HashSet<EnseignantEtablissement>();
            EtablissementRegroupements = new HashSet<EtablissementRegroupement>();
        }

        public string CodeEtablissement { get; set; } = null!;
        public string? CodeTypeEtablissement { get; set; }
        public string? CodeStatut { get; set; }
        public string? CodeSysteme { get; set; }
        public string? CodeTypeSociologique { get; set; }
        public string? CodeStatutPrive { get; set; }
        public string? NomEtablissement { get; set; }
        public string? Adresse { get; set; }
        public string? BoitePostale { get; set; }
        public string? Telephone { get; set; }
        public string? Telecopie { get; set; }
        public string? Mel { get; set; }
        public DateTime? DateCreation { get; set; }
        public string? CodeAdministratif { get; set; }
        public DateTime? DateReconnaissance { get; set; }
        public string? ReferenceAutorisation { get; set; }
        public string? NomChefEtablissement { get; set; }
        public string? CodeTypeStructureAdm { get; set; }
        public string? EcoleApplication { get; set; }
        public int? NbClasse { get; set; }
        public string? CodeAdministratifOld { get; set; }
        public string? EtabVerrouille { get; set; }
        public bool? EtabPrioriteFemme { get; set; }
        public string? OldCodeAdministratif { get; set; }
        public string? OldNomEtablissement { get; set; }
        public decimal? CodePi { get; set; }
        public decimal? CodePiLangue { get; set; }
        public int? EstPrioriteBillingue { get; set; }

        public virtual ICollection<EnseignantEtablissement> EnseignantEtablissements { get; set; }
        public virtual ICollection<EtablissementRegroupement> EtablissementRegroupements { get; set; }
    }
}
