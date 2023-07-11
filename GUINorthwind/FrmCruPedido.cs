using LibBusinessRules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibBusinessEntities;

namespace GUINorthwind
{
    public partial class FrmCruPedido : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int
        lparam);
        public int modoWindow { get; set; }
        public int codorden { get; set; }
        public String  idcliente{ get; set; }
        public int idempleado { get; set; }
        public DateTime FechaOrden { get; set; }
        public String Direccion{ get; set; }
        //public double  trasporte{ get; set; }


        public FrmCruPedido()
        {
            InitializeComponent();
        }

        private void habilitaCasillas(Boolean estado)
        {
            txtCODIGOrden.Enabled = estado;
            txtidcliente.Enabled = estado;
           txtidempleado.Enabled = estado;
            dateFechaorden.Enabled = estado;
            txtdirecion.Enabled = estado;
            //txttrasporte.Enabled = estado;
            btnGrabarpedido.Enabled = estado;

        }
        private void limpiaCasillas()
        {
            txtCODIGOrden.Clear();
            txtidcliente.Clear();
            txtidempleado.Clear();
            //dateFechaorden.Clear();
            txtdirecion.Clear();
            //txttrasporte.Clear();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmCruPedido_Load(object sender, EventArgs e)
        {

            switch (modoWindow)
            {
                case 0: //Ver
                    
                    txtCODIGOrden.Text =  codorden.ToString();
                    txtidcliente.Text = idcliente;
                    txtidempleado.Text =idempleado.ToString();
                    dateFechaorden.Value = FechaOrden;
                    txtdirecion.Text = Direccion.ToString();
                    //txttrasporte.Text = trasporte.ToString()  ;


                    habilitaCasillas(false);
                    break;
                case 1: //Nuevo
                    limpiaCasillas();
                    break;
                case 2: //Editar
                    txtCODIGOrden.Text = codorden.ToString();
                    txtidcliente.Text = idcliente;
                    txtidempleado.Text = idempleado.ToString();
                    dateFechaorden.Value = FechaOrden;
                    txtdirecion.Text = Direccion.ToString();
                    //txttrasporte.Text = trasporte.ToString();
                    habilitaCasillas(true);
                    break;
            }


        }

        BRPedido ordpedido = new BRPedido();
        private void btnGrabarpedido_Click(object sender, EventArgs e)
        {

            if (modoWindow == 1) //Regitstrar
            {

                BEPedido obeEmpleado = new BEPedido();
                {
                    var withBlock = obeEmpleado;
                    withBlock.CodigoOrden= Convert.ToInt32(txtCODIGOrden.Text);
                    withBlock.IdCliente = txtidcliente.Text;
                    withBlock.IdEmpleado = Convert.ToInt32( txtidempleado.Text);
                    withBlock.FechaOrden = dateFechaorden.Value;
                    withBlock.DireccionEnvio =  txtdirecion.Text;
                    //withBlock.Transporte = Convert.ToDouble(txttrasporte.Text);


                }
                int N = ordpedido.AdicionarPedido(obeEmpleado);
                if (N > 0)
                {


                    MessageBox.Show("Se Adicionó el orden", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                    this.Hide();
                }
                else
                {


                    MessageBox.Show("No se pudo Adicionar el orden", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (modoWindow == 2) //Editar
            {
                BEPedido obeEmpleado = new BEPedido();
                {
                    var withBlock = obeEmpleado;
                    withBlock.CodigoOrden = Convert.ToInt32(txtCODIGOrden.Text);
                    withBlock.IdCliente = txtidcliente.Text;
                    withBlock.IdEmpleado = Convert.ToInt32(txtidempleado.Text);
                    withBlock.FechaOrden = dateFechaorden.Value;
                    withBlock.DireccionEnvio = txtdirecion.Text;
                    //withBlock.Transporte = Convert.ToDouble(txttrasporte.Text);
                }
                bool exito = ordpedido.ActualizarPedido(obeEmpleado);
                if (exito)
                {
                    MessageBox.Show("Se Actualizó el pedido", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                    this.Hide();


                }


                else
                {


                    MessageBox.Show("No se pudo Actualizar el pedidpo", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

        }
    }
}
