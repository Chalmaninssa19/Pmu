using pmu.models;
using pmu.objets_graphiques;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pmu
{
    public partial class Pmu : Form
    {
        Terrain terrain;
        Timer timer;
        Stopwatch chronometre;
        double dureeSecondsGame;
        Game gaming;

        public Pmu(Game gaming)
        {
            InitializeComponent();
            terrain = new Terrain();
            timer = new Timer();
            chronometre = new Stopwatch();
            this.gaming = gaming;
            setChevalParier();

            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            DoubleBuffered = false;
        }
        public void setChevalParier()
        { 
            foreach(Joueur joueur in terrain.Joueurs)
            {
                if(joueur.Cheval.Num == this.gaming.Parieur1.ChevalParier.Num || joueur.Cheval.Num == this.gaming.Parieur2.ChevalParier.Num)
                {
                    joueur.Cheval.IsPari = true;
                }
            }
        }

        private void Timer_Tick(Object sender, EventArgs e)
        {
            dureeSecondsGame = chronometre.Elapsed.TotalSeconds;
            foreach (Joueur joueur in terrain.Joueurs)
            {
                Point point = terrain.DeplaceSurEllipse(joueur, gaming);
                joueur.Cheval.Deplacer(point);
                if(joueur.Cheval.IsArrive)
                {
                    joueur.Cheval.DureeArrive = dureeSecondsGame;
                    joueur.Cheval.IsArrive = false;
                }
            }
            if (gaming.isCourseEnd(terrain.Joueurs))
            {
                gaming.setGagnant(terrain.Joueurs);
                timer.Stop();
                ResultatCourse rc = new ResultatCourse(terrain, gaming);
                rc.Show();
            }
            
            Invalidate();
        }
        private void Pmu_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            terrain.DrawPisteEllipse(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
            chronometre.Start();
        }
    }
}
