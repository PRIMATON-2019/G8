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
    public partial class Formulario_Instrucciones : Form
    {
        public Formulario_Instrucciones()
        {
            InitializeComponent();
        }

        private void Formulario_Instrucciones_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/Users/maria/source/repos/G8-master/mindruner2/imagenes/Garfield.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile("C:/Users/maria/source/repos/G8-master/mindruner2/imagenes/snoppy.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

           
        }
    }
    
}
