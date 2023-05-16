namespace Il_Paroliere.View
{
    partial class Dati
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
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label3 = new Label();
            Nome = new TextBox();
            Bottonecontinua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(235, 94, 40);
            label1.Location = new Point(135, 58);
            label1.Name = "label1";
            label1.Size = new Size(589, 108);
            label1.TabIndex = 0;
            label1.Text = "Inserisci dati";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(235, 94, 40);
            label2.Location = new Point(88, 226);
            label2.Name = "label2";
            label2.Size = new Size(244, 54);
            label2.TabIndex = 1;
            label2.Text = "Difficoltà ";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.YellowGreen;
            radioButton1.Location = new Point(43, 295);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(86, 28);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Facile";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.Gold;
            radioButton2.Location = new Point(142, 295);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(105, 28);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Normale";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Bauhaus 93", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.ForeColor = Color.LightCoral;
            radioButton3.Location = new Point(253, 295);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(105, 28);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Difficile";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(235, 94, 40);
            label3.Location = new Point(505, 226);
            label3.Name = "label3";
            label3.Size = new Size(236, 54);
            label3.TabIndex = 5;
            label3.Text = "Nickname";
            // 
            // Nome
            // 
            Nome.BackColor = Color.FromArgb(255, 224, 192);
            Nome.Location = new Point(467, 294);
            Nome.Name = "Nome";
            Nome.Size = new Size(308, 23);
            Nome.TabIndex = 6;
            // 
            // Bottonecontinua
            // 
            Bottonecontinua.BackColor = Color.FromArgb(235, 94, 40);
            Bottonecontinua.Font = new Font("Bauhaus 93", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Bottonecontinua.ForeColor = Color.WhiteSmoke;
            Bottonecontinua.Location = new Point(212, 378);
            Bottonecontinua.Margin = new Padding(2, 1, 2, 1);
            Bottonecontinua.Name = "Bottonecontinua";
            Bottonecontinua.Size = new Size(395, 83);
            Bottonecontinua.TabIndex = 7;
            Bottonecontinua.Text = "Continua";
            Bottonecontinua.UseVisualStyleBackColor = false;
            Bottonecontinua.Click += Bottonecontinua_Click;
            // 
            // Dati
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(839, 511);
            Controls.Add(Bottonecontinua);
            Controls.Add(Nome);
            Controls.Add(label3);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Dati";
            Text = "Log-in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label3;
        private TextBox Nome;
        private Button Bottonecontinua;
    }
}