using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LibBusinessEntities;
using LibBusinessRules;

namespace GUINorthwind
{
    public partial class FrmCRUProducto : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int
        lparam);


        // llamo amis clases 
        private BEProducto producto;
        private BECategoria categoria;
        private BEProveedor proveedor;
        public FrmCRUProducto(BEProducto producto ,  BECategoria categoria , BEProveedor proveedor)// aki resivo los dtaos enviados de frmprincipal
        {
            InitializeComponent();

            // aki guardo mis dtaso enviados en mis clases 
            this.producto = producto;
            this.categoria = categoria;
            this.proveedor = proveedor;

            // Mostrar los detalles del producto en los controles del formulario


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

        private void minimizarVentana(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void FrmCRUProducto_Load(object sender, EventArgs e)
        {
            // para blokear los textos
            txtUser.Enabled = false;
            txtprecio.Enabled = false;
            txtshow.Enabled = false;
            cbxcategoria.Enabled = false;
            cbxproovedor.Enabled = false;

            txtUser.Text = producto.Nombre;

            cbxproovedor.Items.Add(proveedor.Nombre);
            cbxproovedor.Items.Insert(0, "");// agrego una fila  0
            cbxproovedor.SelectedIndex = 1;// le indiko k solo me muestr la fila 1



            cbxcategoria.Items.Add(categoria.Nombre);// agrego el valor 
            cbxcategoria.Items.Insert(0, "");// agrego una fila  0
            cbxcategoria.SelectedIndex = 1;// le indiko k solo me muestr la fila 1

           txtprecio.Text = ""+producto.PrecioUni;
            txtshow.Text = "" + producto.Stock;

           
        }
    }
}
