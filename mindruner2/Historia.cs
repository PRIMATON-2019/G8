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
    public partial class Historia : Form
    {
        public Historia(Form2.Datos info)
        {
            InitializeComponent();
            label2.Text = info.Nombre;
            label5.Text = info.Tema;
        }
        public Historia(Form2.Datos2 info)
        {
            InitializeComponent();
            label2.Text = info.Nombre;
            label5.Text = info.Tema;
        }
        public Historia(Form2.Datos3 info)
        {
            InitializeComponent();
            label2.Text = info.Nombre;
            label5.Text = info.Tema;
        }
        public Historia(Form2.Datos4 info)
        {
            InitializeComponent();
            label2.Text = info.Nombre;
            label5.Text = info.Tema;
        }

        preguntados BuscarPregunta = new preguntados();
        private void Historia_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            label6.Text = BuscarPregunta.PreguntasYRespuestas(label5.Text);

            

        }
    }
}
