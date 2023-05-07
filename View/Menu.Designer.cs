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
            this.bottoneGioca = new System.Windows.Forms.Button();
            this.bottoneClassifica = new System.Windows.Forms.Button();
            this.Titolo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bottoneUscita
            // 
            this.bottoneUscita.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bottoneUscita.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bottoneUscita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.bottoneUscita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bottoneUscita.Location = new System.Drawing.Point(808, 461);
            this.bottoneUscita.Margin = new System.Windows.Forms.Padding(0);
            this.bottoneUscita.Name = "bottoneUscita";
            this.bottoneUscita.Size = new System.Drawing.Size(451, 282);
            this.bottoneUscita.TabIndex = 0;
            this.bottoneUscita.Text = "Esci";
            this.bottoneUscita.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bottoneUscita.UseVisualStyleBackColor = false;
            this.bottoneUscita.Click += new System.EventHandler(this.bottoneUscita_Click);
            // 
            // bottoneGioca
            // 
            this.bottoneGioca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bottoneGioca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.bottoneGioca.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bottoneGioca.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bottoneGioca.Location = new System.Drawing.Point(357, 461);
            this.bottoneGioca.Margin = new System.Windows.Forms.Padding(0);
            this.bottoneGioca.Name = "bottoneGioca";
            this.bottoneGioca.Size = new System.Drawing.Size(451, 282);
            this.bottoneGioca.TabIndex = 2;
            this.bottoneGioca.Text = "Gioca";
            this.bottoneGioca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bottoneGioca.UseVisualStyleBackColor = false;
            // 
            // bottoneClassifica
            // 
            this.bottoneClassifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.bottoneClassifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bottoneClassifica.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bottoneClassifica.Location = new System.Drawing.Point(357, 745);
            this.bottoneClassifica.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bottoneClassifica.Name = "bottoneClassifica";
            this.bottoneClassifica.Size = new System.Drawing.Size(903, 282);
            this.bottoneClassifica.TabIndex = 3;
            this.bottoneClassifica.Text = "Classifica";
            this.bottoneClassifica.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bottoneClassifica.UseVisualStyleBackColor = false;
            this.bottoneClassifica.Click += new System.EventHandler(this.bottoneClassifica_Click);
            // 
            // Titolo
            // 
            this.Titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Titolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.Titolo.Location = new System.Drawing.Point(357, 90);
            this.Titolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titolo.Name = "Titolo";
            this.Titolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Titolo.Size = new System.Drawing.Size(947, 371);
            this.Titolo.TabIndex = 1;
            this.Titolo.Text = "IL PAROLIERE";
            this.Titolo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Titolo.UseMnemonic = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(61)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1575, 1284);
            this.Controls.Add(this.bottoneGioca);
            this.Controls.Add(this.bottoneClassifica);
            this.Controls.Add(this.bottoneUscita);
            this.Controls.Add(this.Titolo);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Menu";
            this.Text = "Il Paroliere";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bottoneUscita;
        private Button bottoneGioca;
        private Button bottoneClassifica;
        private Label Titolo;
    }
}