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
        
        public Suma contador = new Suma();
        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(contador.SumaPuntaje1());
            this.Hide();
        }
    }
}
