﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_68
{
    public partial class FrmPersona : Form
    {
        private Persona persona;
        private event DelegadoString EventoString;

        public FrmPersona()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}
