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
using LibBusinessRules;

namespace GUINorthwind
{
    public partial class FrmCruCliente : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int
        lparam);
        public int modoWindow { get; set; }
        public  String codigoCliente { get; set; }
        public String pcompania { get; set; }
        public String pcontacto { get; set; }
        public String pdireccion { get; set; }
        public String cciudad { get; set; }
        public String ppaiz { get; set; }

        public FrmCruCliente()
        {
            InitializeComponent();
        }

        private void habilitaCasillas(Boolean estado)
        {
            txticcliente.Enabled = estado;
            txtCompania.Enabled = estado;
            txtcontacto.Enabled = estado;
            txtdireccion.Enabled = estado;
            txtciudad.Enabled = estado;
            txtpaizz.Enabled = estado;
            btngravarCliente.Enabled = estado;

        }
        private void limpiaCasillas()
        {
            txticcliente.Clear();
            txtCompania.Clear();
            txtcontacto.Clear();
            txtdireccion.Clear();
            txtciudad.Clear();
            txtpaizz.Clear();
        }

        private void FrmCruCliente_Load(object sender, EventArgs e)
        {

            switch (modoWindow)
            {
                case 0: //Ver
                    txticcliente.Text = codigoCliente;
                    txtCompania.Text = pcompania;
                    txtcontacto.Text = pcontacto;
                    txtdireccion.Text = pdireccion;
                    txtciudad.Text = cciudad;
                    txtpaizz.Text=ppaiz;

                    habilitaCasillas(false);
                    break;
                case 1: //Nuevo
                    limpiaCasillas();
                    break;
                case 2: //Editar
                    txticcliente.Text = codigoCliente;
                    txtCompania.Text = pcompania;
                    txtcontacto.Text = pcontacto;
                    txtdireccion.Text = pdireccion;
                    txtciudad.Text = cciudad;
                    txtpaizz.Text = ppaiz;

                    habilitaCasillas(true);
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        BRCliente obrcliente = new BRCliente();
        private void btngravarCliente_Click(object sender, EventArgs e)
        {


            if (modoWindow == 1) //Regitstrar
            {

                BEEClientes obeCLIENTE = new BEEClientes();
                {
                    var withBlock = obeCLIENTE;
                    withBlock.IdCliente = txticcliente.Text;
                    withBlock.Compania = txtCompania.Text;
                    withBlock.Contacto = txtcontacto.Text;
                    withBlock.Direccion =txtdireccion.Text;
                    withBlock.Ciudad = txtpaiz.Text;
                    withBlock.Paiz= txtpaizz.Text;


                }
                int N = obrcliente.AdicionarCliente(obeCLIENTE);
                if (N > 0)
                {


                    MessageBox.Show("Se Adicionó el cliente", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                    this.Hide();
                }
                else
                {


                    MessageBox.Show("No se pudo Adicionar el cliente", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (modoWindow == 2) //Editar
            {
                BEEClientes obeCLIENTE = new BEEClientes();
                {
                    var withBlock = obeCLIENTE;
                    withBlock.IdCliente = txticcliente.Text;
                    withBlock.Compania = txtCompania.Text;
                    withBlock.Contacto = txtcontacto.Text;
                    withBlock.Direccion = txtdireccion.Text;
                    withBlock.Ciudad = txtpaiz.Text;
                    withBlock.Paiz = txtpaizz.Text;
                }
                bool exito = obrcliente.ActualizarCliente(obeCLIENTE);
                if (exito)
                {
                    MessageBox.Show("Se Actualizó el Cliente ", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                    this.Hide();


                }


                else
                {


                    MessageBox.Show("No se pudo Actualizar el cliente ", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }



        }
    }
}
