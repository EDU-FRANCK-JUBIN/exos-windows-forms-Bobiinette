using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Haukcode.Samples;

namespace Hexagones
{
    public partial class FormHexagones : Form
    {
        //Une constante pour définir la taille de l'univers
        private const int tailleUnivers = 7;

        private Univers univers = null;

        //L'image dans laquelle on va générer l'univers
        private Bitmap bmp;
        
        //Pour gérer la connexion avec les LEDS
        private System.Collections.Generic.IEnumerable<(IPAddress Address, IPAddress NetMask)> addresses;

        //L'hexagone sur lequel on a cliqué
        private Hexagone hexagonesSelectionne;

        public FormHexagones()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Pour créer, puis afficher l'univers. Première fonction à appeler
        /// </summary>
        private new void Show()
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            
            if (univers == null)
            {
                univers = new Univers(tailleUnivers, pictureBox1.Width / 2, pictureBox1.Height / 2);
                Console.WriteLine("---------Creation d'un nouvel univers--------------");
            }
                

            univers.drawUniverse(bmp);
            pictureBox1.Image = bmp;
            //Affichage sur le panneau de LEDs
            ArtNetDisplay();
        }

        /// <summary>
        /// Pour la communication avec le panneau de LEDs.
        /// Récupère l'adresse IP du panneau, et on lui envoie un tableau de bytes avec les couleurs.
        /// </summary>
        private void ArtNetDisplay()
        {
            addresses = Haukcode.ArtNet.Helper.GetAddressesFromInterfaceType();
            System.Console.WriteLine(addresses.ToString());
            univers.generateDMXDatas();
            //if (addresses != null) return;
            
            var addr = addresses.First();
            using (var tester = new SampleCapture(localIp: addr.Address, localSubnetMask: addr.NetMask))
            {
                Console.WriteLine("Start send...");
                
                // Select show
                tester.sendDatas(univers.generateDMXDatas());

                Console.WriteLine("Sended");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Fallait pas double cliquer sur le formulaire
        }

        /// <summary>
        /// Fonction appelée quand on clique sur l'image avec les hexagones.
        /// On vérifie sur quel hexagone on a cliqué
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event qui contient la position du clic</param>
        private void pictureBox1_OnMouseDown(object sender, MouseEventArgs e)
        {
            univers.OnMouseDown(e.X, e.Y, this);
        }

        /// <summary>
        /// On met à jour les trackBars et les affichages numériques lors du clic sur un héxagone
        /// </summary>
        /// <param name="hexa">L'héxagone sur lequel on a cliqué</param>
        public void OnHexaHit(Hexagone hexa)
        {
            hexagonesSelectionne = hexa;
            label_q.Text = hexa.Q.ToString();
            label_r.Text = hexa.R.ToString();
            label_id.Text = hexa.ID.ToString();
            trackBar_rouge.Value = hexa.Rouge;
            trackBar_vert.Value = hexa.Vert;
            trackBar_bleu.Value = hexa.Bleu;
            numericUpDown_rouge.Value = hexa.Rouge;
            numericUpDown_vert.Value = hexa.Vert;
            numericUpDown_bleu.Value = hexa.Bleu;
        }

        /* 
         * Fonctions pour gérer quand on change une valeur numérique sur les trackBar ou les numericUpDown.
         * A chaque fois on met à jour le numericUpDown si on bouge le trackBar ou le trackBar si on change le numericUpDown.
         * Puis, on change la couleur de l'héxagone
         */
        #region
        private void numericUpDown_rouge_ValueChanged(object sender, EventArgs e)
        {
            trackBar_rouge.Value = Convert.ToInt32(numericUpDown_rouge.Value);
            ChangeColorHexagone();
        }

        private void numericUpDown_vert_ValueChanged(object sender, EventArgs e)
        {
            trackBar_vert.Value = Convert.ToInt32(numericUpDown_vert.Value);
            ChangeColorHexagone();
        }

        private void numericUpDown_bleu_ValueChanged(object sender, EventArgs e)
        {
            trackBar_bleu.Value = Convert.ToInt32(numericUpDown_bleu.Value);
            ChangeColorHexagone();
        }

        private void trackBar_rouge_Scroll(object sender, EventArgs e)
        {
            numericUpDown_rouge.Value = trackBar_rouge.Value;
            ChangeColorHexagone();
        }

        private void trackBar_vert_Scroll(object sender, EventArgs e)
        {
            numericUpDown_vert.Value = trackBar_vert.Value;
            ChangeColorHexagone();
        }

        private void trackBar_bleu_Scroll(object sender, EventArgs e)
        {
            numericUpDown_bleu.Value = trackBar_bleu.Value;
            ChangeColorHexagone();
        }
        #endregion

        /// <summary>
        /// Change la couleur de l'héxagone en récupérant les valeurs des trackBars
        /// </summary>
        public void ChangeColorHexagone()
        {
            int rouge = trackBar_rouge.Value;
            int vert = trackBar_vert.Value;
            int bleu = trackBar_bleu.Value;
            hexagonesSelectionne.ChangeColorHexagone(rouge, vert, bleu);
            //On peut faire mieux mais il faut un deuxième thread
            //Il faut éviter d'actualiser en permanence, mais plutôt actualiser toutes les x millisecondes
            this.Show();
        }

        /// <summary>
        /// On enregistre l'état actuel des héxagones dans le fichier à l'emplacement ./Hexagones.txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Votre message a été enregistré dans le fichier : " + univers.EnregistrerUnivers(),
                "Enregistrement effectué",
                MessageBoxButtons.OK);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //Fallait pas double cliquer
        }

        /* Merci Microsoft
         * https://docs.microsoft.com/fr-fr/dotnet/api/system.windows.forms.openfiledialog?view=netframework-4.8
         */
        private void button_ouvrir_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "./";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    AfficherUniversDepuisFichier(filePath);
                }
            }
        }

        /// <summary>
        /// Pour faire de l'annimation avec les LEDs, ne fait rien à l'écran
        /// </summary>
        public void AnnimationLEDs()
        {
            
            //Get the path of specified file
            string filePathBleu = "./hexagonesDegradeBleuRouge.txt";
            string filePathVert = "./hexagonesVerts.txt";
            string filePathNoir = "./hexagonesToutNoir.txt";

            string[] files = new string[5] { filePathBleu, filePathVert, filePathBleu, filePathVert, filePathBleu };

            //Read the contents of the file into a stream
            string fileStream;
            for(int i = 0; i < 5; i++)
            {
                fileStream = files[i];
                AfficherUniversDepuisFichier(fileStream);                
                Thread.Sleep(2000);
            }

            fileStream = filePathNoir;
            AfficherUniversDepuisFichier(fileStream);
        }

        /// <summary>
        /// Pour gérer l'ouverture de fichiers pour l'annimation
        /// </summary>
        /// <param name="fileStream">Le chemin ver le fichier</param>
        private void AfficherUniversDepuisFichier(string fileStream)
        {
            var fileContent = string.Empty;
            try
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                    univers.OuvrirUnivers(fileContent, tailleUnivers);
                    this.Show();
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                MessageBox.Show("Le fichier : " + fileStream + " est introuvable",
                    "",
                    MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Fonction appelée lorsque la fenêtre a chargé.
        /// Mettre ici this.Show pour afficher les héxagones à la fin du chargement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormHexagones_Load(object sender, EventArgs e)
        {
            //A appeler pour un fonctionnement normal
            this.Show();
        }

        /// <summary>
        /// Gère l'event du clic sur l'annimation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_animation_Click(object sender, EventArgs e)
        {
            this.AnnimationLEDs();
        }
    }
}
