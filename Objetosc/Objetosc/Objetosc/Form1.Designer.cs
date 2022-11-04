namespace Objetosc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Kalk = new System.Windows.Forms.Button();
            this.WLabel = new System.Windows.Forms.Label();
            this.HLabel = new System.Windows.Forms.Label();
            this.Dlabel = new System.Windows.Forms.Label();
            this.Wdt = new System.Windows.Forms.NumericUpDown();
            this.Hgt = new System.Windows.Forms.NumericUpDown();
            this.Dpt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Wdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hgt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dpt)).BeginInit();
            this.SuspendLayout();
            // 
            // Kalk
            // 
            this.Kalk.Location = new System.Drawing.Point(250, 100);
            this.Kalk.Name = "Kalk";
            this.Kalk.Size = new System.Drawing.Size(120, 25);
            this.Kalk.TabIndex = 3;
            this.Kalk.Text = "Oblicz objętość";
            this.Kalk.UseVisualStyleBackColor = true;
            this.Kalk.Click += new System.EventHandler(this.Kalk_Click);
            // 
            // WLabel
            // 
            this.WLabel.AutoSize = true;
            this.WLabel.Location = new System.Drawing.Point(50, 32);
            this.WLabel.Name = "WLabel";
            this.WLabel.Size = new System.Drawing.Size(59, 15);
            this.WLabel.TabIndex = 2;
            this.WLabel.Text = "Szerokość";
            this.WLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HLabel
            // 
            this.HLabel.AutoSize = true;
            this.HLabel.Location = new System.Drawing.Point(250, 32);
            this.HLabel.Name = "HLabel";
            this.HLabel.Size = new System.Drawing.Size(60, 15);
            this.HLabel.TabIndex = 3;
            this.HLabel.Text = "Wysokość";
            // 
            // Dlabel
            // 
            this.Dlabel.AutoSize = true;
            this.Dlabel.Location = new System.Drawing.Point(50, 84);
            this.Dlabel.Name = "Dlabel";
            this.Dlabel.Size = new System.Drawing.Size(62, 15);
            this.Dlabel.TabIndex = 6;
            this.Dlabel.Text = "Głębokość";
            // 
            // Wdt
            // 
            this.Wdt.Location = new System.Drawing.Point(50, 50);
            this.Wdt.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.Wdt.Name = "Wdt";
            this.Wdt.Size = new System.Drawing.Size(120, 23);
            this.Wdt.TabIndex = 0;
            // 
            // Hgt
            // 
            this.Hgt.Location = new System.Drawing.Point(250, 50);
            this.Hgt.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.Hgt.Name = "Hgt";
            this.Hgt.Size = new System.Drawing.Size(120, 23);
            this.Hgt.TabIndex = 1;
            // 
            // Dpt
            // 
            this.Dpt.Location = new System.Drawing.Point(50, 100);
            this.Dpt.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.Dpt.Name = "Dpt";
            this.Dpt.Size = new System.Drawing.Size(120, 23);
            this.Dpt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.Dpt);
            this.Controls.Add(this.Hgt);
            this.Controls.Add(this.Wdt);
            this.Controls.Add(this.Dlabel);
            this.Controls.Add(this.HLabel);
            this.Controls.Add(this.WLabel);
            this.Controls.Add(this.Kalk);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oblicz objętość";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hgt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dpt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button Kalk;
        private Label WLabel;
        private Label HLabel;
        private Label Dlabel;
        private NumericUpDown Wdt;
        private NumericUpDown Hgt;
        private NumericUpDown Dpt;
    }
}