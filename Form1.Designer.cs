namespace tcpserwer
{
    partial class Form1
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
            this.adres = new System.Windows.Forms.TextBox();
            this.myport = new System.Windows.Forms.NumericUpDown();
            this.infoopolaczeniu = new System.Windows.Forms.ListBox();
            this.przyciskstart = new System.Windows.Forms.Button();
            this.przyciskstop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myport)).BeginInit();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(21, 26);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(401, 20);
            this.adres.TabIndex = 0;
            this.adres.Text = "adres";
            // 
            // myport
            // 
            this.myport.Location = new System.Drawing.Point(484, 27);
            this.myport.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.myport.Name = "myport";
            this.myport.Size = new System.Drawing.Size(268, 20);
            this.myport.TabIndex = 1;
            // 
            // infoopolaczeniu
            // 
            this.infoopolaczeniu.FormattingEnabled = true;
            this.infoopolaczeniu.Location = new System.Drawing.Point(85, 99);
            this.infoopolaczeniu.Name = "infoopolaczeniu";
            this.infoopolaczeniu.Size = new System.Drawing.Size(570, 290);
            this.infoopolaczeniu.TabIndex = 2;
            // 
            // przyciskstart
            // 
            this.przyciskstart.Location = new System.Drawing.Point(96, 434);
            this.przyciskstart.Name = "przyciskstart";
            this.przyciskstart.Size = new System.Drawing.Size(206, 56);
            this.przyciskstart.TabIndex = 3;
            this.przyciskstart.Text = "start";
            this.przyciskstart.UseVisualStyleBackColor = true;
            // 
            // przyciskstop
            // 
            this.przyciskstop.Location = new System.Drawing.Point(449, 434);
            this.przyciskstop.Name = "przyciskstop";
            this.przyciskstop.Size = new System.Drawing.Size(206, 56);
            this.przyciskstop.TabIndex = 4;
            this.przyciskstop.Text = "stop";
            this.przyciskstop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 523);
            this.Controls.Add(this.przyciskstop);
            this.Controls.Add(this.przyciskstart);
            this.Controls.Add(this.infoopolaczeniu);
            this.Controls.Add(this.myport);
            this.Controls.Add(this.adres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.NumericUpDown myport;
        private System.Windows.Forms.ListBox infoopolaczeniu;
        private System.Windows.Forms.Button przyciskstart;
        private System.Windows.Forms.Button przyciskstop;
    }
}

