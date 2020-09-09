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

using Contador.Properties;

namespace Contador
{
    public partial class Admin : Form
    {
        private int min;
        private int seg;
        private bool active = false;
        private string tickTime = "";
        private static Color mainColor = Color.White;
        public static Color textColor = mainColor;
        public static Image bg = Resources.bg_sw_flip;

        //Componentes
        private static System.Timers.Timer clock;
        private Screen[] telas;
        private Screen tela;
        private Relogio x;
        public event TimeHolder Contagem;


        public Admin()
        {
            InitializeComponent();
            Reset();
            telas = Screen.AllScreens;

            cb_mon.Items.AddRange(telas);
            cb_mon.SelectedItem = cb_mon.Items[0];

            tela = Screen.AllScreens[cb_mon.SelectedIndex] ;

            bt_send.Text = Resources.button_stream;
            bt_start.Text = Resources.button_start;
            bt_stop.Text = Resources.button_stop;
            lb_min.Text = Resources.label_min;
            lb_seg.Text = Resources.label_seg;
            lb_mon.Text = Resources.label_monitor;
            bt_bg.Text = Resources.button_bg;
            bt_reset_bg.Text = Resources.button_resetbg;
            //Definir cb_color

            clock = new System.Timers.Timer();
            clock.Interval = 1000;
            clock.Elapsed += Tick;
            bg_view.Image = bg;

            L("Programa iniciado. Bem vindos.");
        }

        private void Reset()
        {
            L("Resetando relógio");
            min = 0;
            seg = 0;
            textColor = mainColor;
        }

        private void Start()
        {
            L("Relógio iniciado");
            clock.Start();
            active = true;
        }

        private void Stop()
        {
            L("Relógio parado");
            clock.Stop();
            active = false;
        }

        //Eventos de tique, edição e atualização abaixo

        private void Tick(object source, ElapsedEventArgs e)
        {
            L("Tick");

            if (active)
            {
                seg--;
                if (seg < 0)
                {
                    min--;
                    seg = 59;
                }

                if(min < 0)
                {
                    textColor = Color.Red;
                }
            }

            Atualizar();
            
            tickTime = e.SignalTime.ToString();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            L("Botão de começar ativado");
            Start();
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            L("Botão de parar ativado");
            if (active)
            {
                L("Parando...");
                Stop();
            }
            else
            {
                L("Resetando...");
                Reset();
            }

            Atualizar();
        }

        private void tb_min_TextChanged(object sender, EventArgs e)
        {
            min = int.Parse(tb_min.Text);
            Atualizar();
            L("Minutos modificados para " + min.ToString());
        }

        private void tb_seg_TextChanged(object sender, EventArgs e)
        {
            seg = int.Parse(tb_seg.Text);
            Atualizar();
            L("Segundos modificados para " + seg.ToString());
        }

        private void cb_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            tela = Screen.AllScreens[cb_mon.SelectedIndex];
            L("Tela modificada para " + tela.DeviceName);
        }

        private void Exibir()
        {
            x = new Relogio(cb_mon.SelectedIndex);
            x.Show();
        }

        private void L(string text)
        {
            Console.WriteLine(text + " " + tickTime);
        }

        private void Atualizar()
        {
            MethodInvoker inv = delegate
            {
                tb_min.Text = min.ToString();
                tb_seg.Text = seg.ToString();
                
                if(x != null)
                {
                    Contagem += new TimeHolder(x.GetTime);
                    SendTime();
                }
            };

            Invoke(inv);
        }

        private void SendTime()
        {
            TempoEventArgs e = new TempoEventArgs();
            e.Min = min;
            e.Seg = seg;
            e.Img = bg;
            Contagem?.Invoke(new object(), e);
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            Exibir();
        }

        private void cb_cor_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_cor.Checked)
            {
                mainColor = Color.Black;
                textColor = mainColor;
            }
            else
            {
                mainColor = Color.White;
                textColor = mainColor;
            }
        }

        private void bt_bg_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult d = f.ShowDialog();

            if(d == DialogResult.OK)
            {
                Image newbg = Image.FromFile(f.FileName);
                bg = newbg;
                Atualizar();
            }

            bg_view.Image = bg;

        }

        private void bt_reset_bg_Click(object sender, EventArgs e)
        {
            bg = Resources.bg_sw_flip;
            bg_view.Image = bg;
            Atualizar();
        }
    }
}
