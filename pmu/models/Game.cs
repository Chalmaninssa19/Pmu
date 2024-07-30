using pmu.objets_graphiques;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pmu.models
{
    public class Game
    {
        Parieur parieur1;
        Parieur parieur2;
        Parieur gagnant;
        Parieur perdant;
        double mise;
        double monnaieGagne;
        int nbTour;
        public Parieur Parieur1
        {
            get { return parieur1; }
            set { parieur1 = value; }
        }
        public Parieur Parieur2
        {
            get { return parieur2; }
            set { parieur2 = value; }
        }
        public Parieur Gagnant
        {
            get { return gagnant; }
            set { gagnant = value; }
        }
        public Parieur Perdant
        {
            get { return perdant; }
            set { perdant = value; }
        }
        public double Mise
        {
            get { return mise; }
            set { mise = value; }
        }
        public double MonnaieGagne
        {
            get { return monnaieGagne; }
            set { monnaieGagne = value; }
        }
        public int NbTour
        {
            get { return nbTour; }
            set { nbTour = value; }
        }


        public Game(Parieur parieur1, Parieur parieur2, double mise, int nbTour)
        {
            this.parieur1 = parieur1;
            this.parieur2 = parieur2;
            this.mise = mise;
            this.nbTour = nbTour;
        }
        public void setGagnant(List<Joueur> joueurs) 
        {
            Joueur joueur1 = GetChevalParier1(joueurs);
            Joueur joueur2 = GetChevalParier2(joueurs);
            if(joueur1.Rang < joueur2.Rang)
            {
                Gagnant = Parieur1;
                Perdant = Parieur2;
                MonnaieGagne = GetPrixGagnant(joueur1, joueur2);
                Parieur1.Monnaie += MonnaieGagne;
                Parieur2.Monnaie -= MonnaieGagne;
            }
            else
            {
                Gagnant = parieur2;
                Perdant = Parieur1;
                MonnaieGagne = GetPrixGagnant(joueur2, joueur1);
                Parieur2.Monnaie += MonnaieGagne;
                Parieur1.Monnaie -= MonnaieGagne;
            }
        }
        public Joueur GetChevalParier1(List<Joueur> joueurs)
        {
            foreach(Joueur joueur in joueurs)
            {
                if(joueur.Cheval.Num == Parieur1.ChevalParier.Num)
                {
                    return joueur;
                }
            }
            return null;
        }
        public Joueur GetChevalParier2(List<Joueur> joueurs)
        {
            foreach (Joueur joueur in joueurs)
            {
                if (joueur.Cheval.Num == Parieur2.ChevalParier.Num)
                {
                    return joueur;
                }
            }
            return null;
        }
        public double GetPrixGagnant(Joueur joueurGagnant, Joueur joueurPerdant)
        {
            Console.WriteLine("Duree gagant-> " + joueurGagnant.Cheval.DureeArrive + " duree perdant->" + joueurPerdant.Cheval.DureeArrive);
            double diffDuree = joueurPerdant.Cheval.DureeArrive - joueurGagnant.Cheval.DureeArrive;
            Console.WriteLine("Diff-> "+diffDuree+" mise-> "+Mise);
            Console.WriteLine("res-> " + Mise * diffDuree);

            return Mise * diffDuree;
        }
        public bool isCourseEnd(List<Joueur> joueurs)
        {
            int n = 0;
            foreach(Joueur joueur in joueurs)
            {
                if(joueur.Cheval.IsAnimated == false)
                {
                    n++;
                } 
            }
            if(n == joueurs.Capacity)
            {
                return true;
            }
            return false;
        }
        public double calculMonnaie(double diff)
        {
            return Mise * diff;
        }
    }
}
