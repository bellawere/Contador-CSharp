using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador
{
    public delegate void SizeHolder(object sender, SizeEventArgs e);

    public class SizeEventArgs : EventArgs
    {
        private float size;

        public float Size { get => size; set => size = value; }
    }
}
