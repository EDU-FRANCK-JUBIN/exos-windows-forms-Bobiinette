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

        private Univers()
        {

        }

        private Univers(int taille) :this()
        {
            this.taille = taille;
        }

        public Univers(int taille, int x, int y) : this(taille)
        {
            this.centreX = x;
            this.centreY = y;
            this.listeHexagonnes = generatePadding();
        }

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

        public List<Hexagone> generateCoucheI(int i, List<Hexagone> hexas, int centreX, int centreY)
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
                        hexas.Add(new Hexagone(nCount, q, r, centreX, centreY));
                        //System.Console.WriteLine("q " + q + " r " + r);
                    }
                }
            }
            return hexas;
        }

        public void OnMouseDown(int x, int y, FormHexagones form)
        {
            int i = 0;
            foreach(Hexagone hexa in listeHexagonnes)
            {
                hexa.TestIsHit(x, y, i, form);
                i++;
            }
        }

        public void ChangeColorHexagone(int id, int rouge, int vert, int bleu)
        {
            listeHexagonnes[id].ChangeColorHexagone(rouge, vert, bleu);
        }

        /**
         * Enregistre un univers
         * Merci à https://docs.microsoft.com/fr-fr/dotnet/api/system.io.file.open?view=netframework-4.8
         */
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
                    sortie += hexagone.EnregistrerHexa(i + 1) + "\n";
                    // Add some information to the file.
                    i++;
                }
                Byte[] info = new UTF8Encoding(true).GetBytes(sortie);
                fs.Write(info, 0, info.Length);
            }
            return path;
        }

        public void OuvrirUnivers(string univers, int taille)
        {
            string[] universSplit = univers.Split('\n');
            foreach(string univStr in universSplit)
            {
                Console.WriteLine("univStr " + univStr);
                Hexagone hex = JsonConvert.DeserializeObject<Hexagone>(univStr);
                if(hex != null)
                {
                    this.ChangeColorHexagone(hex.ID, hex.Rouge, hex.Vert, hex.Bleu);
                }
            }
            //Console.WriteLine("Count " + universImporte.listeHexagonnes.Count);
        }

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
