namespace GUINorthwind
{
    partial class FrmCruPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateFechaorden = new System.Windows.Forms.DateTimePicker();
            this.txtdirecion = new System.Windows.Forms.TextBox();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGrabarpedido = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtCODIGOrden = new System.Windows.Forms.TextBox();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.txttrasporte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateFechaorden
            // 
            this.dateFechaorden.Location = new System.Drawing.Point(297, 232);
            this.dateFechaorden.Name = "dateFechaorden";
            this.dateFechaorden.Size = new System.Drawing.Size(256, 20);
            this.dateFechaorden.TabIndex = 45;
            // 
            // txtdirecion
            // 
            this.txtdirecion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtdirecion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdirecion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdirecion.ForeColor = System.Drawing.Color.Black;
            this.txtdirecion.Location = new System.Drawing.Point(297, 275);
            this.txtdirecion.Name = "txtdirecion";
            this.txtdirecion.Size = new System.Drawing.Size(256, 20);
            this.txtdirecion.TabIndex = 44;
            // 
            // txtidempleado
            // 
            this.txtidempleado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtidempleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidempleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidempleado.ForeColor = System.Drawing.Color.Black;
            this.txtidempleado.Location = new System.Drawing.Point(297, 182);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(256, 20);
            this.txtidempleado.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(95, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "DIRECCION ENVIO :";
            // 
            // btnGrabarpedido
            // 
            this.btnGrabarpedido.BackColor = System.Drawing.Color.IndianRed;
            this.btnGrabarpedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabarpedido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGrabarpedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnGrabarpedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGrabarpedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabarpedido.ForeColor = System.Drawing.Color.LightGray;
            this.btnGrabarpedido.Location = new System.Drawing.Point(518, 418);
            this.btnGrabarpedido.Name = "btnGrabarpedido";
            this.btnGrabarpedido.Size = new System.Drawing.Size(181, 40);
            this.btnGrabarpedido.TabIndex = 41;
            this.btnGrabarpedido.Text = "GRABAR";
            this.btnGrabarpedido.UseVisualStyleBackColor = false;
            this.btnGrabarpedido.Click += new System.EventHandler(this.btnGrabarpedido_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(118, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "FECHA ORDEN : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(129, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID EMPLEADO :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID CLLENTE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(108, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "CODIGO ORDEN  :";
            // 
            // txtidcliente
            // 
            this.txtidcliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtidcliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidcliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidcliente.ForeColor = System.Drawing.Color.Black;
            this.txtidcliente.Location = new System.Drawing.Point(297, 129);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(256, 20);
            this.txtidcliente.TabIndex = 36;
            // 
            // txtCODIGOrden
            // 
            this.txtCODIGOrden.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCODIGOrden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCODIGOrden.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCODIGOrden.ForeColor = System.Drawing.Color.Black;
            this.txtCODIGOrden.Location = new System.Drawing.Point(297, 80);
            this.txtCODIGOrden.Name = "txtCODIGOrden";
            this.txtCODIGOrden.Size = new System.Drawing.Size(256, 20);
            this.txtCODIGOrden.TabIndex = 35;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.Brown;
            this.pnlBarraTitulo.Controls.Add(this.lblTituloPrincipal);
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(780, 29);
            this.pnlBarraTitulo.TabIndex = 34;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.ForeColor = System.Drawing.Color.White;
            this.lblTituloPrincipal.Location = new System.Drawing.Point(39, 5);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(65, 18);
            this.lblTituloPrincipal.TabIndex = 4;
            this.lblTituloPrincipal.Text = "PEDIDO";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(731, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(19, 19);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "--";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(753, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 19);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "X";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txttrasporte
            // 
            this.txttrasporte.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txttrasporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttrasporte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrasporte.ForeColor = System.Drawing.Color.Black;
            this.txttrasporte.Location = new System.Drawing.Point(297, 341);
            this.txttrasporte.Name = "txttrasporte";
            this.txttrasporte.Size = new System.Drawing.Size(256, 20);
            this.txttrasporte.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(142, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "TRASPORTE :";
            // 
            // FrmCruPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 494);
            this.Controls.Add(this.txttrasporte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateFechaorden);
            this.Controls.Add(this.txtdirecion);
            this.Controls.Add(this.txtidempleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGrabarpedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.txtCODIGOrden);
            this.Controls.Add(this.pnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCruPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCruPedido";
            this.Load += new System.EventHandler(this.FrmCruPedido_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateFechaorden;
        private System.Windows.Forms.TextBox txtdirecion;
        private System.Windows.Forms.TextBox txtidempleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGrabarpedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtCODIGOrden;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Label btnMinimizar;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.TextBox txttrasporte;
        private System.Windows.Forms.Label label6;
    }
}