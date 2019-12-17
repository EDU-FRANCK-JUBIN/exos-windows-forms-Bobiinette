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
    public partial class DataGridChansons : Form
    {
        private List<Artiste> artistes = new List<Artiste>();
        private List<Chanson> chansons = new List<Chanson>();
        public DataGridChansons()
        {
            InitializeComponent();
            Artiste arthur = new Artiste("Arthur");
            arthur.addChanson(new Chanson("Voyage voygae"));
            arthur.addChanson(new Chanson("Pika Girl"));
            arthur.addChanson(new Chanson("Hello world"));
            artistes.Add(arthur);

            Artiste benja = new Artiste("Benja");
            benja.addChanson(new Chanson("J'aime la galette et le csharp"));
            benja.addChanson(new Chanson("Quand c'est propre, c'est propre"));
            artistes.Add(benja);

            Artiste gaetan = new Artiste("Gaetan");
            gaetan.addChanson(new Chanson("Yolo Swag 2k16"));
            artistes.Add(gaetan);

            this.dataGridView1.DataSource = artistes;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = ((DataGridView)sender).Rows[e.RowIndex];
            this.dataGridView2.DataSource = ((Artiste)dataRow.DataBoundItem).Chansons;
        }
    }
}
