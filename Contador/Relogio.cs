using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador
{
    public partial class Relogio : Form
    {
        SolidBrush pincel = new SolidBrush(Color.Black);
        Graphics layout;

        public Relogio(int screenindex, string time)
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;

            Rectangle limites = Screen.AllScreens[screenindex].Bounds;
            StartPosition = FormStartPosition.Manual;
            SetBounds(limites.X, limites.Y, limites.Width, limites.Height);

            Point borda = new Point(10, 10);

            layout = CreateGraphics();
            layout.FillRectangle(pincel, new Rectangle(borda, Size));
            
            tempo.Size = Size;
            tempo.Text = time;
            tempo.ForeColor = Admin.textColor;

            float textSize = Size.Height * Admin.sizeCoef;

            Font font = new Font(FontFamily.GenericSansSerif, textSize, FontStyle.Bold, GraphicsUnit.Pixel);
            tempo.Font = font;

            BackgroundImage = Admin.bg;
            KeyDown += new KeyEventHandler(GetEsc);
            DoubleBuffered = true;
            
        }

        public void GetTime(object sender, TempoEventArgs e)
        {
            string t = e.Min.ToString("D2") + ":" + e.Seg.ToString("D2");
            tempo.Text = t;
            tempo.ForeColor = Admin.textColor;
            if (BackgroundImage != e.Img)
            {
                BackgroundImage = e.Img;
            }
        }

        public void GetSize(object sender, SizeEventArgs e)
        {
            float textsize = Size.Height * e.Size;
            tempo.Font = new Font(FontFamily.GenericSansSerif, textsize, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        public void GetEsc(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            Console.WriteLine("Pressionado: " + e.KeyCode);

            if(e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
