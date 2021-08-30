namespace Contador
{
    partial class Identificador
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
            this.number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number.Location = new System.Drawing.Point(0, 0);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(370, 274);
            this.number.TabIndex = 0;
            this.number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Identificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 274);
            this.Controls.Add(this.number);
            this.Name = "Identificador";
            this.Text = "Identificador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label number;
    }
}