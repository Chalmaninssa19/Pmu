using pmu.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace pmu.objets_graphiques
{
    public class Terrain
    {
        int widthRectRouge = 400;
        int heightRectRouge = 200;
        int widthRectVert = 400;
        int heightRectVert = 300;
        Point positionRectRouge = new Point(200, 100);
        Point positionRectVert = new Point(200, 50);
        int angleDebut = 0;
        int widthDemiCercle = 200;
        int heightDemiCercle = 300;
        Point startPointDemiCercleLeft = new Point(100, 50);
        Point startPointDemiCercleRight = new Point(500, 50);

        List<Joueur> joueurs;
        Point startPoint = new Point(50, 50);
        Point endPoint = new Point(200, 200);

        Point positionDebut = new Point(100, 20);
        int heightEllipse = 400;
        int widthEllipse = 600;
        int position = 0;

        public List<Joueur> Joueurs
        {
            get { return joueurs; }
            set { joueurs = value; }
        }
        public int WidthRectRouge
        {
            get { return widthRectRouge; }
            set { widthRectRouge = value; }
        }
        public int HeightRectRouge
        {
            get { return heightRectRouge; }
            set { heightRectRouge = value; }
        }
        public int WidthRectVert
        {
            get { return widthRectVert; }
            set { widthRectVert = value; }
        }
        public int HeightRectVert
        {
            get { return heightRectVert; }
            set { heightRectVert = value; }
        }
        public Point PositionRectRouge
        {
            get { return positionRectRouge; }
            set { positionRectRouge = value; }
        }
        public Point PositionRectVert
        {
            get { return positionRectVert; }
            set { positionRectVert = value; }
        }
        public int AngleDebut
        {
            get { return angleDebut; }
            set { angleDebut = value; }
        }
        public int WidthDemiCercle
        {
            get { return widthDemiCercle; }
            set { widthDemiCercle = value; }
        }
        public int HeightDemiCercle
        {
            get { return heightDemiCercle; }
            set { heightDemiCercle = value; }
        }
        public Point StartPointDemiCercleLeft
        {
            get { return startPointDemiCercleLeft; }
            set { startPointDemiCercleLeft = value; }
        }
        public Point StartPointDemiCercleRight
        {
            get { return startPointDemiCercleRight; }
            set { startPointDemiCercleRight = value; }
        }
        public int Position
        {
            get { return position; }
            set { position = value; }
        }
        public Terrain()
        {
            InitializeObjets();
        }
        public void InitializeObjets()
        {
            //Initialization des joueurs
            Joueurs = Joueur.ListsJoueur();
        }
        public Point CentreRectRouge()
        {
            int xCentre = PositionRectRouge.X + WidthRectRouge / 2;
            int yCentre = PositionRectRouge.Y + HeightRectRouge / 2;

            return new Point(xCentre, yCentre);
        }
        public Point CentreRectVert()
        {
            int xCentre = PositionRectVert.X + WidthRectVert / 2;
            int yCentre = PositionRectVert.Y + HeightRectVert / 2;

            return new Point(xCentre, yCentre);
        }
        public Point CentreDemiCercleLeft() 
        {
            int xCentre = StartPointDemiCercleLeft.X + WidthDemiCercle / 2;
            int yCentre = StartPointDemiCercleLeft.Y + HeightDemiCercle / 2;

            return new Point(xCentre, yCentre);
        }

        public Point CentreDemiCercleRight()
        {
            int xCentre = StartPointDemiCercleRight.X + WidthDemiCercle / 2;
            int yCentre = StartPointDemiCercleRight.Y + HeightDemiCercle / 2;

            return new Point(xCentre, yCentre);
        }
        public Point CentreEllipse()
        {
            int xCentre = positionDebut.X + widthEllipse / 2;
            int yCentre = positionDebut.Y + heightEllipse / 2;

            return new Point(xCentre, yCentre);
        }

        //Calcule de la distance d'un joueur depuis le centre
        public double DistanceFromCenter(Joueur joueur)
        {
            int dx = PositionRectRouge.X - joueur.Cheval.Position.X;
            int dy = PositionRectRouge.Y - joueur.Cheval.Position.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }
        public double DistanceFromCenterDemiCercle(Joueur joueur)
        {
            int dx = CentreDemiCercleLeft().X - joueur.Cheval.Position.X;
            int dy = CentreDemiCercleLeft().Y - joueur.Cheval.Position.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }
        public Point DeplaceSurEllipse(Joueur joueur, Game game)
        {
            joueur.Cheval.EnduranceActived();   //Activer si l'endurance au moment precis
            Point centre = CentreEllipse();
            int a = (widthEllipse / 2) - joueur.Cheval.DRayon;
            int b = (heightEllipse / 2) - joueur.Cheval.DRayon;
            int x = joueur.Cheval.Position.X;
            int y = joueur.Cheval.Position.Y;
            int vitesse = joueur.Cheval.Vitesse;
            double expression = Math.Pow(a, 2) - Math.Pow(x - centre.X, 2);
            double racine = expression >= 0 ? Math.Sqrt(expression) : 0;
            joueur.Cheval.Angle += vitesse;
            if (joueur.Cheval.IsAnimated)
            {
                if (y == centre.Y && x > centre.X)
                {
                    x -= vitesse;
                    y = (int)(centre.Y + (b / (a * 1.0)) * racine);
                }
                else if (y <= centre.Y)
                {
                    x += vitesse;
                    y = (int)(centre.Y - (b / (a * 1.0)) * racine);
                }
                else if (y > centre.Y)
                {
                    x -= vitesse;
                    y = (int)(centre.Y + (b / (a * 1.0)) * racine);
                }
                if(x <= 420 && y >= 300 && y <= 440 && joueur.Cheval.Angle > 500)
                {
                    joueur.Cheval.TourVita++;
                    if(joueur.Cheval.TourVita == game.NbTour)
                    {
                        Position += 1;
                        joueur.Cheval.IsAnimated = false;
                        joueur.Cheval.IsArrive = true;
                        joueur.Rang = Position;
                        joueur.Cheval.Rang = Position;
                        Console.WriteLine("joueur ->" + joueur.Nom + "Couleur->" + joueur.Cheval.Color + "angle -> " + joueur.Cheval.Angle);
                    }
                }
                Console.WriteLine("nombre-> " + game.NbTour+" cheval -> " + joueur.Cheval.TourVita);
            }

            return new Point(x, y);
        }
       /* public Point DeplaceSurLaPiste()
        {
            int x = Joueur.Cheval.Position.X;
            int y = Joueur.Cheval.Position.Y;
            if(IsMovingLinear)
            {
                int targetX = CentreDemiCercleLeft().X;
                int targetY = y;
                //Deplacement lineaire vers le point cible
                if(x >= targetX)
                {
                    x -= 5;
                }
                else if (y > targetY)
                {
                    y -= 5;
                }
                else
                {
                    isMovingLinear = false;
                }
            }
            //Le joueur parcourt la piste rectangulaire
            /*if (x > CentreDemiCercleLeft().X)
            {
                x = Joueur.Cheval.Position.X - Joueur.Cheval.Vitesse;
                y = Joueur.Cheval.Position.Y;
            }
            else
            {
                int targetX = CentreDemiCercleLeft().X;
                int targetY = StartPointDemiCercleLeft.Y ;
                double angle = Math.Atan2(y - targetY, x - targetX);
                double radius = 100;    //Rayon du cercle sur les bords
                double centerX = targetX + radius * Math.Cos(angle);
                double centerY = targetY + radius * Math.Sin(angle);
                double distanceToCenter = Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2));
                if (distanceToCenter >= radius)
                {
                    //Calucler les coordonnes sur le cercle des bords
                    double currentAngle = Math.Atan2(y - centerY, x - centerX);
                    double newAngle = currentAngle + 0.1;//Vitesse de rotation
                    x = (int)(centerX + radius * Math.Cos(newAngle));
                    y = (int)(centerY + radius * Math.Sin(newAngle));
                }
                else
                {
                    //Revenir au deplacement lineaire
                    IsMovingLinear = true;
                }
            }
            //Le joueur parcourt la piste circulaire
            if (x <= CentreDemiCercleLeft().X)
            {
                //Augmenter l'angle pour faire deplacer l'objet le long de l'ellipse
                 AngleDebut += 5;

                 double radius = DistanceFromCenterDemiCercle(Joueur);
                 // Calculer les coordonnees du pointsur l'ellipse
                 double radians = AngleDebut * Math.PI / 180.0;
                x = CentreDemiCercleLeft().X - x + (int)(100 * Math.Cos(radians));
                y = CentreDemiCercleLeft().Y - y + (int)(100 * Math.Sin(radians));
                //Deplacement circulaire sur les bords de la piste
               
            }

            return new Point(x, y);
        }
        public void Draw(Graphics g)
        {
            //le rectangle vert
            g.FillRectangle(Brushes.Green, new Rectangle(PositionRectVert.X, PositionRectVert.Y, WidthRectVert, HeightRectVert));
            
            //Le rectangle rouge
            g.FillRectangle(Brushes.Red, new Rectangle(PositionRectRouge.X, PositionRectRouge.Y, WidthRectRouge, HeightRectRouge));

            //Definir la partie courbe aux extremites du rectangle vert
            //Partie gauche
            // Définir les coordonnées et les dimensions du rectangle englobant
            Rectangle rectangle3 = new Rectangle(StartPointDemiCercleLeft.X, StartPointDemiCercleLeft.Y, WidthDemiCercle, HeightDemiCercle);

            // Définir les angles de départ et d'ouverture du secteur
            float angleDebut3 = 90.0f;
            float angleOuverture3 = 180.0f;

            // Dessiner le secteur en utilisant le rectangle englobant, l'angle de début et l'angle d'ouverture
            g.FillPie(Brushes.Green, rectangle3, angleDebut3, angleOuverture3);

            //Partie droite
            // Définir les coordonnées et les dimensions du rectangle englobant
            Rectangle rectangle4 = new Rectangle(StartPointDemiCercleRight.X, StartPointDemiCercleRight.Y, WidthDemiCercle, HeightDemiCercle);

            // Définir les angles de départ et d'ouverture du secteur
            float angleDebut4 = -90.0f;
            float angleOuverture4 = 180.0f;

            // Dessiner le secteur en utilisant le rectangle englobant, l'angle de début et l'angle d'ouverture
            g.FillPie(Brushes.Green, rectangle4, angleDebut4, angleOuverture4);


            //Definir la partie courbe aux extremites du rectangle rouge
            //Partie gauche
            // Définir les coordonnées et les dimensions du rectangle englobant
            int x1 =150;
            int y1 = 100;
            int largeur = 100;
            int hauteur = 200;
            Rectangle rectangle1 = new Rectangle(x1, y1, largeur, hauteur);

            // Définir les angles de départ et d'ouverture du secteur
            float angleDebut1 = 90.0f;
            float angleOuverture1 = 180.0f;

            // Dessiner le secteur en utilisant le rectangle englobant, l'angle de début et l'angle d'ouverture
            g.FillPie(Brushes.Red, rectangle1, angleDebut1, angleOuverture1);

            //Partie droite
            // Définir les coordonnées et les dimensions du rectangle englobant
            int x2 = 550;
            int y2 = 100;
            Rectangle rectangle2 = new Rectangle(x2, y2, largeur, hauteur);

            // Définir les angles de départ et d'ouverture du secteur
            float angleDebut2 = -90.0f;
            float angleOuverture2 = 180.0f;

            // Dessiner le secteur en utilisant le rectangle englobant, l'angle de début et l'angle d'ouverture
            g.FillPie(Brushes.Red, rectangle2, angleDebut2, angleOuverture2);

            //Point d'arrive et de depart
            Pen pen = new Pen(Brushes.White, 2);
            g.DrawLine(pen, 400, 300, 400, 350);

            Joueur.Cheval.Draw(g);
            Joueur1.Cheval.Draw(g);
            /* // Définir les coordonnées et les dimensions du rectangle englobant
             int x = 120;
             int y = 80;
             int large = 150;
             int haut = 260;
             Rectangle rectangle = new Rectangle(x, y, large, haut);

             // Définir les angles de départ et d'ouverture de l'arc
             float angleDebut = 90.0f;
             float angleOuverture = 180.0f;

             // Dessiner l'arc en utilisant le rectangle englobant, l'angle de début et l'angle d'ouverture
             g.DrawArc(Pens.White, rectangle, angleDebut, angleOuverture);
            

        }*/
        public void DrawPisteEllipse(Graphics g)
        {
            g.FillEllipse(Brushes.Green, new Rectangle(positionDebut.X, positionDebut.Y, widthEllipse, heightEllipse));
            g.FillEllipse(Brushes.Red, new Rectangle(200, 120, 400, 200));

            //Point d'arrive et de depart
            Pen pen = new Pen(Brushes.White, 2);
            g.DrawLine(pen, 420, 320, 420, 420);
            foreach(Joueur joueur in Joueurs)
            {
                joueur.Cheval.Draw(g);
            }
        }
    }
}
