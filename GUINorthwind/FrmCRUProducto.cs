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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using System.Security.Cryptography;

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
        //private BEProducto producto;
        //private BECategoria categoria;
        //private BEProveedor proveedor;


        public int modoWindow { get; set; }
        public int codProd { get; set; }
        public String nomProd { get; set; }
        public int codProv { get; set; }
        public int codCat { get; set; }
        public decimal precio { get; set; }
        public Int16 stock { get; set; }

        public FrmCRUProducto()// aki resivo los dtaos enviados de frmprincipal
        {
            InitializeComponent();

            // aki guardo mis dtaso enviados en mis clases 
            //this.producto = producto;
            //this.categoria = categoria;
            //this.proveedor = proveedor;


            //BlokearObjetos(true, true, true, true, true, true);

        }



        private void habilitaCasillas(Boolean estado)
        {
            txtUser.Enabled = estado;
            cbxproovedor.Enabled = estado;
            cbxcategoria.Enabled = estado;
            txtprecio.Enabled = estado;
            txtshow.Enabled = estado;
            btnGrabar.Enabled = estado;
        }
        private void limpiaCasillas()
        {
            txtUser.Clear();
            txtprecio.Clear();
            txtshow.Clear();
        }

        //public void BlokearObjetos(Boolean p1, Boolean p2, Boolean p3, Boolean p4, Boolean p5, Boolean p6)
        //{

        //    txtUser.Enabled = p1;
        //    cbxproovedor.Enabled = p2;
        //    txtshow.Enabled = p3;
        //    cbxcategoria.Enabled = p4;
        //    txtprecio.Enabled = p5;
        //    btnGrabar.Enabled = p6;


        //}


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
            //// para blokear los textos
            //BlokearObjetos(false, false, false, false, false, false);


            //txtUser.Text = producto.Nombre;

            //cbxproovedor.Items.Add(proveedor.Nombre);
            //cbxproovedor.Items.Insert(0, "");// agrego una fila  0
            //cbxproovedor.SelectedIndex = 1;// le indiko k solo me muestr la fila 1



            //cbxcategoria.Items.Add(categoria.Nombre);// agrego el valor 
            //cbxcategoria.Items.Insert(0, "");// agrego una fila  0
            //cbxcategoria.SelectedIndex = 1;// le indiko k solo me muestr la fila 1

            //txtprecio.Text = "" + producto.PrecioUni;
            //txtshow.Text = "" + producto.Stock;



            // esto es llenar nuestro combo box categoria y proveedores 

            BRProveedor obrProveedor = new BRProveedor();
            List<BEProveedor> lbeProveedor = obrProveedor.ListarProveedor();
            cbxproovedor.DataSource = lbeProveedor;
            cbxproovedor.DisplayMember = "Nombre";
            cbxproovedor.ValueMember = "Codigo";
            BRCategoria obrCategoria = new BRCategoria();
            List<BECategoria> lbeCategoria = obrCategoria.Listar();
            cbxcategoria.DataSource = lbeCategoria;
            cbxcategoria.DisplayMember = "Nombre";
            cbxcategoria.ValueMember = "Codigo";

         

            switch (modoWindow)
            {
                case 0: //Ver
                    txtUser.Text = nomProd;
                    cbxproovedor.SelectedValue = codProv;
                    cbxcategoria.SelectedValue = codCat;
                    txtprecio.Text = precio.ToString();
                    txtshow.Text = stock.ToString();
                    habilitaCasillas(false);
                    break;
                case 1: //Nuevo
                    limpiaCasillas();
                    break;
                case 2: //Editar
                    txtUser.Text = nomProd;
                    cbxproovedor.SelectedValue = codProv;
                    cbxcategoria.SelectedValue = codCat;
                    txtprecio.Text = precio.ToString();
                    txtshow.Text = stock.ToString();
                    habilitaCasillas(true);
                    break;
            }

        }

        private BRProducto obrProducto = new BRProducto();
        private void btnGrabar_Click(object sender, EventArgs e)
        {

          
      
         

            if (modoWindow == 1) //Regitstrar
            {

                BEProducto obeProducto = new BEProducto();
                {
                    var withBlock = obeProducto;
                    withBlock.Nombre = txtUser.Text;
                    withBlock.IdProveedor = Convert.ToInt32(cbxproovedor.SelectedValue);
                    withBlock.IdCategoria = Convert.ToInt32(cbxcategoria.SelectedValue);
                    withBlock.PrecioUni = Convert.ToDecimal(txtprecio.Text);
                    withBlock.Stock = Convert.ToInt16(txtshow.Text);

                }
                int N = obrProducto.Adicionar(obeProducto);
                if (N > 0)
                {


                    MessageBox.Show("Se Adicionó el Producto", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                    this.Hide();
                }
                else
                {


                    MessageBox.Show("No se pudo Adicionar el Producto", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
            if (modoWindow == 2) //Editar
            {
                BEProducto obeProducto = new BEProducto();
                {
                    var withBlock = obeProducto;
                    withBlock.Codigo = codProd;
                    withBlock.Nombre = txtUser.Text;
                    withBlock.IdProveedor = Convert.ToInt32(cbxproovedor.SelectedValue);
                    withBlock.IdCategoria = Convert.ToInt32(cbxcategoria.SelectedValue);
                    withBlock.PrecioUni = Convert.ToDecimal(txtprecio.Text);
                    withBlock.Stock = Convert.ToInt16(txtshow.Text);
                }
                bool exito = obrProducto.Actualizar(obeProducto);
                if (exito)
                {
                    MessageBox.Show("Se Actualizó el Producto", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                    this.Hide();


                }


                else
                {

                
                        MessageBox.Show("No se pudo Actualizar el Producto", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }



           



            }
        }





    }
    
}
