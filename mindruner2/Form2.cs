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
            label8.Text = Convert.ToString(d1.numero);
            label7.Text = Convert.ToString(d2.numero);
            label6.Text = Convert.ToString(d3.numero);
            label5.Text = Convert.ToString(d4.numero);
            label9.Text = d1.tema;
            label10.Text = d2.tema;
            label11.Text = d3.tema;
            label12.Text = d4.tema;

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
    }

}






