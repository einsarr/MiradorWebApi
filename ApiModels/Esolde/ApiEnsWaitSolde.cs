using System.ComponentModel.DataAnnotations;

namespace MiradorWebAPI.ApiModels.Esolde
{
    public class ApiEnsWaitSolde
    {
        public string matricule { get; set; }
        public string prenom { get; set; }
        public string nom { get; set; }
        public string sexe { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? date_naissance { get; set; }
        public string lieu_naissance { get; set; }
        public string nin { get; set; }
        public Decimal? telelephone { get; set; }
        public Decimal? telelephone_secondaire { get; set; }
        public string email { get; set; }
        public string diplome_aca { get; set; }
        public string diplome_prof { get; set; }
        public string code_corps { get; set; }
        public string code_grade { get; set; }
        public DateTime? date_entree_fonction { get; set; }
    }
}
