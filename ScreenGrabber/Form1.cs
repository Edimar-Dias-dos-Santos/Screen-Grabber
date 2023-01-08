using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace ScreenGrabber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void GrabScreen()
        {
            Rectangle retangulo = Screen.PrimaryScreen.Bounds;

            Bitmap bitMap = new Bitmap(retangulo.Width, retangulo.Height);

            Graphics grafico = Graphics.FromImage(bitMap);

            grafico.CopyFromScreen(0, 0, 0, 0, retangulo.Size);

            this.BackgroundImage = bitMap;
        }


        private void GrabBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(1000);
            GrabScreen();
            this.Show();
            saveBtn.Enabled = true;

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (this.BackgroundImage == null)
            {
                MessageBox.Show("No image to save");
            }
            else
            {
                this.BackgroundImage.Save("teste.bpm");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            saveBtn.Enabled = false;
        }
    }
}
