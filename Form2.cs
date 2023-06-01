using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class FrmCalculos : Form
    {
        public FrmCalculos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            string icm = LblValor.Text;
            string excedente = LblExcedente.Text;
            string estado = LblEstado.Text;

            LblValor.Text = "";
            LblExcedente.Text = "";
            LblEstado.Text = "";


        }

        private void LblValor_Click(object sender, EventArgs e)
        {

        }
    }
}
