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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           



        }
        // evento de boton

        private void Button1_Click(object sender, EventArgs e)
        {
            Form tercerformulario = new Form2();
            tercerformulario.Show();
        }
    }

    }
    

