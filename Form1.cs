using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MihaelZadatak
{
    public partial class Form1 : Form
    {
        List<Govedo> lista = new List<Govedo>();
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void gumbDodaj_Click(object sender, EventArgs e)
        {
            listaGoveda.Items.Add(spolGoveda.Text + " -> " + bojaGoveda.Text);
            lista.Add(new Govedo(bojaGoveda.Text, spolGoveda.Text));
        }

        private void sortSpol_Click(object sender, EventArgs e)
        {
            listaGoveda.Sorted = true;
        }

        private void filtriranjeBoja_Click(object sender, EventArgs e)
        {
            listaGoveda.Items.Clear();
            foreach (Govedo item in lista) {
                if (bojaFiltra.Text == item.Boja) {
                    listaGoveda.Items.Add(item.Spol + " -> " + item.Boja);
                }
            }
        }

        private void filtriranjeSpola_Click(object sender, EventArgs e)
        {
            listaGoveda.Items.Clear();
            foreach (Govedo item in lista)
            {
                if (spolFiltar.Text == item.Spol)
                {
                    listaGoveda.Items.Add(item.Spol + " -> " + item.Boja);
                }
            }
        }
    }
}
