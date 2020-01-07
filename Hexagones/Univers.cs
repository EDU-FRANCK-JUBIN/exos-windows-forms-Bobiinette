using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Hexagones
{
    class Univers
    {
        private int taille;
        private int centreX;
        private int centreY;
        private List<Hexagone> listeHexagonnes = null;
        public static UniverIds universIds;

        private Univers()
        {

        }

        /// <summary>
        /// Constructeur avec la taille d'un univers
        /// Définie les ids des hexagones
        /// </summary>
        /// <param name="taille">La taille de l'univers</param>
        private Univers(int taille) :this()
        {
            this.taille = taille;
            universIds = new UniverIds(taille);
        }

        /// <summary>
        /// Constructeur avec la taille et la position du centre de l'univers
        /// Génère l'univers en créant les Hexagones
        /// </summary>
        /// <param name="taille">La taille de l'univers</param>
        /// <param name="x">Position x du centre de l'univers</param>
        /// <param name="y">Position y du centre de l'univers</param>
        public Univers(int taille, int x, int y) : this(taille)
        {
            this.centreX = x;
            this.centreY = y;
            this.listeHexagonnes = generatePadding();
        }

        /// <summary>
        /// Permet de dessiner l'univers à l'écran
        /// </summary>
        /// <param name="bmp">L'image Bitmap dans laquelle on veut dessiner l'univers</param>
        /// <returns>L'image sur laquelle on dessine l'univers avec les hexagones rajoutés</returns>
        public Bitmap drawUniverse(Bitmap bmp)
        {
            using (Graphics graphic = Graphics.FromImage(bmp))
            {
                if (listeHexagonnes == null)
                    return bmp;
                foreach(Hexagone hex in listeHexagonnes)
                {
                    hex.draw(bmp);
                }
            }
            return bmp;
        }

        /// <summary>
        /// Génère la liste des Hexagones
        /// </summary>
        /// <returns>La liste des hexagones</returns>
        public List<Hexagone> generatePadding()
        {
            List<Hexagone> hexas = new List<Hexagone>();

            for (int i = 0; i < this.taille; i++)
            {
                this.generateCoucheI(i, hexas, centreX, centreY);
                //System.Console.WriteLine(hexas.Count);
            }
            return hexas;
        }

        /// <summary>
        /// Génère la couche i des hexagones (chaque couche entoure la couche précédente)
        /// </summary>
        /// <param name="i">Le numéro de la couche</param>
        /// <param name="hexas">La liste des hex</param>
        /// <param name="centreX">Le centre de l'univers sur l'axe x</param>
        /// <param name="centreY">Le centre de l'univers sur l'axe y</param>
        /// <returns></returns>
        public void generateCoucheI(int i, List<Hexagone> hexas, int centreX, int centreY)
        {
            for(int r = -i; r <= i; r++)
            {
                for(int q = -i; q <= i; q++)
                {
                    //On test savoir si au moins q ou r vaut i (Pour ne pas réécrire sur les anciens héxagones)
                    if (Math.Abs(q) != Math.Abs(i) && Math.Abs(r) != Math.Abs(i) && Math.Abs(q - r) != Math.Abs(i))
                    {
                        continue;
                    }
                    //On teste pour ne pas écrire un carré mais pour faire un héxagone
                    if (Math.Abs(r - q) < i + 1)
                    {
                        int nCount = hexas.Count;
                        hexas.Add(new Hexagone(q, -r, centreX, centreY));
                        //System.Console.WriteLine("q " + q + " r " + r);
                    }
                }
            }
        }

        /// <summary>
        /// Teste si un hexagone a été touché lorsque à la position x,y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="form">Le formulaire dans lequel il y a l'univers</param>
        public void OnMouseDown(int x, int y, FormHexagones form)
        {
            int i = 0;
            foreach(Hexagone hexa in listeHexagonnes)
            {
                hexa.TestIsHit(x, y, form);
                i++;
            }
        }

        /// <summary>
        /// Enregistre un univers 
        /// Merci à https://docs.microsoft.com/fr-fr/dotnet/api/system.io.file.open?view=netframework-4.8
        /// </summary>
        /// <returns></returns>
        public string EnregistrerUnivers()
        {
            // Create a temporary file, and put some data into it.
            //string path = Path.GetTempFileName();
            string path = "./hexagones.txt";
            using (FileStream fs = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                int i = 0;
                string sortie = "";
                foreach (Hexagone hexagone in listeHexagonnes)
                {
                    sortie += hexagone.EnregistrerHexa() + "\n";
                    // Add some information to the file.
                    i++;
                }
                Byte[] info = new UTF8Encoding(true).GetBytes(sortie);
                fs.Write(info, 0, info.Length);
            }
            return path;
        }

        /// <summary>
        /// Permet d'importer un univers depuis un fichier json formaté
        /// </summary>
        /// <param name="univers">Chaine de caractère formaté en Json avec tout l'univers</param>
        /// <param name="taille">La taille de l'universe</param>
        public void OuvrirUnivers(string univers, int taille)
        {
            string[] universSplit = univers.Split('\n');
            listeHexagonnes = new List<Hexagone>();
            foreach (string univStr in universSplit)
            {
                Hexagone hex = null;
                try
                {
                    hex = JsonConvert.DeserializeObject<Hexagone>(univStr);
                } catch(Newtonsoft.Json.JsonSerializationException e)
                {
                    //Ignore en cas d'erreur
                }
                if(hex != null)
                {
                    Hexagone hexagone = new Hexagone(hex.Q, hex.R, centreX, centreY);
                    hexagone.ChangeColorHexagone(hex.Rouge, hex.Vert, hex.Bleu);
                    listeHexagonnes.Add(hexagone);
                    Console.WriteLine("Hex rouge " + hex.Rouge + " vert " + hex.Vert + " bleu " + hex.Bleu + " id " + hex.ID);
                }
            }
            //Console.WriteLine("Count " + universImporte.listeHexagonnes.Count);
        }

        /// <summary>
        /// Génère les données à envoyer pour allumer les LEDs
        /// </summary>
        /// <returns></returns>
        public Byte[] generateDMXDatas()
        {
            List<Byte> bytesRGB = new List<Byte>();
            foreach(Hexagone hexagone in listeHexagonnes)
            {
                bytesRGB.Add(Convert.ToByte(hexagone.Rouge));
                bytesRGB.Add(Convert.ToByte(hexagone.Vert));
                bytesRGB.Add(Convert.ToByte(hexagone.Bleu));
            }
            /*
            foreach(Byte b in bytesRGB)
            {
                Console.WriteLine(b);
            }*/
            return bytesRGB.ToArray();
        }
    }
}
