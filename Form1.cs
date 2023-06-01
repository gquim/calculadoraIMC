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
    public partial class FrmPrincipal : Form
    {
        generalClass claseGeneral = new generalClass();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
         
            string edad = TxtEdad.Text;
            string altura = TxtAltura.Text;
            string peso = Txtpeso.Text;
            
            TxtEdad.Text = "";
            TxtAltura.Text = "";
            Txtpeso.Text = "";


        }
    }
}
