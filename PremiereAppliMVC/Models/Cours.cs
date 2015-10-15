using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PremiereAppliMVC.Models.Personne;

namespace PremiereAppliMVC.Models.Formations
{
    public class Cours
    {
        #region Attributs et Accesseurs

            private int _Identifiant;
            
            public int Identifiant
            {
                get { return _Identifiant; }
                set { _Identifiant = value; }
            }
            
            private string _Libelle;
            
            public string Libelle
            {
                get { return _Libelle; }
                set { _Libelle = value; }
            }
            
            private int _NombreJours;
            
            public int NombreJours
            {
                get { return _NombreJours; }
                set { _NombreJours = value; }
            }
            
            private bool _ELearning;
            
            public bool ELearning
            {
                get { return _ELearning; }
                set { _ELearning = value; }
            }

        #endregion

        #region Constructeurs
            
            public Cours(int aIdentifiant, string aLibelle, int aNombreJours, bool aEstELearning)
            {
                // Initialisation des attributs.
                this.Identifiant = aIdentifiant;
                this.Libelle = aLibelle;
                this.NombreJours = aNombreJours;
                this.ELearning = aEstELearning;
            }
            
        #endregion

        #region Méthodes

            public static List<Cours> GetListeInstances()
            {
                return (from oStagiaire in Stagiaire.ListeStagiaires
                from oCours in oStagiaire.ListeCours
                select oCours)
                .Distinct(new CoursComparer())
                .OrderBy(oCours => oCours.Identifiant)
                .ToList();
            }
            
            public static Cours GetInstance(int aIdCours)
            {
                return (from cours in Cours.GetListeInstances()
                where cours.Identifiant == aIdCours
                select cours).FirstOrDefault();
            }
            
            public List<Stagiaire> GetListeStagiaires()
            {
                return (from oStagiaire in Stagiaire.ListeStagiaires
                from oCours in oStagiaire.ListeCours
                where oCours.Identifiant == this.Identifiant
                select oStagiaire).ToList();
            }
            
        #endregion
    }

    public class CoursComparer : IEqualityComparer<Cours>
    {
        #region IEqualityComparer<Cours> Membres
        
            public bool Equals(Cours x, Cours y)
            {
                return x.Identifiant == y.Identifiant;
            }
            
            public int GetHashCode(Cours obj)
            {
                return obj.Identifiant;
            }

        #endregion
    }
}