﻿using System;
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
    public partial class Geografia : Form
    {
        public Geografia(Form2.Datos info)
        {
            InitializeComponent();
            label2.Text = info.Nombre;
        }
    }
}
