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
    public partial class PmuParier : Form
    {
        public PmuParier()
        {
            InitializeComponent();
            Initialization();
        }
        public void Initialization()
        {
            List<Joueur> joueurs = Joueur.ListsJoueur();
            List<Cheval> chevals = Cheval.ListsCheval();
            foreach( Cheval cheval in chevals)
            {
                listChevalFirst.Items.Add("Num : "+cheval.Num+" - Vitesse : "+cheval.Vitesse+" - Endurance : "+cheval.Endurance+" - Proprietaire : "+joueurs.ElementAt(1).Nom);
                listChevalSecond.Items.Add("Num : " + cheval.Num + " - Vitesse : " + cheval.Vitesse + " - Endurance : " + cheval.Endurance + " - Proprietaire : " + joueurs.ElementAt(1).Nom);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PMU_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] firstSplit = listChevalFirst.Text.Split('-');
            string[] secondSplit = listChevalSecond.Text.Split('-');
            string[] firstingSplit = firstSplit[0].Split(':');
            string[] secondingSplit = secondSplit[0].Split(':');
            Cheval chevalParier1 = Cheval.GetChevalByNum(int.Parse(firstingSplit[1]));
            Cheval chevalParier2 = Cheval.GetChevalByNum(int.Parse(secondingSplit[1]));
            Parieur parieur1 = new Parieur(1, chFirstParieur.Text, chevalParier1, double.Parse(chMonnaieFirst.Text));
            Parieur parieur2 = new Parieur(2, chSecondParieur.Text, chevalParier2, double.Parse(chMonnaieSecond.Text));
            Game gaming = new Game(parieur1, parieur2, double.Parse(chMise.Text), int.Parse(nbTour.Text));
            Pmu pmu = new Pmu(gaming);
            pmu.Show();
        }
    }
}
