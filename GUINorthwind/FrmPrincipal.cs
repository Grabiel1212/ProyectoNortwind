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
using System.Security.Policy;
using System.Drawing.Text;

namespace GUINorthwind
{
    public partial class FrmPrincipal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int
        lparam);

       //  variantes para llamar el nombre , apellido , ocupaciuon desde login ami ventana principal
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ocupacion { get; set; }


        public FrmPrincipal()
        {
            InitializeComponent();
        }

        Font fuente;
        DataGridView dgv;

    

        // esto  sirve para persinalizar los datagriew
        private void personalizaGrilla()
        {
            dgvProductos.BackgroundColor = Color.FromArgb(45,66,91);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.RowsDefaultCellStyle.BackColor = Color.FromArgb(45,66,91);
            fuente = new Font("Century Gothic", 10);
            dgvProductos.RowsDefaultCellStyle.Font = fuente;
            dgvProductos.RowsDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvProductos.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvProductos.GridColor = Color.SteelBlue;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            dgvProductos.ColumnHeadersDefaultCellStyle.Font = fuente;
            dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvProductos.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgvProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductos.ColumnHeadersHeight = 30;
            dgvProductos.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45,66,91);
            fuente = new Font("Microsoft Sans Serif", 9);
            dgvProductos.RowHeadersDefaultCellStyle.Font = fuente;
            dgvProductos.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductos.RowHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvProductos.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductos.ColumnHeadersVisible = true;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.ColumnHeadersVisible=true;

            dgvCategorias.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Century Gothic", 10);
            dgvCategorias.RowsDefaultCellStyle.Font = fuente;
            dgvCategorias.RowsDefaultCellStyle.ForeColor = Color.White;
            dgvCategorias.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvCategorias.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvCategorias.GridColor = Color.SteelBlue;
            dgvCategorias.EnableHeadersVisualStyles = false;
            dgvCategorias.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            dgvCategorias.ColumnHeadersDefaultCellStyle.Font = fuente;
            dgvCategorias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCategorias.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvCategorias.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgvCategorias.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategorias.ColumnHeadersHeight = 30;
            dgvCategorias.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Microsoft Sans Serif", 9);
            dgvCategorias.RowHeadersDefaultCellStyle.Font = fuente;
            dgvCategorias.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCategorias.RowHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvCategorias.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgvCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategorias.ColumnHeadersVisible = true;
            dgvCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCategorias.ColumnHeadersVisible = true;

            dgvEmpleados.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvEmpleados.BorderStyle = BorderStyle.None;
            dgvEmpleados.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Century Gothic", 10);
            dgvEmpleados.RowsDefaultCellStyle.Font = fuente;
            dgvEmpleados.RowsDefaultCellStyle.ForeColor = Color.White;
            dgvEmpleados.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvEmpleados.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvEmpleados.GridColor = Color.SteelBlue;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.Font = fuente;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgvEmpleados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmpleados.ColumnHeadersHeight = 30;
            dgvEmpleados.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Microsoft Sans Serif", 9);
            dgvEmpleados.RowHeadersDefaultCellStyle.Font = fuente;
            dgvEmpleados.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEmpleados.RowHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvEmpleados.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgvEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmpleados.ColumnHeadersVisible = true;
            dgvEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmpleados.ColumnHeadersVisible = true;

            dgvProveedores.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvProveedores.BorderStyle = BorderStyle.None;
            dgvProveedores.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Century Gothic", 10);
            dgvProveedores.RowsDefaultCellStyle.Font = fuente;
            dgvProveedores.RowsDefaultCellStyle.ForeColor = Color.White;
            dgvProveedores.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvProveedores.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvProveedores.GridColor = Color.SteelBlue;
            dgvProveedores.EnableHeadersVisualStyles = false;
            dgvProveedores.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            dgvProveedores.ColumnHeadersDefaultCellStyle.Font = fuente;
            dgvProveedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProveedores.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvProveedores.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgvProveedores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProveedores.ColumnHeadersHeight = 30;
            dgvProveedores.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Microsoft Sans Serif", 9);
            dgvProveedores.RowHeadersDefaultCellStyle.Font = fuente;
            dgvProveedores.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProveedores.RowHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvProveedores.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgvProveedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProveedores.ColumnHeadersVisible = true;
            dgvProveedores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProveedores.ColumnHeadersVisible = true;

            dgvUsuarios.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Century Gothic", 10);
            dgvUsuarios.RowsDefaultCellStyle.Font = fuente;
            dgvUsuarios.RowsDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvUsuarios.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvUsuarios.GridColor = Color.SteelBlue;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = fuente;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsuarios.ColumnHeadersHeight = 30;
            dgvUsuarios.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Microsoft Sans Serif", 9);
            dgvUsuarios.RowHeadersDefaultCellStyle.Font = fuente;
            dgvUsuarios.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.RowHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvUsuarios.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgvUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.ColumnHeadersVisible = true;
            dgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsuarios.ColumnHeadersVisible = true;
        }
        // para lsitar mis encapsulados 
        private List<BEProducto> lbeProducto;
        private List<BECategoria> lbeCategoria;
        private List<BEEmpleado> lbeEmpleado;
        private List<BEProveedor> lbeProveedor;
        private List<BEUsuario> lbeUsuario;

        private void cargaDatos(int identificador) // el indentificador viene de tcventana cada ventana tiene su rango de inicio
        {
            personalizaGrilla(); // llamo ami metodo de personalizar los data griew 

            switch (identificador) { 
                case 0:
                    BRProducto obrProducto = new BRProducto();
                    lbeProducto = obrProducto.Listar();
                    dgvProductos.DataSource = lbeProducto;
                    break;
                case 1:
                    BRCategoria obrCategorias = new BRCategoria();
                    lbeCategoria = obrCategorias.Listar();
                    dgvCategorias.DataSource = lbeCategoria;
                    break;
                case 2:
                    BREmpleado obrEmpleado = new BREmpleado();
                    lbeEmpleado = obrEmpleado.Listar();
                    dgvEmpleados.DataSource = lbeEmpleado;
                    break;
                case 3:
                    BRProveedor obrProveedor = new BRProveedor();
                    lbeProveedor = obrProveedor.Listar();
                    dgvProveedores.DataSource = lbeProveedor;
                    break;
                case 4:
                    BRUsuario obrUsuario = new BRUsuario();
                    lbeUsuario = obrUsuario.Listar();
                    dgvUsuarios.DataSource = lbeUsuario;
                    break;
               
            }
        }

        private void activaSeleccion(int identificador)
        {
            switch(identificador)
            {
                case 0:
                    btnProductos.BackColor = Color.FromArgb(85, 159, 127);
                    btnCategorias.BackColor = Color.FromArgb(33, 53, 73);
                    btnEmpleados.BackColor = Color.FromArgb(33, 53, 73);
                    btnProveedores.BackColor = Color.FromArgb(33, 53, 73);
                    btnUsuarios.BackColor = Color.FromArgb(33, 53, 73);
                    break;
                case 1:
                    btnProductos.BackColor = Color.FromArgb(33, 53, 73);
                    btnCategorias.BackColor = Color.FromArgb(85, 159, 127);
                    btnEmpleados.BackColor = Color.FromArgb(33, 53, 73);
                    btnProveedores.BackColor = Color.FromArgb(33, 53, 73);
                    btnUsuarios.BackColor = Color.FromArgb(33, 53, 73);
                    break;
                case 2:
                    btnProductos.BackColor = Color.FromArgb(33, 53, 73);
                    btnCategorias.BackColor = Color.FromArgb(33, 53, 73);
                    btnEmpleados.BackColor = Color.FromArgb(85, 159, 127);
                    btnProveedores.BackColor = Color.FromArgb(33, 53, 73);
                    btnUsuarios.BackColor = Color.FromArgb(33, 53, 73);
                    break;
                case 3:
                    btnProductos.BackColor = Color.FromArgb(33, 53, 73);
                    btnCategorias.BackColor = Color.FromArgb(33, 53, 73);
                    btnEmpleados.BackColor = Color.FromArgb(33, 53, 73);
                    btnProveedores.BackColor = Color.FromArgb(85, 159, 127);
                    btnUsuarios.BackColor = Color.FromArgb(33, 53, 73);
                    break;
                case 4:
                    btnProductos.BackColor = Color.FromArgb(33, 53, 73);
                    btnCategorias.BackColor = Color.FromArgb(33, 53, 73);
                    btnEmpleados.BackColor = Color.FromArgb(33, 53, 73);
                    btnProveedores.BackColor = Color.FromArgb(33, 53, 73);
                    btnUsuarios.BackColor = Color.FromArgb(85, 159, 127);
                    break;
            }
        }

       
        private void accedeProductos(object sender, EventArgs e)// btn acceder porductos
        {
            btnpoductDesacticadoss.Text = "";
            btnpoductDesacticadoss.Text = "MOSTAR PRODUCTOS DESACTIVADOS";

            tcVentanas.SelectedIndex = 0;
            activaSeleccion(0);
            lblTitulo.Text = btnProductos.Text;
            cargaDatos(0);
        }

      
        private void accedeCategorias(object sender, EventArgs e)// brn aaceder categorias
        {
            tcVentanas.SelectedIndex = 1;
            activaSeleccion(1);
            lblTitulo.Text = btnCategorias.Text;
            cargaDatos(1);
        }

        private void accedeEmpleados(object sender, EventArgs e)// btn acceder empleados
        {
            tcVentanas.SelectedIndex = 2;
            activaSeleccion(2);
            lblTitulo.Text = btnEmpleados.Text;
            cargaDatos(2);
        }

        private void accedeProveedores(object sender, EventArgs e)// btn acceder proovedores
        {
            tcVentanas.SelectedIndex = 3;
            activaSeleccion(3);
            lblTitulo.Text = btnProveedores.Text;
            cargaDatos(3);
        }

        private void accedeUsuarios(object sender, EventArgs e)// btn acceder usuarios
        {
            tcVentanas.SelectedIndex = 4;
            activaSeleccion(4);
            lblTitulo.Text = btnUsuarios.Text;
            cargaDatos(4);
        }

        private void cerrarAplicacion(object sender, EventArgs e) // btn cerrar aplicacion
        {
            Application.Exit();
        }

        private void minimizaVentana(object sender, EventArgs e)// btn minimizar
        {
            this.WindowState = FormWindowState.Minimized;    
        }

        private void moverVentana(object sender, MouseEventArgs e)// evento para mover la ventana libremente
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void carga(object sender, EventArgs e) // para cargar datos al formulario directamente
        {
            cargaDatos(0);

            lblnombreusuario.Text = "";
            lblapellidousuario.Text ="";
            
            lblnombreusuario.Text = Nombre + "  " + Apellido;
            lblapellidousuario.Text = Ocupacion;
        }

        // para filtrar una busqueda 
        List<BEProducto> lbeFiltro01;
        List<BECategoria> lbeFiltro02;
        List<BEEmpleado> lbeFiltro03;
        List<BEProveedor> lbeFiltro04;
        List<BEUsuario> lbeFiltro05;
        private void filtro(int identificador)
        {
            switch (identificador)
            {
                case 0:
                    lbeFiltro01 = new List<BEProducto>();// llamo ami metodo con parametros donde estan mis encapsulados

                    BEProducto obeProducto; // llamo ami metodo vacio donde estan mis encapsulados

                    for (int I = 0; I <= lbeProducto.Count - 1; I++)//lbe productos viene de listar amis encapsulado con parametros 
                    {
                        if (lbeProducto[I].Nombre.ToUpper().Contains(txtFiltroProducto.Text.ToUpper())) // toYpper pone en mayusculas /// y el constrais va analizar si esa lista tiene esa letra y devolvera el resultadi
                        {
                            // esto es para que los datos se listes segun su rago y se guarden sus datos para que luego se muestre en la tabla de busqueda
                            obeProducto = new BEProducto();
                            obeProducto.Codigo = lbeProducto[I].Codigo;
                            obeProducto.Nombre = lbeProducto[I].Nombre;
                            obeProducto.PrecioUni = lbeProducto[I].PrecioUni;
                            obeProducto.Stock = lbeProducto[I].Stock;
                            lbeFiltro01.Add(obeProducto);
                        }
                    }
                    dgvProductos.DataSource = lbeFiltro01;// va a filtrar la vuslqueda es nuestra tabla
                    break;
                case 1:
                    lbeFiltro02 = new List<BECategoria>();
                    BECategoria obeCategoria;

                    for (int I = 0; I <= lbeCategoria.Count - 1; I++)
                    {
                        if (lbeCategoria[I].Nombre.ToUpper().Contains(txtFiltroCategoria.Text.ToUpper()))
                        {
                            obeCategoria = new BECategoria();
                            obeCategoria.Codigo = lbeCategoria[I].Codigo;
                            obeCategoria.Nombre = lbeCategoria[I].Nombre;
                            lbeFiltro02.Add(obeCategoria);
                        }
                    }
                    dgvCategorias.DataSource = lbeFiltro02;
                    break;
                case 2:
                    lbeFiltro03 = new List<BEEmpleado>();
                    BEEmpleado obeEmpleado;

                    for (int I = 0; I <= lbeEmpleado.Count - 1; I++)
                    {
                        if (lbeEmpleado[I].Apellido.ToUpper().Contains(txtFiltroEmpleado.Text.ToUpper()))
                        {
                            obeEmpleado = new BEEmpleado();
                            obeEmpleado.Codigo = lbeEmpleado[I].Codigo;
                            obeEmpleado.Apellido = lbeEmpleado[I].Apellido;
                            obeEmpleado.Nombre = lbeEmpleado[I].Nombre;
                            obeEmpleado.FechaNac = lbeEmpleado[I].FechaNac;
                            lbeFiltro03.Add(obeEmpleado);
                        }
                    }
                    dgvEmpleados.DataSource = lbeFiltro03;
                    break;
                case 3:
                    lbeFiltro04 = new List<BEProveedor>();
                    BEProveedor obeProveedor;

                    for (int I = 0; I <= lbeProveedor.Count - 1; I++)
                    {
                        if (lbeProveedor[I].Nombre.ToUpper().Contains(txtFiltroProveedor.Text.ToUpper()))
                        {
                            obeProveedor = new BEProveedor();
                            obeProveedor.Codigo = lbeProveedor[I].Codigo;
                            obeProveedor.Nombre = lbeProveedor[I].Nombre;
                            lbeFiltro04.Add(obeProveedor);
                        }
                    }
                    dgvProveedores.DataSource = lbeFiltro04;
                    break;
                case 4:
                    lbeFiltro05 = new List<BEUsuario>();
                    BEUsuario obeUsuario;

                    for (int I = 0; I <= lbeUsuario.Count - 1; I++)
                    {
                        if (lbeUsuario[I].Nombre.ToUpper().Contains(txtFiltroUsuario.Text.ToUpper()))
                        {
                            obeUsuario = new BEUsuario();
                            obeUsuario.Codigo = lbeUsuario[I].Codigo;
                            obeUsuario.NombreUsuario = lbeUsuario[I].NombreUsuario;
                            obeUsuario.PasswordUsuario = lbeUsuario[I].PasswordUsuario;
                            obeUsuario.Nombre = lbeUsuario[I].Nombre;
                            obeUsuario.Apellido = lbeUsuario[I].Apellido;
                            obeUsuario.Estado = lbeUsuario[I].Estado;
                            lbeFiltro05.Add(obeUsuario);
                        }
                    }
                    dgvUsuarios.DataSource = lbeFiltro05;
                    break;
            }
        }

        private void filtrarUsuarios(object sender, EventArgs e) //txtfiltrarUusuarios  con el evento TextChanget
        {
            filtro(4);
        }

        private void filtrarProveedores(object sender, EventArgs e)//txtfiltrarProovedores usuario con el evento TextChanget
        {
            filtro(3);
        }

        private void filtrarProductos(object sender, EventArgs e)//txtfiltrarPorductos  con el evento TextChanget
        {
            filtro(0);
        }

        private void filtrarCategorias(object sender, EventArgs e)//txtfiltrar categorias con el evento TextChanget
        {
            filtro(1);
        }

        private void filtrarEmpleados(object sender, EventArgs e)//txtfiltrar empleado con el evento TextChanget
        {
            filtro(2);
        }

     
        private void informacionProducto(object sender, EventArgs e)// boton informacion del producto
        {

            BRCategoria objCategoria = new BRCategoria();
            BRProveedor objProveedor = new BRProveedor();

            //// vreificamos se se seleciono una fila  en mi datagriew

            //if (dgvProductos.SelectedRows.Count > 0) // se ase el conteo
            //{
            //    DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];// esto nos dira la posion en fila se a seleccionado
            //    BEProducto productoSeleccionado = (BEProducto)filaSeleccionada.DataBoundItem;// obtenemos la informacion de nuestra fila

            //    // akim el metodo firnsorDefaul va aobtener el primer dato de la condicion , para eso usamos el c , que va  va analizar k el coidgo se encuentre en las lista de mis categroria}
            //    // y los va a validar una ves , uan ves k se culpa no va aguarda el dato en categria si no nos bottara null
            //      BECategoria categoria = objCategoria.Listar().FirstOrDefault(c => c.Codigo == productoSeleccionado.IdCategoria);
            //    BEProveedor proveedor = objProveedor.Listar().FirstOrDefault(p => p.Codigo==productoSeleccionado.IdProveedor);

            //      FrmCRUProducto abrir = new FrmCRUProducto(productoSeleccionado, categoria , proveedor);// enviamos los dtaos 
            //      abrir.ShowDialog();


            //}
            //else
            //{
            //    MessageBox.Show("Seleccionar una fila por favor ");
            //}



            //        public int modoWindow;
            //public int codProd;
            //public String nomProd;
            //public int codProv;
            //public int codCat;
            //public decimal precio;
            //public Int16 stock;



            if (dgvProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];// esto nos dira la posion en fila se a seleccionado
                BEProducto productoSeleccionado = (BEProducto)filaSeleccionada.DataBoundItem;// obtenemos la informacion de nuestra fila

                FrmCRUProducto abrir = new FrmCRUProducto();
                abrir.modoWindow = 0;
                abrir.codProd = productoSeleccionado.Codigo;
                abrir.nomProd = productoSeleccionado.Nombre;
                abrir.codProv = productoSeleccionado.IdProveedor;
                abrir.codCat = productoSeleccionado.IdCategoria;
                abrir.precio = productoSeleccionado.PrecioUni;
                abrir.stock = productoSeleccionado.Stock;

                abrir.ShowDialog();
             
            }
            else
            {
                MessageBox.Show("Seleccionar una fila por favor");
            }










        }

        private void lblregresarLogin_MouseClick(object sender, MouseEventArgs e)// para regresar la login
        {
          
        }

        private void btnprovar_Click(object sender, EventArgs e)// no exite pee
        {
            
        }

        private void lblregresarLogin_MouseClick_1(object sender, MouseEventArgs e)
        {
            FrmLogin abrir = new FrmLogin();
            abrir.Visible = true;
            this.Hide();
        }

        private bool valor = false; // para enviar valor si esta activado o desactivado
        private void btnpoductDesacticadoss_Click(object sender, EventArgs e)
        {

            valor = !valor;
            int numeroAc = 0;

            if (valor)
            {
                btnpoductDesacticadoss.Text = "";
                numeroAc = 1;
                BRProducto objproducto = new BRProducto();
                lbeProducto = objproducto.ListarProducActivados(numeroAc);
                dgvProductos.DataSource = lbeProducto;
             
                btnLogin.Enabled = false;
                btnregistrarproducto.Enabled = false;
                btnmodificarProducto.Enabled = false;

                btnpoductDesacticadoss.Text = "MOSTRAR PRODUCTOS ACTIVADOS";
                btneliminarProducto.Text = "HABILITAR PRODUCTO";

            }
            else
            {

              
                numeroAc = 0;
                BRProducto objproducto = new BRProducto();
                lbeProducto = objproducto.ListarProducActivados(numeroAc);
                dgvProductos.DataSource = lbeProducto;
                btnLogin.Enabled = true;
                btnregistrarproducto.Enabled = true;
                btnmodificarProducto.Enabled = true;
                btneliminarProducto.Text = "ELIMINAR PRODUCTO";

                btnpoductDesacticadoss.Text = "";
                btnpoductDesacticadoss.Text = "MOSTAR PRODUCTOS DESACTIVADOS";


            }
            //    btnpoductDesacticadoss.Text = "";
            //btnpoductDesacticadoss.Text = "MOSTAR PRODUCTOS DESACTIVADOS";


            //if (btnpoductDesacticadoss.Text.Equals("MOSTAR PRODUCTOS DESACTIVADOS"))
            //{
           
            //        BRProducto obrProducto = new BRProducto();
            //    lbeProducto = obrProducto.ListarInhabi();
            //    dgvProductos.DataSource = lbeProducto;
            //    btnpoductDesacticadoss.Text = "MOSTRAR PRODUCTOS ACTIVOS";
            //    btnLogin.Enabled = false;
            //    btnregistrarproducto.Enabled = false;
            //   btnmodificarProducto.Enabled = false;
            //   btneliminarProducto.Text = "HABILITAR PRODUCTO";


            //}
            //else if (btnpoductDesacticadoss.Text.Equals("MOSTRAR PRODUCTOS ACTIVOS"))
            //{
            //    btnpoductDesacticadoss.Text = "MOSTRAR PRODUCTOS DESACTIVADOS";
            //    BRProducto obrProducto = new BRProducto();
            //    lbeProducto = obrProducto.Listar();
            //    dgvProductos.DataSource = lbeProducto;
            //    btnLogin.Enabled = true;
            //    btnregistrarproducto.Enabled = true;
            //    btnmodificarProducto.Enabled = true;
            //    btneliminarProducto.Text = "ELIMINAR PRODUCTO";
            //}

        }

        private BRProducto obrProducto = new BRProducto();
        private void button3_Click(object sender, EventArgs e)
        {


            if (btneliminarProducto.Text.Equals("ELIMINAR PRODUCTO"))
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el producto " +
               dgvProductos.SelectedRows[0].Cells[1].Value.ToString() + "?", "Aviso",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //AKI LE PREGUNTAMOS SI DESE ALIMINAR UNM PRODUCTO Y SI DOSE L SI ARA LO SIGUINTE
                {
                    BEProducto obeProducto = new BEProducto();
                    {


                        var tomarvalorTabla = obeProducto;
                        // en esta fila le desimoos la psocion de nuestra columna y de nustra cela en este caso sera 0 donde esta el id , y tomara esevalor , y convertilo en entero
                        tomarvalorTabla.Codigo = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value.ToString()); 
                    }
                    bool exito = obrProducto.EliminarProd(obeProducto);
                    if (exito)
                    {
                        MessageBox.Show("Se Elimino el Producto", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Eliminar el Producto", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
                    }
                    accedeProductos(sender, e);
                }
            }
            else
            {
                if (MessageBox.Show("¿Seguro que desea activar el producto " +  // ESTO SIRVE PARA ABLIOTAR
               dgvProductos.SelectedRows[0].Cells[1].Value.ToString() + "?", "Aviso",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BEProducto obeProducto = new BEProducto();
                    {
                        var withBlock = obeProducto;
                        withBlock.Codigo = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value.ToString()); ;
                    }
                    bool exito = obrProducto.ActivarProduc(obeProducto);
                    if (exito)
                    {
                        MessageBox.Show("Se Activo el Producto", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);


                    }
                    else
                    {

                        MessageBox.Show("No se pudo Activar el Producto", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
                        //btnpoductDesacticadoss(sender, e);
                    }
                //this.btnpoductDesacticadoss_Click(sender, e);


                }
            }








        }

        private void btnmodificarProducto_Click(object sender, EventArgs e)
        {
            


            if (dgvProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvProductos.SelectedRows[0];// esto nos dira la posion en fila se a seleccionado
                BEProducto productoSeleccionado = (BEProducto)filaSeleccionada.DataBoundItem;// obtenemos la informacion de nuestra fila

                FrmCRUProducto abrir = new FrmCRUProducto();// enviamos los dtaos 
                abrir.modoWindow = 2;
                abrir.codProd = productoSeleccionado.Codigo;
                abrir.nomProd = productoSeleccionado.Nombre;
                abrir.codProv = productoSeleccionado.IdProveedor;
                abrir.codCat = productoSeleccionado.IdCategoria;
                abrir.precio = productoSeleccionado.PrecioUni;
                abrir.stock = productoSeleccionado.Stock;

                abrir.ShowDialog();

            }
            else
            {
                MessageBox.Show("Seleccionar una fila por favor");
            }

        }

        private void btnregistrarproducto_Click(object sender, EventArgs e)
        {
            FrmCRUProducto abrir = new FrmCRUProducto();// enviamos los dtaos 
            int yoyo = 1 ;
            abrir.modoWindow = yoyo;
            abrir.ShowDialog();
         
        }
    }
}
