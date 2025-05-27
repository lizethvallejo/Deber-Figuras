using System;
using System.Drawing;
using System.Windows.Forms;

namespace DeberFiguras
{
    internal class Rombo
    {
        private float mLado;
        private float mAngulo; // en grados
        private float offsetX, offsetY;
        private float anguloRotacion;
        private float mPerimetro;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 10; // factor de escala
        private Pen mPen;

        public Rombo()
        {
            mLado = 0.0f;
            mAngulo = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
            offsetX = 0;
            offsetY = 0;
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

        public void ReadData(int valorLado, TextBox txtAngulo)
        {
            try
            {
                mLado = valorLado;
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


        public void ReadData(float valorLado, float valorAngulo)
        {
            if (valorLado <= 0 || valorAngulo <= 0 || valorAngulo >= 180)
            {
                MessageBox.Show("Valores inválidos.", "Mensaje error");
                mLado = 0.0f;
                mAngulo = 0.0f;
            }
            else
            {
                mLado = valorLado;
                mAngulo = valorAngulo;
            }
        }

        public void PerimeterRombo()
        {
            mPerimetro = 4 * mLado;
        }

        public void AreaRombo()
        {
            // Área = L² * sin(ángulo en radianes)
            float rad = mAngulo * (float)Math.PI / 180f;
            mArea = mLado * mLado * (float)Math.Sin(rad);
        }

        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }

        public void InitializeData(TextBox txtLado, TextBox txtAngulo, TextBox txtPerimetro, TextBox txtArea, PictureBox picCanvas)
        {
            mLado = 0.0f;
            mAngulo = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
            offsetX = 0;
            offsetY = 0;
            anguloRotacion = 0;

            txtLado.Text = "";
            txtAngulo.Text = "";
            txtPerimetro.Text = "";
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
            if (sentido == "horario") anguloRotacion += paso;
            else if (sentido == "antihorario") anguloRotacion -= paso;
        }

        public void PlotShape(PictureBox picCanvas)
        {
            if (mLado <= 0 || mAngulo <= 0 || mAngulo >= 180) return;

            picCanvas.Refresh();
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 2);

            float centerX = picCanvas.Width / 2f + offsetX;
            float centerY = picCanvas.Height / 2f + offsetY;
            float diagMayor = mLado * (float)Math.Sin(mAngulo * Math.PI / 180f) * SF * 2;
            float diagMenor = mLado * (float)Math.Cos(mAngulo * Math.PI / 180f) * SF * 2;

            float baseAngle = anguloRotacion * (float)Math.PI / 180f;

            PointF[] rombo = new PointF[4];
            rombo[0] = RotatePoint(centerX, centerY - diagMayor / 2, centerX, centerY, baseAngle);
            rombo[1] = RotatePoint(centerX + diagMenor / 2, centerY, centerX, centerY, baseAngle);
            rombo[2] = RotatePoint(centerX, centerY + diagMayor / 2, centerX, centerY, baseAngle);
            rombo[3] = RotatePoint(centerX - diagMenor / 2, centerY, centerX, centerY, baseAngle);

            mGraph.DrawPolygon(mPen, rombo);
            mGraph.Dispose();
        }

        private PointF RotatePoint(float x, float y, float cx, float cy, float angle)
        {
            float dx = x - cx;
            float dy = y - cy;
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);
            return new PointF(
                cx + dx * cos - dy * sin,
                cy + dx * sin + dy * cos
            );
        }
    }
}
