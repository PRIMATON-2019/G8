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
    public partial class Gif_del_dado : Form
    {
        public Gif_del_dado()
        {
            InitializeComponent();
        }

        private void Gif_del_dado_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\maria\source\repos\G8-master\mindruner2\imagenes\Gif del dado.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //this.Close();
            //Program.Form2.Show();
        }
    }
}
