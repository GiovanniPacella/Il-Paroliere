namespace Il_Paroliere.View
{
    partial class FinePartita
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
            this.label1 = new System.Windows.Forms.Label();
            this.Punti = new System.Windows.Forms.Label();
            this.bottoneUscita = new System.Windows.Forms.Button();
            this.bottoneMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(120, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 145);
            this.label1.TabIndex = 1;
            this.label1.Text = "FINE PARTITA";
            // 
            // Punti
            // 
            this.Punti.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Punti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.Punti.Location = new System.Drawing.Point(391, 226);
            this.Punti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Punti.Name = "Punti";
            this.Punti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Punti.Size = new System.Drawing.Size(322, 181);
            this.Punti.TabIndex = 34;
            this.Punti.Text = "000";
            this.Punti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Punti.UseMnemonic = false;
            // 
            // bottoneUscita
            // 
            this.bottoneUscita.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bottoneUscita.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bottoneUscita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.bottoneUscita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bottoneUscita.Location = new System.Drawing.Point(542, 480);
            this.bottoneUscita.Margin = new System.Windows.Forms.Padding(0);
            this.bottoneUscita.Name = "bottoneUscita";
            this.bottoneUscita.Size = new System.Drawing.Size(360, 163);
            this.bottoneUscita.TabIndex = 35;
            this.bottoneUscita.Text = "Esci";
            this.bottoneUscita.UseVisualStyleBackColor = false;
            this.bottoneUscita.Click += new System.EventHandler(this.bottoneUscita_Click);
            // 
            // bottoneMenu
            // 
            this.bottoneMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bottoneMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.bottoneMenu.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bottoneMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bottoneMenu.Location = new System.Drawing.Point(120, 480);
            this.bottoneMenu.Margin = new System.Windows.Forms.Padding(0);
            this.bottoneMenu.Name = "bottoneMenu";
            this.bottoneMenu.Size = new System.Drawing.Size(400, 163);
            this.bottoneMenu.TabIndex = 36;
            this.bottoneMenu.Text = "Menu";
            this.bottoneMenu.UseVisualStyleBackColor = false;
            this.bottoneMenu.Click += new System.EventHandler(this.bottoneMenu_Click);
            // 
            // FinePartita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1054, 679);
            this.Controls.Add(this.bottoneMenu);
            this.Controls.Add(this.bottoneUscita);
            this.Controls.Add(this.Punti);
            this.Controls.Add(this.label1);
            this.Name = "FinePartita";
            this.Text = "Fine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label Punti;
        private Button bottoneUscita;
        private Button bottoneMenu;
    }
}