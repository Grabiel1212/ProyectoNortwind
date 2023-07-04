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
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic;

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


            dgvProductosFiltro.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvProductosFiltro.BorderStyle = BorderStyle.None;
            dgvProductosFiltro.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Century Gothic", 10);
            dgvProductosFiltro.RowsDefaultCellStyle.Font = fuente;
            dgvProductosFiltro.RowsDefaultCellStyle.ForeColor = Color.White;
            dgvProductosFiltro.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvProductosFiltro.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvProductosFiltro.GridColor = Color.SteelBlue;
            dgvProductosFiltro.EnableHeadersVisualStyles = false;
            dgvProductosFiltro.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            dgvProductosFiltro.ColumnHeadersDefaultCellStyle.Font = fuente;
            dgvProductosFiltro.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductosFiltro.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvProductosFiltro.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgvProductosFiltro.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductosFiltro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProductosFiltro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProductosFiltro.ColumnHeadersHeight = 30;
            dgvProductosFiltro.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Microsoft Sans Serif", 9);
            dgvProductosFiltro.RowHeadersDefaultCellStyle.Font = fuente;
            dgvProductosFiltro.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProductosFiltro.RowHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dgvProductosFiltro.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgvProductosFiltro.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProductosFiltro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductosFiltro.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductosFiltro.ColumnHeadersVisible = true;
            dgvProductosFiltro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductosFiltro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductosFiltro.ColumnHeadersVisible = true;

            dtgProductoPorproveedor.BackgroundColor = Color.FromArgb(45, 66, 91);
            dtgProductoPorproveedor.BorderStyle = BorderStyle.None;
            dtgProductoPorproveedor.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Century Gothic", 10);
            dtgProductoPorproveedor.RowsDefaultCellStyle.Font = fuente;
            dtgProductoPorproveedor.RowsDefaultCellStyle.ForeColor = Color.White;
            dtgProductoPorproveedor.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dtgProductoPorproveedor.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dtgProductoPorproveedor.GridColor = Color.SteelBlue;
            dtgProductoPorproveedor.EnableHeadersVisualStyles = false;
            dtgProductoPorproveedor.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            dtgProductoPorproveedor.ColumnHeadersDefaultCellStyle.Font = fuente;
            dtgProductoPorproveedor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgProductoPorproveedor.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dtgProductoPorproveedor.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dtgProductoPorproveedor.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgProductoPorproveedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgProductoPorproveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgProductoPorproveedor.ColumnHeadersHeight = 30;
            dtgProductoPorproveedor.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Microsoft Sans Serif", 9);
            dtgProductoPorproveedor.RowHeadersDefaultCellStyle.Font = fuente;
            dtgProductoPorproveedor.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgProductoPorproveedor.RowHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dtgProductoPorproveedor.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dtgProductoPorproveedor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgProductoPorproveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProductoPorproveedor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgProductoPorproveedor.ColumnHeadersVisible = true;
            dtgProductoPorproveedor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgProductoPorproveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgProductoPorproveedor.ColumnHeadersVisible = true;


            dtgProductoPorproveedor.BackgroundColor = Color.FromArgb(45, 66, 91);
            dtgProductoPorproveedor.BorderStyle = BorderStyle.None;
            dtgProductoPorproveedor.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Century Gothic", 10);
            dtgProductoPorproveedor.RowsDefaultCellStyle.Font = fuente;
            dtgProductoPorproveedor.RowsDefaultCellStyle.ForeColor = Color.White;
            dtgProductoPorproveedor.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dtgProductoPorproveedor.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dtgProductoPorproveedor.GridColor = Color.SteelBlue;
            dtgProductoPorproveedor.EnableHeadersVisualStyles = false;
            dtgProductoPorproveedor.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            dtgProductoPorproveedor.ColumnHeadersDefaultCellStyle.Font = fuente;
            dtgProductoPorproveedor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgProductoPorproveedor.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dtgProductoPorproveedor.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dtgProductoPorproveedor.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgProductoPorproveedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgProductoPorproveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgProductoPorproveedor.ColumnHeadersHeight = 30;
            dtgProductoPorproveedor.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Microsoft Sans Serif", 9);
            dtgProductoPorproveedor.RowHeadersDefaultCellStyle.Font = fuente;
            dtgProductoPorproveedor.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgProductoPorproveedor.RowHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dtgProductoPorproveedor.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dtgProductoPorproveedor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgProductoPorproveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgProductoPorproveedor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgProductoPorproveedor.ColumnHeadersVisible = true;
            dtgProductoPorproveedor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgProductoPorproveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgProductoPorproveedor.ColumnHeadersVisible = true;

            dtgPorveedorPorPaiz.BackgroundColor = Color.FromArgb(45, 66, 91);
            dtgPorveedorPorPaiz.BorderStyle = BorderStyle.None;
            dtgPorveedorPorPaiz.RowsDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Century Gothic", 10);
            dtgPorveedorPorPaiz.RowsDefaultCellStyle.Font = fuente;
            dtgPorveedorPorPaiz.RowsDefaultCellStyle.ForeColor = Color.White;
            dtgPorveedorPorPaiz.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dtgPorveedorPorPaiz.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dtgPorveedorPorPaiz.GridColor = Color.SteelBlue;
            dtgPorveedorPorPaiz.EnableHeadersVisualStyles = false;
            dtgPorveedorPorPaiz.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
            dtgPorveedorPorPaiz.ColumnHeadersDefaultCellStyle.Font = fuente;
            dtgPorveedorPorPaiz.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgPorveedorPorPaiz.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dtgPorveedorPorPaiz.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dtgPorveedorPorPaiz.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgPorveedorPorPaiz.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgPorveedorPorPaiz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgPorveedorPorPaiz.ColumnHeadersHeight = 30;
            dtgPorveedorPorPaiz.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
            fuente = new Font("Microsoft Sans Serif", 9);
            dtgPorveedorPorPaiz.RowHeadersDefaultCellStyle.Font = fuente;
            dtgPorveedorPorPaiz.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgPorveedorPorPaiz.RowHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            dtgPorveedorPorPaiz.RowHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dtgPorveedorPorPaiz.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgPorveedorPorPaiz.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPorveedorPorPaiz.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgPorveedorPorPaiz.ColumnHeadersVisible = true;
            dtgPorveedorPorPaiz.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgPorveedorPorPaiz.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgPorveedorPorPaiz.ColumnHeadersVisible = true;
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
                    lbeProveedor = obrProveedor.ListarProveedor();
                    dgvProveedores.DataSource = lbeProveedor;
                    break;
                case 4:
                    BRUsuario obrUsuario = new BRUsuario();
                    lbeUsuario = obrUsuario.Listar();
                    dgvUsuarios.DataSource = lbeUsuario;
                    break;
                case 5:
                    BRCategoria obrCategoria = new BRCategoria();
                    lbeCategoria = obrCategoria.Listar();
                    cbxcategoria.DataSource = lbeCategoria;
                    dgvProductosFiltro.DataSource = lbeProducto;
                    cbxcategoria.DisplayMember = "Nombre";
                    cbxcategoria.ValueMember = "Codigo";
                    break;
                case 6:
                    BRProveedor obProveedor = new BRProveedor();
                    lbeProveedor = obProveedor.ListarProveedor();
                    cbxproveedorxproducto.DataSource = lbeProveedor;
                    dtgProductoPorproveedor.DataSource = lbeProveedor;
                    cbxproveedorxproducto.DisplayMember = "Nombre";
                    cbxproveedorxproducto.ValueMember = "Codigo";
                    break;
                case 7:
                    BRProveedor obsProveedor = new BRProveedor();
                    lbeProveedor = obsProveedor.ListarProveedor();
                    cbopaizFiltro.DataSource = lbeProveedor;
                    dtgPorveedorPorPaiz.DataSource = lbeProveedor;
                    cbopaizFiltro.DisplayMember = "Paiz";
                    cbopaizFiltro.ValueMember = "Codigo";
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

                case 5:
                    btnProductos.BackColor = Color.FromArgb(33, 53, 73);
                    btnCategorias.BackColor = Color.FromArgb(33, 53, 73);
                    btnEmpleados.BackColor = Color.FromArgb(33, 53, 73);
                    btnProveedores.BackColor = Color.FromArgb(33, 53, 73);
                    btnUsuarios.BackColor = Color.FromArgb(33, 53, 73);
                    btnproductoPorCategoria.BackColor = Color.FromArgb(85, 159, 127);
                    break;
                case 6:
                    btnProductos.BackColor = Color.FromArgb(33, 53, 73);
                    btnCategorias.BackColor = Color.FromArgb(33, 53, 73);
                    btnEmpleados.BackColor = Color.FromArgb(33, 53, 73);
                    btnProveedores.BackColor = Color.FromArgb(33, 53, 73);
                    btnUsuarios.BackColor = Color.FromArgb(33, 53, 73);
                    btnproductoPorCategoria.BackColor = Color.FromArgb(85, 159, 127);
                    btnproductoPorProveedores.BackColor = Color.FromArgb(33, 53, 73);
                    break;
                case 7:
                    //btnProductos.BackColor = Color.FromArgb(33, 53, 73);
                    //btnCategorias.BackColor = Color.FromArgb(33, 53, 73);
                    //btnEmpleados.BackColor = Color.FromArgb(33, 53, 73);
                    //btnProveedores.BackColor = Color.FromArgb(33, 53, 73);
                    //btnUsuarios.BackColor = Color.FromArgb(33, 53, 73);
                    //btnproductoPorCategoria.BackColor = Color.FromArgb(85, 159, 127);
                    //btnproductoPorProveedores.BackColor = Color.FromArgb(133, 153, 173);
                    //btnProveedoresPorPaiz.BackColor = Color.FromArgb(233, 253, 273);
                    break;
            }
        }

       
        private void accedeProductos(object sender, EventArgs e)// btn acceder porductos
        {
            //btnpoductDesacticadoss.Text = "";
            //btnpoductDesacticadoss.Text = "MOSTAR PRODUCTOS DESACTIVADOS";

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
                            obeEmpleado.Direccion1 = lbeEmpleado[I].Direccion1;
                            obeEmpleado.Pais = lbeEmpleado[I].Pais;
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

       /* private bool valor = false; */// para enviar valor si esta activado o desactivado
        private void btnpoductDesacticadoss_Click(object sender, EventArgs e)
        {

            //valor = !valor;
            //int numeroAc = 0;

            //if (valor)
            //{
            //    btnpoductDesacticadoss.Text = "";
            //    numeroAc = 1;
            //    BRProducto objproducto = new BRProducto();
            //    lbeProducto = objproducto.ListarProducActivados(numeroAc);
            //    dgvProductos.DataSource = lbeProducto;

            //    btnLogin.Enabled = false;
            //    btnregistrarproducto.Enabled = false;
            //    btnmodificarProducto.Enabled = false;

            //    btnpoductDesacticadoss.Text = "MOSTRAR PRODUCTOS ACTIVADOS";
            //    btneliminarProducto.Text = "HABILITAR PRODUCTO";

            //}
            //else
            //{


            //    numeroAc = 0;
            //    BRProducto objproducto = new BRProducto();
            //    lbeProducto = objproducto.ListarProducActivados(numeroAc);
            //    dgvProductos.DataSource = lbeProducto;
            //    btnLogin.Enabled = true;
            //    btnregistrarproducto.Enabled = true;
            //    btnmodificarProducto.Enabled = true;
            //    btneliminarProducto.Text = "ELIMINAR PRODUCTO";

            //    btnpoductDesacticadoss.Text = "";
            //    btnpoductDesacticadoss.Text = "MOSTAR PRODUCTOS DESACTIVADOS";


            //}
            //    btnpoductDesacticadoss.Text = "";
            //btnpoductDesacticadoss.Text = "MOSTAR PRODUCTOS DESACTIVADOS";


            if (btnpoductDesacticadoss.Text.Equals("MOSTRAR PRODUCTOS DESACTIVADOS"))
            {
                BRProducto obrProducto = new BRProducto();
                lbeProducto = obrProducto.ListarProductosInhabi();
                dgvProductos.DataSource = lbeProducto;
                btnpoductDesacticadoss.Text = "MOSTRAR PRODUCTOS ACTIVOS";
                btnLogin.Enabled = false;
                btnregistrarproducto.Enabled = false;
                btnmodificarProducto.Enabled = false;
                btneliminarProducto.Text = "HABILITAR PRODUCTO";
            }
            else
            {
                btnpoductDesacticadoss.Text = "MOSTRAR PRODUCTOS DESACTIVADOS";
                BRProducto obrProducto = new BRProducto();
                lbeProducto = obrProducto.Listar();
                dgvProductos.DataSource = lbeProducto;
                btnLogin.Enabled = true;
                btnregistrarproducto.Enabled = true;
                btnmodificarProducto.Enabled = true;
                btneliminarProducto.Text = "ELIMINAR PRODUCTO";

            }




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
                this.btnpoductDesacticadoss_Click(sender, e);


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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // para mistar informacion de l empleados
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvEmpleados.SelectedRows[0];
                BEEmpleado EmpleadoSelecionado = (BEEmpleado)filaSeleccionada.DataBoundItem;

                FrmCRUEmpleado abrir = new FrmCRUEmpleado();
                int yoyo = 0;
                abrir.modoWindow = yoyo;
                abrir.codEmpleado = EmpleadoSelecionado.Codigo;
                abrir.nomEmpleado = EmpleadoSelecionado.Nombre;
                abrir.apeEmpleado = EmpleadoSelecionado.Apellido;
                abrir.FechaNacimiento =EmpleadoSelecionado.FechaNac;
                abrir.Direccion = EmpleadoSelecionado.Direccion1;
                abrir.Pais = EmpleadoSelecionado.Pais;


                abrir.ShowDialog();

            }
        }

        private void btnmostrarinformacionCategoria_Click(object sender, EventArgs e)
        {



            if (dgvCategorias.SelectedRows.Count > 0)
            {



                DataGridViewRow filaSeleccionada = dgvCategorias.SelectedRows[0];// esto nos dira la posion en fila se a seleccionado
                BECategoria categoriaSeleccionado = (BECategoria)filaSeleccionada.DataBoundItem;// obtenemos la informacion de nuestra fila

                FrmCRUCategoria abrir = new FrmCRUCategoria();
                abrir.modoWindow = 0;
                abrir.codCategoria = categoriaSeleccionado.Codigo;
                abrir.nomCategoria = categoriaSeleccionado.Nombre;
                abrir.DescripcionCate = categoriaSeleccionado.Descripcion;


                abrir.ShowDialog();

            }
            else
            {
                MessageBox.Show("Seleccionar una fila por favor");
            }


        }

        private void btnregistrarCategoria_Click(object sender, EventArgs e)
        {
            int yoyo = 1;
            FrmCRUCategoria abrir = new FrmCRUCategoria();// enviamos los dtaos 
            abrir.modoWindow = yoyo;
            abrir.ShowDialog();
        }

        private void btneditarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count > 0)
            {

                DataGridViewRow filaSeleccionada = dgvCategorias.SelectedRows[0];// esto nos dira la posion en fila se a seleccionado
                BECategoria categoriaSeleccionado = (BECategoria)filaSeleccionada.DataBoundItem;// obtenemos la informacion de nuestra fila

                FrmCRUCategoria abrir = new FrmCRUCategoria();
                abrir.modoWindow = 2;
                abrir.codCategoria = categoriaSeleccionado.Codigo;
                abrir.nomCategoria = categoriaSeleccionado.Nombre;
                abrir.DescripcionCate = categoriaSeleccionado.Descripcion;

                abrir.ShowDialog();

            }
            else
            {
                MessageBox.Show("Seleccionar una fila por favor");
            }
        }


        private BRCategoria obrCategoria = new BRCategoria();
        private void btnelimanarCategoria_Click(object sender, EventArgs e)
        {

            if (btnelimanarCategoria.Text.Equals("ELIMINAR CATEGORIA"))
            {
                if (MessageBox.Show("¿Seguro que desea eliminar la categoria " +
               dgvCategorias.SelectedRows[0].Cells[1].Value.ToString() + "?", "Aviso",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //AKI LE PREGUNTAMOS SI DESE ALIMINAR UNM PRODUCTO Y SI DOSE L SI ARA LO SIGUINTE
                {
                    BECategoria obeCategoria = new BECategoria();
                    {


                        var tomarvalorTabla = obeCategoria;
                        // en esta fila le desimoos la psocion de nuestra columna y de nustra cela en este caso sera 0 donde esta el id , y tomara esevalor , y convertilo en entero
                        tomarvalorTabla.Codigo = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells[0].Value.ToString());
                    }
                    bool exito = obrCategoria.EliminarCategoria(obeCategoria);
                    if (exito)
                    {
                        MessageBox.Show("Se Elimino la Categoria", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Eliminar la Categoria", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
                    }
                    accedeCategorias(sender, e);
                }
            }
            else
            {
                if (MessageBox.Show("¿Seguro que desea activar la Categoria " +  // ESTO SIRVE PARA ctivar
               dgvCategorias.SelectedRows[0].Cells[1].Value.ToString() + "?", "Aviso",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BECategoria obeCategoria = new BECategoria();
                    {
                        var withBlock = obeCategoria;
                        withBlock.Codigo = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells[0].Value.ToString()); ;
                    }
                    bool exito = obrCategoria.ActivarCategoria(obeCategoria);
                    if (exito)
                    {
                        MessageBox.Show("Se Activo la Categoria", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);


                    }
                    else
                    {

                        MessageBox.Show("No se pudo Activar la Categoria", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
                        //btnpoductDesacticadoss(sender, e);
                    }
                    this.btnmostrarCategoriaacruvadodesactivado_Click(sender, e);


                }
            }













        }

        private void btnmostrarCategoriaacruvadodesactivado_Click(object sender, EventArgs e)
        {



            if (btnmostrarCategoriaacruvadodesactivado.Text.Equals("MOSTRAR CATEGORIA DESACTIVADOS"))
            {
                BRCategoria obrCategoria = new BRCategoria();
                lbeCategoria = obrCategoria.ListarcateInabilitados();
                dgvCategorias.DataSource = lbeCategoria;
                btnmostrarCategoriaacruvadodesactivado.Text = "MOSTRAR CATEGORIAS ACTIVOS";
                btnmostrarinformacionCategoria.Enabled = false;
                btnregistrarCategoria.Enabled = false;
                btneditarCategoria.Enabled = false;
                btnelimanarCategoria.Text = "HABILITAR CATEGORIA";
            }
            else
            {
                btnmostrarCategoriaacruvadodesactivado.Text = "MOSTRAR CATEGORIA DESACTIVADOS";
                BRCategoria obrCategoria = new BRCategoria();
                lbeCategoria = obrCategoria.Listar();
                dgvCategorias.DataSource = lbeCategoria;
                btnmostrarinformacionCategoria.Enabled = true;
                btnregistrarCategoria.Enabled = true;
                btneditarCategoria.Enabled = true;
                btnelimanarCategoria.Text = "ELIMINAR CATEGORIA";



            }

        }

        private void btnmostarinformacionUsuario_Click(object sender, EventArgs e)
        {


            if (dgvUsuarios.SelectedRows.Count > 0)
            {



                DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];// esto nos dira la posion en fila se a seleccionado
                BEUsuario UsuarioSeleccionado = (BEUsuario)filaSeleccionada.DataBoundItem;// obtenemos la informacion de nuestra fila

                FrmCRUUsuario abrir = new FrmCRUUsuario();
                abrir.modoWindow = 0;
                abrir.codUusuario = UsuarioSeleccionado.Codigo;
                abrir.uUsuario= UsuarioSeleccionado.NombreUsuario;
                abrir.ucontraseña= UsuarioSeleccionado.PasswordUsuario;
                abrir.unombreUsuario = UsuarioSeleccionado.Nombre;
                abrir.uapellidoUsuario = UsuarioSeleccionado.Apellido;
                abrir.uOcupacion = UsuarioSeleccionado.Ocupacion;


                abrir.ShowDialog();

            }
            else
            {
                MessageBox.Show("Seleccionar una fila por favor");
            }



        }

        private void btnregistrarUsuario_Click(object sender, EventArgs e)
        {

            int yoyo = 1;
            FrmCRUUsuario abrir = new FrmCRUUsuario();// enviamos los dtaos 
            abrir.modoWindow = yoyo;
            abrir.ShowDialog();



        }

        private void btneditarUsuario_Click(object sender, EventArgs e)
        {

            if (dgvUsuarios.SelectedRows.Count > 0)
            {


                DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];// esto nos dira la posion en fila se a seleccionado
                BEUsuario UsuarioSeleccionado = (BEUsuario)filaSeleccionada.DataBoundItem;// obtenemos la informacion de nuestra fila

                FrmCRUUsuario abrir = new FrmCRUUsuario();
                abrir.modoWindow = 2;
                abrir.codUusuario = UsuarioSeleccionado.Codigo;
                abrir.uUsuario = UsuarioSeleccionado.NombreUsuario;
                abrir.ucontraseña = UsuarioSeleccionado.PasswordUsuario;
                abrir.unombreUsuario = UsuarioSeleccionado.Nombre;
                abrir.uapellidoUsuario = UsuarioSeleccionado.Apellido;
                abrir.uOcupacion = UsuarioSeleccionado.Ocupacion;


                abrir.ShowDialog();

            }
            else
            {
                MessageBox.Show("Seleccionar una fila por favor");
            }





        }

        private BRUsuario obrUsuario = new BRUsuario();
        private void btneliminarUsuario_Click(object sender, EventArgs e)
        {


            if (btneliminarUsuario.Text.Equals("ELIMINAR USUARIO"))
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el Usuario " +
               dgvUsuarios.SelectedRows[0].Cells[1].Value.ToString() + "?", "Aviso",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //AKI LE PREGUNTAMOS SI DESE ALIMINAR UNM PRODUCTO Y SI DOSE L SI ARA LO SIGUINTE
                {
                    BEUsuario obeUsuario= new BEUsuario();
                    {


                        var tomarvalorTabla = obeUsuario;
                        // en esta fila le desimoos la psocion de nuestra columna y de nustra cela en este caso sera 0 donde esta el id , y tomara esevalor , y convertilo en entero
                        tomarvalorTabla.Codigo = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
                    }
                    bool exito = obrUsuario.EliminarUsuario(obeUsuario);
                    if (exito)
                    {
                        MessageBox.Show("Se Elimino el Usuario", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Eliminar el Usuario", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
                    }
                    accedeUsuarios(sender, e);
                }
            }
            else
            {
                if (MessageBox.Show("¿Seguro que desea activar el Usuario " +  // ESTO SIRVE PARA ctivar
               dgvUsuarios.SelectedRows[0].Cells[1].Value.ToString() + "?", "Aviso",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BEUsuario obeUsuario = new BEUsuario();
                    {
                        var withBlock = obeUsuario;
                        withBlock.Codigo = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString()); ;
                    }
                    bool exito = obrUsuario.ActivarUsuario(obeUsuario);
                    if (exito)
                    {
                        MessageBox.Show("Se Activo el Usuario", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);


                    }
                    else
                    {

                        MessageBox.Show("No se pudo Activar el Usuario", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
                        //btnpoductDesacticadoss(sender, e);
                    }
                   btnactivarDesativarUsuario_Click(sender, e);


                }
            }









        }

        private void btnactivarDesativarUsuario_Click(object sender, EventArgs e)
        {

            if (btnactivarDesativarUsuario.Text.Equals("MOSTRAR USUARIOS DESACTIVADOS"))
            {
                BRUsuario obrUsuario = new BRUsuario();
                lbeUsuario = obrUsuario.ListarUsuariosInhabi();
                dgvUsuarios.DataSource = lbeUsuario;

                btnactivarDesativarUsuario.Text = "MOSTRAR USUARIOS ACTIVOS";
                btnmostarinformacionUsuario.Enabled = false;
                btnregistrarUsuario.Enabled = false;
                btneditarUsuario.Enabled = false;
                btneliminarUsuario.Text = "HABILITAR USUARIO";
            }
            else
            {
                btnactivarDesativarUsuario.Text = "MOSTRAR USUARIOS DESACTIVADOS";
                BRUsuario obrUsuario= new BRUsuario();
                lbeUsuario = obrUsuario.Listar();
                dgvUsuarios.DataSource = lbeUsuario;

                btnmostarinformacionUsuario.Enabled = true;
                btnregistrarUsuario.Enabled = true;
                btneditarUsuario.Enabled = true;
                btneliminarUsuario.Text = "ELIMINAR USUARIO";



            }
        }

        private void btnmostarInformacionProveedor_Click(object sender, EventArgs e)
        {



            if (dgvProveedores.SelectedRows.Count > 0)
            {



                DataGridViewRow filaSeleccionada = dgvProveedores.SelectedRows[0];// esto nos dira la posion en fila se a seleccionado
                BEProveedor ProveedorSeleccionado = (BEProveedor)filaSeleccionada.DataBoundItem;// obtenemos la informacion de nuestra fila

                FrmCRUProveedor abrir = new FrmCRUProveedor();
                abrir.modoWindow = 0;
                abrir.codigoProvee = ProveedorSeleccionado.Codigo;
                abrir.pcompania = ProveedorSeleccionado.Nombre;
                abrir.pcontacto = ProveedorSeleccionado.Contacto;
                abrir.pdireccion = ProveedorSeleccionado.Direccion;
                abrir.ppaiz = ProveedorSeleccionado.Paiz;



                abrir.ShowDialog();

            }
            else
            {
                MessageBox.Show("Seleccionar una fila por favor");
            }


        }

        private void btnEditarProovedor_Click(object sender, EventArgs e)
        {


            if (dgvProveedores.SelectedRows.Count > 0)
            {


                DataGridViewRow filaSeleccionada = dgvProveedores.SelectedRows[0];// esto nos dira la posion en fila se a seleccionado
                BEProveedor ProveedorSeleccionado = (BEProveedor)filaSeleccionada.DataBoundItem;// obtenemos la informacion de nuestra fila

                FrmCRUProveedor abrir = new FrmCRUProveedor();
                abrir.modoWindow = 2;
                abrir.codigoProvee = ProveedorSeleccionado.Codigo;
                abrir.pcompania = ProveedorSeleccionado.Nombre;
                abrir.pcontacto = ProveedorSeleccionado.Contacto;
                abrir.pdireccion = ProveedorSeleccionado.Direccion;
                abrir.ppaiz = ProveedorSeleccionado.Paiz;



                abrir.ShowDialog();


        

            }
            else
            {
                MessageBox.Show("Seleccionar una fila por favor");
            }

        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {

            FrmCRUEmpleado abrir = new FrmCRUEmpleado();// enviamos los dtaos 
            int yoyo = 1;
            abrir.modoWindow = yoyo;
            abrir.ShowDialog();




        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvEmpleados.SelectedRows[0];
                BEEmpleado EmpleadoSelecionado = (BEEmpleado)filaSeleccionada.DataBoundItem;

                FrmCRUEmpleado abrir = new FrmCRUEmpleado();
                int yoyo = 2;
                abrir.modoWindow = yoyo;
                abrir.codEmpleado = EmpleadoSelecionado.Codigo;
                abrir.nomEmpleado = EmpleadoSelecionado.Nombre;
                abrir.apeEmpleado = EmpleadoSelecionado.Apellido;
                abrir.FechaNacimiento = EmpleadoSelecionado.FechaNac;
                abrir.Direccion = EmpleadoSelecionado.Direccion1;
                abrir.Pais = EmpleadoSelecionado.Pais;


                abrir.ShowDialog();

            }
            else
            {
                MessageBox.Show(" POR FAVOR SELECIONAR UYN FILA ?");
            }
        }

        private BREmpleado obrEmpleado = new BREmpleado();
        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {


            
            if (btnEliminarEmpleado.Text.Equals("ELIMINAR EMPLEADO"))
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el EMPLEADO " +
               dgvEmpleados.SelectedRows[0].Cells[1].Value.ToString() + "?", "Aviso",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //AKI LE PREGUNTAMOS SI DESE ALIMINAR UNM PRODUCTO Y SI DOSE L SI ARA LO SIGUINTE
                {
                    BEEmpleado obeEmpleado= new BEEmpleado();
                    {


                        var tomarvalorTabla = obeEmpleado;
                        // en esta fila le desimoos la psocion de nuestra columna y de nustra cela en este caso sera 0 donde esta el id , y tomara esevalor , y convertilo en entero
                        tomarvalorTabla.Codigo = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells[0].Value.ToString());
                    }
                    bool exito = obrEmpleado.EliminarEmpl(obeEmpleado);
                    if (exito)
                    {
                        MessageBox.Show("Se Elimino el EMPLEADO", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Eliminar el EMPLEADO", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
                    }
                    accedeEmpleados(sender, e);
                }
            }
            else
            {
                if (MessageBox.Show("¿Seguro que desea activar el EMPLEADO" +  // ESTO SIRVE PARA ctivar
               dgvEmpleados.SelectedRows[0].Cells[1].Value.ToString() + "?", "Aviso",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BEEmpleado obeEmpleado = new BEEmpleado();
                    {
                        var withBlock = obeEmpleado;
                        withBlock.Codigo = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString()); ;
                    }
                    bool exito = obrEmpleado.ActivarEmpl(obeEmpleado);
                    if (exito)
                    {
                        MessageBox.Show("Se Activo el Empleado", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);


                    }
                    else
                    {

                        MessageBox.Show("No se pudo Activar el empleado", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
                        //btnpoductDesacticadoss(sender, e);
                    }
                    //btmactivardesativarempleados_Click(sender, e);


                }
            }



        }

        private void btnDescativadoActivadoEmpleado_Click(object sender, EventArgs e)
        {





        }

        private void btmactivardesativarempleados_Click(object sender, EventArgs e)
        {
          

            if (btmactivardesativarempleados.Text.Equals("MOSTRAR EMPLEADOS DESACTIVADOS"))
            {
                BREmpleado obrEmplead = new BREmpleado();
                lbeEmpleado = obrEmpleado.ListarInactivos();
                dgvEmpleados.DataSource = lbeEmpleado;

                btmactivardesativarempleados.Text = "MOSTRAR EMPLEADOS ACTIVOS";
                btnMostrarEmpleado.Enabled = false;
                btnRegistrarEmpleado.Enabled = false;
                btnEditarEmpleado.Enabled = false;
         
            }
            else
            {
                btmactivardesativarempleados.Text = "MOSTRAR EMPLEADOS DESACTIVADOS";
                BREmpleado obrEmplea = new BREmpleado();
                lbeEmpleado = obrEmpleado.Listar();
                dgvEmpleados.DataSource = lbeEmpleado;

                btnMostrarEmpleado.Enabled = true;
                btnRegistrarEmpleado.Enabled = true;
                btnEditarEmpleado.Enabled = true;
                btnEliminarEmpleado.Text = "ELIMINAR EMPLEADO";



            }

        }

        private void btnRegistarProveedor_Click(object sender, EventArgs e)
        {
            FrmCRUProveedor abrir = new FrmCRUProveedor();// enviamos los dtaos 
            int yoyo = 1;
            abrir.modoWindow = yoyo;
            abrir.ShowDialog();
        }

        private BRProveedor obrProveedor = new BRProveedor();
        private void btneliminarProvedor_Click(object sender, EventArgs e)
        {

            if (btneliminarProvedor.Text.Equals("ELIMINAR PROVEEDOR"))
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el PROVEEDOR " +
               dgvProveedores.SelectedRows[0].Cells[1].Value.ToString() + "?", "Aviso",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //AKI LE PREGUNTAMOS SI DESE ALIMINAR UNM PRODUCTO Y SI DOSE L SI ARA LO SIGUINTE
                {
                    BEProveedor  obeProveedor = new BEProveedor();
                    {


                        var tomarvalorTabla = obeProveedor;
                        // en esta fila le desimoos la psocion de nuestra columna y de nustra cela en este caso sera 0 donde esta el id , y tomara esevalor , y convertilo en entero
                        tomarvalorTabla.Codigo = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells[0].Value.ToString());
                    }
                    bool exito = obrProveedor.EliminarProveedor(obeProveedor);
                    if (exito)
                    {
                        MessageBox.Show("Se Elimino el Proveedor", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Eliminar el Porveedor", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
                    }
                    accedeProveedores(sender, e);
                }
            }
            else
            {

                if (MessageBox.Show("¿Seguro que desea activar el Porveedor " +  // ESTO SIRVE PARA ctivar
              dgvProveedores.SelectedRows[0].Cells[1].Value.ToString() + "?", "Aviso",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BEProveedor obeProveedor = new BEProveedor();
                    {
                        var withBlock = obeProveedor;
                        withBlock.Codigo = Convert.ToInt32(dgvProveedores.SelectedRows[0].Cells[0].Value.ToString()); ;
                    }
                    bool exito = obrProveedor.ActivarPriveedor(obeProveedor);
                    if (exito)
                    {
                        MessageBox.Show("Se Activo el proveedor", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);


                    }
                    else
                    {

                        MessageBox.Show("No se pudo Activar el Porveedor", "Error", MessageBoxButtons.OK,
                       MessageBoxIcon.Exclamation);
                        //btnpoductDesacticadoss(sender, e);
                    }
                  btnactivarDesactivarProvedor_Click(sender, e);


                }


            }
        }

        private void btnactivarDesactivarProvedor_Click(object sender, EventArgs e)
        {

            if (btnactivarDesactivarProvedor.Text.Equals("MOSTRAR PROVEEDORES DESACTIVADOS"))
            {
                BRProveedor obrProveedor = new BRProveedor();
                lbeProveedor = obrProveedor.ListarProcedordesavilitado();
                dgvProveedores.DataSource = lbeProveedor;

                btnactivarDesactivarProvedor.Text = "MOSTRAR PROVEEDOR ACTIVOS";
                btnmostarInformacionProveedor.Enabled = false;
                btnRegistarProveedor.Enabled = false;
                btnEditarProovedor.Enabled = false;
                btneliminarProvedor.Text = "HABILITAR PROVEEDOR";
            }
            else
            {
                btnactivarDesactivarProvedor.Text = "MOSTRAR PROVEEDORES DESACTIVADOS";
                BRProveedor obrProveedor = new BRProveedor();
                lbeProveedor = obrProveedor.ListarProveedor();
                dgvProveedores.DataSource = lbeProveedor;

                btnmostarInformacionProveedor.Enabled = true;
                btnRegistarProveedor.Enabled = true;
                btnEditarProovedor.Enabled = true;
                btneliminarProvedor.Text = "ELIMINAR PROVEEDOR";



            }



        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnproductoPorCategoria_Click(object sender, EventArgs e)
        {
            tcVentanas.SelectedIndex = 5;
            activaSeleccion(5);
            lblTitulo.Text = btnproductoPorCategoria.Text;
            cargaDatos(5);
        }

        private void bTNFILTRO_Click(object sender, EventArgs e)
        {
            lbeFiltro01 = new List<BEProducto>();
            BEProducto obeProducto;
            for (int I = 0; I <= lbeProducto.Count - 1; I++)
            {
                if (lbeProducto[I].IdCategoria.Equals(cbxcategoria.SelectedValue))
                {
                    obeProducto = new BEProducto();
                    obeProducto.Codigo = lbeProducto[I].Codigo;
                    obeProducto.Nombre = lbeProducto[I].Nombre;
                    obeProducto.IdProveedor = lbeProducto[I].IdProveedor;
                    obeProducto.IdCategoria = lbeProducto[I].IdCategoria;
                    obeProducto.PrecioUni = lbeProducto[I].PrecioUni;
                    obeProducto.Stock = lbeProducto[I].Stock;
                    lbeFiltro01.Add(obeProducto);
                }
            }
            dgvProductosFiltro.DataSource = lbeFiltro01;
        }

        private void m(object sender, EventArgs e)
        {

        }
        private int cr;
        private int totPags;
        private int numPag;
        private void imprimirPagina(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            Rectangle rec = new Rectangle(x, y - 20, e.MarginBounds.Width, e.MarginBounds.Height);
            LinearGradientBrush deg = new LinearGradientBrush(rec, Color.Aqua, Color.Blue,
           LinearGradientMode.BackwardDiagonal);
            Font fuente = new Font("Arial", 10);
            Brush brocha = Brushes.Blue;
            Brush brochaTitulo = Brushes.Red;
            int tlp = (int)(e.MarginBounds.Height / (fuente.GetHeight() + 20));
            totPags = (lbeFiltro01.Count / (tlp - 1));
            if (lbeFiltro01.Count % (tlp - 1) > 0)
                totPags += 1;
            numPag += 1;
            {
                var withBlock = e.Graphics;
                x = e.MarginBounds.Left;
                withBlock.DrawString("Codigo", fuente, brochaTitulo, x, y);
                x = x + 100;
                withBlock.DrawString("Nombre", fuente, brochaTitulo, x, y);
                x = x + 300;
                withBlock.DrawString("Precio Unit", fuente, brochaTitulo, x, y);
                x = x + 100;
                withBlock.DrawString("Stock", fuente, brochaTitulo, x, y);
                y = (int)(y + fuente.GetHeight() + 20);
                int I;
                for (I = 0; I <= tlp - 2; I++)
                {
                    if (cr == lbeFiltro01.Count)
                        break;
                    x = e.MarginBounds.Left;
                    withBlock.DrawString(lbeFiltro01[cr].Codigo.ToString(), fuente, brocha, x, y);
                    x = x + 100;
                    withBlock.DrawString(lbeFiltro01[cr].Nombre.ToString(), fuente, brocha, x, y);
                    x = x + 300;
                    withBlock.DrawString(lbeFiltro01[cr].PrecioUni.ToString(), fuente, brocha, x, y);
                    x = x + 100;
                    withBlock.DrawString(lbeFiltro01[cr].Stock.ToString(), fuente, brocha, x, y);
                    y = (int)(y + fuente.GetHeight() + 20);
                    cr += 1;
                }
                withBlock.DrawString(string.Format("Pag {0} de {1}", numPag, totPags), fuente,
               brochaTitulo, 400, e.MarginBounds.Top + e.MarginBounds.Height);
                e.HasMorePages = (cr < lbeFiltro01.Count - 1);
            }
        }

        private void btnaserreporte_Click(object sender, EventArgs e)
        {
            cr = 0;
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;

            ppd.ShowDialog();
        }

        private void previewReporte(object sender, MouseEventArgs e)
        {

        }

        private void btnconfigurarPajina_Click(object sender, EventArgs e)
        {
            PageSetupDialog psd = new PageSetupDialog();
            psd.Document = pd;
            psd.ShowDialog();

        }

        private void btnImprimirReporte_Click(object sender, EventArgs e)
        {
            PrintDialog pdg = new PrintDialog();
            pdg.Document = pd;
            pdg.ShowDialog();

        }

        private void btnFiltroProductoXproveedor_Click(object sender, EventArgs e)
        {

            lbeFiltro01 = new List<BEProducto>();
            BEProducto obeProducto;
            for (int I = 0; I <= lbeProducto.Count - 1; I++)
            {
                if (lbeProducto[I].IdProveedor.Equals(cbxproveedorxproducto.SelectedValue))
                {
                    obeProducto = new BEProducto();
                    obeProducto.Codigo = lbeProducto[I].Codigo;
                    obeProducto.Nombre = lbeProducto[I].Nombre;
                    obeProducto.IdProveedor = lbeProducto[I].IdProveedor;
                    obeProducto.IdCategoria = lbeProducto[I].IdCategoria;
                    obeProducto.PrecioUni = lbeProducto[I].PrecioUni;
                    obeProducto.Stock = lbeProducto[I].Stock;
                    lbeFiltro01.Add(obeProducto);
                }
            }
            dtgProductoPorproveedor.DataSource = lbeFiltro01;
        }

        private void btnproductoPorProveedores_Click(object sender, EventArgs e)
        {
            tcVentanas.SelectedIndex = 6;
            activaSeleccion(6);
            lblTitulo.Text = btnproductoPorProveedores.Text;
            cargaDatos(6);
        }

        private void btnProveedoresPorPaiz_Click(object sender, EventArgs e)
        {
            tcVentanas.SelectedIndex = 7;
            activaSeleccion(7);
            lblTitulo.Text = btnProveedoresPorPaiz.Text;
            cargaDatos(7);
        }

        private void btnProveedorPorPaiz_Click(object sender, EventArgs e)
        {
            lbeFiltro04 = new List<BEProveedor>();
            BEProveedor obeProveedor;
            for (int I = 0; I <= lbeProveedor.Count - 1; I++)
            {
                if (lbeProveedor[I].Codigo.Equals(cbopaizFiltro.SelectedValue))
                {
                    obeProveedor = new BEProveedor();
                    obeProveedor.Codigo = lbeProveedor[I].Codigo;
                    obeProveedor.Nombre = lbeProveedor[I].Nombre;
                    obeProveedor.Contacto = lbeProveedor[I].Contacto;
                    obeProveedor.Direccion= lbeProveedor[I].Direccion;
                    obeProveedor.Paiz = lbeProveedor[I].Paiz;
                   
                    lbeFiltro04.Add(obeProveedor);
                }
            }
            dtgPorveedorPorPaiz.DataSource = lbeFiltro04;
        }

        private void btnreporteProductoPoveedor_Click(object sender, EventArgs e)
        {
            cr = 0;
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;

            ppd.ShowDialog();
        }

        private void btnConfugurarPajinaPorductoProveedor_Click(object sender, EventArgs e)
        {
            PageSetupDialog psd = new PageSetupDialog();
            psd.Document = pd;
            psd.ShowDialog();
        }

        private void btnImprimirProductoProveedor_Click(object sender, EventArgs e)
        {
            PrintDialog pdg = new PrintDialog();
            pdg.Document = pd;
            pdg.ShowDialog();

        }

        private void pd02_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            Rectangle rec = new Rectangle(x, y - 20, e.MarginBounds.Width, e.MarginBounds.Height);
            LinearGradientBrush deg = new LinearGradientBrush(rec, Color.Aqua, Color.Blue,
           LinearGradientMode.BackwardDiagonal);
            Font fuente = new Font("Arial", 10);
            Brush brocha = Brushes.Blue;
            Brush brochaTitulo = Brushes.Red;
            int tlp = (int)(e.MarginBounds.Height / (fuente.GetHeight() + 20));
            totPags = (lbeFiltro04.Count / (tlp - 1));
            if (lbeFiltro04.Count % (tlp - 1) > 0)
                totPags += 1;
            numPag += 1;
            {
                var withBlock = e.Graphics;
                x = e.MarginBounds.Left;
                withBlock.DrawString("Codigo", fuente, brochaTitulo, x, y);
                x = x + 100;
                withBlock.DrawString("Nombre", fuente, brochaTitulo, x, y);
                x = x + 300;
                withBlock.DrawString("Contacto", fuente, brochaTitulo, x, y);
                x = x + 100;
                withBlock.DrawString("Direccion", fuente, brochaTitulo, x, y);
                y = (int)(y + fuente.GetHeight() + 20);
                int I;
                for (I = 0; I <= tlp - 2; I++)
                {
                    if (cr == lbeFiltro04.Count)
                        break;
                    x = e.MarginBounds.Left;
                    withBlock.DrawString(lbeFiltro04[cr].Codigo.ToString(), fuente, brocha, x, y);
                    x = x + 100;
                    withBlock.DrawString(lbeFiltro04[cr].Nombre.ToString(), fuente, brocha, x, y);
                    x = x + 300;
                    withBlock.DrawString(lbeFiltro04[cr].Contacto.ToString(), fuente, brocha, x, y);
                    x = x + 100;
                    withBlock.DrawString(lbeFiltro04[cr].Direccion.ToString(), fuente, brocha, x, y);
                    y = (int)(y + fuente.GetHeight() + 20);
                    cr += 1;
                }
                withBlock.DrawString(string.Format("Pag {0} de {1}", numPag, totPags), fuente,
               brochaTitulo, 400, e.MarginBounds.Top + e.MarginBounds.Height);
                e.HasMorePages = (cr < lbeFiltro04.Count - 1);
            }

        }

        private void BTNreporteProveedorPaiz_Click(object sender, EventArgs e)
        {
            cr = 0;
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd02;

            ppd.ShowDialog();
        }

        private void btnconfiggurarPajinaProverdorPorPAIZ_Click(object sender, EventArgs e)
        {
            PageSetupDialog psd = new PageSetupDialog();
            psd.Document = pd02;
            psd.ShowDialog();
        }

        private void BTNimprimirPorveedorPorPaiz_Click(object sender, EventArgs e)
        {
            PrintDialog pdg = new PrintDialog();
            pdg.Document = pd02;
            pdg.ShowDialog();
        }

        private void detalleWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                {
                    //var withBlock = dgvProductosFiltro.CurrentRow;
                    string DocPlantilla = string.Format("{0}Ficha del Producto.docx", ruta);
                    string DocFicha = string.Format("{0}Ficha del Producto {1}.docx", ruta, dgvProductos.CurrentRow.Cells[1].Value);
                    Microsoft.Office.Interop.Word.Application oWord01 = new Microsoft.Office.Interop.Word.Application();
                    oWord01.Visible = true;
                    oWord01.Documents.Open(DocPlantilla);
                    oWord01.ActiveDocument.Fields[1].Result.Text = (string)dgvProductos.CurrentRow.Cells[0].Value.ToString();
                    oWord01.ActiveDocument.Fields[2].Result.Text = (string)dgvProductos.CurrentRow.Cells[1].Value.ToString();
                    oWord01.ActiveDocument.Fields[3].Result.Text = (string)dgvProductos.CurrentRow.Cells[4].Value.ToString();
                    oWord01.ActiveDocument.Fields[4].Result.Text = (string)dgvProductos.CurrentRow.Cells[5].Value.ToString();
                    oWord01.ActiveDocument.SaveAs(DocFicha);
                }
            }

        }
        String ruta = "D:\\Trabajos Visual Estudio\\EJERCICIOS_solucionesEmpresariales\\documentos\\";

        private void muestraLasLlistaEnWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application oWord01 = new Microsoft.Office.Interop.Word.Application();
            oWord01.Visible = true;
            oWord01.Documents.Add();
            {
                var withBlock = oWord01.Selection;
                withBlock.Font.Size = 16;
                withBlock.Font.ColorIndex = (Microsoft.Office.Interop.Word.WdColorIndex)2;
                withBlock.TypeText("Lista de Productos");
                withBlock.TypeParagraph();
                object Rango = withBlock.Range;
                withBlock.Tables.Add((Microsoft.Office.Interop.Word.Range)Rango, dgvProductos.Rows.Count + 1, dgvProductos.Columns.Count);
                withBlock.Tables[1].ApplyStyleHeadingRows = true;
                withBlock.Tables[1].ApplyStyleFirstColumn = true;
                withBlock.Tables[1].ApplyStyleColumnBands = true;
                for (var I = 0; I <= dgvProductos.ColumnCount - 1; I++)
                {
                    withBlock.Tables[1].Rows[1].Cells[I + 1].Select();
                    withBlock.Font.Size = 12;
                    withBlock.Font.ColorIndex = (Microsoft.Office.Interop.Word.WdColorIndex)6;
                    withBlock.TypeText(dgvProductos.Columns[I].HeaderText);
                }
                withBlock.Font.ColorIndex = (Microsoft.Office.Interop.Word.WdColorIndex)1;
                for (var I = 0; I <= dgvProductos.RowCount - 1; I++)
                {
                    for (var J = 0; J <= dgvProductos.ColumnCount - 1; J++)
                    {
                        withBlock.Tables[1].Rows[I + 2].Cells[J + 1].Select();
                        withBlock.Font.Size = 12;
                        withBlock.Font.ColorIndex = (Microsoft.Office.Interop.Word.WdColorIndex)1;
                        withBlock.TypeText(dgvProductos.Rows[I].Cells[J].Value.ToString());
                    }
                }
            }
            string DocLista = string.Format("{0}Lista de Productos.docx", ruta);
            oWord01.ActiveDocument.SaveAs(DocLista);
        }

        private void listaYGraficaEbExelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Range oRango;
            oExcel.Visible = true;
            oExcel.Workbooks.Add();
            {
                var withBlock = oExcel;
                withBlock.Cells[1, 1].Value = "Descripción del Producto";
                withBlock.Cells[1, 2].Value = "Precio Unitario";
                for (var I = 0; I <= dgvProductos.Rows.Count - 1; I++)
                {
                    withBlock.Cells[I + 2, 1].Value = dgvProductos.Rows[I].Cells[1].Value;
                    withBlock.Cells[I + 2, 2].Value = dgvProductos.Rows[I].Cells[4].Value;
                }
                withBlock.Columns.AutoFit();
                withBlock.Range["A1"].Select();
                oRango = withBlock.Selection.CurrentRegion;
                withBlock.ActiveWorkbook.Charts.Add();
            }
            {
                var withBlock = oExcel.ActiveChart;
                withBlock.Location((Microsoft.Office.Interop.Excel.XlChartLocation)1);
                withBlock.SetSourceData(oRango, 2);
                withBlock.ChartType = (Microsoft.Office.Interop.Excel.XlChartType)(-4100);
                withBlock.ChartTitle.Text = "Gráfico de Precios de Productos";
            }
        }
    }
}
