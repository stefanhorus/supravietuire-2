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
            this.poveste = new System.Windows.Forms.Label();
            this.poza = new System.Windows.Forms.PictureBox();
            this.varianta1 = new System.Windows.Forms.Label();
            this.varianta2 = new System.Windows.Forms.Label();
            this.varianta3 = new System.Windows.Forms.Label();
            this.Lstima = new System.Windows.Forms.Label();
            this.Lenergie = new System.Windows.Forms.Label();
            this.Incepe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.poza)).BeginInit();
            this.SuspendLayout();
            // 
            // poveste
            // 
            this.poveste.Location = new System.Drawing.Point(13, 13);
            this.poveste.Name = "poveste";
            this.poveste.Size = new System.Drawing.Size(1168, 130);
            this.poveste.TabIndex = 0;
            this.poveste.Text = "label1";
            // 
            // poza
            // 
            this.poza.Location = new System.Drawing.Point(12, 122);
            this.poza.Name = "poza";
            this.poza.Size = new System.Drawing.Size(1324, 234);
            this.poza.TabIndex = 1;
            this.poza.TabStop = false;
            // 
            // varianta1
            // 
            this.varianta1.AutoSize = true;
            this.varianta1.Location = new System.Drawing.Point(9, 386);
            this.varianta1.Name = "varianta1";
            this.varianta1.Size = new System.Drawing.Size(46, 17);
            this.varianta1.TabIndex = 2;
            this.varianta1.Text = "label1";
            this.varianta1.Click += new System.EventHandler(this.varianta1_Click);
            // 
            // varianta2
            // 
            this.varianta2.AutoSize = true;
            this.varianta2.Location = new System.Drawing.Point(9, 439);
            this.varianta2.Name = "varianta2";
            this.varianta2.Size = new System.Drawing.Size(46, 17);
            this.varianta2.TabIndex = 3;
            this.varianta2.Text = "label1";
            this.varianta2.Click += new System.EventHandler(this.varianta2_Click);
            // 
            // varianta3
            // 
            this.varianta3.AutoSize = true;
            this.varianta3.Location = new System.Drawing.Point(9, 492);
            this.varianta3.Name = "varianta3";
            this.varianta3.Size = new System.Drawing.Size(46, 17);
            this.varianta3.TabIndex = 4;
            this.varianta3.Text = "label1";
            this.varianta3.Click += new System.EventHandler(this.varianta3_Click);
            // 
            // Lstima
            // 
            this.Lstima.AutoSize = true;
            this.Lstima.Location = new System.Drawing.Point(1289, 13);
            this.Lstima.Name = "Lstima";
            this.Lstima.Size = new System.Drawing.Size(46, 17);
            this.Lstima.TabIndex = 5;
            this.Lstima.Text = "label1";
            // 
            // Lenergie
            // 
            this.Lenergie.AutoSize = true;
            this.Lenergie.Location = new System.Drawing.Point(1211, 13);
            this.Lenergie.Name = "Lenergie";
            this.Lenergie.Size = new System.Drawing.Size(46, 17);
            this.Lenergie.TabIndex = 6;
            this.Lenergie.Text = "label2";
            // 
            // Incepe
            // 
            this.Incepe.Location = new System.Drawing.Point(664, 172);
            this.Incepe.Name = "Incepe";
            this.Incepe.Size = new System.Drawing.Size(75, 23);
            this.Incepe.TabIndex = 7;
            this.Incepe.Text = "Start joc!";
            this.Incepe.UseVisualStyleBackColor = true;
            this.Incepe.Click += new System.EventHandler(this.Incepe_Click);
            // 
            // joc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.Incepe);
            this.Controls.Add(this.poveste);
            this.Controls.Add(this.Lenergie);
            this.Controls.Add(this.Lstima);
            this.Controls.Add(this.varianta3);
            this.Controls.Add(this.varianta2);
            this.Controls.Add(this.varianta1);
            this.Controls.Add(this.poza);
            this.Name = "joc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "joc";
            this.Load += new System.EventHandler(this.joc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label poveste;
        private System.Windows.Forms.PictureBox poza;
        private System.Windows.Forms.Label varianta1;
        private System.Windows.Forms.Label varianta2;
        private System.Windows.Forms.Label varianta3;
        private System.Windows.Forms.Label Lstima;
        private System.Windows.Forms.Label Lenergie;
        private System.Windows.Forms.Button Incepe;
    }
}