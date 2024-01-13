using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiradorWebAPI.ApiModels;
using MiradorWebAPI.Context;

namespace MiradorWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    public class EnsController : ControllerBase
    {
        FUPContext context;

        public EnsController(FUPContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var ens = (from e in context.Enseignants select new { e.MatriculeEnseignant, e.PrenomsEnseignant, e.NomEnseignant }).Where(ens => ens.MatriculeEnseignant.Equals("679358/B")).Single();
            ApiEnsWaitMirador enseignantAPI = new ApiEnsWaitMirador();
            //var ens = context.Fonctions.Join(context.Enseignants, x => x.CodeFonction, y => y.CodeFonction, (x, y) => new { y.MatriculeEnseignant, y.PrenomsEnseignant,y.NomEnseignant, y.DateNaissEnseignant, y.LieuNaissanceEnseignant, y.MobileEnseignant, y.MailEnseignant, x.LibelleFonction }).Where(ens => ens.MatriculeEnseignant.Equals("679358/B")).Single();
            enseignantAPI.MATRICULE_ENSEIGNANT = ens.MatriculeEnseignant;
            enseignantAPI.PRENOMS_ENSEIGNANT = ens.PrenomsEnseignant;
            enseignantAPI.NOM_ENSEIGNANT = ens.NomEnseignant;
            return Ok(enseignantAPI);
        }
        [HttpGet("messages")]
        public string GetMessages()
        {
            return "Bonjour";
        }

    }
}
