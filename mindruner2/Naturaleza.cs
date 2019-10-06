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
    public partial class Naturaleza : Form
    {
        public Naturaleza(Form2.Datos info)
        {
            InitializeComponent();
            label10.Text = info.Nombre;
        }
        public Naturaleza(Form2.Datos2 info)
        {
            InitializeComponent();
            label10.Text = info.Nombre;
        }
        public Naturaleza(Form2.Datos3 info)
        {
            InitializeComponent();
            label10.Text = info.Nombre;
        }
        public Naturaleza(Form2.Datos4 info)
        {
            InitializeComponent();
            label10.Text = info.Nombre;
        }
        public struct Datos
        {
            public int contador;
            
        }


        private void BtnQuit_Click(object sender, EventArgs e)
        {
           

        }
    }
}
