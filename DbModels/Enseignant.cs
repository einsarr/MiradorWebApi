using System;
using System.Collections.Generic;

namespace MiradorWebAPI.DbModels
{
    public partial class Enseignant
    {
        public Enseignant()
        {
            EnseignantEtablissements = new HashSet<EnseignantEtablissement>();
        }

        public int IdentifiantEnseignant { get; set; }
        public string? CodeCorps { get; set; }
        public string? CodeDiplome { get; set; }
        public string? CodeDiplomeProfessionnel { get; set; }
        public string? CodeNationalite { get; set; }
        public string? CodeLangue { get; set; }
        public string? CodeEmployeur { get; set; }
        public string? CodeGrade { get; set; }
        public string? CodeEtablissement { get; set; }
        public string? CodeMatiere { get; set; }
        public string MatriculeEnseignant { get; set; } = null!;
        public string NomEnseignant { get; set; } = null!;
        public string? PrenomsEnseignant { get; set; }
        public string SexeEnseignant { get; set; } = null!;
        public DateTime? DateNaissEnseignant { get; set; }
        public DateTime? DateEntreeEtablissementEnse { get; set; }
        public DateTime? DateEntreeFonctionPublique { get; set; }
        public DateTime? DateEntreeEnseignementEnsei { get; set; }
        public int? VolumeHoraireDu { get; set; }
        public string? CodeFonction { get; set; }
        public string? CodeSpecialite { get; set; }
        public short? NbHeuresAssures { get; set; }
        public string? CodeStatutPersonnel { get; set; }
        public short? NbJourFormation { get; set; }
        public string? CodeTypePoste { get; set; }
        public bool? Ok { get; set; }
        public decimal? CodeMouvement { get; set; }
        public decimal? IdentifiantEnseignantPointage { get; set; }
        public decimal? IdentifiantEnseignantFup { get; set; }
        public string? OldMatricule { get; set; }
        public DateTime? DateCorps { get; set; }
        public string? SituationMatrimoniale { get; set; }
        public decimal? NbreEnfants { get; set; }
        public string? FupCodeCorps06 { get; set; }
        public string? FupCodeGrade06 { get; set; }
        public string? CreePar { get; set; }
        public DateTime? DateCreation { get; set; }
        public string? ModifiePar { get; set; }
        public DateTime? DateDerniereModification { get; set; }
        public decimal? CodeMouvement2006 { get; set; }
        public string? FupCodeCorps07 { get; set; }
        public string? FupCodeGrade07 { get; set; }
        public decimal? CodeMouvement20071erMvmt { get; set; }
        public decimal? CodeMouvement20072emeMvmt { get; set; }
        public string? FupCodeCorps08 { get; set; }
        public string? FupCodeGrade08 { get; set; }
        public decimal? CodeMouvement20081emeMvmt { get; set; }
        public decimal? CodeMouvement20082emeMvmt { get; set; }
        public int? IdentifiantEnseignantAxe { get; set; }
        public string? CodeClasseTenue { get; set; }
        public string? Cni { get; set; }
        public decimal? CodeMouvement20091erMvmt { get; set; }
        public decimal? CodeMouvement2010 { get; set; }
        public decimal? CodeMouvement2011 { get; set; }
        public decimal? CodeMouvement2012 { get; set; }
        public bool? DeclarationPsv { get; set; }
        public string? CommentaireEnseignant { get; set; }
        public string? LieuNaissanceEnseignant { get; set; }
        public string? MailEnseignant { get; set; }
        public string? MailEnseignant2 { get; set; }
        public decimal? MobileEnseignant { get; set; }
        public decimal? MobileEnseignant2 { get; set; }
        public string? PasswordEnseignant { get; set; }
        public string? PasswordValide { get; set; }
        public string? Status { get; set; }
        public decimal? CodeMouvement2014 { get; set; }
        public DateTime? DateInscriptionMirador { get; set; }
        public string CodeTypeUtilisation { get; set; } = null!;
        public DateTime? DateObtentionDiplomeAca { get; set; }
        public DateTime? DateObtentionDiplomePro { get; set; }
        public string? CodePosition { get; set; }
        public string? Adresse { get; set; }
        public string? Ien { get; set; }
        public string? EmailPro { get; set; }
        public decimal? CodePiLangue { get; set; }
        public bool? EstBillingue { get; set; }
        public bool? Mvt { get; set; }

        public virtual ICollection<EnseignantEtablissement> EnseignantEtablissements { get; set; }
    }
}
