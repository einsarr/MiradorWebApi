using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MiradorWebAPI.DbModels;

namespace MiradorWebAPI.Context
{
    public partial class FUPContext : IdentityDbContext
    {
        public FUPContext()
        {
        }
        //Step 5 Inhérit from IdentityDbContext
        public FUPContext(DbContextOptions<FUPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AtlasSysDefAll> AtlasSysDefAlls { get; set; } = null!;
        public virtual DbSet<Enseignant> Enseignants { get; set; } = null!;
        public virtual DbSet<EnseignantEtablissement> EnseignantEtablissements { get; set; } = null!;
        public virtual DbSet<Etablissement> Etablissements { get; set; } = null!;
        public virtual DbSet<EtablissementRegroupement> EtablissementRegroupements { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-H0HTCRI;Database=FUP;Trusted_Connection=True;");
                //optionsBuilder.UseSqlServer("Server=10.42.2.164;Database=FUP;User ID=sirh;Password=sirhacdi;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AtlasSysDefAll>(entity =>
            {
                entity.HasKey(e => e.Code00);

                entity.ToTable("ATLAS_SYS_DEF_ALL");

                entity.Property(e => e.Code00)
                    .HasMaxLength(6)
                    .HasColumnName("code00");

                entity.Property(e => e.Arrondissement).HasMaxLength(50);

                entity.Property(e => e.Code01)
                    .HasMaxLength(6)
                    .HasColumnName("code01");

                entity.Property(e => e.Code02)
                    .HasMaxLength(6)
                    .HasColumnName("code02");

                entity.Property(e => e.Code03)
                    .HasMaxLength(6)
                    .HasColumnName("code03");

                entity.Property(e => e.Code04)
                    .HasMaxLength(6)
                    .HasColumnName("code04");

                entity.Property(e => e.Code05)
                    .HasMaxLength(6)
                    .HasColumnName("code05");

                entity.Property(e => e.Code06)
                    .HasMaxLength(6)
                    .HasColumnName("code06");

                entity.Property(e => e.CommunautéRurale)
                    .HasMaxLength(50)
                    .HasColumnName("Communauté rurale");

                entity.Property(e => e.Commune).HasMaxLength(50);

                entity.Property(e => e.Département).HasMaxLength(50);

                entity.Property(e => e.Ia)
                    .HasMaxLength(50)
                    .HasColumnName("IA");

                entity.Property(e => e.Iden)
                    .HasMaxLength(50)
                    .HasColumnName("IDEN");
            });

            modelBuilder.Entity<Enseignant>(entity =>
            {
                entity.HasKey(e => e.IdentifiantEnseignant);

                entity.ToTable("ENSEIGNANT");

                entity.HasIndex(e => e.CodeCorps, "IX_CORPS");

                entity.HasIndex(e => e.MatriculeEnseignant, "IX_ENSEIGNANT")
                    .IsUnique();

                entity.HasIndex(e => e.CodeCorps, "IX_ENSEIGNANT_1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CodeEtablissement, "IX_ENSEIGNANT_2")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.NomEnseignant, e.PrenomsEnseignant }, "idx_nom_prenom");

                entity.Property(e => e.IdentifiantEnseignant).HasColumnName("IDENTIFIANT_ENSEIGNANT");

                entity.Property(e => e.Adresse)
                    .HasMaxLength(150)
                    .HasColumnName("ADRESSE");

                entity.Property(e => e.Cni)
                    .HasMaxLength(50)
                    .HasColumnName("CNI");

                entity.Property(e => e.CodeClasseTenue)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_CLASSE_TENUE");

                entity.Property(e => e.CodeCorps)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_CORPS");

                entity.Property(e => e.CodeDiplome)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_DIPLOME");

                entity.Property(e => e.CodeDiplomeProfessionnel)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_DIPLOME_PROFESSIONNEL");

                entity.Property(e => e.CodeEmployeur)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_EMPLOYEUR");

                entity.Property(e => e.CodeEtablissement)
                    .HasMaxLength(6)
                    .HasColumnName("CODE_ETABLISSEMENT");

                entity.Property(e => e.CodeFonction)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_FONCTION");

                entity.Property(e => e.CodeGrade)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_GRADE");

                entity.Property(e => e.CodeLangue)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_LANGUE");

                entity.Property(e => e.CodeMatiere)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_MATIERE");

                entity.Property(e => e.CodeMouvement)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CODE_MOUVEMENT");

                entity.Property(e => e.CodeMouvement2006)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CODE_MOUVEMENT_2006");

                entity.Property(e => e.CodeMouvement20071erMvmt)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CODE_MOUVEMENT_2007_1erMvmt");

                entity.Property(e => e.CodeMouvement20072emeMvmt)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CODE_MOUVEMENT_2007_2emeMvmt");

                entity.Property(e => e.CodeMouvement20081emeMvmt)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CODE_MOUVEMENT_2008_1emeMvmt");

                entity.Property(e => e.CodeMouvement20082emeMvmt)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CODE_MOUVEMENT_2008_2emeMvmt");

                entity.Property(e => e.CodeMouvement20091erMvmt)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CODE_MOUVEMENT_2009_1erMvmt");

                entity.Property(e => e.CodeMouvement2010)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CODE_MOUVEMENT_2010");

                entity.Property(e => e.CodeMouvement2011)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CODE_MOUVEMENT_2011");

                entity.Property(e => e.CodeMouvement2012)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CODE_MOUVEMENT_2012");

                entity.Property(e => e.CodeMouvement2014)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CODE_MOUVEMENT_2014");

                entity.Property(e => e.CodeNationalite)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_NATIONALITE");

                entity.Property(e => e.CodePiLangue)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CODE_PI_LANGUE");

                entity.Property(e => e.CodePosition)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODE_POSITION");

                entity.Property(e => e.CodeSpecialite)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_SPECIALITE");

                entity.Property(e => e.CodeStatutPersonnel)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_STATUT_PERSONNEL");

                entity.Property(e => e.CodeTypePoste)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_TYPE_POSTE")
                    .HasDefaultValueSql("((-99))");

                entity.Property(e => e.CodeTypeUtilisation)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_TYPE_UTILISATION")
                    .HasDefaultValueSql("('000')");

                entity.Property(e => e.CommentaireEnseignant)
                    .HasMaxLength(200)
                    .HasColumnName("COMMENTAIRE_ENSEIGNANT");

                entity.Property(e => e.CreePar)
                    .HasMaxLength(40)
                    .HasColumnName("CREE_PAR");

                entity.Property(e => e.DateCorps)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CORPS");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateDerniereModification)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_DERNIERE_MODIFICATION");

                entity.Property(e => e.DateEntreeEnseignementEnsei)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATE_ENTREE_ENSEIGNEMENT_ENSEI");

                entity.Property(e => e.DateEntreeEtablissementEnse)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATE_ENTREE_ETABLISSEMENT_ENSE");

                entity.Property(e => e.DateEntreeFonctionPublique)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATE_ENTREE_FONCTION_PUBLIQUE_");

                entity.Property(e => e.DateInscriptionMirador)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_INSCRIPTION_MIRADOR");

                entity.Property(e => e.DateNaissEnseignant)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATE_NAISS_ENSEIGNANT");

                entity.Property(e => e.DateObtentionDiplomeAca)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_OBTENTION_DIPLOME_ACA");

                entity.Property(e => e.DateObtentionDiplomePro)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_OBTENTION_DIPLOME_PRO");

                entity.Property(e => e.DeclarationPsv).HasColumnName("DECLARATION_PSV");

                entity.Property(e => e.EmailPro)
                    .HasMaxLength(200)
                    .HasColumnName("EMAIL_PRO");

                entity.Property(e => e.EstBillingue).HasColumnName("EST_BILLINGUE");

                entity.Property(e => e.FupCodeCorps06)
                    .HasMaxLength(3)
                    .HasColumnName("FUP_CODE_CORPS06");

                entity.Property(e => e.FupCodeCorps07)
                    .HasMaxLength(3)
                    .HasColumnName("FUP_CODE_CORPS07");

                entity.Property(e => e.FupCodeCorps08)
                    .HasMaxLength(3)
                    .HasColumnName("FUP_CODE_CORPS08");

                entity.Property(e => e.FupCodeGrade06)
                    .HasMaxLength(3)
                    .HasColumnName("FUP_CODE_GRADE06");

                entity.Property(e => e.FupCodeGrade07)
                    .HasMaxLength(3)
                    .HasColumnName("FUP_CODE_GRADE07");

                entity.Property(e => e.FupCodeGrade08)
                    .HasMaxLength(3)
                    .HasColumnName("FUP_CODE_GRADE08");

                entity.Property(e => e.IdentifiantEnseignantAxe).HasColumnName("IDENTIFIANT_ENSEIGNANT_AXE");

                entity.Property(e => e.IdentifiantEnseignantFup)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDENTIFIANT_ENSEIGNANT_FUP");

                entity.Property(e => e.IdentifiantEnseignantPointage)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDENTIFIANT_ENSEIGNANT_POINTAGE");

                entity.Property(e => e.Ien)
                    .HasMaxLength(10)
                    .HasColumnName("IEN");

                entity.Property(e => e.LieuNaissanceEnseignant)
                    .HasMaxLength(200)
                    .HasColumnName("LIEU_NAISSANCE_ENSEIGNANT");

                entity.Property(e => e.MailEnseignant)
                    .HasMaxLength(100)
                    .HasColumnName("MAIL_ENSEIGNANT");

                entity.Property(e => e.MailEnseignant2)
                    .HasMaxLength(100)
                    .HasColumnName("MAIL_ENSEIGNANT2");

                entity.Property(e => e.MatriculeEnseignant)
                    .HasMaxLength(11)
                    .HasColumnName("MATRICULE_ENSEIGNANT");

                entity.Property(e => e.MobileEnseignant)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("MOBILE_ENSEIGNANT");

                entity.Property(e => e.MobileEnseignant2)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("MOBILE_ENSEIGNANT2");

                entity.Property(e => e.ModifiePar)
                    .HasMaxLength(40)
                    .HasColumnName("MODIFIE_PAR");

                entity.Property(e => e.Mvt).HasColumnName("MVT");

                entity.Property(e => e.NbHeuresAssures).HasColumnName("NB_HEURES_ASSURES");

                entity.Property(e => e.NbJourFormation).HasColumnName("NB_JOUR_FORMATION");

                entity.Property(e => e.NbreEnfants)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("NBRE_ENFANTS");

                entity.Property(e => e.NomEnseignant)
                    .HasMaxLength(30)
                    .HasColumnName("NOM_ENSEIGNANT");

                entity.Property(e => e.Ok)
                    .HasColumnName("OK")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OldMatricule)
                    .HasMaxLength(11)
                    .HasColumnName("OLD_MATRICULE");

                entity.Property(e => e.PasswordEnseignant)
                    .HasMaxLength(100)
                    .HasColumnName("PASSWORD_ENSEIGNANT");

                entity.Property(e => e.PasswordValide)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD_VALIDE")
                    .IsFixedLength();

                entity.Property(e => e.PrenomsEnseignant)
                    .HasMaxLength(255)
                    .HasColumnName("PRENOMS_ENSEIGNANT");

                entity.Property(e => e.SexeEnseignant)
                    .HasMaxLength(1)
                    .HasColumnName("SEXE_ENSEIGNANT");

                entity.Property(e => e.SituationMatrimoniale)
                    .HasMaxLength(15)
                    .HasColumnName("SITUATION_MATRIMONIALE");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.VolumeHoraireDu).HasColumnName("VOLUME_HORAIRE_DU");
            });

