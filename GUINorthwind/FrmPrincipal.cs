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

namespace GUINorthwind
{
    public partial class FrmPrincipal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int
        lparam);

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ocupacion { get; set; }


        public FrmPrincipal()
        {
            InitializeComponent();
        }

        Font fuente;
        DataGridView dgv;
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
        private List<BEProducto> lbeProducto;
        private List<BECategoria> lbeCategoria;
        private List<BEEmpleado> lbeEmpleado;
        private List<BEProveedor> lbeProveedor;
        private List<BEUsuario> lbeUsuario;

        private void cargaDatos(int identificador)
        {
            personalizaGrilla();
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
                    btnProductos.BackColor=Color.FromArgb(85, 159, 127);
                    btnCategorias.BackColor=Color.FromArgb(33,53,73);
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

        private void accedeProductos(object sender, EventArgs e)
        {
            tcVentanas.SelectedIndex = 0;
            activaSeleccion(0);
            lblTitulo.Text = btnProductos.Text;
            cargaDatos(0);
        }

        private void accedeCategorias(object sender, EventArgs e)
        {
            tcVentanas.SelectedIndex = 1;
            activaSeleccion(1);
            lblTitulo.Text = btnCategorias.Text;
            cargaDatos(1);
        }

        private void accedeEmpleados(object sender, EventArgs e)
        {
            tcVentanas.SelectedIndex = 2;
            activaSeleccion(2);
            lblTitulo.Text = btnEmpleados.Text;
            cargaDatos(2);
        }

        private void accedeProveedores(object sender, EventArgs e)
        {
            tcVentanas.SelectedIndex = 3;
            activaSeleccion(3);
            lblTitulo.Text = btnProveedores.Text;
            cargaDatos(3);
        }

        private void accedeUsuarios(object sender, EventArgs e)
        {
            tcVentanas.SelectedIndex = 4;
            activaSeleccion(4);
            lblTitulo.Text = btnUsuarios.Text;
            cargaDatos(4);
        }

        private void cerrarAplicacion(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizaVentana(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;    
        }

        private void moverVentana(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void carga(object sender, EventArgs e)
        {
            cargaDatos(0);

            lblnombreusuario.Text = "";
            lblapellidousuario.Text ="";
            
            lblnombreusuario.Text = Nombre + "  " + Apellido;
            lblapellidousuario.Text = Ocupacion;
        }


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
                    lbeFiltro01 = new List<BEProducto>();
                    BEProducto obeProducto;

                    for (int I = 0; I <= lbeProducto.Count - 1; I++)
                    {
                        if (lbeProducto[I].Nombre.ToUpper().Contains(txtFiltroProducto.Text.ToUpper()))
                        {
                            obeProducto = new BEProducto();
                            obeProducto.Codigo = lbeProducto[I].Codigo;
                            obeProducto.Nombre = lbeProducto[I].Nombre;
                            obeProducto.PrecioUni = lbeProducto[I].PrecioUni;
                            obeProducto.Stock = lbeProducto[I].Stock;
                            lbeFiltro01.Add(obeProducto);
                        }
                    }
                    dgvProductos.DataSource = lbeFiltro01;
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

        private void filtrarUsuarios(object sender, EventArgs e)
        {
            filtro(4);
        }

        private void filtrarProveedores(object sender, EventArgs e)
        {
            filtro(3);
        }

        private void filtrarProductos(object sender, EventArgs e)
        {
            filtro(0);
        }

        private void filtrarCategorias(object sender, EventArgs e)
        {
            filtro(1);
        }

        private void filtrarEmpleados(object sender, EventArgs e)
        {
            filtro(2);
        }

        private void informacionProducto(object sender, EventArgs e)
        {
            FrmCRUProducto winCRUProducto = new FrmCRUProducto();
            winCRUProducto.ShowDialog();
        }

        private void lblregresarLogin_MouseClick(object sender, MouseEventArgs e)
        {
            FrmLogin abrir = new FrmLogin();
            abrir.Visible = true;
            this.Hide();
        }
    }
}
