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
            this.bottoneUscita = new System.Windows.Forms.Button();
            this.Titolo = new System.Windows.Forms.Label();
            this.bottoneGioca = new System.Windows.Forms.Button();
            this.bottoneClassifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bottoneUscita
            // 
            this.bottoneUscita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.bottoneUscita.Font = new System.Drawing.Font("Tw Cen MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bottoneUscita.ForeColor = System.Drawing.Color.Black;
            this.bottoneUscita.Location = new System.Drawing.Point(450, 554);
            this.bottoneUscita.Name = "bottoneUscita";
            this.bottoneUscita.Size = new System.Drawing.Size(296, 104);
            this.bottoneUscita.TabIndex = 0;
            this.bottoneUscita.Text = "Esci";
            this.bottoneUscita.UseVisualStyleBackColor = false;
            this.bottoneUscita.Click += new System.EventHandler(this.bottoneUscita_Click);
            // 
            // Titolo
            // 
            this.Titolo.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Titolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.Titolo.Location = new System.Drawing.Point(12, 119);
            this.Titolo.Name = "Titolo";
            this.Titolo.Size = new System.Drawing.Size(1550, 155);
            this.Titolo.TabIndex = 1;
            this.Titolo.Text = "Il Paroliere";
            this.Titolo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bottoneGioca
            // 
            this.bottoneGioca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bottoneGioca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.bottoneGioca.Font = new System.Drawing.Font("Tw Cen MT", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bottoneGioca.ForeColor = System.Drawing.Color.Black;
            this.bottoneGioca.Location = new System.Drawing.Point(425, 375);
            this.bottoneGioca.Name = "bottoneGioca";
            this.bottoneGioca.Size = new System.Drawing.Size(750, 150);
            this.bottoneGioca.TabIndex = 2;
            this.bottoneGioca.Text = "Gioca!";
            this.bottoneGioca.UseVisualStyleBackColor = false;
            this.bottoneGioca.Click += new System.EventHandler(this.bottoneGioca_Click);
            // 
            // bottoneClassifica
            // 
            this.bottoneClassifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.bottoneClassifica.Font = new System.Drawing.Font("Tw Cen MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bottoneClassifica.ForeColor = System.Drawing.Color.Black;
            this.bottoneClassifica.Location = new System.Drawing.Point(868, 554);
            this.bottoneClassifica.Name = "bottoneClassifica";
            this.bottoneClassifica.Size = new System.Drawing.Size(282, 104);
            this.bottoneClassifica.TabIndex = 3;
            this.bottoneClassifica.Text = "Classifica";
            this.bottoneClassifica.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1574, 929);
            this.Controls.Add(this.bottoneClassifica);
            this.Controls.Add(this.bottoneGioca);
            this.Controls.Add(this.Titolo);
            this.Controls.Add(this.bottoneUscita);
            this.Name = "Form1";
            this.Text = "Il Paroliere";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bottoneUscita;
        private Label Titolo;
        private Button bottoneGioca;
        private Button bottoneClassifica;
    }
}