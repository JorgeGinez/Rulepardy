namespace Proyecto_MétodosNum
{
    partial class Ruleta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ruleta));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGirar = new System.Windows.Forms.Button();
            this.lblNumProblema = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 373);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnGirar
            // 
            this.btnGirar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGirar.Location = new System.Drawing.Point(171, 420);
            this.btnGirar.Name = "btnGirar";
            this.btnGirar.Size = new System.Drawing.Size(136, 38);
            this.btnGirar.TabIndex = 2;
            this.btnGirar.Text = "Girar!";
            this.btnGirar.UseVisualStyleBackColor = false;
            this.btnGirar.Click += new System.EventHandler(this.btnGirar_Click);
            // 
            // lblNumProblema
            // 
            this.lblNumProblema.AutoSize = true;
            this.lblNumProblema.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblNumProblema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProblema.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumProblema.Location = new System.Drawing.Point(166, 9);
            this.lblNumProblema.Name = "lblNumProblema";
            this.lblNumProblema.Size = new System.Drawing.Size(0, 25);
            this.lblNumProblema.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ruleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(489, 470);
            this.Controls.Add(this.lblNumProblema);
            this.Controls.Add(this.btnGirar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ruleta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGirar;
        private System.Windows.Forms.Label lblNumProblema;
        private System.Windows.Forms.Timer timer1;
    }
}