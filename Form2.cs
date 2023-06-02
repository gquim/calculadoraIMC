using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        //*********Permite mover el login con mause
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // ************************************************
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCalculos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            //string icm = LblValor.Text;
            //string excedente = LblExcedente.Text;
            //string estado = LblEstado.Text;

            LblValor.Text = "";
            LblExcedente.Text = "";
            LblEstado.Text = "";
            Close();

        }

        private void LblValor_Click(object sender, EventArgs e)
        {

        }

        private void FrmCalculos_Load(object sender, EventArgs e)
        {
            /*double valor = Convert.ToDouble(LblValor.Text);    
            double excedente = Convert.ToDouble (LblExcedente.Text);

            if(valor < 18.5)
            {
                excedente = 18.5 - valor;
                LblExcedente.Text = "-" + Convert.ToString(excedente);
                LblEstado.Text = "Peso inferior al normal";
            }
            if(valor > 18.5 && valor < 24.9)
            {
                LblExcedente.Text = "___";
                LblEstado.Text = "Peso normal";
            }
            if (valor > 25 && valor < 29.9)
            {
                excedente = valor - 24.9;
                LblExcedente.Text = "+" + Convert.ToString(excedente);
                LblEstado.Text = "Peso superior al normal";
            }           
            if (valor > 30)
            {
                excedente = valor - 24.9;
                LblExcedente.Text = "-----";
                LblEstado.Text = "Obesidad";
            }
            LblValor.Text = valor.ToString();
            */
        }
    }
}
