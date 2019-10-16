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
    public partial class suma1 : Form
    {
        public suma1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            suma1 Inicio = new suma1();
            Inicio.Close();

            Form Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}
