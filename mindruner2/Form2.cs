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
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            for (int h = 0; h < 4; h++)
            {
                d1.lanzar();
                d2.lanzar();
                d3.lanzar();
                d4.lanzar();

            }

            for (int i = 0; i < 4; i++)
            { 
                switch (pepe[i])
                {
                    case 1:

                        pb.Image = mindruner2.Properties.Resources.lado1;
                        break;

                    case 2:

                        pb.Image = mindruner2.Properties.Resources.lado2;
                        break;

                    case 3:

                        pb.Image = mindruner2.Properties.Resources.lado3;
                        break;

                    case 4:

                        pb.Image = mindruner2.Properties.Resources.lado4;
                        break;

                    case 5:

                        pb.Image = mindruner2.Properties.Resources.lado5;
                        break;

                    case 6:

                        pb.Image = mindruner2.Properties.Resources.lado6;
                        break;
                }


            switch (pepe.Length)
            {
                case 1:

                    pictureBox1.Image = pb.Image;
                    break;


                case 2:

                    pictureBox2.Image = pb.Image;

                    break;

                case 3:

                    pictureBox3.Image = pb.Image;

                    break;

                case 4:

                    pictureBox4.Image = pb.Image;

                    break;
            }
        }
    }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