            modelBuilder.Entity<EnseignantEtablissement>(entity =>
            {
                entity.HasKey(e => new { e.IdentifiantEnseignant, e.CodeEtablissement });

                entity.ToTable("ENSEIGNANT_ETABLISSEMENT");

                entity.Property(e => e.IdentifiantEnseignant).HasColumnName("IDENTIFIANT_ENSEIGNANT");

                entity.Property(e => e.CodeEtablissement)
                    .HasMaxLength(6)
                    .HasColumnName("CODE_ETABLISSEMENT");

                entity.Property(e => e.CodeAnnee)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_ANNEE");

                entity.Property(e => e.CodeSituation)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_SITUATION");

                entity.Property(e => e.CreePar)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CREE_PAR")
                    .HasDefaultValueSql("(user_name())");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATION")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateDerniereModification)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_DERNIERE_MODIFICATION");

                entity.Property(e => e.ModifiePar)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIE_PAR");

                entity.Property(e => e.NumeroOrdreEnseignant).HasColumnName("NUMERO_ORDRE_ENSEIGNANT");

                entity.Property(e => e.Temp).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.CodeEtablissementNavigation)
                    .WithMany(p => p.EnseignantEtablissements)
                    .HasForeignKey(d => d.CodeEtablissement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ENSEIGNANT_ETABLISSEMENT_ETABLISSEMENT");

                entity.HasOne(d => d.IdentifiantEnseignantNavigation)
                    .WithMany(p => p.EnseignantEtablissements)
                    .HasForeignKey(d => d.IdentifiantEnseignant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ENSEIGNANT_ETABLISSEMENT_ENSEIGNANT");
            });

