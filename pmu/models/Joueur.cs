using pmu.objets_graphiques;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pmu.models
{
    public class Joueur
    {
        int idJoueur;
        string nom;
        Cheval cheval;
        int rang;

        public int IdJoueur
        {
            get { return idJoueur; }
            set { idJoueur = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public Cheval Cheval
        {
            get { return cheval; }
            set { cheval = value; }
        }
        public int Rang
        {
            get { return rang; }
            set { rang = value; }
        }

        public Joueur(int idJoueur, string nom, Cheval cheval)
        {
            this.idJoueur = idJoueur;
            this.nom = nom;
            this.cheval = cheval;
        }
        //Listes des joueurs
        public static List<Joueur> ListsJoueur()
        {
            List<Cheval> listsCheval = Cheval.ListsCheval();
            List<Joueur> joueurs = new List<Joueur>()
            {
                new Joueur(1, "Oui", listsCheval.ElementAt(0)),
                new Joueur(2, "Jah", listsCheval.ElementAt(1)),
                new Joueur(3, "Bon", listsCheval.ElementAt(2)),
                new Joueur(4, "Non", listsCheval.ElementAt(3)),
                new Joueur(5, "Ah", listsCheval.ElementAt(4))
            };
            return joueurs;
        }
        public static Joueur GetJoueurById(int idJoueur)
        {
            List<Joueur> joueurs = Joueur.ListsJoueur();
            foreach (Joueur joueur in joueurs)
            {
                if (idJoueur == joueur.IdJoueur)
                {
                    return joueur;
                }
            }
            return null;
        }
    }
}
