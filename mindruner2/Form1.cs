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
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "C:/Users/Usuario/Downloads/Chrono Cross Opening HD.wav"; Este No Va
            //Player.Stream = Properties.Resources.Chrono_Cross_Opening_HD;
            //Player.Play();
            //btnCredits.BackgroundImage = Properties.Resources.Boton_estilo_Inicio; Este Tampoco
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
            this.Hide();


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
            MessageBox.Show("END GAME");
            Application.Exit();
        }

        private void BtnCredits_Click(object sender, EventArgs e)
        {
            
            

            Form suma1 = new suma1();
            suma1.Show();
           

            //SoundPlayer NotificacionBoton = new SoundPlayer();
            //NotificacionBoton.SoundLocation= @"C:\Users\maria\source\repos\GrupoPrimaton\G8MartesMadrugada\G8\mindruner2\Sound\FGBS(37).wav";
            //NotificacionBoton.Play();




        }

        private void BtnCredits_MouseMove(object sender, MouseEventArgs e)
        {

            //btnCredits.BackgroundImage = Properties.Resources.Boton_estilo_2;


            //SoundPlayer NotificacionBoton = new SoundPlayer();
            //NotificacionBoton.SoundLocation = @"C:\Users\maria\source\repos\GrupoPrimaton\G8MartesMadrugada\G8\mindruner2\Sound\FGBS(37).wav";
            //NotificacionBoton.Play();
        }

        private void BtnCredits_MouseLeave(object sender, EventArgs e)
        {
            //SoundPlayer NotificacionBoton = new SoundPlayer();
            //NotificacionBoton.SoundLocation = @"C:\Users\maria\source\repos\GrupoPrimaton\G8MartesMadrugada\G8\mindruner2\Sound\FGBS(37).wav";
            //NotificacionBoton.Stop();

            //btnCredits.BackgroundImage = Properties.Resources.boton_estilo_inicio1;


        }
    }

}


