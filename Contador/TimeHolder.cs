using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador
{
    public delegate void TimeHolder(object sender, TempoEventArgs e);

    public class TempoEventArgs : EventArgs
    {
        private int min;
        private int seg;

        public int Min { get => min; set => min = value; }
        public int Seg { get => seg; set => seg = value; }
        public Image Img { get; set; }
    }
}
