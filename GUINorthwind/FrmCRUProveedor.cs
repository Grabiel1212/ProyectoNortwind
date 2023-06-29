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
using LibBusinessEntities;
using LibBusinessRules;

namespace GUINorthwind
{
    public partial class FrmCRUProveedor : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int
        lparam);


        // llamo amis clases 
        //private BEProducto producto;
        //private BECategoria categoria;
        //private BEProveedor proveedor;


        public int modoWindow { get; set; }
        public int codigoProvee { get; set; }
        public String pcompania { get; set; }
        public String pcontacto { get; set; }
        public String pdireccion { get; set; }
        public String ppaiz { get; set; }
    

        public FrmCRUProveedor()
        {
            InitializeComponent();
        }

        private void habilitaCasillas(Boolean estado)
        {
            txtcompania.Enabled = estado;
            txtContacto.Enabled = estado;
            txtdireccion.Enabled = estado;
            txtpaiz.Enabled = estado;
            btngravarProveedor.Enabled= estado;
        
        }
        private void limpiaCasillas()
        {
            txtcompania.Clear();
           txtContacto.Clear();
           txtdireccion.Clear();
           txtpaiz.Clear();    
        }


        private void moverVentana(object sender, MouseEventArgs e)
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

        private void FrmCRUProveedor_Load(object sender, EventArgs e)
        {

            switch (modoWindow)
            {
                case 0: //Ver
                    txtcompania.Text = pcompania;
                    txtContacto.Text = pcontacto;
                    txtdireccion.Text = pdireccion;
                    txtpaiz.Text = ppaiz;

                    habilitaCasillas(false);
                    break;
                case 1: //Nuevo
                    limpiaCasillas();
                    break;
                case 2: //Editar
                    txtcompania.Text = pcompania;
                    txtContacto.Text = pcontacto;
                    txtdireccion.Text = pdireccion;
                    txtpaiz.Text = ppaiz;

                    habilitaCasillas(true);
                    break;
            }

        }

        private BRProveedor obrProveedor = new BRProveedor();
        private void btngravarProveedor_Click(object sender, EventArgs e)
        {

            //if (modoWindow == 1) //Regitstrar
            //{

            //    BEProveedor obeProveedor = new BEProveedor();
            //    {
            //        var withBlock = obeProducto;
            //        withBlock.Nombre = txtUser.Text;
            //        withBlock.IdProveedor = Convert.ToInt32(cbxproovedor.SelectedValue);
            //        withBlock.IdCategoria = Convert.ToInt32(cbxcategoria.SelectedValue);
            //        withBlock.PrecioUni = Convert.ToDecimal(txtprecio.Text);
            //        withBlock.Stock = Convert.ToInt16(txtshow.Text);

            //    }
            //    int N = obrProducto.Adicionar(obeProducto);
            //    if (N > 0)
            //    {


            //        MessageBox.Show("Se Adicionó el Producto", "Aviso", MessageBoxButtons.OK,
            //       MessageBoxIcon.Information);

            //        this.Hide();
            //    }
            //    else
            //    {


            //        MessageBox.Show("No se pudo Adicionar el Producto", "Error",
            //       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //}

            //if (modoWindow == 2) //Editar
            //{
            //    BEProducto obeProducto = new BEProducto();
            //    {
            //        var withBlock = obeProducto;
            //        withBlock.Codigo = codProd;
            //        withBlock.Nombre = txtUser.Text;
            //        withBlock.IdProveedor = Convert.ToInt32(cbxproovedor.SelectedValue);
            //        withBlock.IdCategoria = Convert.ToInt32(cbxcategoria.SelectedValue);
            //        withBlock.PrecioUni = Convert.ToDecimal(txtprecio.Text);
            //        withBlock.Stock = Convert.ToInt16(txtshow.Text);
            //    }
            //    bool exito = obrProducto.Actualizar(obeProducto);
            //    if (exito)
            //    {
            //        MessageBox.Show("Se Actualizó el Producto", "Aviso", MessageBoxButtons.OK,
            //       MessageBoxIcon.Information);

            //        this.Hide();


            //    }


            //    else
            //    {


            //        MessageBox.Show("No se pudo Actualizar el Producto", "Error",
            //       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }





        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
