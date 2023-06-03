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
    public partial class FrmPrincipal : Form
    {
        generalClass claseGeneral = new generalClass();
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        //*********Permite mover el login con mause
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // ************************************************

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        }
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            //Form form = new Form();
            FrmCalculos frmCalculos = new FrmCalculos();
            //frmCalculos.LblValor.Text
            double resultado;

            double EdadN;
            bool si = double.TryParse(TxtEdad.Text, out EdadN);
            if (si == false)
            {
                MessageBox.Show("Ha ingresado un valor incorrecto");
                TxtEdad.Focus();
                TxtEdad.Text = "";
                return;
            }

            double alturaN = Convert.ToDouble ( TxtAltura.Text);
            bool siAltura = double.TryParse(TxtAltura.Text, out alturaN);
            if (siAltura == false)
            {
                MessageBox.Show("Ha ingresado un valor incorrecto");
                TxtAltura.Focus();
                TxtAltura.Text = "";
                return;
            }

            double pesoN = Convert.ToDouble(Txtpeso.Text); 
            bool sipeso = double.TryParse(Txtpeso.Text, out pesoN);
            if (sipeso == false)
            {
                MessageBox.Show("Ha ingresado un valor incorrecto");
                Txtpeso.Focus();
                Txtpeso.Text = "";
                return;
            }
            resultado = Math.Round( Math.Pow( pesoN,2)/alturaN,2) ;
            frmCalculos.LblValor.Text = "----" + resultado.ToString() + "----";

            double excedente = Convert.ToDouble(frmCalculos.LblExcedente.Text);

            if (resultado < 18.5)
            {
                excedente = 18.5 - resultado;
                frmCalculos. LblExcedente.Text = "-" + Convert.ToString(excedente);
                frmCalculos.LblEstado.Text = "Peso inferior al normal";
            }
            if (resultado > 18.5 && resultado < 24.9)
            {
                frmCalculos.LblExcedente.Text = "___";
                frmCalculos.LblEstado.Text = "Peso normal";
            }
            if (resultado > 25 && resultado < 29.9)
            {
                excedente = resultado - 24.9;
                frmCalculos.LblExcedente.Text = "+" + Convert.ToString(excedente);
                frmCalculos.LblEstado.Text = "Peso superior al normal";
            }
            if (resultado > 30)
            {
                excedente = resultado - 24.9;
                frmCalculos.LblExcedente.Text = "+" + Convert.ToString(excedente);
                frmCalculos.LblEstado.Text = "Obesidad";
            }


            TxtEdad.Text = "";
            TxtAltura.Text = "";
            Txtpeso.Text = "";

            frmCalculos.Show();
            
        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtEdad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
