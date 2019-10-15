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
    public partial class MuestraGanadores : Form
    {
        public MuestraGanadores()
        {
            InitializeComponent();


           

           

        }
        public MuestraGanadores(Form2.DatosMatriz info)

        {
            InitializeComponent();
            label1.Text = info.MatrizEnvio[0, 0];
            label2.Text = info.MatrizEnvio[1, 0];
            label3.Text = info.MatrizEnvio[2, 0];
            label4.Text = info.MatrizEnvio[3, 0];
            label5.Text = info.MatrizEnvio[0, 1];
            label6.Text = info.MatrizEnvio[1, 1];
            label7.Text = info.MatrizEnvio[2, 1];
            label8.Text = info.MatrizEnvio[3, 1];

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Inicio = new Form1();
            Inicio.Show();
        }
    }
}
