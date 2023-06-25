using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LibBusinessEntities;
using LibBusinessRules;

namespace GUINorthwind
{
    public partial class FrmLogin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int
        lparam);

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.PasswordChar = '*';
                txtPass.ForeColor = Color.LightGray;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.PasswordChar = '\0';
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.Silver;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void login(object sender, EventArgs e)
        {
            BindingSource bsUsuario = new BindingSource();
            BRUsuario obrUsuario = new BRUsuario();
            List<BEUsuario> lbeUsuario = obrUsuario.Login(txtUser.Text, txtPass.Text);
            bsUsuario.DataSource = lbeUsuario;




            string nombre = lbeUsuario[0].Nombre;
            string apellido = lbeUsuario[0].Apellido;
            //string ocupacion = lbeUsuario[0].Ocupacion;

            if (bsUsuario.Count > 0)
            {
                MessageBox.Show("Bienvenido");
                FrmPrincipal winPrincipal = new FrmPrincipal();
                winPrincipal.Nombre = nombre;
                winPrincipal.Apellido = apellido;
                //winPrincipal.Ocupacion = ocupacion;

                winPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error de Usuario");
                txtUser.Clear();
                txtPass.Clear();    
                txtUser.Focus();
            }

        }
    }
}
