namespace Il_Paroliere
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // bottoneUscita
            // 
            this.bottoneUscita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bottoneUscita.Font = new System.Drawing.Font("Tw Cen MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bottoneUscita.Location = new System.Drawing.Point(12, 750);
            this.bottoneUscita.Name = "bottoneUscita";
            this.bottoneUscita.Size = new System.Drawing.Size(287, 154);
            this.bottoneUscita.TabIndex = 0;
            this.bottoneUscita.Text = "Esci";
            this.bottoneUscita.UseVisualStyleBackColor = false;
            this.bottoneUscita.Click += new System.EventHandler(this.bottoneUscita_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1561, 916);
            this.Controls.Add(this.bottoneUscita);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bottoneUscita;
    }
}