            modelBuilder.Entity<Etablissement>(entity =>
            {
                entity.HasKey(e => e.CodeEtablissement);

                entity.ToTable("ETABLISSEMENT");

                entity.HasIndex(e => e.NomEtablissement, "IX_ETABLISSEMENT")
                    .HasFillFactor(90);

                entity.Property(e => e.CodeEtablissement)
                    .HasMaxLength(6)
                    .HasColumnName("CODE_ETABLISSEMENT");

                entity.Property(e => e.Adresse)
                    .HasMaxLength(30)
                    .HasColumnName("ADRESSE");

                entity.Property(e => e.BoitePostale)
                    .HasMaxLength(5)
                    .HasColumnName("BOITE_POSTALE");

                entity.Property(e => e.CodeAdministratif)
                    .HasMaxLength(15)
                    .HasColumnName("CODE_ADMINISTRATIF");

                entity.Property(e => e.CodeAdministratifOld)
                    .HasMaxLength(6)
                    .HasColumnName("CODE_ADMINISTRATIF_old");

                entity.Property(e => e.CodePi)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CODE_PI");

                entity.Property(e => e.CodePiLangue)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CODE_PI_LANGUE");

                entity.Property(e => e.CodeStatut)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_STATUT");

                entity.Property(e => e.CodeStatutPrive)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_STATUT_PRIVE");

                entity.Property(e => e.CodeSysteme)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_SYSTEME");

                entity.Property(e => e.CodeTypeEtablissement)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_TYPE_ETABLISSEMENT");

                entity.Property(e => e.CodeTypeSociologique)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_TYPE_SOCIOLOGIQUE");

                entity.Property(e => e.CodeTypeStructureAdm)
                    .HasMaxLength(3)
                    .HasColumnName("CODE_TYPE_STRUCTURE_ADM");

                entity.Property(e => e.DateCreation)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATE_CREATION");

                entity.Property(e => e.DateReconnaissance)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DATE_RECONNAISSANCE");

                entity.Property(e => e.EcoleApplication)
                    .HasMaxLength(3)
                    .HasColumnName("ECOLE_APPLICATION")
                    .HasDefaultValueSql("(N'Non')");

                entity.Property(e => e.EstPrioriteBillingue).HasColumnName("EST_PRIORITE_BILLINGUE");

                entity.Property(e => e.EtabPrioriteFemme)
                    .HasColumnName("ETAB_PRIORITE_FEMME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EtabVerrouille)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ETAB_VERROUILLE")
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();

                entity.Property(e => e.Mel)
                    .HasMaxLength(30)
                    .HasColumnName("MEL");

                entity.Property(e => e.NbClasse).HasColumnName("NB_CLASSE");

                entity.Property(e => e.NomChefEtablissement)
                    .HasMaxLength(40)
                    .HasColumnName("NOM_CHEF_ETABLISSEMENT");

                entity.Property(e => e.NomEtablissement)
                    .HasMaxLength(50)
                    .HasColumnName("NOM_ETABLISSEMENT");

                entity.Property(e => e.OldCodeAdministratif)
                    .HasMaxLength(15)
                    .HasColumnName("OLD_CODE_ADMINISTRATIF");

                entity.Property(e => e.OldNomEtablissement)
                    .HasMaxLength(50)
                    .HasColumnName("OLD_NOM_ETABLISSEMENT");

                entity.Property(e => e.ReferenceAutorisation)
                    .HasMaxLength(30)
                    .HasColumnName("REFERENCE_AUTORISATION");

                entity.Property(e => e.Telecopie)
                    .HasMaxLength(12)
                    .HasColumnName("TELECOPIE");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(12)
                    .HasColumnName("TELEPHONE");
            });

            modelBuilder.Entity<EtablissementRegroupement>(entity =>
            {
                entity.HasKey(e => new { e.CodeEtablissement, e.CodeRegroupement });

                entity.ToTable("ETABLISSEMENT_REGROUPEMENT");

                entity.Property(e => e.CodeEtablissement)
                    .HasMaxLength(6)
                    .HasColumnName("CODE_ETABLISSEMENT");

                entity.Property(e => e.CodeRegroupement)
                    .HasMaxLength(6)
                    .HasColumnName("CODE_REGROUPEMENT");

                entity.HasOne(d => d.CodeEtablissementNavigation)
                    .WithMany(p => p.EtablissementRegroupements)
                    .HasForeignKey(d => d.CodeEtablissement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ETABLISSEMENT_REGROUPEMENT_ETABLISSEMENT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
