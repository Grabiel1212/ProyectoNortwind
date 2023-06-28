using LibBusinessRules;
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
using LibBusinessEntities;

namespace GUINorthwind
{
    public partial class FrmCRUUsuario : Form
    {


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int
        lparam);
        public int modoWindow { get; set; }
        public int codUusuario { get; set; }
        public String uUsuario { get; set; }
        public string ucontraseña { get; set; }
        public String unombreUsuario { get; set; }
        public string uapellidoUsuario { get; set; }

        public string uOcupacion { get; set; }

        public FrmCRUUsuario()
        {
            InitializeComponent();
        }

        private void FrmCRUUsuario_Load(object sender, EventArgs e)
        {

            switch (modoWindow)
            {
                case 0: //Ver
                    txtusuario.Text = uUsuario;
                    txtcontraseña.Text= ucontraseña;
                    textnombreuser.Text= unombreUsuario;
                    txtapellidouser.Text= uapellidoUsuario;
                    txtocupacion.Text = uOcupacion;
         

                    habilitaCasillas(false);
                    break;
                case 1: //Nuevo
                    limpiaCasillas();
                    break;
                case 2: //Editar
                    txtusuario.Text = uUsuario;
                    txtcontraseña.Text = ucontraseña;
                    textnombreuser.Text = unombreUsuario;
                    txtapellidouser.Text = uapellidoUsuario;
                    txtocupacion.Text = uOcupacion;

                    habilitaCasillas(true);
                    break;
            }

        }


        private void habilitaCasillas(Boolean estado)
        {

            txtusuario.Enabled = estado;
            txtcontraseña.Enabled = estado;
            textnombreuser.Enabled = estado;
            txtapellidouser.Enabled = estado;
            txtocupacion.Enabled=estado;
            btnGrabarusuario.Enabled = estado;

        }
        private void limpiaCasillas()
        {

            txtusuario.Clear();
            txtcontraseña.Clear();
            textnombreuser.Clear();
            txtocupacion.Clear();
            txtapellidouser.Clear();

        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private BRUsuario obrUsuario= new BRUsuario();
        private void btnGrabarusuario_Click(object sender, EventArgs e)
        {


            if (modoWindow == 1) //Regitstrar
            {

                BEUsuario obeUsario = new BEUsuario();
                {
                    var withBlock = obeUsario;
                    withBlock.NombreUsuario = txtusuario.Text;
                    withBlock.PasswordUsuario = txtcontraseña.Text;
                    withBlock.Nombre = textnombreuser.Text;
                    withBlock.Apellido = txtapellidouser.Text;
                    withBlock.Ocupacion =txtocupacion.Text;
                  


                }
                int N = obrUsuario.IngresarUsuario(obeUsario);
                if (N > 0)
                {


                    MessageBox.Show("Se Adicionó el Usuario", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                    this.Hide();
                }
                else
                {


                    MessageBox.Show("No se pudo Adicionar el Usuario", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (modoWindow == 2) //Editar
            {
                BEUsuario obeUsario = new BEUsuario();
                {
                    var withBlock = obeUsario;
                    withBlock.Codigo = codUusuario;
                    withBlock.NombreUsuario = txtusuario.Text;
                    withBlock.PasswordUsuario = txtcontraseña.Text;
                    withBlock.Nombre = textnombreuser.Text;
                    withBlock.Apellido = txtapellidouser.Text;
                    withBlock.Ocupacion = txtocupacion.Text;



                }

                bool exito = obrUsuario.ActualizarUsuario(obeUsario);
                if (exito)
                {
                    MessageBox.Show("Se Actualizó el Usuario", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                    this.Hide();


                }


                else
                {


                    MessageBox.Show("No se pudo Actualizar el Usuario", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }



        }
    }
}
