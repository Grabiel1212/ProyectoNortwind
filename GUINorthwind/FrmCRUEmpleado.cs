using LibBusinessEntities;
using LibBusinessRules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUINorthwind
{
    public partial class FrmCRUEmpleado : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int
        lparam);
        public int modoWindow { get; set; }
        public int codEmpleado { get; set; }
        public String nomEmpleado { get; set; }
        public String apeEmpleado { get; set; }
        public DateTime   FechaNacimiento { get; set; }
        public String Direccion { get; set; }
        public String Pais { get; set; }
        public FrmCRUEmpleado()
        {
            InitializeComponent();
        }
        private void habilitaCasillas(Boolean estado)
        {
            txtApellidoEmpleado.Enabled = estado;
            txtNombreEmpleado.Enabled = estado;
            dateFechaNacimiento.Enabled = estado;
            txtDireccionEmp.Enabled = estado;
            txtPaisEmp.Enabled = estado;
            btnGrabarEmpleado.Enabled = estado;
            
        }
        private void limpiaCasillas()
        {
            txtApellidoEmpleado.Clear();
            txtNombreEmpleado.Clear();
            txtDireccionEmp.Clear();
            //txtFNacimientoEmp.Clear();
            txtPaisEmp.Clear();

        }
        private void moverVentana(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void cerrarVentana(object sender, EventArgs e)
        {
                this.Hide();
        }

        private void minimizar(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmCRUEmpleado_Load(object sender, EventArgs e)
        {
            switch (modoWindow)
            {
                case 0: //Ver
                    txtNombreEmpleado.Text = nomEmpleado;
                    txtApellidoEmpleado.Text = apeEmpleado;
                   dateFechaNacimiento.Value =FechaNacimiento;
                    txtDireccionEmp.Text = Direccion;
                    txtPaisEmp.Text = Pais;
                    habilitaCasillas(false);
                    break;
                case 1: //Nuevo
                    limpiaCasillas();
                    break;
                case 2: //Editar
                    txtNombreEmpleado.Text = nomEmpleado;
                    txtApellidoEmpleado.Text = apeEmpleado;
                    dateFechaNacimiento.Value = FechaNacimiento;
                    txtDireccionEmp.Text = Direccion;
                    txtPaisEmp.Text = Pais;
                    habilitaCasillas(true);
                    break;
            }
        }

        private BREmpleado obrEmpleado = new BREmpleado();

        private void btnGrabarEmpleado_Click(object sender, EventArgs e)
        {

            if (modoWindow == 1) //Regitstrar
            {

                BEEmpleado obeEmpleado = new BEEmpleado();
                {
                    var withBlock = obeEmpleado;
                    withBlock.Nombre = txtNombreEmpleado.Text;
                    withBlock.Apellido = txtApellidoEmpleado.Text;
                    withBlock.FechaNac = FechaNacimiento;
                    withBlock.Direccion1 = txtDireccionEmp.Text;
                    withBlock.Pais = txtPaisEmp.Text;


                }
                int N = obrEmpleado.InsertarEmpleados(obeEmpleado);
                if (N > 0)
                {


                    MessageBox.Show("Se Adicionó el Empleado", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                    this.Hide();
                }
                else
                {


                    MessageBox.Show("No se pudo Adicionar el empleado", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (modoWindow == 2) //Editar
            {
                BEEmpleado obeEmpleado = new BEEmpleado();
                {
                    var withBlock = obeEmpleado;
                    withBlock.Codigo = codEmpleado;
                    withBlock.Nombre = txtNombreEmpleado.Text;
                    withBlock.Apellido = txtApellidoEmpleado.Text;
                    withBlock.FechaNac = FechaNacimiento;
                    withBlock.Direccion1 = txtDireccionEmp.Text;
                    withBlock.Pais = txtPaisEmp.Text;
                }
                bool exito = obrEmpleado.Actualizar(obeEmpleado);
                if (exito)
                {
                    MessageBox.Show("Se Actualizó el empleado", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                    this.Hide();


                }


                else
                {


                    MessageBox.Show("No se pudo Actualizar el Rmplreado", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
