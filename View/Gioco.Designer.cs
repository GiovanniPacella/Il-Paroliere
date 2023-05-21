using System.Windows.Forms;

namespace Il_Paroliere.View
{
    partial class Gioco
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

        void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (e.Index > -1)
            {
                object item = list.Items[e.Index];
                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(e.ForeColor);
                SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
            }
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gioco));
            this.Titolo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.Ricerca = new System.Windows.Forms.RichTextBox();
            this.Timer = new System.Windows.Forms.Label();
            this.PuntiT = new System.Windows.Forms.Label();
            this.Punti = new System.Windows.Forms.Label();
            this.Tittrov = new System.Windows.Forms.Label();
            this.Trovate = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Reset = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titolo
            // 
            this.Titolo.Font = new System.Drawing.Font("Bauhaus 93", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.Titolo.Location = new System.Drawing.Point(11, 0);
            this.Titolo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titolo.Name = "Titolo";
            this.Titolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Titolo.Size = new System.Drawing.Size(1490, 242);
            this.Titolo.TabIndex = 2;
            this.Titolo.Text = "JUICE WORD";
            this.Titolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titolo.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(66, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 120);
            this.button1.TabIndex = 3;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button2.Location = new System.Drawing.Point(192, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 120);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button3.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(318, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 120);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button4.Location = new System.Drawing.Point(444, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 120);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button5.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(570, 279);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 120);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button10.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button10.Location = new System.Drawing.Point(570, 405);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 120);
            this.button10.TabIndex = 12;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button9.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Location = new System.Drawing.Point(444, 405);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 120);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button8.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button8.Location = new System.Drawing.Point(318, 405);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(120, 120);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button7.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(192, 405);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 120);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button6.Location = new System.Drawing.Point(66, 405);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 120);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button15.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button15.Location = new System.Drawing.Point(570, 531);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(120, 120);
            this.button15.TabIndex = 17;
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button14.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button14.Location = new System.Drawing.Point(444, 531);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 120);
            this.button14.TabIndex = 16;
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button13.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button13.Location = new System.Drawing.Point(318, 531);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 120);
            this.button13.TabIndex = 15;
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button12.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button12.Location = new System.Drawing.Point(192, 531);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 120);
            this.button12.TabIndex = 14;
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button11.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button11.Location = new System.Drawing.Point(66, 531);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 120);
            this.button11.TabIndex = 13;
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button20.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button20.Location = new System.Drawing.Point(570, 657);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(120, 120);
            this.button20.TabIndex = 22;
            this.button20.Text = "20";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button19.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button19.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button19.Location = new System.Drawing.Point(444, 657);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(120, 120);
            this.button19.TabIndex = 21;
            this.button19.Text = "19";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button18.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button18.Location = new System.Drawing.Point(318, 657);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(120, 120);
            this.button18.TabIndex = 20;
            this.button18.Text = "18";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button17.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button17.Location = new System.Drawing.Point(192, 657);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(120, 120);
            this.button17.TabIndex = 19;
            this.button17.Text = "17";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button16.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button16.Location = new System.Drawing.Point(66, 657);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(120, 120);
            this.button16.TabIndex = 18;
            this.button16.Text = "16";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button25.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button25.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button25.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button25.Location = new System.Drawing.Point(570, 783);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(120, 120);
            this.button25.TabIndex = 27;
            this.button25.Text = "25";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button24.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button24.Location = new System.Drawing.Point(444, 783);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(120, 120);
            this.button24.TabIndex = 26;
            this.button24.Text = "24";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button23.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button23.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button23.Location = new System.Drawing.Point(318, 783);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(120, 120);
            this.button23.TabIndex = 25;
            this.button23.Text = "23";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button22.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button22.Location = new System.Drawing.Point(192, 783);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(120, 120);
            this.button22.TabIndex = 24;
            this.button22.Text = "22";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button21.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button21.Location = new System.Drawing.Point(66, 783);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(120, 120);
            this.button21.TabIndex = 23;
            this.button21.Text = "21";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Linen;
            this.button26.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.button26.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button26.Location = new System.Drawing.Point(192, 1042);
            this.button26.Margin = new System.Windows.Forms.Padding(0);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(159, 110);
            this.button26.TabIndex = 30;
            this.button26.Text = "Invia";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // Ricerca
            // 
            this.Ricerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Ricerca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ricerca.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ricerca.Location = new System.Drawing.Point(66, 959);
            this.Ricerca.Multiline = false;
            this.Ricerca.Name = "Ricerca";
            this.Ricerca.Size = new System.Drawing.Size(624, 68);
            this.Ricerca.TabIndex = 29;
            this.Ricerca.Text = "";
            // 
            // Timer
            // 
            this.Timer.Font = new System.Drawing.Font("Bauhaus 93", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.Timer.Location = new System.Drawing.Point(861, 386);
            this.Timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Timer.Name = "Timer";
            this.Timer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Timer.Size = new System.Drawing.Size(267, 112);
            this.Timer.TabIndex = 31;
            this.Timer.Text = "00:00";
            this.Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Timer.UseMnemonic = false;
            // 
            // PuntiT
            // 
            this.PuntiT.Font = new System.Drawing.Font("Bauhaus 93", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PuntiT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.PuntiT.Location = new System.Drawing.Point(1132, 295);
            this.PuntiT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PuntiT.Name = "PuntiT";
            this.PuntiT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PuntiT.Size = new System.Drawing.Size(321, 75);
            this.PuntiT.TabIndex = 32;
            this.PuntiT.Text = "Punti";
            this.PuntiT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PuntiT.UseMnemonic = false;
            // 
            // Punti
            // 
            this.Punti.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Punti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.Punti.Location = new System.Drawing.Point(1132, 386);
            this.Punti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Punti.Name = "Punti";
            this.Punti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Punti.Size = new System.Drawing.Size(321, 112);
            this.Punti.TabIndex = 33;
            this.Punti.Text = "000";
            this.Punti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Punti.UseMnemonic = false;
            // 
            // Tittrov
            // 
            this.Tittrov.Font = new System.Drawing.Font("Bauhaus 93", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tittrov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.Tittrov.Location = new System.Drawing.Point(861, 531);
            this.Tittrov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tittrov.Name = "Tittrov";
            this.Tittrov.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tittrov.Size = new System.Drawing.Size(567, 75);
            this.Tittrov.TabIndex = 34;
            this.Tittrov.Text = "Corrette";
            this.Tittrov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Tittrov.UseMnemonic = false;
            // 
            // Trovate
            // 
            this.Trovate.BackColor = System.Drawing.Color.Linen;
            this.Trovate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Trovate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Trovate.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Trovate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.Trovate.FormattingEnabled = true;
            this.Trovate.ItemHeight = 60;
            this.Trovate.Location = new System.Drawing.Point(861, 647);
            this.Trovate.Name = "Trovate";
            this.Trovate.Size = new System.Drawing.Size(550, 480);
            this.Trovate.TabIndex = 35;
            this.Trovate.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_DrawItem);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.Reset.Font = new System.Drawing.Font("Bauhaus 93", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Reset.ForeColor = System.Drawing.Color.Linen;
            this.Reset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Reset.Location = new System.Drawing.Point(369, 1042);
            this.Reset.Margin = new System.Windows.Forms.Padding(0);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(195, 110);
            this.Reset.TabIndex = 36;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.Font = new System.Drawing.Font("Bauhaus 93", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.timerLabel.Location = new System.Drawing.Point(861, 295);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timerLabel.Size = new System.Drawing.Size(267, 75);
            this.timerLabel.TabIndex = 37;
            this.timerLabel.Text = "Timer";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timerLabel.UseMnemonic = false;
            // 
            // Gioco
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1512, 1192);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Trovate);
            this.Controls.Add(this.Tittrov);
            this.Controls.Add(this.Punti);
            this.Controls.Add(this.PuntiT);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.Ricerca);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Titolo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gioco";
            this.Text = "Gioco";
            this.ResumeLayout(false);

        }

        #endregion

        private Label Titolo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button25;
        private Button button24;
        private Button button23;
        private Button button22;
        private Button button21;
        private Button button26;
        private RichTextBox Ricerca;
        private Label Timer;
        private Label PuntiT;
        private Label Punti;
        private Label Tittrov;
        private ListBox Trovate;
        private System.Windows.Forms.Timer timer1;
        private Button Reset;
        private Label timerLabel;
    }
}