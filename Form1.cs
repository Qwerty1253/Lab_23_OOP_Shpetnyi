using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Встановимо початкове значення для параметрів
            textBoxA.Text = "1";
            textBoxTMin.Text = "-10";
            textBoxTMax.Text = "10";
            DrawGraph();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            DrawGraph();
        }

        private void DrawGraph()
        {
            if (!float.TryParse(textBoxA.Text, out float a))
            {
                MessageBox.Show("Будь ласка, введіть правельне значення для а.");
                return;
            }

            if (!float.TryParse(textBoxTMin.Text, out float tMin) || !float.TryParse(textBoxTMax.Text, out float tMax) || tMin >= tMax)
            {
                MessageBox.Show("Будь ласка, введіть правильне значення для tMin і tMax.");
                return;
            }

            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TranslateTransform(width / 2, height / 2);

            Pen axisPen = new Pen(Color.Black, 2);
            Pen graphPen = new Pen(Color.Red, 2);
            Font axisFont = new Font("Arial", 10);
            Brush axisBrush = Brushes.Black;

            // Рисуємо осі
            g.DrawLine(axisPen, -width / 2, 0, width / 2, 0); // Ось X
            g.DrawLine(axisPen, 0, -height / 2, 0, height / 2); // Ось Y

            // Назви осей
            g.DrawString("X", axisFont, axisBrush, width / 2 - 20, -20);
            g.DrawString("Y", axisFont, axisBrush, 10, -height / 2 + 10);

            // Значення на осях
            for (int i = -width / 2; i <= width / 2; i += 50)
            {
                if (i != 0)
                {
                    g.DrawString((i / 50).ToString(), axisFont, axisBrush, i, 5);
                }
            }
            for (int i = -height / 2; i <= height / 2; i += 50)
            {
                if (i != 0)
                {
                    g.DrawString((-i / 50).ToString(), axisFont, axisBrush, 5, i);
                }
            }

            // Параметри для рисування графіка
            float scale = 50.0f;
            float step = (tMax - tMin) / 1000; // Оптимізкємо крок для уникнення зависання

            // Рисуємо параметричну криву
            for (float t = tMin; t <= tMax; t += step)
            {
                try
                {
                    float x = 3 * a * t / (1 + t * t * t);
                    float y = 3 * a * t * t / (1 + t * t);
                    float nextX = 3 * a * (t + step) / (1 + (t + step) * (t + step) * (t + step));
                    float nextY = 3 * a * (t + step) * (t + step) / (1 + (t + step) * (t + step));

                    if (float.IsNaN(x) || float.IsNaN(y) || float.IsNaN(nextX) || float.IsNaN(nextY) ||
                        float.IsInfinity(x) || float.IsInfinity(y) || float.IsInfinity(nextX) || float.IsInfinity(nextY))
                    {
                        continue; // Пропускаємо недопустимі значення
                    }

                    g.DrawLine(graphPen, x * scale, -y * scale, nextX * scale, -nextY * scale);
                }
                catch (OverflowException)
                {
                    // Пропускаємо значення, викликаючі переповнення
                    continue;
                }
            }

            // Відображаємо зображення в PictureBox
            pictureBox1.Image = bmp;
        }
    }
}
