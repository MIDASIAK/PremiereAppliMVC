using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PremiereAppliMVC.Models.Personne;
using PremiereAppliMVC.Models.Formations;

namespace PremiereAppliMVC.Controllers
{
    public class StagiaireController : Controller
    {
        //
        // GET: /Stagiaire/

        public ActionResult Index(int? aIdentifiantCours)
        {
            List<Stagiaire> oListeStagiaires = null;
            if (aIdentifiantCours.HasValue)
            {
                Cours oCours = Cours.GetInstance(aIdentifiantCours.Value);
                oListeStagiaires = oCours.GetListeStagiaires();
            }
            else
            {
                oListeStagiaires = Stagiaire.ListeStagiaires;
            }
            return View(oListeStagiaires);
        }

        public void AfficherListeStagiaires()
        {
            Response.Write("Vous avez exécutez l'action Tester du contrôleur StagiaireController.");
            Response.Write("<br /><br />");
            Response.Write("Voici la liste des stagiaires : ");
            Response.Write("<ul>");
            foreach (Stagiaire oStagiaire in Stagiaire.ListeStagiaires)
            {
                Response.Write("<li>" + oStagiaire.Nom + " " + oStagiaire.Prenom + "</li>");
            }
            Response.Write("</ul>");
        }
    }
}
