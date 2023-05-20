namespace Il_Paroliere
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.bottoneUscita = new System.Windows.Forms.Button();
            this.bottoneGioca = new System.Windows.Forms.Button();
            this.bottoneClassifica = new System.Windows.Forms.Button();
            this.Titolo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bottoneUscita
            // 
            this.bottoneUscita.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bottoneUscita.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bottoneUscita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.bottoneUscita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bottoneUscita.Location = new System.Drawing.Point(821, 390);
            this.bottoneUscita.Margin = new System.Windows.Forms.Padding(0);
            this.bottoneUscita.Name = "bottoneUscita";
            this.bottoneUscita.Size = new System.Drawing.Size(386, 233);
            this.bottoneUscita.TabIndex = 0;
            this.bottoneUscita.Text = "Esci";
            this.bottoneUscita.UseVisualStyleBackColor = false;
            this.bottoneUscita.Click += new System.EventHandler(this.bottoneUscita_Click);
            // 
            // bottoneGioca
            // 
            this.bottoneGioca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bottoneGioca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.bottoneGioca.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bottoneGioca.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bottoneGioca.Location = new System.Drawing.Point(370, 390);
            this.bottoneGioca.Margin = new System.Windows.Forms.Padding(0);
            this.bottoneGioca.Name = "bottoneGioca";
            this.bottoneGioca.Size = new System.Drawing.Size(386, 233);
            this.bottoneGioca.TabIndex = 2;
            this.bottoneGioca.Text = "Gioca";
            this.bottoneGioca.UseVisualStyleBackColor = false;
            this.bottoneGioca.Click += new System.EventHandler(this.bottoneGioca_Click);
            // 
            // bottoneClassifica
            // 
            this.bottoneClassifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.bottoneClassifica.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bottoneClassifica.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bottoneClassifica.Location = new System.Drawing.Point(370, 668);
            this.bottoneClassifica.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bottoneClassifica.Name = "bottoneClassifica";
            this.bottoneClassifica.Size = new System.Drawing.Size(838, 233);
            this.bottoneClassifica.TabIndex = 3;
            this.bottoneClassifica.Text = "Classifica";
            this.bottoneClassifica.UseVisualStyleBackColor = false;
            this.bottoneClassifica.Click += new System.EventHandler(this.bottoneClassifica_Click);
            // 
            // Titolo
            // 
            this.Titolo.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.Titolo.Location = new System.Drawing.Point(280, 19);
            this.Titolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titolo.Name = "Titolo";
            this.Titolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Titolo.Size = new System.Drawing.Size(838, 371);
            this.Titolo.TabIndex = 1;
            this.Titolo.Text = "JUICE WORD";
            this.Titolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titolo.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Il_Paroliere.Properties.Resources.Due__2_;
            this.pictureBox1.Location = new System.Drawing.Point(1094, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 229);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1558, 1060);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bottoneGioca);
            this.Controls.Add(this.bottoneClassifica);
            this.Controls.Add(this.bottoneUscita);
            this.Controls.Add(this.Titolo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Juice Word";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bottoneUscita;
        private Button bottoneGioca;
        private Button bottoneClassifica;
        private Label Titolo;
        private PictureBox pictureBox1;
    }
}