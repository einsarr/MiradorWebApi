using System.ComponentModel.DataAnnotations;

namespace MiradorWebAPI.ApiModels.Girafe
{
    public class ApiEnsWaitGirafe
    {
        public string matricule { get; set; }
        public string prenom { get; set; }
        public string nom { get; set; }
        public string sexe { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? date_nais { get; set; }
        public string lieu_nais { get; set; }
        public string num_piece { get; set; }
        public Decimal? tel { get; set; }
        public Decimal? tel_secondaire { get; set; }
        public string email { get; set; }
        public string diplome_aca { get; set; }
        public string diplome_prof { get; set; }
        public string code_corps { get; set; }
        public string code_grade { get; set; }
        public DateTime? date_entree_fonction { get; set; }
    }
}
