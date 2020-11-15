namespace Macchine_BGW_v2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.imgNera = new System.Windows.Forms.PictureBox();
            this.imgRossa = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.imgTraguardo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgNera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRossa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTraguardo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(392, 386);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 52);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // imgNera
            // 
            this.imgNera.Image = global::Macchine_BGW_v2.Properties.Resources.macchinabianca__1_;
            this.imgNera.Location = new System.Drawing.Point(15, 63);
            this.imgNera.Name = "imgNera";
            this.imgNera.Size = new System.Drawing.Size(128, 73);
            this.imgNera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNera.TabIndex = 2;
            this.imgNera.TabStop = false;
            // 
            // imgRossa
            // 
            this.imgRossa.Image = global::Macchine_BGW_v2.Properties.Resources.macchinarossa__1_;
            this.imgRossa.Location = new System.Drawing.Point(15, 240);
            this.imgRossa.Name = "imgRossa";
            this.imgRossa.Size = new System.Drawing.Size(128, 73);
            this.imgRossa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRossa.TabIndex = 3;
            this.imgRossa.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Macchine_BGW_v2.Properties.Resources.road_trip_background_10864211__1_;
            this.pictureBox3.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(873, 381);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // imgTraguardo
            // 
            this.imgTraguardo.Image = global::Macchine_BGW_v2.Properties.Resources.finishline;
            this.imgTraguardo.Location = new System.Drawing.Point(785, -1);
            this.imgTraguardo.Name = "imgTraguardo";
            this.imgTraguardo.Size = new System.Drawing.Size(74, 381);
            this.imgTraguardo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTraguardo.TabIndex = 5;
            this.imgTraguardo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.imgNera);
            this.Controls.Add(this.imgRossa);
            this.Controls.Add(this.imgTraguardo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgNera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRossa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTraguardo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox imgNera;
        private System.Windows.Forms.PictureBox imgRossa;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox imgTraguardo;
    }
}

