using pmu.models;
using pmu.objets_graphiques;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pmu
{
    public partial class ResultatCourse : Form
    {
        Terrain terrain;
        Game game;
        public ResultatCourse(Terrain terrain, Game game)
        {
            InitializeComponent();
            this.game = game;
            this.terrain = terrain;
        }

        private void ResultaCourse_Load(object sender, EventArgs e)
        {
            Joueur jFirst = GetJoueurFirst(terrain.Joueurs);
            foreach(Joueur joueur in terrain.Joueurs)
            {
                double diff = joueur.Cheval.calculDifferenceTemps(jFirst.Cheval);
                double monnaie = game.calculMonnaie(diff);
                tableResultat.Rows.Add(joueur.Cheval.Num, joueur.Rang,joueur.Cheval.DureeArrive+" seconde", diff,monnaie+" ariary");
            }
            gagnant.Text = game.Gagnant.Nom;
            perdant.Text = game.Perdant.Nom;
            prixGagant.Text = game.MonnaieGagne.ToString()+" ariary";
        }
        public Joueur GetJoueurFirst(List<Joueur> joueurs)
        {
            foreach(Joueur joueur in joueurs)
            {
                if(joueur.Rang == 1)
                {
                    return joueur;
                }
            }
            return null;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
