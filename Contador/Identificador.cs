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
    public partial class Identificador : Form
    {
        System.Timers.Timer clock = new System.Timers.Timer();

        public Identificador(int tela)
        {
            InitializeComponent();
            Screen scr = Screen.AllScreens[tela];
            Console.WriteLine("Abrindo identificador...");
            Console.WriteLine("Tela: " + tela + ", Specs: " + scr);
            FormBorderStyle = FormBorderStyle.None;

            Rectangle limites = scr.Bounds;
            StartPosition = FormStartPosition.Manual;
            SetBounds(limites.X, limites.Y, limites.Width, limites.Height / 10);
            
            int textSize = Size.Height;

            Font font = new Font(FontFamily.GenericSansSerif, textSize, FontStyle.Bold, GraphicsUnit.Pixel);
            number.Font = font;
            number.ForeColor = Color.Black;
            number.BackColor = Color.LightGray;
            number.Text = scr.DeviceName;

            clock.Interval = 3000;
            clock.Elapsed += Die;
            clock.Start();
        }

        private void Die(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Fechando identificador...");
            clock.Stop();
            Kill();
        }

        private void Kill()
        {
            MethodInvoker inv = delegate
            {
                Close();
            };
            Invoke(inv);
        }
    }
}
