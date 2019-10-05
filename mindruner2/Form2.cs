using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mindruner2
{
    public partial class Form2 : Form
    {
        int[] pepe = new int[4];
        dado d1 = new dado();
        dado d2 = new dado();
        dado d3 = new dado();
        dado d4 = new dado();
        public Form2(Form3jugadores.Datos info)

        {
            InitializeComponent();
            lbljugador1.Text = info.Nombre1;
            lbljugador2.Text = info.Nombre2;
            lbljugador3.Text = info.Nombre3;
            lbljugador4.Text = info.Nombre4;
        }
        public struct Datos
        {
            public string Nombre;
            public string Tema;
            public string Puntage;

           

        }

        Lista Jugadores = new Lista();


        private void Button1_Click(object sender, EventArgs e)
        {
            Jugadores.Carga(lbljugador1.Text, lbljugador2.Text, lbljugador3.Text, lbljugador4.Text);

            d1.lanzar();
            d2.lanzar();
            d3.lanzar();
            d4.lanzar();

            for (int i = 0; i < 10; i++)
            {



                if (d1.numero == d2.numero)
                {
                    d2.lanzar();

                }
                if (d2.numero == d3.numero)
                {

                    d3.lanzar();
                }

                if (d1.numero == d3.numero)
                {
                    d3.lanzar();

                }
                if (d4.numero == d1.numero)
                {
                    d4.lanzar();

                }
                if (d4.numero == d2.numero)
                {
                    d4.lanzar();
                }

                if (d3.numero == d4.numero)
                {
                    d4.lanzar();
                }

            }
            label1.Text = lbljugador1.Text;
            label2.Text = lbljugador2.Text;
            label3.Text = lbljugador3.Text;
            label4.Text = lbljugador4.Text;
            label5.Text = Convert.ToString(d1.numero);
            label6.Text = Convert.ToString(d2.numero);
            label7.Text = Convert.ToString(d3.numero);
            label8.Text = Convert.ToString(d4.numero);
            label12.Text = d1.tema;
            label11.Text = d2.tema;
            label10.Text = d3.tema;
            label9.Text = d4.tema;

            switch (d1.numero)
            {
                case 1:


                    pictureBox1.Image = mindruner2.Properties.Resources.lado1;
                    break;

                case 2:

                    pictureBox1.Image = mindruner2.Properties.Resources.lado2;
                    break;

                case 3:

                    pictureBox1.Image = mindruner2.Properties.Resources.lado3;
                    break;

                case 4:

                    pictureBox1.Image = mindruner2.Properties.Resources.lado4;
                    break;

                case 5:

                    pictureBox1.Image = mindruner2.Properties.Resources.lado5;
                    break;

                case 6:

                    pictureBox1.Image = mindruner2.Properties.Resources.lado6;
                    break;
            }

            switch (d2.numero)
            {
                case 1:

                    pictureBox2.Image = mindruner2.Properties.Resources.lado1;
                    break;

                case 2:

                    pictureBox2.Image = mindruner2.Properties.Resources.lado2;
                    break;

                case 3:

                    pictureBox2.Image = mindruner2.Properties.Resources.lado3;
                    break;

                case 4:

                    pictureBox2.Image = mindruner2.Properties.Resources.lado4;
                    break;

                case 5:

                    pictureBox2.Image = mindruner2.Properties.Resources.lado5;
                    break;

                case 6:

                    pictureBox2.Image = mindruner2.Properties.Resources.lado6;
                    break;
            }

            switch (d3.numero)
            {
                case 1:

                    pictureBox3.Image = mindruner2.Properties.Resources.lado1;
                    break;

                case 2:

                    pictureBox3.Image = mindruner2.Properties.Resources.lado2;
                    break;

                case 3:

                    pictureBox3.Image = mindruner2.Properties.Resources.lado3;
                    break;

                case 4:

                    pictureBox3.Image = mindruner2.Properties.Resources.lado4;
                    break;

                case 5:

                    pictureBox3.Image = mindruner2.Properties.Resources.lado5;
                    break;

                case 6:

                    pictureBox3.Image = mindruner2.Properties.Resources.lado6;
                    break;
            }

            switch (d4.numero)
            {
                case 1:

                    pictureBox4.Image = mindruner2.Properties.Resources.lado1;
                    break;

                case 2:

                    pictureBox4.Image = mindruner2.Properties.Resources.lado2;
                    break;

                case 3:

                    pictureBox4.Image = mindruner2.Properties.Resources.lado3;
                    break;

                case 4:

                    pictureBox4.Image = mindruner2.Properties.Resources.lado4;
                    break;

                case 5:

                    pictureBox4.Image = mindruner2.Properties.Resources.lado5;
                    break;

                case 6:

                    pictureBox4.Image = mindruner2.Properties.Resources.lado6;
                    break;
            }

        }

        private void Lbljugador1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            //Se modificó el tipo de struct de cada jugador a Datos.           
            Datos Info1;
            Datos Info2;
            Datos Info3;
            Datos Info4;

            Info1.Nombre = label1.Text;
            Info1.Tema = label8.Text;
            Info1.Puntage = label12.Text;

            Info2.Nombre = label2.Text;
            Info2.Tema = label11.Text;
            Info2.Puntage = label7.Text;

            Info3.Nombre = label3.Text;
            Info3.Tema = label10.Text;
            Info3.Puntage = label6.Text;

            Info4.Nombre = label4.Text;
            Info4.Tema = label9.Text;
            Info4.Puntage = label5.Text;

            Evaluar(d1, Info1);
            Evaluar(d2, Info2);
            Evaluar(d3, Info3);
            Evaluar(d4, Info4);


            //FALTA:
            //1- Limpiar el código.
            //2- Tratar de trabajar con clases(objetos).
            //3- Hacer un sólo formulario de pregunta en vez de 6.
            //4- Hacer un label para cada jugador con los puntos.
            //5- Modificar el método Evaluar() para que escriba en el label de puntaje correspondiente.
            //6- Crear una variable para identificar en qué instancia del juego se encuentra. Esto sirve para hacer al botón Jugar dinámico. 

            
            //El método Evaluar funciona para todos los jugadores.
            //Toma argumentos dependiendo del dado y del jugador.
            void Evaluar(dado cualdado, Datos cualjugador)
            {

                switch (cualdado.numero)
                {
                    
                    //Se evalua cuál es la temática a elegir.
                    //Este Switch NO haría falta en el caso de que se utilice un sólo formulario para las preguntas.
                    case 1:

                        //Se crea el formulario con la pregunta correspondiente mandando la información.
                        Form historia = new Historia(cualjugador);
                        //En vez de utilizar el método Show(), lo hacemos surgir como un Dialog.
                        //Para ello, creamos un botón en cada formulario de pregunta y le asignamos el valor OK a la propiedad DialogResult.
                        //Esto indica que realize una acción dependiendo del botón oprimido.
                        if (historia.ShowDialog(this) == DialogResult.OK)
                        {
                            //En este caso, para demostrar que el código recibe información, se trae un parámetro del otro formulario.
                            //Aquí se sumarían los puntos al total en caso de responder afirmativamente.
                            this.lbltema.Text = historia.Name;
                        }
                        //Una vez que se oprime el botón OK, el formulario se cierra.
                        historia.Dispose();
                        break;

                    //El switch se repite por cada otra asignatura.
                    case 2:
                        Form geografia = new Geografia(cualjugador);
                        if (geografia.ShowDialog(this) == DialogResult.OK)
                        {
                            this.lbltema.Text = geografia.Name;
                        }
                        geografia.Dispose();
                        break;
                    case 3:
                        Form Deportes = new deporte(cualjugador);
                        if (Deportes.ShowDialog(this) == DialogResult.OK)
                        {
                            this.lbltema.Text = Deportes.Name;
                        }
                        Deportes.Dispose();
                        break;
                    case 4:
                        Form cine = new Cine(cualjugador);
                        if (cine.ShowDialog(this) == DialogResult.OK)
                        {
                            this.lbltema.Text = cine.Name;
                        }
                        cine.Dispose();
                        break;
                    case 5:
                        Form musica = new Musica(cualjugador);
                        if (musica.ShowDialog(this) == DialogResult.OK)
                        {
                            this.lbltema.Text = musica.Name;
                        }
                        musica.Dispose();
                        break;
                    case 6:
                        Form naturaleza = new Naturaleza(cualjugador);
                        if (naturaleza.ShowDialog(this) == DialogResult.OK)
                        {
                            this.lbltema.Text = naturaleza.Name;
                        }
                        naturaleza.Dispose();
                        break;
                }

            }

        }
    }
}






