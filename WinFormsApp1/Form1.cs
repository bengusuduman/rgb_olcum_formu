using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // "Görüntü Yükle" butonu
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyalarý|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                using (var img = Image.FromFile(ofd.FileName))
                {
                    pictureBox1.Image = new Bitmap(img);
                }
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        // "RGB Göster" butonu
        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Önce bir görüntü yükleyin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Resmi Bitmap'e çevir 
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            // TextBox temizle
            textBox1.Clear();

            // Eðer resim çok büyükse küçült 20x20
           
            if (bmp.Width > 20 || bmp.Height > 20)
            {
                bmp = new Bitmap(bmp, new Size(20, 20));
            }

            // Piksel piksel gez ve yaz
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    textBox1.AppendText($"({x},{y}) = RGB({c.R},{c.G},{c.B}){Environment.NewLine}");
                }
            }
        }
        private void label2_Click(object sender, EventArgs e) { 
        }

    }
}
