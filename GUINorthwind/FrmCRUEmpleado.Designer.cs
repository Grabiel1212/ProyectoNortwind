namespace GUINorthwind
{
    partial class FrmCRUEmpleado
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
            this.btnGrabarEmpleado = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccionEmp = new System.Windows.Forms.TextBox();
            this.txtPaisEmp = new System.Windows.Forms.TextBox();
            this.dateFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.pnlBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrabarEmpleado
            // 
            this.btnGrabarEmpleado.BackColor = System.Drawing.Color.IndianRed;
            this.btnGrabarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnGrabarEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnGrabarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnGrabarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabarEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.btnGrabarEmpleado.Location = new System.Drawing.Point(381, 368);
            this.btnGrabarEmpleado.Name = "btnGrabarEmpleado";
            this.btnGrabarEmpleado.Size = new System.Drawing.Size(181, 40);
            this.btnGrabarEmpleado.TabIndex = 28;
            this.btnGrabarEmpleado.Text = "GRABAR";
            this.btnGrabarEmpleado.UseVisualStyleBackColor = false;
            this.btnGrabarEmpleado.Click += new System.EventHandler(this.btnGrabarEmpleado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "DIRECCION : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "FECHA DE NACIMIENTO :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "APELLIDO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "NOMBRE :";
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtApellidoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(234, 157);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(256, 20);
            this.txtApellidoEmpleado.TabIndex = 15;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNombreEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(234, 108);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(256, 20);
            this.txtNombreEmpleado.TabIndex = 14;
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
            this.pnlBarraTitulo.Size = new System.Drawing.Size(603, 29);
            this.pnlBarraTitulo.TabIndex = 13;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.ForeColor = System.Drawing.Color.White;
            this.lblTituloPrincipal.Location = new System.Drawing.Point(39, 5);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(101, 18);
            this.lblTituloPrincipal.TabIndex = 4;
            this.lblTituloPrincipal.Text = "EMPLEADOS";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(554, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(19, 19);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.Text = "--";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimizar.Click += new System.EventHandler(this.minimizar);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(576, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 19);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "X";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.Click += new System.EventHandler(this.cerrarVentana);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "PAIS :";
            // 
            // txtDireccionEmp
            // 
            this.txtDireccionEmp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDireccionEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccionEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionEmp.ForeColor = System.Drawing.Color.Black;
            this.txtDireccionEmp.Location = new System.Drawing.Point(234, 259);
            this.txtDireccionEmp.Name = "txtDireccionEmp";
            this.txtDireccionEmp.Size = new System.Drawing.Size(256, 20);
            this.txtDireccionEmp.TabIndex = 31;
            // 
            // txtPaisEmp
            // 
            this.txtPaisEmp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPaisEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaisEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaisEmp.ForeColor = System.Drawing.Color.Black;
            this.txtPaisEmp.Location = new System.Drawing.Point(234, 303);
            this.txtPaisEmp.Name = "txtPaisEmp";
            this.txtPaisEmp.Size = new System.Drawing.Size(256, 20);
            this.txtPaisEmp.TabIndex = 32;
            // 
            // dateFechaNacimiento
            // 
            this.dateFechaNacimiento.Location = new System.Drawing.Point(234, 209);
            this.dateFechaNacimiento.Name = "dateFechaNacimiento";
            this.dateFechaNacimiento.Size = new System.Drawing.Size(256, 20);
            this.dateFechaNacimiento.TabIndex = 33;
            // 
            // FrmCRUEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.dateFechaNacimiento);
            this.Controls.Add(this.txtPaisEmp);
            this.Controls.Add(this.txtDireccionEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGrabarEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.pnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCRUEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCRUEmpleado";
            this.Load += new System.EventHandler(this.FrmCRUEmpleado_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabarEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Label btnMinimizar;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccionEmp;
        private System.Windows.Forms.TextBox txtPaisEmp;
        private System.Windows.Forms.DateTimePicker dateFechaNacimiento;
    }
}