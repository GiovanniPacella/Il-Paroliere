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
            Model.creaBoard();
            char[,] board = Model.getBoard();
            button1.Text = Char.ToString(board[0, 0]);
            button2.Text = Char.ToString(board[0, 1]);
            button3.Text = Char.ToString(board[0, 2]);
            button4.Text = Char.ToString(board[0, 3]);
            button5.Text = Char.ToString(board[0, 4]);
            button6.Text = Char.ToString(board[1, 0]);
            button7.Text = Char.ToString(board[1, 1]);
            button8.Text = Char.ToString(board[1, 2]);
            button9.Text = Char.ToString(board[1, 3]);
            button10.Text = Char.ToString(board[1, 4]);
            button11.Text = Char.ToString(board[2, 0]);
            button12.Text = Char.ToString(board[2, 1]);
            button13.Text = Char.ToString(board[2, 2]);
            button14.Text = Char.ToString(board[2, 3]);
            button15.Text = Char.ToString(board[2, 4]);
            button16.Text = Char.ToString(board[3, 0]);
            button17.Text = Char.ToString(board[3, 1]);
            button18.Text = Char.ToString(board[3, 2]);
            button19.Text = Char.ToString(board[3, 3]);
            button20.Text = Char.ToString(board[3, 4]);
            button21.Text = Char.ToString(board[4, 0]);
            button22.Text = Char.ToString(board[4, 1]);
            button23.Text = Char.ToString(board[4, 2]);
            button24.Text = Char.ToString(board[4, 3]);
            button25.Text = Char.ToString(board[4, 4]);

        }

        public Gioco(object v, object sender, EventArgs eventArgs, EventArgs e)
        {
        }
    }


}