using System.ComponentModel.DataAnnotations;

namespace MiradorWebAPI.ApiModels
{
    public class ApiEnsWaitMirador
    {
       
        [Required]
        public string MATRICULE_ENSEIGNANT { get; set; }
        [Required]
        public string NOM_ENSEIGNANT { get; set; }
        [Required]
        public string PRENOMS_ENSEIGNANT { get; set; }
        [Required]
        public string SEXE_ENSEIGNANT { get; set; }
        [Required]
        public string CNI { get; set; }
        public string LIEU_NAISSANCE_ENSEIGNANT { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DATE_NAISS_ENSEIGNANT { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DATE_ENTREE_ETABLISSEMENT_ENSE { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DATE_ENTREE_FONCTION_PUBLIQUE_ { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DATE_ENTREE_ENSEIGNEMENT_ENSEI { get; set; }
        public string CODE_FONCTION { get; set; }
        public string CODE_SPECIALITE { get; set; }
        public string CODE_STATUT_PERSONNEL { get; set; }
        public string CODE_TYPE_POSTE { get; set; }
        public string CODE_CORPS { get; set; }
        public string CODE_DIPLOME { get; set; }
        public string CODE_DIPLOME_PROFESSIONNEL { get; set; }
        public string CODE_NATIONALITE { get; set; }
        public string CODE_EMPLOYEUR { get; set; } //(par defaut 001)
        public string CODE_GRADE { get; set; }
        public string CODE_ADMINISTRATIF { get; set; }
        public string CODE_POSITION { get; set; }
        public Decimal CODE_PI_LANGUE { get; set; }
        public string CODE_TYPE_UTILISATION { get; set; }
        public string SITUATION_MATRIMONIALE { get; set; }
        public string MAIL_ENSEIGNANT { get; set; }
        public Decimal MOBILE_ENSEIGNANT { get; set; }
        public Decimal MOBILE_ENSEIGNANT2 { get; set; }
        public string MAIL_ENSEIGNANT2 { get; set; }
        public string ADRESSE { get; set; }
        public string IEN { get; set; }
        public string EMAIL_PRO { get; set; }
       
    }
}
