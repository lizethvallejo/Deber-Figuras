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
    
    public partial class FrmRombo : Form
    {
        private Rombo objRombo = new Rombo();
        public FrmRombo()
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
            objRombo.ReadData(txtLado, txtAngulo);
            objRombo.PerimeterRombo();
            objRombo.AreaRombo();
            objRombo.PrintData(txtPerimeter, txtArea);
            objRombo.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objRombo.InitializeData(txtLado, txtAngulo, txtPerimeter, txtArea, picCanvas);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int valor = trackBar1.Value;
            txtLado.Text = valor.ToString();
            objRombo.ReadData(valor, txtAngulo);
            objRombo.PerimeterRombo();
            objRombo.AreaRombo();
            objRombo.PrintData(txtPerimeter, txtArea);
            objRombo.PlotShape(picCanvas);
            this.ActiveControl = null;
        }

        private void FrmRombo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    objRombo.Mover("arriba");
                    break;
                case Keys.Down:
                    objRombo.Mover("abajo");
                    break;
                case Keys.Left:
                    objRombo.Mover("izquierda");
                    break;
                case Keys.Right:
                    objRombo.Mover("derecha");
                    break;
                case Keys.R:
                    objRombo.Rotar("horario");
                    break;
                case Keys.L:
                    objRombo.Rotar("antihorario");
                    break;
            }

            objRombo.PlotShape(picCanvas);
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
