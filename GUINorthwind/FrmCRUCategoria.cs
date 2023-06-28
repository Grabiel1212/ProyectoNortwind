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
using LibBusinessRules;
using LibBusinessEntities;


namespace GUINorthwind
{
    public partial class FrmCRUCategoria : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int
        lparam);
        public int modoWindow { get; set; }
        public int codCategoria { get; set; }
        public String nomCategoria { get; set; }
        public string DescripcionCate { get; set; }


        public FrmCRUCategoria()
        {
            InitializeComponent();
        }

        private void habilitaCasillas(Boolean estado)
        {

            txtcategoria.Enabled = estado;
            txtdescripccion.Enabled = estado;
            btngrabarcategoria.Enabled = estado;

        }
        private void limpiaCasillas()
        {
            txtcategoria.Clear();
            txtdescripccion.Clear();

        }

        private void FrmCRUCategoria_Load(object sender, EventArgs e)
        {
            //BRCategoria obrCategoria = new BRCategoria();
            //List<BECategoria> lbeCategotia = obrCategoria.Listar();
            //cbxproovedor.DataSource = lbeProveedor;
            //cbxproovedor.DisplayMember = "Nombre";
            //cbxproovedor.ValueMember = "Codigo";
            //BRCategoria obrCategoria = new BRCategoria();
            //List<BECategoria> lbeCategoria = obrCategoria.Listar();
            //cbxcategoria.DataSource = lbeCategoria;
            //cbxcategoria.DisplayMember = "Nombre";
            //cbxcategoria.ValueMember = "Codigo";



            switch (modoWindow)
            {
                case 0: //Ver
                    txtcategoria.Text = nomCategoria;
                    txtdescripccion.Text = DescripcionCate;

                    habilitaCasillas(false);
                    break;
                case 1: //Nuevo
                    limpiaCasillas();
                    break;
                case 2: //Editar
                    txtcategoria.Text = nomCategoria;
                    txtdescripccion.Text = DescripcionCate;

                    habilitaCasillas(true);
                    break;
            }
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


        private BRCategoria obrCategoria = new BRCategoria();
        private void btngrabarcategoria_Click(object sender, EventArgs e)
        {

            if (modoWindow == 1) //Regitstrar
            {

                BECategoria obeCategoria = new BECategoria();
                {
                    var withBlock = obeCategoria;
                    withBlock.Nombre = txtcategoria.Text;
                    withBlock.Descripcion = txtdescripccion.Text;


                }
                int N = obrCategoria.InsertarCategoria(obeCategoria);
                if (N > 0)
                {


                    MessageBox.Show("Se Adicionó la Categoria", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                    this.Hide();
                }
                else
                {


                    MessageBox.Show("No se pudo Adicionar la Categoria", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (modoWindow == 2) //Editar
            {
                BECategoria obeCategoria = new BECategoria();
                {
                    var withBlock = obeCategoria;
                    withBlock.Codigo = codCategoria;
                    withBlock.Nombre = txtcategoria.Text;
                    withBlock.Descripcion = txtdescripccion.Text;

                }
                bool exito = obrCategoria.ActualizarCategorias(obeCategoria);
                if (exito)
                {
                    MessageBox.Show("Se Actualizó la Categoria", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                    this.Hide();


                }


                else
                {


                    MessageBox.Show("No se pudo Actualizar la Categoria", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }




            }
        }






    }
    
}
