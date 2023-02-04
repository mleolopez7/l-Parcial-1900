using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Tarea1 : Form
    {
        public Tarea1()
        {
            InitializeComponent();
        }

        private void buttonvali_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnum.Text);

            if (numero > 0)
            {
                lblposi.Text = "El número es positivo.";
            }
            else
            {
                lblnega.Text = "El número es negativo.";
            }

            if (numero % 2 == 0)
            {
                lblpar.Text += "El número es par.";
            }
            else
            {
                lblimp.Text += "El número es impar.";
            }

            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lblposi.Text = string.Empty;
            lblnega.Text = string.Empty;
            lblpar.Text = string.Empty;
            lblimp.Text = string.Empty;
            txtnum.Text = string.Empty;
        }
    }
}
