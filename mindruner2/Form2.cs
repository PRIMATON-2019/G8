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



        string[,] Pepe = new string[4,2];
        Lista Jugadores = new Lista();
        dado d1 = new dado();
        dado d2 = new dado();
        dado d3 = new dado();
        dado d4 = new dado();
        preguntados pregunta = new preguntados();
        int cont1 = 0;
        int cont2 = 0;
        int cont3 = 0;
        int cont4 = 0;


        
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
            public string Npregunta;
            public string Njugador;

           

        }
        public struct Datos2
        {
            public string Nombre;
            public string Tema;
            public string Npregunta;
            public string Njugador;


        }
        public struct Datos3
        {
            public string Nombre;
            public string Tema;
            public string Npregunta;
            public string Njugador;


        }

        internal static void Show(Action initializeComponent)
        {
            throw new NotImplementedException();
        }

        public struct Datos4
        {
            public string Nombre;
            public string Tema;
            public string Npregunta;
            public string Njugador;
        }
        public struct DatosMatriz
        {
            public string[,] MatrizEnvio;            

        }

        Suma contador = new Suma();
        int J = 1;


        private void Button1_Click(object sender, EventArgs e)
        {
            
           
            if (J==3)
            {
                MessageBox.Show("YA HAN COMPLETADO LAS "+Convert.ToString(J)+"...RONDAS");
                 Pepe = Jugadores.quiengana(label1.Text,label2.Text,label3.Text,label4.Text,label17.Text,label18.Text,label19.Text,label20.Text);
                DatosMatriz Info;

                Info.MatrizEnvio=Pepe;
                this.Hide();
                MuestraGanadores obj1 = new MuestraGanadores(Info);
                obj1.ShowDialog();

            }

            else
            {
                MessageBox.Show("RONDA N." + Convert.ToString(J));
                J++;
                btnlanzar.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                //Jugadores.Carga(lbljugador1.Text, lbljugador2.Text, lbljugador3.Text, lbljugador4.Text);

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
                label5.Text = Convert.ToString(d1.materia);
                label6.Text = Convert.ToString(d2.materia);
                label7.Text = Convert.ToString(d3.materia);
                label12.Text = Convert.ToString(d4.materia);
                label8.Text = d1.tema;
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

        }

        private void Lbljugador1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Datos Info1;

            Info1.Nombre = label1.Text;
            Info1.Tema = label12.Text;
            Info1.Npregunta = label8.Text;
            Info1.Njugador = "1";
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;


            {
                   switch (d1.numero)
                    {
                        case 1:
                            Form historia = new Historia(Info1);
                            if (historia.ShowDialog()==DialogResult.OK)
                            {
                              cont1 = contador.SumaPuntaje1();
                              label17.Text = Convert.ToString(cont1);
                            }
                        

                        break;
                        case 2:
                            Form geografia = new Geografia(Info1);
                        if (geografia.ShowDialog() == DialogResult.OK)
                        {
                            cont1 = contador.SumaPuntaje1();
                            label17.Text = Convert.ToString(cont1);
                        }

                        break;
                        case 3:
                            Form Deportes = new deporte(Info1);
                        if (Deportes.ShowDialog() == DialogResult.OK)
                        {
                            cont1 = contador.SumaPuntaje1();
                            label17.Text = Convert.ToString(cont1);
                        }

                        break;
                        case 4:
                            Form cine = new Cine(Info1);
                            if (cine.ShowDialog() == DialogResult.OK)
                            {
                             cont1 = contador.SumaPuntaje1();
                             label17.Text = Convert.ToString(cont1);
                            }

                        break;
                        case 5:
                            Form musica = new Musica(Info1);
                            if (musica.ShowDialog() == DialogResult.OK)
                            {
                             cont1 = contador.SumaPuntaje1();
                             label17.Text = Convert.ToString(cont1);
                            }
                        break;
                        case 6:
                            Form naturaleza = new Naturaleza(Info1);
                        if (naturaleza.ShowDialog() == DialogResult.OK)
                        {
                            cont1 = contador.SumaPuntaje1();
                            label17.Text = Convert.ToString(cont1);
                        };
                        
                        break;

                        
                    }
                    
            }

            

                  
                                
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Datos2 Info2;

            Info2.Nombre = label2.Text;
            Info2.Tema = label7.Text;
            Info2.Npregunta = label11.Text;
            Info2.Njugador = "2";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
            switch (d2.numero)
            {
                case 1:
                    Form historia = new Historia(Info2);
                    if (historia.ShowDialog() == DialogResult.OK)
                    {
                        cont2 = contador.SumaPuntaje2();
                        label18.Text = Convert.ToString(cont2);
                    }

                    break;
                case 2:
                    Form geografia = new Geografia(Info2);
                    if (geografia.ShowDialog() == DialogResult.OK)
                    {
                        cont2 = contador.SumaPuntaje2();
                        label18.Text = Convert.ToString(cont2);
                    }
                    break;
                case 3:
                    Form Deportes = new deporte(Info2);
                    if (Deportes.ShowDialog() == DialogResult.OK)
                    {
                        cont2 = contador.SumaPuntaje2();
                        label18.Text = Convert.ToString(cont2);
                    }
                    break;
                case 4:
                    Form cine = new Cine(Info2);
                    if (cine.ShowDialog() == DialogResult.OK)
                    {
                        cont2 = contador.SumaPuntaje2();
                        label18.Text = Convert.ToString(cont2);
                    }
                    break;
                case 5:
                    Form musica = new Musica(Info2);
                    if (musica.ShowDialog() == DialogResult.OK)
                    {
                        cont2 = contador.SumaPuntaje2();
                        label18.Text = Convert.ToString(cont2);
                    }
                    break;
                case 6:
                    Form naturaleza = new Naturaleza(Info2);
                    if (naturaleza.ShowDialog() == DialogResult.OK)
                    {
                        cont2 = contador.SumaPuntaje2();
                        label18.Text = Convert.ToString(cont2);
                    }
                    break;


            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Datos3 Info3;

            Info3.Nombre = label3.Text;
            Info3.Tema = label6.Text;
            Info3.Npregunta = label10.Text;
            Info3.Njugador = "3";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;


            switch (d3.numero)
            {
                case 1:
                    Form historia = new Historia(Info3);
                    if (historia.ShowDialog() == DialogResult.OK)
                    {
                        cont3 = contador.SumaPuntaje3();
                        label19.Text = Convert.ToString(cont3);
                    }

                    break;
                case 2:
                    Form geografia = new Geografia(Info3);
                    if (geografia.ShowDialog() == DialogResult.OK)
                    {
                        cont3 = contador.SumaPuntaje3();
                        label19.Text = Convert.ToString(cont3);
                    }
                    break;
                case 3:
                    Form Deportes = new deporte(Info3);
                    if (Deportes.ShowDialog() == DialogResult.OK)
                    {
                        cont3 = contador.SumaPuntaje3();
                        label19.Text = Convert.ToString(cont3);
                    }
                    break;
                case 4:
                    Form cine = new Cine(Info3);
                    if (cine.ShowDialog() == DialogResult.OK)
                    {
                        cont3 = contador.SumaPuntaje3();
                        label19.Text = Convert.ToString(cont3);
                    }
                    break;
                case 5:
                    Form musica = new Musica(Info3);
                    if (musica.ShowDialog() == DialogResult.OK)
                    {
                        cont3 = contador.SumaPuntaje3();
                        label19.Text = Convert.ToString(cont3);
                    }
                    break;
                case 6:
                    Form naturaleza = new Naturaleza(Info3);
                    if (naturaleza.ShowDialog() == DialogResult.OK)
                    {
                        cont3 = contador.SumaPuntaje3();
                        label19.Text = Convert.ToString(cont3);
                    }
                    break;


            }

        }

        private void Button4_Click(object sender, EventArgs e)
            {
            Datos4 Info4;

            Info4.Nombre = label4.Text;
            Info4.Tema = label5.Text;
            Info4.Npregunta = label9.Text;
            Info4.Njugador = "4";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            btnlanzar.Enabled = true;


            switch (d4.numero)
            {
                case 1:
                    Form historia = new Historia(Info4);
                    if (historia.ShowDialog() == DialogResult.OK)
                    {
                        cont4 = contador.SumaPuntaje4();
                        label20.Text = Convert.ToString(cont4);
                    }

                    break;
                case 2:
                    Form geografia = new Geografia(Info4);
                    if (geografia.ShowDialog() == DialogResult.OK)
                    {
                        cont4 = contador.SumaPuntaje4();
                        label20.Text = Convert.ToString(cont4);
                    }
                    break;
                case 3:
                    Form Deportes = new deporte(Info4);
                    if (Deportes.ShowDialog() == DialogResult.OK)
                    {
                        cont4 = contador.SumaPuntaje4();
                        label20.Text = Convert.ToString(cont4);
                    }
                    break;
                case 4:
                    Form cine = new Cine(Info4);
                    if (cine.ShowDialog() == DialogResult.OK)
                    {
                        cont4 = contador.SumaPuntaje4();
                        label20.Text = Convert.ToString(cont4);
                    }
                    break;
                case 5:
                    Form musica = new Musica(Info4);
                    if (musica.ShowDialog() == DialogResult.OK)
                    {
                        cont4 = contador.SumaPuntaje4();
                        label20.Text = Convert.ToString(cont4);
                    }
                    break;
                case 6:
                    Form naturaleza = new Naturaleza(Info4);
                    if (naturaleza.ShowDialog() == DialogResult.OK)
                    {
                        cont4 = contador.SumaPuntaje4();
                        label20.Text = Convert.ToString(cont4);
                    }
                    break;
                    

                   
            }
            pictureBox1.Image = mindruner2.Properties.Resources.ani;
            pictureBox2.Image = mindruner2.Properties.Resources.ani;
            pictureBox3.Image = mindruner2.Properties.Resources.ani;
            pictureBox4.Image = mindruner2.Properties.Resources.ani;
        }

        
    }
                       
}
                   
                
               


            


           
        
    








