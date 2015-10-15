using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PremiereAppliMVC.Models.Formations;

namespace PremiereAppliMVC.Models.Personne
{
    public class Stagiaire
    {
        #region Attributs et Accesseurs

            private int _Identifiant;
            
            public int Identifiant
            {
                get { return _Identifiant; }
                set { _Identifiant = value; }
            }
            
            private string _Nom;
            
            public string Nom
            {
                get { return _Nom; }
                set { _Nom = value; }
            }
            
            private string _Prenom;
            
            public string Prenom
            {
                get { return _Prenom; }
                set { _Prenom = value; }
            }
            
            private List<Cours> _ListeCours;
            
            public List<Cours> ListeCours
            {
                get { return _ListeCours; }
                set { _ListeCours = value; }
            }
            
            private static List<Stagiaire> _ListeStagiaires;
            
            public static List<Stagiaire> ListeStagiaires
            {
                get
                {
                    if (_ListeStagiaires == null)
                    {
                        _ListeStagiaires = new List<Stagiaire>()
                        {
                            new Stagiaire(1, "RAVAILLE", "James", new List<Cours>()
                            {
                                new Cours(1, "Formation C# 3.0", 5, true),
                                new Cours(2, "ASP .NET 3.5", 4, false),
                                new Cours(3, "Architecture d'applications", 2, false),
                                new Cours(4, "Conception de bases de données SQL Server", 3, true)
                            }),
                            new Stagiaire(2, "PAGES", "Anthony", new List<Cours>()
                            {
                                new Cours(5, "Formation VB 9.0", 5, true),
                                new Cours(2, "ASP .NET 3.5", 4, false),
                                new Cours(6, "Administration de bases de données SQL Server", 5, false)
                            }),
                            new Stagiaire(3, "DOLLON", "Julien", new List<Cours>()
                            {
                                new Cours(7, "Windows Presentation Foundation", 5, true),
                                new Cours(8, "Silverlight", 2, true),
                                new Cours(9, ".NET RIA Services", 3, false),
                                new Cours(10, "MOOS 2007", 5, false)
                            }),
                            new Stagiaire(4, "VERGNAULT", "Bertrand",new List<Cours>()
                            {
                                new Cours(7, "Windows Presentation Foundation", 5, true),
                                new Cours(1, "Formation C# 3.0", 5, false),
                                new Cours(6, "Administration de bases de données SQL Server", 5, false)
                            })
                        };
                    }
                    return _ListeStagiaires;
                }
            }

        #endregion

        #region Constructeurs
            
            public Stagiaire(int aIdentifiant, string aNom, string aPrenom)
            {
                // Initialisation des attributs.
                this.Identifiant = aIdentifiant;
                this.Nom = aNom;
                this.Prenom = aPrenom;
                this.ListeCours = new List<Cours>();
            }
            
            public Stagiaire(int aIdentifiant, string aNom, string aPrenom, List<Cours> aListeFormations) : this(aIdentifiant, aNom, aPrenom)
            {
                // Initialisation des attributs.
                this.ListeCours = aListeFormations;
            }
            
        #endregion

        #region Méthodes

            public static Stagiaire GetInstance(int aIdentifiant)
            {
                return (from oStagiaire in ListeStagiaires
                        where oStagiaire.Identifiant == aIdentifiant
                        select oStagiaire).FirstOrDefault();
            }
            
        #endregion
    }
}