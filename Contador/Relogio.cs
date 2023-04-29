using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Contador
{
    public partial class Relogio : Form
    {
        SolidBrush pincel = new SolidBrush(Color.Black);
        Graphics layout;
        System.Timers.Timer ticker;
        bool invert = false;
        float clkFontSize;

        public Relogio(int screenindex, string time)
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            Text = " ";

            Rectangle limites = Screen.AllScreens[screenindex].Bounds;
            StartPosition = FormStartPosition.Manual;
            SetBounds(limites.X, limites.Y, limites.Width, limites.Height);

            Point borda = new Point(10, 10);

            layout = CreateGraphics();
            layout.FillRectangle(pincel, new Rectangle(borda, Size));

            ticker = new System.Timers.Timer();
            ticker.Interval = 999;
            ticker.Elapsed += Tick;
            ticker.Start();

            tempo.Size = Size;
            tempo.Text = time;
            tempo.ForeColor = Admin.textColor;
            clock.Text = DateTime.Now.ToLongTimeString();
            clock.ForeColor = Admin.extColor;

            clkFontSize = clock.Font.Size;

            float textSize = Math.Min(Size.Height, Size.Width) * Admin.sizeCoef;

            Font font = new Font(FontFamily.GenericSansSerif, textSize, FontStyle.Bold, GraphicsUnit.Pixel);
            tempo.Font = font;

            BackgroundImage = Admin.bg;
            KeyDown += new KeyEventHandler(GetEsc);
            Resize += new EventHandler(GetResize);
            DoubleBuffered = true;
            
        }

        public void GetTime(object sender, TempoEventArgs e)
        {
            string t = "";
            if (e.Late)
            {
                t = "-";
                lb_latetext.Text = e.LateText;
                lb_latetext.ForeColor = Admin.extColor;
            }
            else
            {
                lb_latetext.Text = "";
            }
            t = e.StringedTime;
            if (e.ShowTime)
            {
                invert = true;
                clock.Text = t;
                clock.ForeColor = Admin.textColor;
            }
            else
            {
                invert = false;
                tempo.Text = t;
                tempo.ForeColor = Admin.textColor;
                
            }
            if (BackgroundImage != e.Img)
            {
                BackgroundImage = e.Img;
            }
        }

        public void Tick(object sender, ElapsedEventArgs e)
        {
            if (!invert)
            {
                clock.BeginInvoke((MethodInvoker)delegate () {
                    clock.Text = DateTime.Now.ToLongTimeString();
                    clock.ForeColor = Admin.extColor;
                });
            }
            else
            {
                tempo.BeginInvoke((MethodInvoker)delegate ()
                {
                    tempo.Text = DateTime.Now.ToLongTimeString();
                    tempo.ForeColor = Admin.extColor;
                });
            }
        }

        public void ResizeClock()
        {
            clock.BeginInvoke((MethodInvoker)delegate ()
            {
                float calcMultiplier = Admin.clkSizeMultiplier / 10;
                float textsize = clkFontSize * calcMultiplier;
                clock.Font = new Font(FontFamily.GenericSansSerif, textsize, FontStyle.Bold, GraphicsUnit.Pixel);
            });
        }

        public void GetSize(object sender, SizeEventArgs e)
        {
            float textsize = Math.Min(Size.Height, Size.Width) * e.Size;
            tempo.Font = new Font(FontFamily.GenericSansSerif, textsize, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        public void GetResize(object sender, EventArgs e)
        {
            float textsize = Math.Min(Size.Height, Size.Width) * Admin.sizeCoef;
            tempo.Font = new Font(FontFamily.GenericSansSerif, textsize, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        public void GetEsc(object sender, KeyEventArgs e)
        {
            ticker.Stop();
            e.Handled = true;

            Console.WriteLine("Pressionado: " + e.KeyCode);

            if(e.KeyCode == Keys.Escape)
            {
                Close();
            } else if(e.KeyCode == Keys.Enter)
            {
                if (FormBorderStyle == FormBorderStyle.None)
                {
                    FormBorderStyle = FormBorderStyle.SizableToolWindow;
                } else
                {
                    FormBorderStyle = FormBorderStyle.None;
                }
            }
        }
    }
}
