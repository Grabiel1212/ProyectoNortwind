namespace GUINorthwind
{
    partial class FrmCRUProveedor
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
            this.btngravarProveedor = new System.Windows.Forms.Button();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpaiz = new System.Windows.Forms.TextBox();
            this.txtcompania = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.pnlBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngravarProveedor
            // 
            this.btngravarProveedor.BackColor = System.Drawing.Color.IndianRed;
            this.btngravarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngravarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btngravarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btngravarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btngravarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngravarProveedor.ForeColor = System.Drawing.Color.LightGray;
            this.btngravarProveedor.Location = new System.Drawing.Point(375, 303);
            this.btngravarProveedor.Name = "btngravarProveedor";
            this.btngravarProveedor.Size = new System.Drawing.Size(181, 40);
            this.btngravarProveedor.TabIndex = 39;
            this.btngravarProveedor.Text = "GRABAR";
            this.btngravarProveedor.UseVisualStyleBackColor = false;
            this.btngravarProveedor.Click += new System.EventHandler(this.btngravarProveedor_Click);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.Brown;
            this.pnlBarraTitulo.Controls.Add(this.lblTituloPrincipal);
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(644, 29);
            this.pnlBarraTitulo.TabIndex = 31;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.ForeColor = System.Drawing.Color.White;
            this.lblTituloPrincipal.Location = new System.Drawing.Point(39, 5);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(106, 18);
            this.lblTituloPrincipal.TabIndex = 4;
            this.lblTituloPrincipal.Text = "PROOVEDOR";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(595, 5);
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
            this.btnCerrar.Location = new System.Drawing.Point(617, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 19);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "X";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Paiz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Compania";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(162, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 1);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(162, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 1);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(162, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 1);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(162, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 1);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // txtpaiz
            // 
            this.txtpaiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtpaiz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpaiz.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaiz.ForeColor = System.Drawing.Color.Black;
            this.txtpaiz.Location = new System.Drawing.Point(162, 228);
            this.txtpaiz.Name = "txtpaiz";
            this.txtpaiz.Size = new System.Drawing.Size(408, 20);
            this.txtpaiz.TabIndex = 41;
            // 
            // txtcompania
            // 
            this.txtcompania.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtcompania.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcompania.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompania.ForeColor = System.Drawing.Color.Black;
            this.txtcompania.Location = new System.Drawing.Point(162, 77);
            this.txtcompania.Name = "txtcompania";
            this.txtcompania.Size = new System.Drawing.Size(408, 20);
            this.txtcompania.TabIndex = 40;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.ForeColor = System.Drawing.Color.Black;
            this.txtdireccion.Location = new System.Drawing.Point(162, 179);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(408, 20);
            this.txtdireccion.TabIndex = 55;
            // 
            // txtContacto
            // 
            this.txtContacto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtContacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContacto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto.ForeColor = System.Drawing.Color.Black;
            this.txtContacto.Location = new System.Drawing.Point(162, 127);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(408, 20);
            this.txtContacto.TabIndex = 56;
            // 
            // FrmCRUProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(644, 392);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtpaiz);
            this.Controls.Add(this.txtcompania);
            this.Controls.Add(this.btngravarProveedor);
            this.Controls.Add(this.pnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCRUProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCRUProveedor";
            this.Load += new System.EventHandler(this.FrmCRUProveedor_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlBarraTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btngravarProveedor;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Label btnMinimizar;
        private System.Windows.Forms.Label btnCerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpaiz;
        private System.Windows.Forms.TextBox txtcompania;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtContacto;
    }
}