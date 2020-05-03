namespace supravietuire
{
    partial class joc
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
            this.Poveste = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Varianta1 = new System.Windows.Forms.Label();
            this.Varianta2 = new System.Windows.Forms.Label();
            this.Varianta3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Poveste
            // 
            this.Poveste.AutoSize = true;
            this.Poveste.Location = new System.Drawing.Point(13, 13);
            this.Poveste.Name = "Poveste";
            this.Poveste.Size = new System.Drawing.Size(46, 17);
            this.Poveste.TabIndex = 0;
            this.Poveste.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1324, 302);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Varianta1
            // 
            this.Varianta1.AutoSize = true;
            this.Varianta1.Location = new System.Drawing.Point(9, 386);
            this.Varianta1.Name = "Varianta1";
            this.Varianta1.Size = new System.Drawing.Size(46, 17);
            this.Varianta1.TabIndex = 2;
            this.Varianta1.Text = "label1";
            // 
            // Varianta2
            // 
            this.Varianta2.AutoSize = true;
            this.Varianta2.Location = new System.Drawing.Point(9, 439);
            this.Varianta2.Name = "Varianta2";
            this.Varianta2.Size = new System.Drawing.Size(46, 17);
            this.Varianta2.TabIndex = 3;
            this.Varianta2.Text = "label1";
            // 
            // Varianta3
            // 
            this.Varianta3.AutoSize = true;
            this.Varianta3.Location = new System.Drawing.Point(9, 492);
            this.Varianta3.Name = "Varianta3";
            this.Varianta3.Size = new System.Drawing.Size(46, 17);
            this.Varianta3.TabIndex = 4;
            this.Varianta3.Text = "label1";
            // 
            // joc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.Varianta3);
            this.Controls.Add(this.Varianta2);
            this.Controls.Add(this.Varianta1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Poveste);
            this.Name = "joc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "joc";
            this.Load += new System.EventHandler(this.joc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Poveste;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Varianta1;
        private System.Windows.Forms.Label Varianta2;
        private System.Windows.Forms.Label Varianta3;
    }
}