using pmu.objets_graphiques;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pmu.models
{
    public class Parieur
    {
        int idParieur;
        string nom;
        Cheval chevalParier;
        double monnaie;
        public int IdParieur
        {
            get { return idParieur; }
            set { idParieur = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public Cheval ChevalParier
        {
            get { return chevalParier; }
            set { chevalParier = value; }
        }
        public double Monnaie
        {
            get { return monnaie; }
            set { monnaie = value; }
        }

        public Parieur(int idParieur, string nom, Cheval chevalParier, double monnaie)
        {
            this.idParieur = idParieur;
            this.nom = nom;
            this.chevalParier = chevalParier;
            this.monnaie = monnaie;
        }
    }
}
