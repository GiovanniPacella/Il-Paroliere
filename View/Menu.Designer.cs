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
            bottoneUscita.Font = new Font("Dugas Pro Black Normal", 48F, FontStyle.Bold, GraphicsUnit.Point);
            bottoneUscita.ForeColor = Color.FromArgb(235, 94, 40);
            bottoneUscita.ImageAlign = ContentAlignment.TopCenter;
            bottoneUscita.Location = new Point(435, 216);
            bottoneUscita.Margin = new Padding(0);
            bottoneUscita.Name = "bottoneUscita";
            bottoneUscita.Size = new Size(243, 132);
            bottoneUscita.TabIndex = 0;
            bottoneUscita.Text = "Esci";
            bottoneUscita.TextAlign = ContentAlignment.TopCenter;
            bottoneUscita.UseVisualStyleBackColor = false;
            bottoneUscita.Click += bottoneUscita_Click;
            // 
            // bottoneGioca
            // 
            bottoneGioca.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bottoneGioca.BackColor = Color.FromArgb(235, 94, 40);
            bottoneGioca.Font = new Font("Dugas Pro Black Normal", 48F, FontStyle.Bold, GraphicsUnit.Point);
            bottoneGioca.ForeColor = Color.WhiteSmoke;
            bottoneGioca.Location = new Point(192, 216);
            bottoneGioca.Margin = new Padding(0);
            bottoneGioca.Name = "bottoneGioca";
            bottoneGioca.Size = new Size(243, 132);
            bottoneGioca.TabIndex = 2;
            bottoneGioca.Text = "Gioca";
            bottoneGioca.TextAlign = ContentAlignment.TopCenter;
            bottoneGioca.UseVisualStyleBackColor = false;
            // 
            // bottoneClassifica
            // 
            bottoneClassifica.BackColor = Color.FromArgb(235, 94, 40);
            bottoneClassifica.Font = new Font("Dugas Pro Black Normal", 48F, FontStyle.Bold, GraphicsUnit.Point);
            bottoneClassifica.ForeColor = Color.WhiteSmoke;
            bottoneClassifica.Location = new Point(192, 349);
            bottoneClassifica.Margin = new Padding(2, 1, 2, 1);
            bottoneClassifica.Name = "bottoneClassifica";
            bottoneClassifica.Size = new Size(486, 132);
            bottoneClassifica.TabIndex = 3;
            bottoneClassifica.Text = "Classifica";
            bottoneClassifica.TextAlign = ContentAlignment.TopCenter;
            bottoneClassifica.UseVisualStyleBackColor = false;
            bottoneClassifica.Click += bottoneClassifica_Click;
            // 
            // Titolo
            // 
            Titolo.Font = new Font("Dugas Pro Black Normal", 71.99999F, FontStyle.Bold, GraphicsUnit.Point);
            Titolo.ForeColor = Color.FromArgb(235, 94, 40);
            Titolo.Location = new Point(192, 42);
            Titolo.Margin = new Padding(2, 0, 2, 0);
            Titolo.Name = "Titolo";
            Titolo.RightToLeft = RightToLeft.No;
            Titolo.Size = new Size(510, 174);
            Titolo.TabIndex = 1;
            Titolo.Text = "IL PAROLIERE";
            Titolo.TextAlign = ContentAlignment.TopCenter;
            Titolo.UseMnemonic = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 61, 57);
            ClientSize = new Size(848, 497);
            Controls.Add(bottoneGioca);
            Controls.Add(bottoneClassifica);
            Controls.Add(bottoneUscita);
            Controls.Add(Titolo);
            Margin = new Padding(2, 1, 2, 1);
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