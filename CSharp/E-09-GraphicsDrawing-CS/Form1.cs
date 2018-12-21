using System.Drawing;
using System.Windows.Forms;

namespace E_09_GraphicsDrawing_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Width = 500;
            Height = 500;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var gr = e.Graphics;

            Pen myPen = new Pen(Color.Black);
            Brush myBrush = new SolidBrush(Color.Red);

            gr.FillRectangle(new SolidBrush(Color.Aqua), 0, 0, Width, Height);
            gr.FillRectangle(new SolidBrush(Color.ForestGreen),0,300,Width, Height );
        }
    }
}