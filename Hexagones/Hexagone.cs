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
        //Les points de l'hexagone
        private Point[] points;
        
        //La couleur RGB de l'héxagone
        private int rouge;
        private int vert;
        private int bleu;

        //Des constantes pour les calculs
        private const int rayon = Program.rayon;
        private const double SIN_60 = 1.732050807569 / 2.0;//Math.Sqrt(3) / 2

        public Hexagone()
        {
            rouge = 0;
            vert = 0;
            bleu = 0;
            hPen = new Pen(Color.Black);
            hPen.Width = 2;
            hBrush = new SolidBrush(Color.FromArgb(rouge, vert, bleu));
        }

        public Hexagone(int q, int r, int centreX, int centreY) : this()
        {
            this.q = q;
            this.r =  - r;
            this.x = Convert.ToInt32(q * rayon * 2 * SIN_60 - r * rayon * SIN_60) + centreX;
            this.y = - r * rayon * 2 * 3 / 4 + centreY;
        }

        public Hexagone(int id, int q, int r, int centreX, int centreY) : this(q, r, centreX, centreY)
        {
            this.id = id;
            //Dégradé bleu et rouge
            this.ChangeColorHexagone(Math.Min(255, id * 2), 0, Math.Max(0, 255-(id*3)));
            //Dégradé de vert
            //this.ChangeColorHexagone(0, Math.Min(255, id * 2), 0);
        }

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

        /*
         * Code pris en ligne, normalement ça marche
         */
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

        public void TestIsHit(int x, int y, int id, FormHexagones form)
        {
            if(IsHit(x, y))
            {
                this.id = id;
                form.OnHexaHit(this);
            }
        }

        public void ChangeColorHexagone(int rouge, int vert, int bleu)
        {
            this.rouge = rouge;
            this.vert = vert;
            this.bleu = bleu;
            hBrush = new SolidBrush(Color.FromArgb(rouge, vert, bleu));
        }

        public string EnregistrerHexa(int id)
        {
            string jsonOutput = JsonConvert.SerializeObject(new HexagoneSimplifie(this));
            Console.WriteLine("EnregistrerHexa" + jsonOutput);
            return jsonOutput;
        }
    }

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
