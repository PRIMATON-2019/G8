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
        dado d1 = new dado();
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            d1.lanzar();
            int nro = d1.numero;

                switch (nro)
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
            pictureBox1.Image = pb.Image;
        }

    }
}

