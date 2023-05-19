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
            bottoneUscita = new Button();
            bottoneGioca = new Button();
            bottoneClassifica = new Button();
            Titolo = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bottoneUscita
            // 
            bottoneUscita.BackColor = Color.WhiteSmoke;
            bottoneUscita.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point);
            bottoneUscita.ForeColor = Color.FromArgb(235, 94, 40);
            bottoneUscita.ImageAlign = ContentAlignment.TopCenter;
            bottoneUscita.Location = new Point(442, 183);
            bottoneUscita.Margin = new Padding(0);
            bottoneUscita.Name = "bottoneUscita";
            bottoneUscita.Size = new Size(208, 109);
            bottoneUscita.TabIndex = 0;
            bottoneUscita.Text = "Esci";
            bottoneUscita.UseVisualStyleBackColor = false;
            bottoneUscita.Click += bottoneUscita_Click;
            // 
            // bottoneGioca
            // 
            bottoneGioca.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bottoneGioca.BackColor = Color.FromArgb(235, 94, 40);
            bottoneGioca.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point);
            bottoneGioca.ForeColor = Color.WhiteSmoke;
            bottoneGioca.Location = new Point(199, 183);
            bottoneGioca.Margin = new Padding(0);
            bottoneGioca.Name = "bottoneGioca";
            bottoneGioca.Size = new Size(208, 109);
            bottoneGioca.TabIndex = 2;
            bottoneGioca.Text = "Gioca";
            bottoneGioca.UseVisualStyleBackColor = false;
            bottoneGioca.Click += bottoneGioca_Click;
            // 
            // bottoneClassifica
            // 
            bottoneClassifica.BackColor = Color.FromArgb(235, 94, 40);
            bottoneClassifica.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point);
            bottoneClassifica.ForeColor = Color.WhiteSmoke;
            bottoneClassifica.Location = new Point(199, 313);
            bottoneClassifica.Margin = new Padding(2, 1, 2, 1);
            bottoneClassifica.Name = "bottoneClassifica";
            bottoneClassifica.Size = new Size(451, 109);
            bottoneClassifica.TabIndex = 3;
            bottoneClassifica.Text = "Classifica";
            bottoneClassifica.UseVisualStyleBackColor = false;
            bottoneClassifica.Click += bottoneClassifica_Click;
            // 
            // Titolo
            // 
            Titolo.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point);
            Titolo.ForeColor = Color.FromArgb(235, 94, 40);
            Titolo.Location = new Point(88, 9);
            Titolo.Margin = new Padding(2, 0, 2, 0);
            Titolo.Name = "Titolo";
            Titolo.RightToLeft = RightToLeft.No;
            Titolo.Size = new Size(451, 174);
            Titolo.TabIndex = 1;
            Titolo.Text = "JUICE WORD";
            Titolo.TextAlign = ContentAlignment.MiddleCenter;
            Titolo.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Due__3_;
            pictureBox1.Location = new Point(492, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 140);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(839, 497);
            Controls.Add(pictureBox1);
            Controls.Add(bottoneGioca);
            Controls.Add(bottoneClassifica);
            Controls.Add(bottoneUscita);
            Controls.Add(Titolo);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Menu";
            Text = "Il Paroliere";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bottoneUscita;
        private Button bottoneGioca;
        private Button bottoneClassifica;
        private Label Titolo;
        private PictureBox pictureBox1;
    }
}