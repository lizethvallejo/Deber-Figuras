using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeberFiguras
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void OpenForm(Form formulario)
        {
            panelContenedor.Controls.Clear();     // Limpiar contenido anterior
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPentagono());
        }

        private void romboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRombo());
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRomboide());
        }

        private void trapezoideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmTrapezoide());
        }
    }
}
