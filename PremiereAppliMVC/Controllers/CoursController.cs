using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PremiereAppliMVC.Models.Personne;
using PremiereAppliMVC.Models.Formations;

namespace PremiereAppliMVC.Controllers
{
    public class CoursController : Controller
    {
        //
        // GET: /Cours/

        public ActionResult Index(int? aIdentifiantStagiaire)
        {
            List<Cours> oListeCours = null;
            if (aIdentifiantStagiaire.HasValue)
            {
                oListeCours = Stagiaire.GetInstance(aIdentifiantStagiaire.Value).ListeCours;
            }
            else
            {
                oListeCours = Cours.GetListeInstances();
            }
            return View(oListeCours);
        }
    }
}
