using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supravietuire
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
    public partial class joc : Form
    {
        public joc()
        {
            InitializeComponent();
        }

        private void joc_Load(object sender, EventArgs e)
        {

        }
    }
}
