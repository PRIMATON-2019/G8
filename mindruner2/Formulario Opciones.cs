﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace mindruner2
{
    public partial class Formulario_Opciones : Form
    {
        public Formulario_Opciones()
        {
            InitializeComponent();
        }

        SoundPlayer Player = new SoundPlayer();

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Player.SoundLocation = "C:/Users/Usuario/Downloads/Chrono Cross Opening HD.wav";
            Player.Stream = Properties.Resources.Chrono_Cross_Opening_HD;
            Player.Play();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Player.Stop();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
