using Figuras;
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
    public partial class FrmTrapezoide : Form
    {
        private Trapezoide objTrapezoide = new Trapezoide();
        public FrmTrapezoide()
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
            objTrapezoide.ReadData(txtBaseMayor, txtBaseMenor, txtAltura);
            objTrapezoide.PerimetroTrapezoide();
            objTrapezoide.AreaTrapezoide();
            objTrapezoide.PrintData(txtPerimeter, txtArea);
            objTrapezoide.PlotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            objTrapezoide.InitializeData(txtBaseMayor, txtBaseMenor, txtAltura, txtPerimeter, txtArea, picCanvas);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int valor = trackBar1.Value;
            txtBaseMayor.Text = (valor).ToString();
            txtBaseMenor.Text = (valor*0.6f).ToString();
            txtAltura.Text = (valor*0.5f).ToString();
            objTrapezoide.ReadData(valor);
            objTrapezoide.PerimetroTrapezoide();
            objTrapezoide.AreaTrapezoide();
            objTrapezoide.PrintData(txtPerimeter, txtArea);
            objTrapezoide.PlotShape(picCanvas);
            this.ActiveControl = null;
        }

        private void FrmTrapezoide_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    objTrapezoide.Mover("arriba");
                    break;
                case Keys.Down:
                    objTrapezoide.Mover("abajo");
                    break;
                case Keys.Left:
                    objTrapezoide.Mover("izquierda");
                    break;
                case Keys.Right:
                    objTrapezoide.Mover("derecha");
                    break;
                case Keys.R:
                    objTrapezoide.Rotar("horario");
                    break;
                case Keys.L:
                    objTrapezoide.Rotar("antihorario");
                    break;
            }

            objTrapezoide.PlotShape(picCanvas);
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
