using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras
{
    internal class Trapezoide
    {
        private float baseMayor;
        private float baseMenor;
        private float altura;
        private float mArea;
        private float mPerimetro;
        private float offsetX = 0;
        private float offsetY = 0;
        private float angulo = 0; // en grados
        private Graphics mGraph;
        private const float SF = 10;
        private Pen mPen = new Pen(Color.Blue, 2);

        public Trapezoide()
        {
            baseMayor = baseMenor = altura = mArea = mPerimetro = 0;
            offsetX = 0; offsetY = 0; angulo = 0;
        }

        public void ReadData(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtAltura)
        {
            try
            {
                baseMayor = float.Parse(txtBaseMayor.Text);
                baseMenor = float.Parse(txtBaseMenor.Text);
                altura = float.Parse(txtAltura.Text);

                if (baseMayor <= 0 || baseMenor <= 0 || altura <= 0)
                    throw new ArgumentException("Todos los valores deben ser positivos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer datos: " + ex.Message, "Error");
                baseMayor = baseMenor = altura = 0;
            }
        }

        public void ReadData(int valor)
        {
            if (valor <= 0)
            {
                MessageBox.Show("El valor debe ser positivo.", "Error");
                baseMayor = baseMenor = altura = 0;
            }
            else
            {
                baseMayor = valor;
                baseMenor = valor * 0.6f;
                altura = valor * 0.5f;
            }
        }
        public void InitializeData(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtAltura, TextBox txtArea, TextBox txtPerimetro, PictureBox picCanvas)
        {
            baseMayor = 0;
            baseMenor = 0;
            altura = 0;
            mArea = 0;
            mPerimetro = 0;
            offsetX = 0;
            offsetY = 0;
            angulo = 0;

            txtBaseMayor.Text = "";
            txtBaseMenor.Text = "";
            txtAltura.Text = "";
            txtArea.Text = "";
            txtPerimetro.Text = "";

            picCanvas.Refresh();
            txtBaseMayor.Focus();
        }


        public void AreaTrapezoide()
        {
            mArea = ((baseMayor + baseMenor) / 2) * altura;
        }

        public void PerimetroTrapezoide()
        {
            // Trapecio isósceles para lados no paralelos
            float lado = (float)Math.Sqrt(Math.Pow((baseMayor - baseMenor) / 2, 2) + Math.Pow(altura, 2));
            mPerimetro = baseMayor + baseMenor + 2 * lado;
        }

        public void PrintData(TextBox txtArea, TextBox txtPerimetro)
        {
            txtArea.Text = mArea.ToString("0.00");
            txtPerimetro.Text = mPerimetro.ToString("0.00");
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
            if (baseMayor <= 0 || baseMenor <= 0 || altura <= 0) return;

            picCanvas.Refresh();
            mGraph = picCanvas.CreateGraphics();

            float centerX = picCanvas.Width / 2f + offsetX;
            float centerY = picCanvas.Height / 2f + offsetY;

            float bm = baseMayor * SF;
            float bmn = baseMenor * SF;
            float h = altura * SF;
            float offset = (bm - bmn) / 2;

            PointF[] puntos = new PointF[4];
            puntos[0] = new PointF(-bm / 2, h / 2);    // Inferior izquierda (relativo)
            puntos[1] = new PointF(bm / 2, h / 2);     // Inferior derecha
            puntos[2] = new PointF(bmn / 2, -h / 2);   // Superior derecha
            puntos[3] = new PointF(-bmn / 2, -h / 2);  // Superior izquierda

            // Aplicar rotación a cada punto
            PointF[] puntosRotados = new PointF[4];
            double rad = angulo * Math.PI / 180.0;
            for (int i = 0; i < 4; i++)
            {
                float x = puntos[i].X;
                float y = puntos[i].Y;
                puntosRotados[i] = new PointF(
                    (float)(x * Math.Cos(rad) - y * Math.Sin(rad)) + centerX,
                    (float)(x * Math.Sin(rad) + y * Math.Cos(rad)) + centerY
                );
            }

            mGraph.DrawPolygon(mPen, puntosRotados);
            mGraph.Dispose();
        }
    }
}
