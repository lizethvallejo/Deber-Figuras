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
    public partial class FrmRomboide : Form
    {
        private Romboide objRomboide = new Romboide();
        public FrmRomboide()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.btnCalculate.PreviewKeyDown += Control_PreviewKeyDown;
            this.btnReset.PreviewKeyDown += Control_PreviewKeyDown;
        }

        private void Control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objRomboide.ReadData(txtLado,txtAngulo);
            objRomboide.PerimeterRomboide();
            objRomboide.AreaRomboide();
            objRomboide.PrintData(txtPerimeter, txtArea);
            objRomboide.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objRomboide.InitializeData(txtLado, txtAngulo, txtPerimeter, txtArea, picCanvas);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int valor = trackBar1.Value;
            txtLado.Text = valor.ToString();
            objRomboide.ReadData(valor, txtAngulo);
            objRomboide.PerimeterRomboide();
            objRomboide.AreaRomboide();
            objRomboide.PrintData(txtPerimeter, txtArea);
            objRomboide.PlotShape(picCanvas);
            this.ActiveControl = null;
        }

        private void FrmRomboide_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    objRomboide.Mover("arriba");
                    break;
                case Keys.Down:
                    objRomboide.Mover("abajo");
                    break;
                case Keys.Left:
                    objRomboide.Mover("izquierda");
                    break;
                case Keys.Right:
                    objRomboide.Mover("derecha");
                    break;
                case Keys.R:
                    objRomboide.Rotar("horario");
                    break;
                case Keys.L:
                    objRomboide.Rotar("antihorario");
                    break;
            }

            objRomboide.PlotShape(picCanvas);
        }

        private void trackBar1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void trackBar1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }
    }
}
