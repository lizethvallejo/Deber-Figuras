using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeberFiguras
{
    internal class Pentagono
    {
        private float mLado;
        private float offsetX, offsetY;
        private float angulo;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public Pentagono()
        {
            mLado = 0.0f; mPerimeter = 0.0f; mArea = 0.0f; offsetX = 0; offsetY = 0; angulo = 0;
        }


        public void ReadData(TextBox txtLado)
        {
            try
            {
                mLado = float.Parse(txtLado.Text);
                if (mLado < 0)
                {
                    throw new ArgumentException("El valor no puede ser negativo.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Mensaje error");
                mLado = 0.0f; 
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje error");
                mLado = 0.0f;
            }


        }

        public void ReadData(int valor)
        {
            if (valor < 0)
            {
                MessageBox.Show("El valor no puede ser negativo.", "Mensaje error");
                mLado = 0.0f;
            }
            else
            {
                mLado = valor;
            }
        }

        public void PerimeterPentagon()
        {
            mPerimeter = 5 * mLado;
        }

        public void AreaPentagon()
        {
            mArea = (float)(1.720477 * Math.Pow(mLado, 2));
        }
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtLado, TextBox txtPerimeter,
                                    TextBox txtArea,
                                    PictureBox picCanvas)
        {
            mLado = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
            offsetX = 0; offsetY = 0; angulo = 0;

            txtLado.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtLado.Focus();
            picCanvas.Refresh();
        }
        public void Mover(string direccion)
        {
            float paso = 10;

            switch (direccion)
            {
                case "arriba": offsetY -= paso; break;
                case "abajo": offsetY += paso; break;
                case "izquierda": offsetX -= paso; break;
                case "derecha": offsetX += paso; break;
            }
        }

        public void Rotar(string sentido)
        {
            float paso = 10;
            if (sentido == "horario")
                angulo += paso;
            else if (sentido == "antihorario")
                angulo -= paso;
        }

        public void PlotShape(PictureBox picCanvas)
        {
            if (mLado <= 0) return;

            picCanvas.Refresh(); 
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 2);

            float centerX = picCanvas.Width / 2f + offsetX;
            float centerY = picCanvas.Height / 2f + offsetY;

            float radio = mLado * SF; 

            float baseAngle = angulo * (float)Math.PI / 180f;
            PointF[] pentagon = new PointF[5];

            for (int i = 0; i < 5; i++)
            {
                float angle = baseAngle + (i * 2 * (float)Math.PI / 5);
                pentagon[i] = new PointF(
                    centerX + radio * (float)Math.Cos(angle),
                    centerY + radio * (float)Math.Sin(angle)
                );
            }

            mGraph.DrawPolygon(mPen, pentagon);
            mGraph.Dispose(); 
        }


        public void ClearCanvas(PictureBox picCanvas)
        {
            picCanvas.Refresh();
            mGraph.Dispose();
        }
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
