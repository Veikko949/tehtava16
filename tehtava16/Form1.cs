using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tehtava16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int kokoaika;

        private void Form1_Load(object sender, EventArgs e)
        {
            lopeta_button.Enabled = false;
            for(int i=0; i < 60; i++)
            {
                minuuti_comboBox.Items.Add(i.ToString());
                sekuntti_comboBox.Items.Add(i.ToString());
            }
            minuuti_comboBox.SelectedIndex = 30;
            sekuntti_comboBox.SelectedIndex = 0;
        }

        private void aloita_button_Click(object sender, EventArgs e)
        {
            aloita_button.Enabled = false;
            lopeta_button.Enabled = true;
            int minuuti = int.Parse(minuuti_comboBox.SelectedItem.ToString());
            int sekunnit = int.Parse(sekuntti_comboBox.SelectedItem.ToString());
            kokoaika = (minuuti * 60) + sekunnit;
            timer1.Enabled = true;
        }

        private void lopeta_button_Click(object sender, EventArgs e)
        {
            aloita_button.Enabled = true;
            lopeta_button.Enabled = false;
            kokoaika = 0;
            timer1.Enabled = false;
            ajastin_label.Text = "00:00";
        }

        private void ajastin_timer(object sender, EventArgs e)
        {
            if (kokoaika > 0)
            {
                kokoaika --;
                int minuuti = kokoaika / 60;
                int sekunnit = kokoaika = (minuuti * 60);
                ajastin_label.Text = minuuti.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}
