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
            double EdadN;
            bool si = double.TryParse(TxtEdad.Text, out EdadN);
            if (si == false)
            {
                MessageBox.Show("Ha ingresado un valor incorrecto");
                TxtEdad.Focus();
                TxtEdad.Text = "";
                return;
            }

            double alturaN;
            bool siAltura = double.TryParse(TxtAltura.Text, out alturaN);
            if (siAltura == false)
            {
                MessageBox.Show("Ha ingresado un valor incorrecto");
                TxtAltura.Focus();
                TxtAltura.Text = "";
                return;
            }

            double pesoN; 
            bool sipeso = double.TryParse(Txtpeso.Text, out pesoN);
            if (sipeso == false)
            {
                MessageBox.Show("Ha ingresado un valor incorrecto");
                Txtpeso.Focus();
                Txtpeso.Text = "";
                return;
            }

            string edad = TxtEdad.Text;
            string altura = TxtAltura.Text;
            string peso = Txtpeso.Text;
            
            TxtEdad.Text = "";
            TxtAltura.Text = "";
            Txtpeso.Text = "";


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
