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
    public partial class UserDetails : Form
    {
        public UserDetails()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox_cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listBox_cities.GetItemText(listBox_cities.SelectedItem);
            MessageBox.Show(text);
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            String name = textBox_name.Text;
            String address = textBox_address.Text;

            if(name == "Never gonna")
            {
                MessageBox.Show("Give you up");
            } else if (name == "What is love")
            {
                MessageBox.Show("Baby don't hurt me");
            } else
            {
                MessageBox.Show(name + " habite à " + address);
            }

            
        }
    }
}
