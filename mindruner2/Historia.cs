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
    public partial class Historia : Form
    {
        public Historia(Form2.Datos info)
        {
            InitializeComponent();
            label2.Text = info.Nombre;
            label5.Text = info.Tema;
        }
        public Historia(Form2.Datos2 info)
        {
            InitializeComponent();
            label2.Text = info.Nombre;
            label5.Text = info.Tema;
        }
        public Historia(Form2.Datos3 info)
        {
            InitializeComponent();
            label2.Text = info.Nombre;
            label5.Text = info.Tema;
        }
        public Historia(Form2.Datos4 info)
        {
            InitializeComponent();
            label2.Text = info.Nombre;
            label5.Text = "Pregunta N" +(info.Tema);
        }

        preguntados BuscarPregunta = new preguntados();
        int ValorRespuesta = 0;
        private void Historia_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            label6.Text = BuscarPregunta.Preguntas(label5.Text);
            label7.Text = BuscarPregunta.opc1(label5.Text);
            label8.Text = BuscarPregunta.opc2(label5.Text);
            label9.Text = BuscarPregunta.opc3(label5.Text);
            ValorRespuesta = Convert.ToInt32(BuscarPregunta.resultado(label5.Text));
            


        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                if (ValorRespuesta==1)
                {
                    MessageBox.Show("EL RESULTADO ES CORRECTO");  
                }
                else
                {
                    MessageBox.Show("ES INCORRECTO, HAS PERDIDO :( ");
                }
            }
            if (radioButton2.Checked == true)
            {
                if (ValorRespuesta == 2)
                {
                    MessageBox.Show("EL RESULTADO ES CORRECTO");
                }
                else
                {
                    MessageBox.Show("ES INCORRECTO, HAS PERDIDO :( ");
                }
            }
            if (radioButton3.Checked == true)
            {
                if (ValorRespuesta == 3)
                {
                    MessageBox.Show("EL RESULTADO ES CORRECTO");
                }
                else
                {
                    MessageBox.Show("ES INCORRECTO, HAS PERDIDO :( ");
                }
            }
        }
    }
}
