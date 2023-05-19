using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Il_Paroliere.View
{
    public partial class Dati : Form
    {
        public Dati()
        {
            InitializeComponent();
        }

        private void Bottonecontinua_Click(object sender, EventArgs e)
        {
            string nickname= Nickname.Text;
            if(nickname != "")
            {
                MainController controller = new MainController();
                controller.setNicknameGiocatore(nickname);
                int difficolta=0;

                bool isChecked = radioButton1.Checked;
                if (isChecked)
                    difficolta = 1;

                isChecked = radioButton2.Checked;
                if (isChecked)
                    difficolta = 2;

                isChecked = radioButton3.Checked;
                if (isChecked)
                    difficolta = 3;

                controller.setDifficolta(difficolta);

                this.Hide();
                var gioca = new Gioco();
                gioca.Closed += (s, args) => this.Close();
                gioca.Show();
            }
        }
    }
}
