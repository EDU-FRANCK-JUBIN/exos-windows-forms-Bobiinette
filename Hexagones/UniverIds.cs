using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexagones
{
    /// <summary>
    /// Classe pour générer les ids des Hexagones en fonction de leur position
    /// Voir le cours du prof Initiation CS 07 page 81 pour plus d'explications
    /// </summary>
    public class UniverIds
    {
        private int taille;
        //Un tableau deux dimensions avec les ids des Hexagones en fonction de leur position q et r
        private int[,] ids;

        //Les positions q et r à la position actuelle
        private int q = 0;
        private int r = 0;

        /// <summary>
        /// Constructeur de l'UniversIds avec sa taille (la taille de l'univers)
        /// </summary>
        /// <param name="taille">La taille de l'univers</param>
        public UniverIds(int taille)
        {
            this.ids = new int[(taille - 1) * 2 + 1, (taille - 1) * 2 + 1];
            this.taille = taille;
            q = taille - 1;
            r = taille - 1;
            this.GenerateIds();
        }

        /// <summary>
        /// Accesseur Get pour l'id
        /// </summary>
        /// <param name="q">La position q de l'hexagone</param>
        /// <param name="r">La position r de l'hexagone</param>
        /// <returns>L'id de l'hexagone à la position q,r</returns>
        public int this[int q, int r]
        {
            get { return ids[taille - 1 + q, taille - 1 + r]; }
        }

        /// <summary>
        /// Génère les ids des Hexagones en fonction de leur position q et r.
        /// Stocke l'id dans le tableau
        /// </summary>
        public void GenerateIds()
        {
            int id = 1;
            int nombreHexagoneCouche;
            int casActuel = 0;
            int nombreAvancement = 0;
            ids[q, r] = id++;
            q++;
            for (int i = 1; i < this.taille; i ++)
            {
                nombreHexagoneCouche = i * 6;

                for(int j = 0; j < nombreHexagoneCouche; j ++)
                {
                    ids[q, r] = id++;
                    Avance(casActuel);
                    nombreAvancement++;

                    if(nombreAvancement == i)
                    {
                        casActuel = AvanceCas(casActuel);
                        nombreAvancement = 0;
                    }

                    if(j == nombreHexagoneCouche - 2)
                    {
                        casActuel = ReculeCas(casActuel);
                        nombreAvancement = i - 1;
                    }
                }
                nombreAvancement++;
            }
        }

        /// <summary>
        /// On avance de 1 dans la position des ids
        /// </summary>
        /// <param name="position">La position actuelle</param>
        /// <returns></returns>
        private int AvanceCas(int casActuel)
        {
            return (casActuel + 1) % 6;
        }

        /// <summary>
        /// On recule de 1 dans la position des ids
        /// </summary>
        /// <param name="position">La position actuelle</param>
        /// <returns></returns>
        private int ReculeCas(int casActuel)
        {
            return (casActuel - 1 + 6) % 6;
        }

        private void Avance(int casActuel)
        {
            switch(casActuel)
            {
                case 0:
                    this.q--;
                    this.r++;
                    break;
                case 1:
                    this.q--;
                    break;
                case 2:
                    this.r--;
                    break;
                case 3:
                    this.q++;
                    this.r--;
                    break;
                case 4:
                    this.q++;
                    break;
                case 5:
                    this.r++;
                    break;
                default:
                    break;
            }
        }
    }
}
