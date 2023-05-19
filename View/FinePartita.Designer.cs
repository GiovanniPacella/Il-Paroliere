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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinePartita));
            label1 = new Label();
            Punti = new Label();
            bottoneUscita = new Button();
            bottoneMenu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(235, 94, 40);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(65, 16);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(406, 73);
            label1.TabIndex = 1;
            label1.Text = "FINE PARTITA";
            // 
            // Punti
            // 
            Punti.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Punti.ForeColor = Color.FromArgb(235, 94, 40);
            Punti.Location = new Point(199, 105);
            Punti.Margin = new Padding(2, 0, 2, 0);
            Punti.Name = "Punti";
            Punti.RightToLeft = RightToLeft.No;
            Punti.Size = new Size(173, 85);
            Punti.TabIndex = 34;
            Punti.Text = "000";
            Punti.TextAlign = ContentAlignment.MiddleCenter;
            Punti.UseMnemonic = false;
            // 
            // bottoneUscita
            // 
            bottoneUscita.BackColor = Color.WhiteSmoke;
            bottoneUscita.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point);
            bottoneUscita.ForeColor = Color.FromArgb(235, 94, 40);
            bottoneUscita.ImageAlign = ContentAlignment.TopCenter;
            bottoneUscita.Location = new Point(292, 225);
            bottoneUscita.Margin = new Padding(0);
            bottoneUscita.Name = "bottoneUscita";
            bottoneUscita.Size = new Size(194, 76);
            bottoneUscita.TabIndex = 35;
            bottoneUscita.Text = "Esci";
            bottoneUscita.UseVisualStyleBackColor = false;
            bottoneUscita.Click += bottoneUscita_Click;
            // 
            // bottoneMenu
            // 
            bottoneMenu.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bottoneMenu.BackColor = Color.FromArgb(235, 94, 40);
            bottoneMenu.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point);
            bottoneMenu.ForeColor = Color.WhiteSmoke;
            bottoneMenu.Location = new Point(65, 225);
            bottoneMenu.Margin = new Padding(0);
            bottoneMenu.Name = "bottoneMenu";
            bottoneMenu.Size = new Size(215, 76);
            bottoneMenu.TabIndex = 36;
            bottoneMenu.Text = "Menu";
            bottoneMenu.UseVisualStyleBackColor = false;
            bottoneMenu.Click += bottoneMenu_Click;
            // 
            // FinePartita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(568, 318);
            Controls.Add(bottoneMenu);
            Controls.Add(bottoneUscita);
            Controls.Add(Punti);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FinePartita";
            Text = "Fine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Punti;
        private Button bottoneUscita;
        private Button bottoneMenu;
    }
}