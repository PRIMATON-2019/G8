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
    public partial class Form3jugadores : Form
    {
        public Form3jugadores()
        {
            InitializeComponent();
        }
        Lista Jugadores = new Lista();

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Jugadores.Carga(txt1.Text, txt2.Text, txt3.Text, txt4.Text);
            lbl6.Text = Jugadores.Mostrar();

        }

        private void Form3jugadores_Load(object sender, EventArgs e)
        {

        }
    }
}
