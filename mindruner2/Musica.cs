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
    public partial class Musica : Form
    {
        public Musica(Form2.Datos info)
        {
            InitializeComponent();
            label2.Text = info.Nombre;
            label5.Text = info.Tema;
            label10.Text = info.Njugador;
        }
        public Musica(Form2.Datos2 info)
        {
            InitializeComponent();
            label2.Text = info.Nombre;
            label5.Text = info.Tema;
            label10.Text = info.Njugador;
        }
        public Musica(Form2.Datos3 info)
        {
            InitializeComponent();
            label2.Text = info.Nombre;
            label5.Text = info.Tema;
            label10.Text = info.Njugador;
        }
        public Musica(Form2.Datos4 info)
        {
            InitializeComponent();
            label2.Text = info.Nombre;
            label5.Text = info.Tema;
            label10.Text = info.Njugador;
        }
        Preguntasmusica BuscarPregunta = new Preguntasmusica();
        int ValorRespuesta = 0;
        Suma contador = new Suma();

        private void Musica_Load(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Btnpregunta_Click(object sender, EventArgs e)
        {
            label6.Text = BuscarPregunta.Preguntas(label5.Text);
            label7.Text = BuscarPregunta.opc1(label5.Text);
            label8.Text = BuscarPregunta.opc2(label5.Text);
            label9.Text = BuscarPregunta.opc3(label5.Text);
            ValorRespuesta = Convert.ToInt32(BuscarPregunta.resultado(label5.Text));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (ValorRespuesta == 1)
                {
                    MessageBox.Show("EL RESULTADO ES CORRECTO");
                    label11.Text = contador.SumaPuntaje(label10.Text);

                }
                else
                {
                    MessageBox.Show("ES INCORRECTO, HAS PERDIDO :( ");
                    label11.Text = contador.VisualizarPuntaje(label10.Text);
                }
            }
            if (radioButton2.Checked == true)
            {
                if (ValorRespuesta == 2)
                {
                    MessageBox.Show("EL RESULTADO ES CORRECTO");
                    label11.Text = contador.SumaPuntaje(label10.Text);
                }
                else
                {
                    MessageBox.Show("ES INCORRECTO, HAS PERDIDO :( ");
                    label11.Text = contador.VisualizarPuntaje(label10.Text);
                }
            }
            if (radioButton3.Checked == true)
            {
                if (ValorRespuesta == 3)
                {
                    MessageBox.Show("EL RESULTADO ES CORRECTO");
                    label11.Text = contador.SumaPuntaje(label10.Text);
                }
                else
                {
                    MessageBox.Show("ES INCORRECTO, HAS PERDIDO :( ");
                    label11.Text = contador.VisualizarPuntaje(label10.Text);
                }
            }
        }
    }
}
