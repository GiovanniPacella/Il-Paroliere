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
            bottoneUscita = new Button();
            bottoneGioca = new Button();
            bottoneClassifica = new Button();
            Titolo = new Label();
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
            Titolo.Location = new Point(199, 9);
            Titolo.Margin = new Padding(2, 0, 2, 0);
            Titolo.Name = "Titolo";
            Titolo.RightToLeft = RightToLeft.No;
            Titolo.Size = new Size(451, 174);
            Titolo.TabIndex = 1;
            Titolo.Text = "IL PAROLIERE";
            Titolo.TextAlign = ContentAlignment.MiddleCenter;
            Titolo.UseMnemonic = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(839, 511);
            Controls.Add(bottoneGioca);
            Controls.Add(bottoneClassifica);
            Controls.Add(bottoneUscita);
            Controls.Add(Titolo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Menu";
            Text = "Il Paroliere";
            ResumeLayout(false);
        }

        #endregion

        private Button bottoneUscita;
        private Button bottoneGioca;
        private Button bottoneClassifica;
        private Label Titolo;
    }
}