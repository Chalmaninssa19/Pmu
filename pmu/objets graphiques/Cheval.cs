using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pmu.objets_graphiques
{
    public class Cheval
    {
        int num;
        int vitesse;
        double endurance;
        Point position;
        bool isPari;
        int width =20;
        int height = 20;
        int dRayon;
        Brush color;
        double angle = 0;
        bool isAnimated;
        int valueTour;
        int activeEndurancePercent;
        int valueVitesseEnduranceActive;
        bool isArrive;
        double dureeArrive;
        int rang;
        int tourVita = 0;
        bool isTour = false;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public int Vitesse
        {
            get { return vitesse; }
            set { vitesse = value; }
        }
        public double Endurance
        {
            get { return endurance; }
            set { endurance = value; }
        }
        public Point Position
        {
            get { return position; }
            set { position = value; }
        }
        public bool IsPari
        {
            get { return isPari; }
            set { isPari = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int DRayon
        {
            get { return dRayon; }
            set { dRayon = value; }
        }
        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }
        public Brush Color
        {
            get { return color; }
            set { color = value; }
        }
        public bool IsAnimated
        {
            get { return isAnimated; }
            set { isAnimated = value; }
        }
        public int ValueTour
        {
            get { return valueTour; }
            set { valueTour = value; }
        }
        public int ActiveEndurancePercent
        {
            get { return activeEndurancePercent; }
            set { activeEndurancePercent = value; }
        }
        public int ValueVitesseEnduranceActive
        {
            get { return valueVitesseEnduranceActive; }
            set { valueVitesseEnduranceActive = value; }
        }
        public bool IsArrive
        {
            get { return isArrive; }
            set { isArrive = value; }
        }
        public double DureeArrive
        {
            get { return dureeArrive; }
            set { dureeArrive = value; }
        }
        public int Rang
        {
            get { return rang; }
            set { rang = value; }
        }
        public int TourVita
        {
            get { return tourVita; }
            set { tourVita = value; }
        }
        public bool IsTour
        {
            get { return isTour; }
            set { isTour = value; }
        }

        public Cheval(int num, int vitesse, double endurance, Point position, bool isPari, int dRayon, Brush color, int valueTour, int activeEndurancePercent)
        {
            this.num = num;
            this.vitesse = vitesse;
            this.endurance = endurance;
            this.position = position;
            this.isPari = isPari;
            this.dRayon = dRayon;
            this.color = color;
            this.isAnimated = true;
            this.valueTour = valueTour;
            this.activeEndurancePercent = activeEndurancePercent;
            this.valueVitesseEnduranceActive = vitesse + (int)(vitesse * endurance);
            this.isArrive = false;
            this.dureeArrive = 0.0;
        }

        //Deplacement du cheval
        public void Deplacer(Point point)
        {
            Position = point;
        }
        public int CalculPourcentActivation()
        {
            return ((ValueTour * ActiveEndurancePercent) / 100);
        }
        public void EnduranceActived()
        {
            if(Angle >= CalculPourcentActivation())
            {
                Vitesse = ValueVitesseEnduranceActive;
            }
        }
        //Listes des chevals disponibles
        public static List<Cheval> ListsCheval()
        {
            List<Cheval> chevals= new List<Cheval>()
            {
                new Cheval(1, 4, -10, new Point(420, 320), false, 100, Brushes.DarkGreen, 800, 70),
                new Cheval(2, 4, 0, new Point(420, 350), false, 70, Brushes.Brown, 900, 70),
                new Cheval(3, 4, 10, new Point(420, 380), false, 40, Brushes.Gold, 1000, 70),
                new Cheval(4, 4, 20, new Point(420, 410), false, 10, Brushes.Black, 1200, 70),
                new Cheval(5, 4, -20, new Point(420, 390), false, 50, Brushes.RoyalBlue, 1000, 70)
            };

            return chevals;
        }
        public static Cheval GetChevalByNum(int num)
        {
            List<Cheval> chevals = Cheval.ListsCheval();
            foreach(Cheval cheval in chevals)
            {
                if(num == cheval.num)
                {
                    return cheval;
                }
            }
            return null;
        }
        public double calculDifferenceTemps(Cheval cheval)
        {
            return DureeArrive - cheval.DureeArrive;
        }
        
        //Dessiner le cheval
        public void Draw(Graphics g)
        {
            g.FillEllipse(Color, new Rectangle(Position.X, Position.Y, Width, Height));
            if(IsPari)
            {
                Pen pen = new Pen(System.Drawing.Color.White, 2);
                g.DrawEllipse(pen, new Rectangle(Position.X, Position.Y, Width, Height));
            }
        }
    }
}
