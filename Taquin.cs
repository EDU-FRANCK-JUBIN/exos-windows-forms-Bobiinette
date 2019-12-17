using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class Taquin : Form
    {
        private bool pause = false;
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        static Random rnd = new Random();
        const int n = 3;
        int[,] image = new int[n,n];
        List<PictureBox> picturesBoxs = new List<PictureBox>();
        int nombredeCoups = 0;

        public Taquin()
        {
            InitializeComponent();
            picturesBoxs.Add(pictureBox1);
            picturesBoxs.Add(pictureBox2);
            picturesBoxs.Add(pictureBox3);
            picturesBoxs.Add(pictureBox4);
            picturesBoxs.Add(pictureBox5);
            picturesBoxs.Add(pictureBox6);
            picturesBoxs.Add(pictureBox7);
            picturesBoxs.Add(pictureBox8);
            picturesBoxs.Add(pictureBox9);
        }

        private void OnPictureClick(int i)
        {
            i--;
            if(i/n - 1 >= 0)
            {
                if(IsVoidPosition(i / n - 1, i % n))
                {
                    image[i / n - 1, i % n] = image[i / n, i % n];
                    image[i / n, i % n] = 0;
                    picturesBoxs[i - n].Image = picturesBoxs[i].Image;
                    picturesBoxs[i].Image = Properties.Resources._null;
                    MajCompteur();
                }
            }
            if (i / n + 1 < n)
            {
                if (IsVoidPosition(i / n + 1, i % n))
                {
                    image[i / n + 1, i % n] = image[i / n, i % n];
                    image[i / n, i % n] = 0;
                    picturesBoxs[i + n].Image = picturesBoxs[i].Image;
                    picturesBoxs[i].Image = Properties.Resources._null;
                    MajCompteur();
                }
            }
            if (i % n - 1 >= 0)
            {
                if (IsVoidPosition(i/n, i % n - 1))
                {
                    image[i / n, i % n - 1] = image[i / n, i % n];
                    image[i / n, i % n] = 0;
                    picturesBoxs[i - 1].Image = picturesBoxs[i].Image;
                    picturesBoxs[i].Image = Properties.Resources._null;
                    MajCompteur();
                }
            }
            if (i % n + 1 < n)
            {
                if (IsVoidPosition(i / n, i % n + 1))
                {
                    image[i / n, i % n + 1] = image[i / n, i % n];
                    image[i / n, i % n] = 0;
                    picturesBoxs[i + 1].Image = picturesBoxs[i].Image;
                    picturesBoxs[i].Image = Properties.Resources._null;
                    MajCompteur();
                }
            }
        }

        private bool IsVoidPosition(int x, int y)
        {
            return image[x, y] == 0;
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            List<Bitmap> picturesListe = new List<Bitmap>();
            picturesListe.Add(Properties.Resources._null);
            picturesListe.Add(Properties.Resources._1);
            picturesListe.Add(Properties.Resources._2);
            picturesListe.Add(Properties.Resources._3);
            picturesListe.Add(Properties.Resources._4);
            picturesListe.Add(Properties.Resources._5);
            picturesListe.Add(Properties.Resources._6);
            picturesListe.Add(Properties.Resources._7);
            picturesListe.Add(Properties.Resources._8);
            List<int> valeurs = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

            for (int i = 0; i < 9; i++)
            {
                int r = rnd.Next(picturesListe.Count);
                image[i / n, i % n] = valeurs[r];
                picturesBoxs[i].Image = picturesListe[r];
                picturesListe.RemoveAt(r);
                valeurs.RemoveAt(r);
            }
            labelMoves.Text = "";
            nombredeCoups = 0;
            timer.Restart();
        }

        private bool TestVictory()
        {
            for(int i = 0; i < n; i ++)
            {
                for(int j = 0; j < n; j ++)
                {
                    if(image[i , j] - 1 != i * n + j)
                    {
                        if(i != n - 1 || j != n - 1)
                        {
                            return false;
                        }
                    }
                }
            }
            OnVictory();
            return true;
        }

        private void OnVictory()
        {
            timer.Stop();
            picturesBoxs[n * n - 1].Image = Properties.Resources._9;
            image[n - 1, n - 1] = 9;
            MessageBox.Show("Bravo, vous avez gagné!!", "Bravo");
        }

        private void MajCompteur()
        {
            nombredeCoups++;
            labelMoves.Text = "Nombre de coups : " + nombredeCoups;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnPictureClick(1);
            TestVictory();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OnPictureClick(2);
            TestVictory();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OnPictureClick(3);
            TestVictory();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OnPictureClick(4);
            TestVictory();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OnPictureClick(5);
            TestVictory();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OnPictureClick(6);
            TestVictory();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OnPictureClick(7);
            TestVictory();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OnPictureClick(8);
            TestVictory();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            OnPictureClick(9);
            TestVictory();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            string ms = timer.Elapsed.Milliseconds.ToString();
            string s = timer.Elapsed.Seconds.ToString();
            string m = timer.Elapsed.Minutes.ToString();
            labelTimer.Text = m + ";" + s + ";" + ms;
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if(!pause)
            {
                timer.Stop();
                ChangeTaquin(true);
            } else
            {
                timer.Start();
                ChangeTaquin(false);
            }
            pause = !pause;
        }

        private void ChangeTaquin(bool turnToBlack)
        {
            int j = 0;
            foreach(int i in image)
            {
                if(turnToBlack)
                {
                    picturesBoxs[i].Image = Properties.Resources._null;
                } else
                {
                    switch (i)
                    {
                        case 0:
                            picturesBoxs[j].Image = Properties.Resources._null;
                            break;
                        case 1:
                            picturesBoxs[j].Image = Properties.Resources._1;
                            break;
                        case 2:
                            picturesBoxs[j].Image = Properties.Resources._2;
                            break;
                        case 3:
                            picturesBoxs[j].Image = Properties.Resources._3;
                            break;
                        case 4:
                            picturesBoxs[j].Image = Properties.Resources._4;
                            break;
                        case 5:
                            picturesBoxs[j].Image = Properties.Resources._5;
                            break;
                        case 6:
                            picturesBoxs[j].Image = Properties.Resources._6;
                            break;
                        case 7:
                            picturesBoxs[j].Image = Properties.Resources._7;
                            break;
                        case 8:
                            picturesBoxs[j].Image = Properties.Resources._8;
                            break;
                    }
                }
                j++;
            }
        }
    }
}
