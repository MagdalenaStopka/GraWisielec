using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogikaGry;

namespace WindowsFormsAppWisielec
{
    public partial class FormGra : Form
    {
        private Gra g = null;
        public FormGra()
        {
            InitializeComponent();
            textBoxWzorzec.Visible = false;
            panelWprowadzenie.Visible = false;
            labelWzorzec.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             g = new Gra();
            textBoxWzorzec.Visible = true;
            panelWprowadzenie.Visible = true;
            labelWzorzec.Visible = true;
            textBoxWzorzec.Text = g.AktualnyWzorzec;
            buttonNowaGra.Enabled = false;
            buttonPoddaj.Enabled = true;
            pictureBoxSzubienica.Image = Properties.Resources.Szubienica0;
        }

        private void buttonPoddaj_Click(object sender, EventArgs e)
        {
            Poddaj();

        }

        private void Poddaj()
        {
            string szukaneSlowo;
            szukaneSlowo = g.Poddaj();
            textBoxWzorzec.Text = szukaneSlowo;
            buttonNowaGra.Enabled = true;
            buttonPoddaj.Enabled = false;
            pictureBoxSzubienica.Image = Properties.Resources.Szubienica11;
            panelWprowadzenie.Visible = false;
        }
        private void buttonWyslij_Click(object sender, EventArgs e)
        {
            if (textBoxLitera.Text == null || textBoxLitera.Text.Length != 1)
                return;
            char c = textBoxLitera.Text[0];
            if(g.CzyJest(c))
            {

            }
            else
            {
                string obrazek = $"Szubienica{ (int)g.StanGry}";
                pictureBoxSzubienica.Image = (Image)Properties.Resources.ResourceManager.GetObject(obrazek);
                

            };
            textBoxWzorzec.Text = g.AktualnyWzorzec;
            textBoxLitera.Text = string.Empty;
            textBoxLitera.Focus();
            if (g.StanGry == StanSzubienicy.PrawaNoga)
            {
                Poddaj();
            }
            
        }
    }
}
