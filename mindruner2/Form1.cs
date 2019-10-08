using System;
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
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
            SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "C:/Users/Usuario/Downloads/Chrono Cross Opening HD.wav";
            Player.Stream = Properties.Resources.Chrono_Cross_Opening_HD;
            Player.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                                 
        }
        // evento de boton


        private void Button1_Click(object sender, EventArgs e)
        {

            Form1 Inicio = new Form1();
            Inicio.Close();

            Form tercerformulario = new Form3jugadores();
            tercerformulario.Show();
            

        }

        private void BtnInstructions_Click(object sender, EventArgs e)
        {
            Form Instrucciones = new Formulario_Instrucciones();
            Instrucciones.Show();
           
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            Form FormularioOpciones = new Formulario_Opciones();
            FormularioOpciones.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}


