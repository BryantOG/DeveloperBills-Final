namespace CapaPresentacion
{
    partial class Producto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textnomPro = new System.Windows.Forms.TextBox();
            this.textprecioPro = new System.Windows.Forms.TextBox();
            this.textCantidadPro = new System.Windows.Forms.TextBox();
            this.textDetallesPro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificar2 = new System.Windows.Forms.Button();
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnModificar1 = new System.Windows.Forms.Button();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.gridProducto = new System.Windows.Forms.DataGridView();
            this.bntOculconsulta = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.panelClave = new System.Windows.Forms.Panel();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.textClave = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducto)).BeginInit();
            this.panelClave.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(489, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "PRODUCTOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "CODIGO PRODUCTO:";
            // 
            // textCodigo
            // 
            this.textCodigo.Enabled = false;
            this.textCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodigo.Location = new System.Drawing.Point(232, 94);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(184, 20);
            this.textCodigo.TabIndex = 37;
            this.textCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "NOMBRE PRODUCTO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(460, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "PRECIO PRODUCTO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(460, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "CANTIDAD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "DETALLES PRODUCTO:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textnomPro
            // 
            this.textnomPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnomPro.Location = new System.Drawing.Point(232, 141);
            this.textnomPro.Name = "textnomPro";
            this.textnomPro.Size = new System.Drawing.Size(184, 20);
            this.textnomPro.TabIndex = 42;
            this.textnomPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textprecioPro
            // 
            this.textprecioPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textprecioPro.Location = new System.Drawing.Point(662, 95);
            this.textprecioPro.Name = "textprecioPro";
            this.textprecioPro.Size = new System.Drawing.Size(184, 20);
            this.textprecioPro.TabIndex = 43;
            this.textprecioPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textprecioPro.TextChanged += new System.EventHandler(this.textprecioPro_TextChanged);
            // 
            // textCantidadPro
            // 
            this.textCantidadPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCantidadPro.Location = new System.Drawing.Point(662, 147);
            this.textCantidadPro.Name = "textCantidadPro";
            this.textCantidadPro.Size = new System.Drawing.Size(184, 20);
            this.textCantidadPro.TabIndex = 44;
            this.textCantidadPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDetallesPro
            // 
            this.textDetallesPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDetallesPro.Location = new System.Drawing.Point(232, 194);
            this.textDetallesPro.Multiline = true;
            this.textDetallesPro.Name = "textDetallesPro";
            this.textDetallesPro.Size = new System.Drawing.Size(184, 68);
            this.textDetallesPro.TabIndex = 45;
            this.textDetallesPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(905, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 33);
            this.button1.TabIndex = 46;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModificar2
            // 
            this.btnModificar2.BackColor = System.Drawing.Color.Green;
            this.btnModificar2.ForeColor = System.Drawing.Color.White;
            this.btnModificar2.Location = new System.Drawing.Point(905, 134);
            this.btnModificar2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar2.Name = "btnModificar2";
            this.btnModificar2.Size = new System.Drawing.Size(162, 33);
            this.btnModificar2.TabIndex = 47;
            this.btnModificar2.Text = "MODIFICAR";
            this.btnModificar2.UseVisualStyleBackColor = false;
            this.btnModificar2.Visible = false;
            this.btnModificar2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.BackColor = System.Drawing.Color.Green;
            this.btnEliminar2.ForeColor = System.Drawing.Color.White;
            this.btnEliminar2.Location = new System.Drawing.Point(905, 181);
            this.btnEliminar2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(162, 33);
            this.btnEliminar2.TabIndex = 48;
            this.btnEliminar2.Text = "ELIMINAR";
            this.btnEliminar2.UseVisualStyleBackColor = false;
            this.btnEliminar2.Visible = false;
            this.btnEliminar2.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(905, 229);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 33);
            this.button4.TabIndex = 49;
            this.button4.Text = "CONSULTAR PRODUCTO";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnModificar1
            // 
            this.btnModificar1.BackColor = System.Drawing.Color.Green;
            this.btnModificar1.ForeColor = System.Drawing.Color.White;
            this.btnModificar1.Location = new System.Drawing.Point(905, 134);
            this.btnModificar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar1.Name = "btnModificar1";
            this.btnModificar1.Size = new System.Drawing.Size(162, 33);
            this.btnModificar1.TabIndex = 50;
            this.btnModificar1.Text = "MODIFICAR";
            this.btnModificar1.UseVisualStyleBackColor = false;
            this.btnModificar1.Click += new System.EventHandler(this.btnModificar1_Click);
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.BackColor = System.Drawing.Color.Green;
            this.btnEliminar1.ForeColor = System.Drawing.Color.White;
            this.btnEliminar1.Location = new System.Drawing.Point(905, 181);
            this.btnEliminar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(162, 33);
            this.btnEliminar1.TabIndex = 51;
            this.btnEliminar1.Text = "ELIMINAR";
            this.btnEliminar1.UseVisualStyleBackColor = false;
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // gridProducto
            // 
            this.gridProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducto.Location = new System.Drawing.Point(33, 357);
            this.gridProducto.Name = "gridProducto";
            this.gridProducto.Size = new System.Drawing.Size(859, 234);
            this.gridProducto.TabIndex = 52;
            this.gridProducto.Visible = false;
            this.gridProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducto_CellContentClick);
            // 
            // bntOculconsulta
            // 
            this.bntOculconsulta.BackColor = System.Drawing.Color.Green;
            this.bntOculconsulta.ForeColor = System.Drawing.Color.White;
            this.bntOculconsulta.Location = new System.Drawing.Point(905, 539);
            this.bntOculconsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bntOculconsulta.Name = "bntOculconsulta";
            this.bntOculconsulta.Size = new System.Drawing.Size(162, 33);
            this.bntOculconsulta.TabIndex = 53;
            this.bntOculconsulta.Text = "OCULTAR CONSULTA";
            this.bntOculconsulta.UseVisualStyleBackColor = false;
            this.bntOculconsulta.Visible = false;
            this.bntOculconsulta.Click += new System.EventHandler(this.bntOculconsulta_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(205, 316);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(184, 20);
            this.textBuscar.TabIndex = 55;
            this.textBuscar.Text = "CODIGO PARA BUSCAR";
            this.textBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBuscar.Visible = false;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(30, 318);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(169, 18);
            this.lblBuscar.TabIndex = 54;
            this.lblBuscar.Text = "BUSCAR PRODUCTO";
            this.lblBuscar.Visible = false;
            // 
            // panelClave
            // 
            this.panelClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(82)))));
            this.panelClave.Controls.Add(this.btnVerificar);
            this.panelClave.Controls.Add(this.textClave);
            this.panelClave.Controls.Add(this.label9);
            this.panelClave.Location = new System.Drawing.Point(336, 342);
            this.panelClave.Name = "panelClave";
            this.panelClave.Size = new System.Drawing.Size(490, 219);
            this.panelClave.TabIndex = 56;
            this.panelClave.Visible = false;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(169, 161);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(156, 35);
            this.btnVerificar.TabIndex = 10;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // textClave
            // 
            this.textClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClave.Location = new System.Drawing.Point(131, 94);
            this.textClave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textClave.Name = "textClave";
            this.textClave.PasswordChar = '*';
            this.textClave.Size = new System.Drawing.Size(234, 22);
            this.textClave.TabIndex = 9;
            this.textClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(100, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 40);
            this.label9.TabIndex = 0;
            this.label9.Text = "Para realizar esta accion nesecita una \r\n        clave de administrador";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.panelClave);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.bntOculconsulta);
            this.Controls.Add(this.gridProducto);
            this.Controls.Add(this.btnEliminar1);
            this.Controls.Add(this.btnModificar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEliminar2);
            this.Controls.Add(this.btnModificar2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textDetallesPro);
            this.Controls.Add(this.textCantidadPro);
            this.Controls.Add(this.textprecioPro);
            this.Controls.Add(this.textnomPro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducto)).EndInit();
            this.panelClave.ResumeLayout(false);
            this.panelClave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textnomPro;
        private System.Windows.Forms.TextBox textprecioPro;
        private System.Windows.Forms.TextBox textCantidadPro;
        private System.Windows.Forms.TextBox textDetallesPro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificar2;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnModificar1;
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.DataGridView gridProducto;
        private System.Windows.Forms.Button bntOculconsulta;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Panel panelClave;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.Label label9;
    }
}