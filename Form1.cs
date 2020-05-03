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
    public partial class supravietuire : Form
    {
        ToolTip tt_padure_tropicala, tt_desert, tt_campie, tt_mare_ocean, tt_padure_temperata, tt_tehnici_de_supravietuire;
        public supravietuire()
        {
            InitializeComponent();
            tt_desert = new ToolTip();
            tt_desert.SetToolTip(this.desert, "Deșert");
            tt_padure_tropicala = new ToolTip();
            tt_padure_tropicala.SetToolTip(this.padure_tropicala, "Pădure tropicală");
            tt_campie = new ToolTip();
            tt_campie.SetToolTip(this.Campie, "Câmpie");
            tt_mare_ocean = new ToolTip();
            tt_mare_ocean.SetToolTip(this.Mare_Ocean, "Mare/Ocean");
            tt_padure_temperata = new ToolTip();
            tt_padure_temperata.SetToolTip(this.Padure_temperata, "Pădure temperată");
            tt_tehnici_de_supravietuire = new ToolTip();
            tt_tehnici_de_supravietuire.SetToolTip(this.Tehnici_de_supravietuire, "Munte");
        }

        private void Padure_temperata_Click(object sender, EventArgs e)
        {
            F_padurea_tropicala pt = new F_padurea_tropicala();
            pt.Left = supravietuire.ActiveForm.Left;
            pt.Top = supravietuire.ActiveForm.Top;
            pt.Height = supravietuire.ActiveForm.Height;
            pt.Width = supravietuire.ActiveForm.Width;
            pt.wb.Navigate(Directory.GetCurrentDirectory() + @"\info\padure_temperata.htm");
            pt.ShowDialog();
        }

        private void padure_tropicala_Click(object sender, EventArgs e)
        {
            F_padurea_tropicala pt = new F_padurea_tropicala();
            pt.Left = supravietuire.ActiveForm.Left;
            pt.Top = supravietuire.ActiveForm.Top;
            pt.Height = supravietuire.ActiveForm.Height;
            pt.Width = supravietuire.ActiveForm.Width;
            pt.wb.Navigate(Directory.GetCurrentDirectory() + @"\info\padure_tropicala.htm");
            pt.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void padure_tropicala_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void desert_MouseHover(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //supravietuire.ActiveForm.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void desert_Click(object sender, EventArgs e)
        {
            F_padurea_tropicala pt = new F_padurea_tropicala();
            pt.Left = supravietuire.ActiveForm.Left;
            pt.Top = supravietuire.ActiveForm.Top;
            pt.Height = supravietuire.ActiveForm.Height;
            pt.Width = supravietuire.ActiveForm.Width;
            pt.wb.Navigate(Directory.GetCurrentDirectory() + @"\info\desert.htm");
            pt.ShowDialog();
        }

        private void Campie_Click(object sender, EventArgs e)
        {
            F_padurea_tropicala pt = new F_padurea_tropicala();
            pt.Left = supravietuire.ActiveForm.Left;
            pt.Top = supravietuire.ActiveForm.Top;
            pt.Height = supravietuire.ActiveForm.Height;
            pt.Width = supravietuire.ActiveForm.Width;
            pt.wb.Navigate(Directory.GetCurrentDirectory() + @"\info\campie.htm");
            pt.ShowDialog();
        }

        private void Mare_Ocean_Click(object sender, EventArgs e)
        {
            F_padurea_tropicala pt = new F_padurea_tropicala();
            pt.Left = supravietuire.ActiveForm.Left;
            pt.Top = supravietuire.ActiveForm.Top;
            pt.Height = supravietuire.ActiveForm.Height;
            pt.Width = supravietuire.ActiveForm.Width;
            pt.wb.Navigate(Directory.GetCurrentDirectory() + @"\info\mare.htm");
            pt.ShowDialog();
        }

        private void Tehnici_de_supravietuire_Click(object sender, EventArgs e)
        {
            F_padurea_tropicala pt = new F_padurea_tropicala();
            pt.Left = supravietuire.ActiveForm.Left;
            pt.Top = supravietuire.ActiveForm.Top;
            pt.Height = supravietuire.ActiveForm.Height;
            pt.Width = supravietuire.ActiveForm.Width;
            pt.wb.Navigate(Directory.GetCurrentDirectory() + @"\info\munte.htm");
            pt.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            joc j = new joc();
            j.Left = supravietuire.ActiveForm.Left;
            j.Top = supravietuire.ActiveForm.Top;
            j.Height = supravietuire.ActiveForm.Height;
            j.Width = supravietuire.ActiveForm.Width;
            j.ShowDialog();
        }

        private void Tehnici_de_supravietuire_MouseHover(object sender, EventArgs e)
        {

        }

        private void Padure_temperata_MouseHover(object sender, EventArgs e)
        {

        }

        private void Mare_Ocean_MouseHover(object sender, EventArgs e)
        {

        }

        private void Campie_MouseHover(object sender, EventArgs e)
        {

        }

        private void supravietuire_Load(object sender, EventArgs e)
        {

        }
    }
}
