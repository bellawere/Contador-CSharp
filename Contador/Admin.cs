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
using System.IO;

using Contador.Properties;

namespace Contador
{
    public partial class Admin : Form
    {
        private int min;
        private int seg;
        private bool active = false;
        private bool late = false;
        private string tickTime = "";
        private static Color mainColor = Color.White;
        public static Color textColor = mainColor;
        public static Image bg = Resources.bg_sw_flip;
        public static float sizeCoef = 0.58f;

        //Componentes
        private static System.Timers.Timer clock;
        private Screen[] telas;
        private Screen tela;
        private Relogio x;
        public event TimeHolder Contagem;
        private List<string> telasIndex;
        private List<string> console;
        
        public Admin()
        {
            InitializeComponent();
            telas = Screen.AllScreens;
            telasIndex = new List<string>();
            console = new List<string>();

            foreach (Screen x in telas)
            {
                telasIndex.Add(x.DeviceName);
            }

            cb_mon.Items.AddRange(telasIndex.ToArray());
            cb_mon.SelectedItem = cb_mon.Items[0];

            tela = Screen.AllScreens[cb_mon.SelectedIndex] ;

            bt_send.Text = Resources.button_stream;
            bt_start.Text = Resources.button_start;
            bt_stop.Text = Resources.button_stop;
            bt_identify.Text = Resources.button_id;
            lb_min.Text = Resources.label_min;
            lb_seg.Text = Resources.label_seg;
            lb_mon.Text = Resources.label_monitor;
            bt_bg.Text = Resources.button_bg;
            bt_reset_bg.Text = Resources.button_resetbg;
            cb_cor.Text = Resources.check_cor;

            clock = new System.Timers.Timer();
            clock.Interval = 1000;
            clock.Elapsed += Tick;
            bg_view.Image = bg;
            Reset();

            FormClosing += OnClose;

            L("Programa iniciado. Bem vindos.");
        }

        private void Reset()
        {
            L("Resetando relógio");
            min = 0;
            seg = 0;
            textColor = mainColor;
            late = false;
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
            L("Tique");

            if (active)
            {
                if (late)
                {
                    textColor = Color.Red;
                    seg++;
                    if(seg > 59)
                    {
                        min++;
                        seg = 0;
                    }
                }
                else
                {
                    textColor = mainColor;
                    seg--;
                    if (seg < 0)
                    {
                        min--;
                        seg = 59;
                    }

                    if (min < 0)
                    {
                        textColor = Color.Red;
                        late = true;
                        min = 0;
                        seg = 1;
                    }
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
            try
            {
                min = int.Parse(tb_min.Text);
            }
            catch (FormatException)
            {
                min = 0;
            }
            Atualizar();
            L("Minutos: " + min.ToString());
        }

        private void tb_seg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                seg = int.Parse(tb_seg.Text);
            }
            catch (FormatException)
            {
                seg = 0;
            }
            Atualizar();
            L("Segundos: " + seg.ToString());
        }

        private void cb_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            tela = Screen.AllScreens[cb_mon.SelectedIndex];
            L("Tela modificada para " + tela.DeviceName);
        }

        private void Exibir()
        {
            string t = min.ToString("D2") + ":" + seg.ToString("D2");
            x = new Relogio(cb_mon.SelectedIndex, t);
            x.Show();
            L("Exibindo relógio");
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
            L("Cor modificada");
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

            L("Modificando Background...");
            bg_view.Image = bg;
            L("Background modificado");

        }

        private void bt_reset_bg_Click(object sender, EventArgs e)
        {
            bg = Resources.bg_sw_flip;
            bg_view.Image = bg;
            L("Redefinindo Background");
            Atualizar();
        }

        private void bt_identify_Click(object sender, EventArgs e)
        {
            L("Identificando telas");

            int size = telasIndex.Count;

            for(int x = 0; x < size; x++)
            {
                new Identificador(x).Show();
            }
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            L("Fechando...");

            string time = DateTime.Now.ToString();
            string datecorrected = time.Replace(":", "_");
            string spacecorrected = datecorrected.Replace(" ", "_");
            string timeformat = spacecorrected.Replace("/", "_");

            string path = Path.GetTempPath();
            string file = "CSW_log_" + timeformat + ".txt";
            string fullpath = path + file;
            File.AppendAllLines(fullpath, console);
        }

        private void L(string text)
        {
            Console.WriteLine(text + " " + tickTime);

            console.Add(DateTime.Now.ToString() + ": " + text);

            try
            {
                tb_console.Lines = console.ToArray();
                tb_console.AppendText(" ");
            }
            catch (Exception)
            {
                MethodInvoker cs = delegate
                {
                    tb_console.Lines = console.ToArray();
                    tb_console.AppendText(" ");
                };
                Invoke(cs);
            }
        }
    }
}
