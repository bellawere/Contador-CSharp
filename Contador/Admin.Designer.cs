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
            ((System.ComponentModel.ISupportInitialize)(this.bg_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.bt_send.Location = new System.Drawing.Point(12, 236);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(484, 31);
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
            this.cb_mon.Location = new System.Drawing.Point(12, 209);
            this.cb_mon.Name = "cb_mon";
            this.cb_mon.Size = new System.Drawing.Size(484, 21);
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
            this.cb_cor.Size = new System.Drawing.Size(98, 17);
            this.cb_cor.TabIndex = 13;
            this.cb_cor.Text = "Fundo branco?";
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(513, 317);
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
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bg_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

