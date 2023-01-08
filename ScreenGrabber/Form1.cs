using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenGrabber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Rectangle retangulo = Screen.PrimaryScreen.Bounds;

            Bitmap bitMap = new Bitmap(retangulo.Width, retangulo.Height);

            Graphics grafico = Graphics.FromImage(bitMap);

            grafico.CopyFromScreen(0, 0, 0, 0, retangulo.Size);

            this.BackgroundImage = bitMap;



        }
    }
}
