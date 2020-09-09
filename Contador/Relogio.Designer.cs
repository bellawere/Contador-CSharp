namespace Contador
{
    partial class Relogio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tempo
            // 
            this.tempo.BackColor = System.Drawing.Color.Transparent;
            this.tempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempo.ForeColor = System.Drawing.SystemColors.Control;
            this.tempo.Location = new System.Drawing.Point(0, 0);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(800, 450);
            this.tempo.TabIndex = 0;
            this.tempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Relogio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tempo);
            this.KeyPreview = true;
            this.Name = "Relogio";
            this.Text = "Relogio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tempo;
    }
}