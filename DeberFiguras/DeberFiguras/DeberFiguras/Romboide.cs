using System;
using System.Drawing;
using System.Windows.Forms;

namespace DeberFiguras
{
    internal class Romboide
    {
        private float mLado;
        private float mAngulo;
        private float mPerimeter;
        private float mArea;
        private float offsetX, offsetY;
        private float anguloRotacion;
        private Graphics mGraph;
        private const float SF = 10;
        private Pen mPen;

        public Romboide()
        {
            mLado = 0.0f;
            mAngulo = 0.0f;
            offsetX = offsetY = 0;
            anguloRotacion = 0;
        }

        public void ReadData(TextBox txtLado, TextBox txtAngulo)
        {
            try
            {
                mLado = float.Parse(txtLado.Text);
                mAngulo = float.Parse(txtAngulo.Text);

                if (mLado <= 0 || mAngulo <= 0 || mAngulo >= 180)
                    throw new ArgumentException("Valores inválidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer datos: " + ex.Message, "Error");
                mLado = 0.0f;
                mAngulo = 0.0f;
            }
        }

        // Sobrecarga: leer lado desde un TrackBar y ángulo desde TextBox
        public void ReadData(int valorTrackBar, TextBox txtAngulo)
        {
            try
            {
                mLado = valorTrackBar;
                mAngulo = float.Parse(txtAngulo.Text);

                if (mLado <= 0 || mAngulo <= 0 || mAngulo >= 180)
                    throw new ArgumentException("Valores inválidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer datos: " + ex.Message, "Error");
                mLado = 0.0f;
                mAngulo = 0.0f;
            }
        }

        public void InitializeData(TextBox txtLado, TextBox txtAngulo, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mLado = 0.0f;
            mAngulo = 0.0f;
            offsetX = offsetY = 0;
            anguloRotacion = 0;

            txtLado.Text = "";
            txtAngulo.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtLado.Focus();
            picCanvas.Refresh();
        }

        public void PerimeterRomboide()
        {
            // Un romboide tiene lados opuestos iguales: 2 lados largos + 2 lados cortos
            // En este caso asumimos un romboide con todos los lados iguales (romboide equilátero)
            // o simplemente que mLado representa ambos pares.
            mPerimeter = 4 * mLado;
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }


        public void AreaRomboide()
        {
            // Área = base * altura
            // altura = lado * sin(ángulo)
            float anguloRad = mAngulo * (float)Math.PI / 180f;
            float altura = mLado * (float)Math.Sin(anguloRad);
            mArea = mLado * altura;
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
            if (sentido == "horario") anguloRotacion += paso;
            else if (sentido == "antihorario") anguloRotacion -= paso;
        }

        public void PlotShape(PictureBox picCanvas)
        {
            if (mLado <= 0 || mAngulo <= 0) return;

            picCanvas.Refresh();
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 2);

            float centerX = picCanvas.Width / 2f + offsetX;
            float centerY = picCanvas.Height / 2f + offsetY;
            float anguloRad = mAngulo * (float)Math.PI / 180f;

            float baseX = mLado * SF;
            float heightY = (float)(mLado * SF * Math.Sin(anguloRad));
            float offsetXDiagonal = (float)(mLado * SF * Math.Cos(anguloRad));

            PointF[] puntos = new PointF[4];
            puntos[0] = new PointF(centerX, centerY);
            puntos[1] = new PointF(centerX + baseX, centerY);
            puntos[2] = new PointF(centerX + baseX + offsetXDiagonal, centerY - heightY);
            puntos[3] = new PointF(centerX + offsetXDiagonal, centerY - heightY);

            if (anguloRotacion != 0)
            {
                for (int i = 0; i < puntos.Length; i++)
                {
                    puntos[i] = RotarPunto(puntos[i], new PointF(centerX, centerY), anguloRotacion);
                }
            }

            mGraph.DrawPolygon(mPen, puntos);
            mGraph.Dispose();
        }

        private PointF RotarPunto(PointF p, PointF centro, float anguloGrados)
        {
            float anguloRad = anguloGrados * (float)Math.PI / 180f;
            float cosA = (float)Math.Cos(anguloRad);
            float sinA = (float)Math.Sin(anguloRad);

            float dx = p.X - centro.X;
            float dy = p.Y - centro.Y;

            float xRot = centro.X + dx * cosA - dy * sinA;
            float yRot = centro.Y + dx * sinA + dy * cosA;

            return new PointF(xRot, yRot);
        }
    }
}
