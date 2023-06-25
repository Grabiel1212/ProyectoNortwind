﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUINorthwind
{
    public partial class FrmCRUProducto : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int
        lparam);

        public FrmCRUProducto()
        {
            InitializeComponent();
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
    }
}
