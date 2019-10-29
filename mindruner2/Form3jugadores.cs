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

        Form1 Inicio = new Form1();
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




            //MessageBox.Show("Usuario 1:" + txt1.Text + "Usuario 2:" + txt2.Text + "Usuario 3:" + txt3.Text + "Usuario 4:" + txt4.Text);

            if (txt1.Text + txt2.Text + txt3.Text + txt4.Text == "")
            {
                MessageBox.Show("Por Favor Introduzca nombre en algunos casilleros");
            }
            else
            {
                Datos Info;
                Info.Nombre1 = txt1.Text;
                Info.Nombre2 = txt2.Text;
                Info.Nombre3 = txt3.Text;
                Info.Nombre4 = txt4.Text;
                this.Hide();
                Form2 obj = new Form2(Info);
                obj.ShowDialog();
            }

            




            //Jugadores.Carga(txt1.Text, txt2.Text, txt3.Text, txt4.Text);
            //lbl6.Text = Jugadores.Mostrar();


        }



        private void Form3jugadores_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
     
            this.Close();
            Inicio.Show();

        }

        private void Txt1_Validated(object sender, EventArgs e)
        {
            //if (txt1.Text.Trim() == "" )
    //        {
              //  epError.SetError(txt1, "Ingrese Nonbre");
                //txt1.Focus();

  //          }
//            else
      //      {
        //        epError.Clear();
          //  }

        }

        private void Txt2_Validated(object sender, EventArgs e)
        {
//            if (txt2.Text.Trim() == "")
      //      {
  //              epError.SetError(txt2, "Ingrese Nonbre");
                //txt2.Focus();

    //        }
        //    else
          //  {
              //  epError.Clear();
            //}
        }

        private void Txt3_Validated(object sender, EventArgs e)
        {
          //  if (txt3.Text.Trim() == "")
            //{
              //  epError.SetError(txt3, "Ingrese Nonbre");
                //txt3.Focus();

            //}
            //else
            //{
              //  epError.Clear();
            //}
        }

        private void Txt4_Validated(object sender, EventArgs e)
        {
            //if (txt4.Text.Trim() == "")
            //{
              //  epError.SetError(txt4, "Ingrese Nombre");
                //txt4.Focus();

            //}
            //else
            //{
              //  epError.Clear();
            //}
        }
    }
}
