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
            Titolo = new Label();
            bottoneGioca = new Button();
            bottoneClassifica = new Button();
            SuspendLayout();
            // 
            // bottoneUscita
            // 
            bottoneUscita.BackColor = Color.FromArgb(255, 102, 0);
            bottoneUscita.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            bottoneUscita.ForeColor = Color.Black;
            bottoneUscita.Location = new Point(242, 260);
            bottoneUscita.Margin = new Padding(2, 1, 2, 1);
            bottoneUscita.Name = "bottoneUscita";
            bottoneUscita.Size = new Size(159, 49);
            bottoneUscita.TabIndex = 0;
            bottoneUscita.Text = "Esci";
            bottoneUscita.UseVisualStyleBackColor = false;
            bottoneUscita.Click += bottoneUscita_Click;
            // 
            // Titolo
            // 
            Titolo.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            Titolo.ForeColor = Color.FromArgb(255, 102, 0);
            Titolo.Location = new Point(6, 56);
            Titolo.Margin = new Padding(2, 0, 2, 0);
            Titolo.Name = "Titolo";
            Titolo.Size = new Size(835, 73);
            Titolo.TabIndex = 1;
            Titolo.Text = "Il Paroliere";
            Titolo.TextAlign = ContentAlignment.TopCenter;
            // 
            // bottoneGioca
            // 
            bottoneGioca.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bottoneGioca.BackColor = Color.FromArgb(255, 102, 0);
            bottoneGioca.Font = new Font("Microsoft Sans Serif", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            bottoneGioca.ForeColor = Color.Black;
            bottoneGioca.Location = new Point(229, 176);
            bottoneGioca.Margin = new Padding(2, 1, 2, 1);
            bottoneGioca.Name = "bottoneGioca";
            bottoneGioca.Size = new Size(404, 70);
            bottoneGioca.TabIndex = 2;
            bottoneGioca.Text = "Gioca";
            bottoneGioca.UseVisualStyleBackColor = false;
            bottoneGioca.Click += bottoneGioca_Click;
            // 
            // bottoneClassifica
            // 
            bottoneClassifica.BackColor = Color.FromArgb(255, 102, 0);
            bottoneClassifica.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            bottoneClassifica.ForeColor = Color.Black;
            bottoneClassifica.Location = new Point(467, 260);
            bottoneClassifica.Margin = new Padding(2, 1, 2, 1);
            bottoneClassifica.Name = "bottoneClassifica";
            bottoneClassifica.Size = new Size(152, 49);
            bottoneClassifica.TabIndex = 3;
            bottoneClassifica.Text = "Classifica";
            bottoneClassifica.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(848, 435);
            Controls.Add(bottoneClassifica);
            Controls.Add(bottoneGioca);
            Controls.Add(Titolo);
            Controls.Add(bottoneUscita);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Menu";
            Text = "Il Paroliere";
            ResumeLayout(false);
        }

        #endregion

        private Button bottoneUscita;
        private Label Titolo;
        private Button bottoneGioca;
        private Button bottoneClassifica;
    }
}