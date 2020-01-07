using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Hexagones
{
    public class Hexagone
    {
        //Position x et y 
        private int x;
        private int y;
        
        //Les positions suivant le repère q, r et l'id
        private int q;
        private int r;
        private int id;

        //L'objet associé au contour de l'hexagone
        private Pen hPen;
        //L'objet associé au remplissage de l'hexagone
        private SolidBrush hBrush;
        //Les points de l'hexagone, initialisé lorsque l'on dessine l'hexagone
        private Point[] points;
        
        //La couleur RGB de l'héxagone
        private int rouge;
        private int vert;
        private int bleu;

        //Des constantes pour les calculs
        private const int rayon = Program.rayon;
        private const double SIN_60 = 1.732050807569 / 2.0;//Math.Sqrt(3) / 2

        ///<summary>
        /// Constructeur par défaut 
        /// On initialise les couleurs pour qu'il soit noir, et le trait de contour
        ///</summary>
        public Hexagone()
        {
            rouge = 0;
            vert = 0;
            bleu = 0;
            hPen = new Pen(Color.Black);
            hPen.Width = 2;
            hBrush = new SolidBrush(Color.FromArgb(rouge, vert, bleu));
        }

        ///<summary>
        /// Constructeur pour placer l'hexagone à partir de sa position <paramref name="q"/> et <paramref name="r"/> et de la position du centre de l'univers
        ///</summary>
        ///<param name="q">La position q dans le repère q,r</param>
        ///<param name="r">La position r dans le repère q,r</param>
        ///<param name="centreX">La position x du centre de l'univers</param>
        ///<param name="centreY">La position y du centre de l'univers</param>
        public Hexagone(int q, int r, int centreX, int centreY) : this()
        {
            this.q = q;
            this.r =  r;
            this.x = Convert.ToInt32(q * rayon * 2 * SIN_60 + r * rayon * SIN_60) + centreX;
            this.y = r * rayon * 2 * 3 / 4 + centreY;
            this.id = Univers.universIds[this.q, this.r];
            this.ChangeColorHexagone(id*2, 0, 255 - id*2);
        }

        //GET SET
        public int Q
        {
            get { return q; }
            set { q = value; }
        }

        public int R
        {
            get { return r; }
            set { r = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Rouge { set { rouge = value; } get { return rouge; } }
        public int Vert { set { vert = value; } get { return vert ; } }
        public int Bleu { set { bleu = value; } get { return bleu; } }

        ///<summary>
        /// Permet de faire le rendu graphique d'un Hexagone
        /// Calculs ses points pour le dessiner
        ///</summary>
        ///<param name="bmp">L'image dans laquelle on dessine l'hexagone</param>
        public Bitmap draw(Bitmap bmp)
        {
            points = new Point[6]
            {
                new Point(x, y + rayon),
                new Point(Convert.ToInt32(x + rayon * SIN_60), y + rayon / 2),
                new Point(Convert.ToInt32(x + rayon * SIN_60), y - rayon / 2),
                new Point(x, y - rayon),
                new Point(Convert.ToInt32(x - rayon * SIN_60), y - rayon / 2),
                new Point(Convert.ToInt32(x - rayon * SIN_60), y + rayon / 2)
                
            };
            using (Graphics graphic = Graphics.FromImage(bmp))
            {
                graphic.FillPolygon(hBrush, points);
                graphic.DrawPolygon(hPen, points);
            }
            return bmp;
        }

        ///<summary>
        /// Code pris en ligne, normalement ça marche
        /// Permet de déterminer si l'Hexagone est touché lorsque l'on clique à la position <paramref name="x"/> <paramref name="y"/>
        ///</summary>
        public bool IsHit(int x, int y)
        {
            int i, j = 5;
            bool oddNodes = false;

            for (i = 0; i < 6; i++)
            {
                if ((points[i].Y < y && points[j].Y >= y
                || points[j].Y < y && points[i].Y >= y)
                && (points[i].X <= x || points[j].X <= x))
                {
                    oddNodes ^= (points[i].X + (y - points[i].Y) / (points[j].Y - points[i].Y) * (points[j].X - points[i].X) < x);
                }
                j = i;
            }

            return oddNodes;
        }

        ///<summary>
        ///Test si l'hexagone est touché et traite le cas si il l'est
        ///</summary>
        ///<param name="x">La position x où l'on clique</param>
        ///<param name="y">La position y où l'on clique</param>
        ///<param name="form">Le formulaire sur lequel on clique</param>
        public void TestIsHit(int x, int y, FormHexagones form)
        {
            if(IsHit(x, y))
            {
                form.OnHexaHit(this);
            }
        }

        /// <summary>
        /// Change la couleur d'un hexagone
        /// </summary>
        /// <param name="rouge">Valeur de la couleur rouge entre 0 et 255</param>
        /// <param name="vert">Valeur de la couleur vert entre 0 et 255</param>
        /// <param name="bleu">Valeur de la couleur bleu entre 0 et 255</param>
        public void ChangeColorHexagone(int rouge, int vert, int bleu)
        {
            this.rouge = rouge;
            this.vert = vert;
            this.bleu = bleu;
            hBrush = new SolidBrush(Color.FromArgb(rouge, vert, bleu));
        }

        /// <summary>
        /// Permet de générer une chaine de caractère avec les informations d'un hexagone
        /// </summary>
        /// <returns>Renvoie une chaine de caractères formatée en JSON pour enregistrer l'Hexagone dans un fichier</returns>
        public string EnregistrerHexa()
        {
            string jsonOutput = JsonConvert.SerializeObject(new HexagoneSimplifie(this));
            Console.WriteLine("EnregistrerHexa" + jsonOutput);
            return jsonOutput;
        }
    }

    /// <summary>
    /// Une classe avec seulement qu'une partie des informations pour l'enregistrement
    /// </summary>
    public class HexagoneSimplifie
    {
        //Les positions suivant le repère q, r et l'id
        private int q;
        private int r;
        private int id;

        //La couleur RGB de l'héxagone
        private int rouge;
        private int vert;
        private int bleu;

        public HexagoneSimplifie(Hexagone hexa)
        {
            this.q = hexa.Q;
            this.r = hexa.R;
            this.id = hexa.ID;
            this.rouge = hexa.Rouge;
            this.vert = hexa.Vert;
            this.bleu = hexa.Bleu;
        }


        public int Q
        {get { return q; }}

        public int R
        { get { return r; }}

        public int ID
        { get { return id; }}

        public int Rouge { get { return rouge; } }
        public int Vert { get { return vert; } }
        public int Bleu { get { return bleu; } }
    }
}
