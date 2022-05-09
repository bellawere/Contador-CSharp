namespace Contador
{
    partial class Admin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.tb_min = new System.Windows.Forms.TextBox();
            this.lb_min = new System.Windows.Forms.Label();
            this.lb_seg = new System.Windows.Forms.Label();
            this.tb_seg = new System.Windows.Forms.TextBox();
            this.bt_send = new System.Windows.Forms.Button();
            this.bg_view = new System.Windows.Forms.PictureBox();
            this.bt_bg = new System.Windows.Forms.Button();
            this.bt_reset_bg = new System.Windows.Forms.Button();
            this.cb_mon = new System.Windows.Forms.ComboBox();
            this.lb_mon = new System.Windows.Forms.Label();
            this.cb_cor = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_identify = new System.Windows.Forms.Button();
            this.lb_console = new System.Windows.Forms.Label();
            this.tb_console = new System.Windows.Forms.TextBox();
            this.time_return = new System.Windows.Forms.Label();
            this.lb_textsize = new System.Windows.Forms.Label();
            this.tr_textsize = new System.Windows.Forms.TrackBar();
            this.lb_lateText = new System.Windows.Forms.Label();
            this.tb_lateTxt = new System.Windows.Forms.TextBox();
            this.cb_switchClk = new System.Windows.Forms.CheckBox();
            this.lb_clksize = new System.Windows.Forms.Label();
            this.tr_clksize = new System.Windows.Forms.TrackBar();
            this.bt_clockcolor = new System.Windows.Forms.Button();
            this.cd_clkcolor = new System.Windows.Forms.ColorDialog();
            this.lb_colorpick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bg_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_textsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_clksize)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(340, 8);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 0;
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(421, 8);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(75, 23);
            this.bt_stop.TabIndex = 1;
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // tb_min
            // 
            this.tb_min.Location = new System.Drawing.Point(78, 12);
            this.tb_min.Name = "tb_min";
            this.tb_min.Size = new System.Drawing.Size(54, 20);
            this.tb_min.TabIndex = 2;
            this.tb_min.Text = "0";
            this.tb_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_min.TextChanged += new System.EventHandler(this.tb_min_TextChanged);
            // 
            // lb_min
            // 
            this.lb_min.AutoSize = true;
            this.lb_min.Location = new System.Drawing.Point(12, 15);
            this.lb_min.Name = "lb_min";
            this.lb_min.Size = new System.Drawing.Size(0, 13);
            this.lb_min.TabIndex = 3;
            // 
            // lb_seg
            // 
            this.lb_seg.AutoSize = true;
            this.lb_seg.Location = new System.Drawing.Point(174, 15);
            this.lb_seg.Name = "lb_seg";
            this.lb_seg.Size = new System.Drawing.Size(0, 13);
            this.lb_seg.TabIndex = 4;
            // 
            // tb_seg
            // 
            this.tb_seg.Location = new System.Drawing.Point(244, 11);
            this.tb_seg.Name = "tb_seg";
            this.tb_seg.Size = new System.Drawing.Size(56, 20);
            this.tb_seg.TabIndex = 5;
            this.tb_seg.Text = "0";
            this.tb_seg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_seg.TextChanged += new System.EventHandler(this.tb_seg_TextChanged);
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(15, 238);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(480, 31);
            this.bt_send.TabIndex = 6;
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // bg_view
            // 
            this.bg_view.BackColor = System.Drawing.Color.Transparent;
            this.bg_view.Location = new System.Drawing.Point(15, 50);
            this.bg_view.Name = "bg_view";
            this.bg_view.Size = new System.Drawing.Size(377, 117);
            this.bg_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bg_view.TabIndex = 7;
            this.bg_view.TabStop = false;
            // 
            // bt_bg
            // 
            this.bt_bg.Location = new System.Drawing.Point(398, 50);
            this.bt_bg.Name = "bt_bg";
            this.bt_bg.Size = new System.Drawing.Size(98, 44);
            this.bt_bg.TabIndex = 8;
            this.bt_bg.UseVisualStyleBackColor = true;
            this.bt_bg.Click += new System.EventHandler(this.bt_bg_Click);
            // 
            // bt_reset_bg
            // 
            this.bt_reset_bg.Location = new System.Drawing.Point(398, 100);
            this.bt_reset_bg.Name = "bt_reset_bg";
            this.bt_reset_bg.Size = new System.Drawing.Size(98, 44);
            this.bt_reset_bg.TabIndex = 9;
            this.bt_reset_bg.UseVisualStyleBackColor = true;
            this.bt_reset_bg.Click += new System.EventHandler(this.bt_reset_bg_Click);
            // 
            // cb_mon
            // 
            this.cb_mon.FormattingEnabled = true;
            this.cb_mon.Location = new System.Drawing.Point(15, 209);
            this.cb_mon.Name = "cb_mon";
            this.cb_mon.Size = new System.Drawing.Size(480, 21);
            this.cb_mon.TabIndex = 10;
            this.cb_mon.SelectedIndexChanged += new System.EventHandler(this.cb_mon_SelectedIndexChanged);
            // 
            // lb_mon
            // 
            this.lb_mon.AutoSize = true;
            this.lb_mon.Location = new System.Drawing.Point(15, 184);
            this.lb_mon.Name = "lb_mon";
            this.lb_mon.Size = new System.Drawing.Size(0, 13);
            this.lb_mon.TabIndex = 11;
            // 
            // cb_cor
            // 
            this.cb_cor.AutoSize = true;
            this.cb_cor.BackColor = System.Drawing.Color.Transparent;
            this.cb_cor.Location = new System.Drawing.Point(398, 150);
            this.cb_cor.Name = "cb_cor";
            this.cb_cor.Size = new System.Drawing.Size(15, 14);
            this.cb_cor.TabIndex = 13;
            this.cb_cor.UseVisualStyleBackColor = false;
            this.cb_cor.CheckedChanged += new System.EventHandler(this.cb_cor_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Contador.Properties.Resources.sw_logo;
            this.pictureBox1.Location = new System.Drawing.Point(340, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // bt_identify
            // 
            this.bt_identify.Location = new System.Drawing.Point(375, 180);
            this.bt_identify.Name = "bt_identify";
            this.bt_identify.Size = new System.Drawing.Size(120, 23);
            this.bt_identify.TabIndex = 15;
            this.bt_identify.UseVisualStyleBackColor = true;
            this.bt_identify.Click += new System.EventHandler(this.bt_identify_Click);
            // 
            // lb_console
            // 
            this.lb_console.AutoSize = true;
            this.lb_console.Location = new System.Drawing.Point(12, 287);
            this.lb_console.Name = "lb_console";
            this.lb_console.Size = new System.Drawing.Size(0, 13);
            this.lb_console.TabIndex = 16;
            // 
            // tb_console
            // 
            this.tb_console.Enabled = false;
            this.tb_console.Location = new System.Drawing.Point(15, 318);
            this.tb_console.Multiline = true;
            this.tb_console.Name = "tb_console";
            this.tb_console.Size = new System.Drawing.Size(480, 92);
            this.tb_console.TabIndex = 17;
            // 
            // time_return
            // 
            this.time_return.AutoSize = true;
            this.time_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_return.Location = new System.Drawing.Point(513, 8);
            this.time_return.Name = "time_return";
            this.time_return.Size = new System.Drawing.Size(237, 91);
            this.time_return.TabIndex = 18;
            this.time_return.Text = "00:00";
            this.time_return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_textsize
            // 
            this.lb_textsize.AutoSize = true;
            this.lb_textsize.Location = new System.Drawing.Point(529, 130);
            this.lb_textsize.Name = "lb_textsize";
            this.lb_textsize.Size = new System.Drawing.Size(0, 13);
            this.lb_textsize.TabIndex = 19;
            // 
            // tr_textsize
            // 
            this.tr_textsize.Location = new System.Drawing.Point(529, 158);
            this.tr_textsize.Maximum = 48;
            this.tr_textsize.Minimum = 25;
            this.tr_textsize.Name = "tr_textsize";
            this.tr_textsize.Size = new System.Drawing.Size(221, 45);
            this.tr_textsize.TabIndex = 1;
            this.tr_textsize.Value = 48;
            this.tr_textsize.Scroll += new System.EventHandler(this.tr_textsize_Scroll);
            // 
            // lb_lateText
            // 
            this.lb_lateText.AutoSize = true;
            this.lb_lateText.Location = new System.Drawing.Point(532, 216);
            this.lb_lateText.Name = "lb_lateText";
            this.lb_lateText.Size = new System.Drawing.Size(0, 13);
            this.lb_lateText.TabIndex = 20;
            // 
            // tb_lateTxt
            // 
            this.tb_lateTxt.Location = new System.Drawing.Point(529, 248);
            this.tb_lateTxt.Name = "tb_lateTxt";
            this.tb_lateTxt.Size = new System.Drawing.Size(221, 20);
            this.tb_lateTxt.TabIndex = 21;
            // 
            // cb_switchClk
            // 
            this.cb_switchClk.AutoSize = true;
            this.cb_switchClk.Location = new System.Drawing.Point(529, 289);
            this.cb_switchClk.Name = "cb_switchClk";
            this.cb_switchClk.Size = new System.Drawing.Size(15, 14);
            this.cb_switchClk.TabIndex = 22;
            this.cb_switchClk.UseVisualStyleBackColor = true;
            this.cb_switchClk.CheckedChanged += new System.EventHandler(this.cb_switchClk_CheckedChanged);
            // 
            // lb_clksize
            // 
            this.lb_clksize.AutoSize = true;
            this.lb_clksize.Location = new System.Drawing.Point(529, 318);
            this.lb_clksize.Name = "lb_clksize";
            this.lb_clksize.Size = new System.Drawing.Size(0, 13);
            this.lb_clksize.TabIndex = 23;
            // 
            // tr_clksize
            // 
            this.tr_clksize.Location = new System.Drawing.Point(529, 338);
            this.tr_clksize.Maximum = 30;
            this.tr_clksize.Minimum = 5;
            this.tr_clksize.Name = "tr_clksize";
            this.tr_clksize.Size = new System.Drawing.Size(221, 45);
            this.tr_clksize.TabIndex = 24;
            this.tr_clksize.Value = 10;
            this.tr_clksize.Scroll += new System.EventHandler(this.tr_clksize_Scroll);
            // 
            // bt_clockcolor
            // 
            this.bt_clockcolor.Location = new System.Drawing.Point(686, 387);
            this.bt_clockcolor.Name = "bt_clockcolor";
            this.bt_clockcolor.Size = new System.Drawing.Size(64, 23);
            this.bt_clockcolor.TabIndex = 25;
            this.bt_clockcolor.UseVisualStyleBackColor = true;
            this.bt_clockcolor.Click += new System.EventHandler(this.bt_clockcolor_Click);
            // 
            // lb_colorpick
            // 
            this.lb_colorpick.AutoSize = true;
            this.lb_colorpick.Location = new System.Drawing.Point(526, 397);
            this.lb_colorpick.Name = "lb_colorpick";
            this.lb_colorpick.Size = new System.Drawing.Size(0, 13);
            this.lb_colorpick.TabIndex = 26;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(772, 422);
            this.Controls.Add(this.lb_colorpick);
            this.Controls.Add(this.bt_clockcolor);
            this.Controls.Add(this.tr_clksize);
            this.Controls.Add(this.lb_clksize);
            this.Controls.Add(this.cb_switchClk);
            this.Controls.Add(this.tb_lateTxt);
            this.Controls.Add(this.lb_lateText);
            this.Controls.Add(this.tr_textsize);
            this.Controls.Add(this.lb_textsize);
            this.Controls.Add(this.time_return);
            this.Controls.Add(this.tb_console);
            this.Controls.Add(this.lb_console);
            this.Controls.Add(this.bt_identify);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cb_cor);
            this.Controls.Add(this.lb_mon);
            this.Controls.Add(this.cb_mon);
            this.Controls.Add(this.bt_reset_bg);
            this.Controls.Add(this.bt_bg);
            this.Controls.Add(this.bg_view);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.tb_seg);
            this.Controls.Add(this.lb_seg);
            this.Controls.Add(this.lb_min);
            this.Controls.Add(this.tb_min);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.DoubleBuffered = true;
            this.Name = "Admin";
            this.Text = "Cronômetro Stereoworks";
            ((System.ComponentModel.ISupportInitialize)(this.bg_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_textsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr_clksize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.TextBox tb_min;
        private System.Windows.Forms.Label lb_min;
        private System.Windows.Forms.Label lb_seg;
        private System.Windows.Forms.TextBox tb_seg;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.PictureBox bg_view;
        private System.Windows.Forms.Button bt_bg;
        private System.Windows.Forms.Button bt_reset_bg;
        private System.Windows.Forms.ComboBox cb_mon;
        private System.Windows.Forms.Label lb_mon;
        private System.Windows.Forms.CheckBox cb_cor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_identify;
        private System.Windows.Forms.Label lb_console;
        private System.Windows.Forms.TextBox tb_console;
        private System.Windows.Forms.Label time_return;
        private System.Windows.Forms.Label lb_textsize;
        private System.Windows.Forms.TrackBar tr_textsize;
        private System.Windows.Forms.Label lb_lateText;
        private System.Windows.Forms.TextBox tb_lateTxt;
        private System.Windows.Forms.CheckBox cb_switchClk;
        private System.Windows.Forms.Label lb_clksize;
        private System.Windows.Forms.TrackBar tr_clksize;
        private System.Windows.Forms.Button bt_clockcolor;
        private System.Windows.Forms.ColorDialog cd_clkcolor;
        private System.Windows.Forms.Label lb_colorpick;
    }
}

