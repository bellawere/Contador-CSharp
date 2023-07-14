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
        private int hour;
        private int min;
        private int seg;

        private int time;

        private bool active = false;
        private bool late = false;
        private bool showtime = false;
        private string tickTime = "";

        private static Color mainColor = Color.White;
        public static Color textColor = mainColor;
        public static Color extColor = mainColor;

        public static Image bg = Resources.bg_sw_flip;

        public static float sizeCoef = 0.48f;
        public static float clkSizeMultiplier = 10f;

        //Componentes
        private static System.Timers.Timer clock;
        private Screen[] telas;
        private Screen tela;
        private Relogio x;
        public event TimeHolder Contagem;
        public event SizeHolder Tamanho;
        private List<string> telasIndex;
        private List<string> console;
        
        public Admin()
        {
            InitializeComponent();
            telasIndex = new List<string>();
            console = new List<string>();

            UpdateScreens();

            cb_mon.SelectedItem = cb_mon.Items[cb_mon.Items.Count - 1];

            tela = Screen.AllScreens[cb_mon.SelectedIndex];

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
            lb_textsize.Text = Resources.label_txtsize;
            cb_switchClk.Text = Resources.label_switchclock;
            lb_lateText.Text = Resources.label_latetext;
            lb_clksize.Text = Resources.label_clocksize;
            lb_colorpick.Text = Resources.label_colorpick;

            cd_clkcolor.Color = extColor;
            bt_clockcolor.BackColor = cd_clkcolor.Color;

            clock = new System.Timers.Timer();
            clock.Interval = 999;
            clock.Elapsed += Tick;

            

            bg_view.Image = bg;
            Reset();

            FormClosing += OnClose;

            L("Programa iniciado. Bem vindos.");
        }

        private void Reset()
        {
            L("Resetando relógio");
            hour = 0;
            min = 0;
            seg = 0;
            textColor = mainColor;
            late = false;
            bt_stop.Text = Resources.button_stop;
        }

        private void Start()
        {
            L("Relógio iniciado");
            clock.Start();
            active = true;
            bt_stop.Text = Resources.button_stop;
        }

        private void Stop()
        {
            L("Relógio parado");
            clock.Stop();
            active = false;
            bt_stop.Text = Resources.button_reset;
        }

        private void UpdateScreens()
        {
            telas = Screen.AllScreens;

            telasIndex.Clear();

            foreach (Screen x in telas)
            {
                telasIndex.Add(x.DeviceName);
            }

            cb_mon.Items.Clear();
            cb_mon.Items.AddRange(telasIndex.ToArray());
        }

        //Eventos de tique, edição e atualização abaixo

        private void Tick(object source, ElapsedEventArgs e)
        {
            if (active)
            {
                //New implement
                time--;

                if(time < 60)
                {
                    seg = time;
                    min = 0;
                    hour = 0;
                }
                else
                {
                    seg = time % 60;
                    int remaining_min = time / 60;

                    if(remaining_min < 60)
                    {
                        min = remaining_min;
                        hour = 0;
                    }
                    else
                    {
                        min = remaining_min % 60;
                        hour = remaining_min / 60;
                    }
                }

                if(time < 0)
                {
                    late = true;
                    textColor = Color.Red;

                    if (time > -60)
                    {
                        seg = time;
                        min = 0;
                        hour = 0;
                    }
                    else
                    {
                        seg = time % 60;
                        int remaining_min = time / 60;

                        if (remaining_min > -60)
                        {
                            min = remaining_min;
                            hour = 0;
                        }
                        else
                        {
                            min = remaining_min % 60;
                            hour = remaining_min / 60;
                        }
                    }
                }
                else
                {
                    late = false;
                    textColor = mainColor;
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
                int rawmin = int.Parse(tb_min.Text);

                time = (rawmin * 60) + seg;

                if (rawmin >= 60)
                {
                    hour = rawmin / 60;
                    min = rawmin % 60;
                }
                else
                {
                    hour = 0;
                    min = rawmin;
                }
            }
            catch (FormatException)
            {
                min = 0;
            }

            Atualizar();
        }

        private void tb_seg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int rawseg = int.Parse(tb_seg.Text);

                if(rawseg >= 60)
                {
                    seg = rawseg % 60;
                    min++;

                    tb_min.Text = ((hour * 60) + min).ToString();
                    tb_seg.Text = seg.ToString();
                }
                else
                {
                    seg = rawseg;
                }

                time = (((hour * 60) + min) * 60) + rawseg;
            }
            catch (FormatException)
            {
                seg = 0;
            }
            Atualizar();
        }

        private void cb_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            tela = Screen.AllScreens[cb_mon.SelectedIndex];
            L("Tela modificada para " + tela.DeviceName);
        }

        private void Exibir()
        {
            if (x != null) {
                x.ticker.Stop();
                x.Close();
                x.Dispose();
                x = null;
                bt_send.Text = Resources.button_stream;
                return;
            }

            string t = 
                hour > 0 ? 
                hour.ToString() + ":" + min.ToString() + ":" + seg.ToString() : 
                min.ToString("D2") + ":" + seg.ToString("D2");
            x = new Relogio(cb_mon.SelectedIndex, t);
            x.Show();
            bt_send.Text = Resources.button_closeclock;
            L("Exibindo relógio");
        }

        private void Atualizar()
        {
            MethodInvoker inv = delegate
            {
                string timestring = "";

                if(hour > 0)
                {
                    timestring = hour.ToString("D2") + ":" + min.ToString("D2") + ":" + seg.ToString("D2");

                }
                else
                {
                    timestring = min.ToString("D2") + ":" + seg.ToString("D2");
                }

                if (timestring.Contains("-"))
                {
                    string corrected = "-";

                    foreach(char c in timestring)
                    {
                        if (c != '-') { corrected += c; }
                    }
                    timestring = corrected;
                }

                time_return.Text = timestring;

                tb_min.Text = hour > 0 ? ((hour * 60)+min).ToString() : min.ToString();
                tb_seg.Text = seg.ToString();
                
                if(x != null)
                {
                    Contagem = new TimeHolder(x.GetTime);
                    SendTime(timestring);
                }
            };

            Invoke(inv);
        }

        private void SendTime(string time)
        {
            TempoEventArgs e = new TempoEventArgs();
            e.StringedTime = time;
            e.Late = late;
            e.ShowTime = showtime;
            e.LateText = tb_lateTxt.Text;
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

        private void tr_textsize_Scroll(object sender, EventArgs e)
        {
            if (showtime)
            {
                float tsize = float.Parse((tr_textsize.Value / 120f).ToString());
                sizeCoef = tsize;

                if (x != null)
                {
                    Tamanho = new SizeHolder(x.GetSize);
                    SizeEventArgs z = new SizeEventArgs();
                    z.Size = tsize;
                    Tamanho?.Invoke(new object(), z);
                }
            }
            else
            {
                float tsize = float.Parse("0," + tr_textsize.Value.ToString());
                sizeCoef = tsize;

                if (x != null)
                {
                    Tamanho = new SizeHolder(x.GetSize);
                    SizeEventArgs z = new SizeEventArgs();
                    z.Size = tsize;
                    Tamanho?.Invoke(new object(), z);
                }
            }
        }

        private void GetKey(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            L("Pressionado: " + e.KeyValue);
        }

        private void cb_switchClk_CheckedChanged(object sender, EventArgs e)
        {
            showtime = cb_switchClk.Checked;
            Atualizar();
        }

        private void tr_clksize_Scroll(object sender, EventArgs e)
        {
            clkSizeMultiplier = tr_clksize.Value;
            if(x != null)
            {
                x.ResizeClock();
            }
        }

        private void bt_clockcolor_Click(object sender, EventArgs e)
        {
            DialogResult colorpick = cd_clkcolor.ShowDialog();
            if(colorpick == DialogResult.OK)
            {
                extColor = cd_clkcolor.Color;
                bt_clockcolor.BackColor = cd_clkcolor.Color;
            }
        }

        private void cb_mon_DropDown(object sender, EventArgs e)
        {
            UpdateScreens();
        }
    }
}
