using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace supravietuire
{
    
    public partial class joc : Form
    {
        public class Pas
        {
            public string povestePas, poza;
            public int nrVariante;
            public string[] variante;
            public int[] energie;
            public int[] stima;
            public int[] urmator;
            public Pas()
            {

                energie = new int[5];
                stima = new int[5];
                variante = new string[5];
                urmator = new int[5];
            }
        }
        string Povestea;
        Pas[] p;
        int nrPasi, energie, stima ,crt;

        private void Incepe_Click(object sender, EventArgs e)
        {
            Incepe.Visible = false;
            crt = 1;
            poveste.Text = p[crt].povestePas;
            poza.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\poveste\" + p[crt].poza);
            varianta1.Text = p[crt].variante[1];
            varianta2.Text = p[crt].variante[2];
            if (p[crt].nrVariante > 2) { varianta3.Visible = true; varianta3.Text = p[crt].variante[3]; }
            else varianta3.Visible = false;
        }

        private void varianta1_Click(object sender, EventArgs e)
        {
            energie += p[crt].energie[1];
            stima += p[crt].stima[1];
            Lenergie.Text = "Energie:" + energie.ToString();
            Lstima.Text = "Stima:" + stima.ToString();
            crt = p[crt].urmator[1];
            if (energie <= 0 || stima <= 0) crt = nrPasi; // ai pierdut
            poveste.Text = p[crt].povestePas;
            poza.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\poveste\" + p[crt].poza);
            varianta1.Text = p[crt].variante[1];
            varianta2.Text = p[crt].variante[2];
            if (p[crt].nrVariante > 2) { varianta3.Visible = true; varianta3.Text = p[crt].variante[3]; }
            else varianta3.Visible = false;
        }

        private void varianta2_Click(object sender, EventArgs e)
        {
            energie += p[crt].energie[2];
            stima += p[crt].stima[2];
            Lenergie.Text = "Energie:" + energie.ToString();
            Lstima.Text = "Stima:" + stima.ToString();
            crt = p[crt].urmator[2];
            if (energie <= 0 || stima <= 0) crt = nrPasi; // ai pierdut
            poveste.Text = p[crt].povestePas;
            poza.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\poveste\" + p[crt].poza);
            varianta1.Text = p[crt].variante[1];
            varianta2.Text = p[crt].variante[2];
            if (p[crt].nrVariante > 2) { varianta3.Visible = true; varianta3.Text = p[crt].variante[3]; }
            else varianta3.Visible = false;
        }

        private void varianta3_Click(object sender, EventArgs e)
        {
            energie += p[crt].energie[3];
            stima += p[crt].stima[3];
            Lenergie.Text = "Energie:" + energie.ToString();
            Lstima.Text = "Stima:" + stima.ToString();
            crt = p[crt].urmator[3];
            if (energie <= 0 || stima <= 0) crt = nrPasi; // ai pierdut
            poveste.Text = p[crt].povestePas;
            poza.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\poveste\" + p[crt].poza);
            varianta1.Text = p[crt].variante[1];
            varianta2.Text = p[crt].variante[2];
            if (p[crt].nrVariante > 2) { varianta3.Visible = true; varianta3.Text = p[crt].variante[3]; }
            else varianta3.Visible = false;
        }

        void initializare(string nume)
        {
            try
            {
                string[] fin = File.ReadAllLines(nume);
                nrPasi = Int32.Parse(fin[0]); // extrag nr de pasi
                p = new Pas[nrPasi + 2]; // aloc memorie pentru poveste
                for (int i = 0; i < nrPasi + 2; i++) p[i] = new Pas();
                Povestea = fin[1]; // copiez textul initial
                int k = 2;
                for (int i = 1; i <= nrPasi; i++)
                {
                    p[i].povestePas = fin[k]; k++;
                    p[i].poza = fin[k]; k++;
                    p[i].nrVariante = Int32.Parse(fin[k]); k++;
                    for (int j = 1; j <= p[i].nrVariante; j++)
                    {
                        p[i].variante[j] = fin[k]; k++;

                        string[] va = fin[k].Split(' '); k++;

                        p[i].energie[j] = Int32.Parse(va[0]);
                        p[i].stima[j] = Int32.Parse(va[1]);
                        p[i].urmator[j] = Int32.Parse(va[2]);
                    }


                }

            }
            catch
            {
                MessageBox.Show("Eroare la citirea fisierului");
            }
        }
        public joc()
        {
            InitializeComponent();
            initializare(Directory.GetCurrentDirectory() + @"\poveste\poveste.in");
        }

        private void joc_Load(object sender, EventArgs e)
        {
            poveste.Text = Povestea;
            Lenergie.Text = "Energie:" + energie.ToString();
            Lstima.Text = "Stima:" + stima.ToString();
        }
    }
}
