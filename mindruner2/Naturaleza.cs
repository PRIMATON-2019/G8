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
    public partial class Naturaleza : Form
    {
        public Naturaleza(Form2.Datos info)
        {
            InitializeComponent();
            label10.Text = info.Nombre;
            label5.Text = info.Tema;
           // label1.Text = info.Njugador;
        }
        public Naturaleza(Form2.Datos2 info)
        {
            InitializeComponent();
            label10.Text = info.Nombre;
            label5.Text = info.Tema;
           // label1.Text = info.Njugador;
        }
        public Naturaleza(Form2.Datos3 info)
        {
            InitializeComponent();
            label10.Text = info.Nombre;
            label5.Text = info.Tema;
           // label1.Text = info.Njugador;
        }
        public Naturaleza(Form2.Datos4 info)
        {
            InitializeComponent();
            label10.Text = info.Nombre;
            label5.Text = info.Tema;
           // label1.Text = info.Njugador;
        }
        preguntasnaturaleza BuscarPregunta = new preguntasnaturaleza();
        int ValorRespuesta = 0;
        Suma contador = new Suma();

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            btnQuit.Enabled = false;
            if (radioButton1.Checked == true)
            {
                if (ValorRespuesta == 1)
                {
                    MessageBox.Show("EL RESULTADO ES CORRECTO, HAS GANADO 10 PUNTOS");
                    btnok.Visible = true;


                }
                else
                {
                    MessageBox.Show("INCORRECTO, LA RESPUESTA CORRECTA ES LA N." + "..." + Convert.ToString(ValorRespuesta));
                    this.Close();

                }
            }
            if (radioButton2.Checked == true)
            {
                if (ValorRespuesta == 2)
                {
                    MessageBox.Show("EL RESULTADO ES CORRECTO, HAS GANADO 10 PUNTOS");
                    btnok.Visible = true;

                }
                else
                {
                    MessageBox.Show("INCORRECTO, LA RESPUESTA CORRECTA ES LA N." + "..." + Convert.ToString(ValorRespuesta));
                    this.Close();
                }
            }
            if (radioButton3.Checked == true)
            {
                if (ValorRespuesta == 3)
                {
                    MessageBox.Show("EL RESULTADO ES CORRECTO, HAS GANADO 10 PUNTOS");
                    btnok.Visible = true;
                    

                }
                else
                {
                    MessageBox.Show("INCORRECTO, LA RESPUESTA CORRECTA ES LA N."+"..."+Convert.ToString(ValorRespuesta));
                    this.Close();

                }
            }
        }



        private void Btnpregunta_Click(object sender, EventArgs e)
        {
            label6.Text = BuscarPregunta.Preguntas(label5.Text);
            label7.Text = BuscarPregunta.opc1(label5.Text);
            label8.Text = BuscarPregunta.opc2(label5.Text);
            label9.Text = BuscarPregunta.opc3(label5.Text);
            ValorRespuesta = Convert.ToInt32(BuscarPregunta.resultado(label5.Text));
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
