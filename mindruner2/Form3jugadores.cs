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
        public struct Datos
        {
            public string Nombre1;
            public string Nombre2;
            public string Nombre3;
            public string Nombre4;
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
            Datos Info;

            Info.Nombre1 = txt1.Text;
            Info.Nombre2 = txt2.Text;
            Info.Nombre3 = txt3.Text;
            Info.Nombre4 = txt4.Text;

            Form2 obj = new Form2(Info);
            obj.ShowDialog();

            //Jugadores.Carga(txt1.Text, txt2.Text, txt3.Text, txt4.Text);
            //lbl6.Text = Jugadores.Mostrar();


        }

        private void Form3jugadores_Load(object sender, EventArgs e)
        {

        }
    }
}
