﻿using Il_Paroliere.Model;
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
    public partial class Gioco : Form
    {
        public Gioco()
        {
            InitializeComponent();
            MainModel Model = new MainModel();
            char[][] board = Model.getBoard();
        }

        public Gioco(object v, object sender, EventArgs eventArgs, EventArgs e)
        {
        }
    }


}
