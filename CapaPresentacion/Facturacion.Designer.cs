
namespace CapaPresentacion
{
    partial class Facturacion
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
            this.cbbCodigoEmpleado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigopro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombreproduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbFecha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbDetalleProducto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbNombreProducto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbCodigoProducto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbNombreCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCodigoCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPrecioProducto = new System.Windows.Forms.ComboBox();
            this.cbbCantidadProducto = new System.Windows.Forms.ComboBox();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addcliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCodigoEmpleado
            // 
            this.cbbCodigoEmpleado.FormattingEnabled = true;
            this.cbbCodigoEmpleado.Location = new System.Drawing.Point(557, 236);
            this.cbbCodigoEmpleado.Name = "cbbCodigoEmpleado";
            this.cbbCodigoEmpleado.Size = new System.Drawing.Size(165, 21);
            this.cbbCodigoEmpleado.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(374, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 18);
            this.label11.TabIndex = 51;
            this.label11.Text = "CODIGO EMPLEADO:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCliente,
            this.NombreC,
            this.Codigopro,
            this.Nombreproduc,
            this.Detalle,
            this.PrecioProduc,
            this.TotalPago});
            this.dataGridView1.Location = new System.Drawing.Point(15, 341);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 232);
            this.dataGridView1.TabIndex = 50;
            // 
            // CodigoCliente
            // 
            this.CodigoCliente.HeaderText = "Codigo Cliente";
            this.CodigoCliente.Name = "CodigoCliente";
            // 
            // NombreC
            // 
            this.NombreC.HeaderText = "Nombre Cliente";
            this.NombreC.Name = "NombreC";
            // 
            // Codigopro
            // 
            this.Codigopro.HeaderText = "Codigo Producto";
            this.Codigopro.Name = "Codigopro";
            // 
            // Nombreproduc
            // 
            this.Nombreproduc.HeaderText = "Nombre Producto";
            this.Nombreproduc.Name = "Nombreproduc";
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle Producto";
            this.Detalle.Name = "Detalle";
            // 
            // PrecioProduc
            // 
            this.PrecioProduc.HeaderText = "Precio Producto";
            this.PrecioProduc.Name = "PrecioProduc";
            // 
            // TotalPago
            // 
            this.TotalPago.HeaderText = "Total Pago";
            this.TotalPago.Name = "TotalPago";
            // 
            // txbFecha
            // 
            this.txbFecha.Location = new System.Drawing.Point(168, 182);
            this.txbFecha.Name = "txbFecha";
            this.txbFecha.Size = new System.Drawing.Size(178, 20);
            this.txbFecha.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 18);
            this.label10.TabIndex = 48;
            this.label10.Text = "FECHA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(734, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 47;
            this.label9.Text = "TOTAL PAGO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(728, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 18);
            this.label8.TabIndex = 46;
            this.label8.Text = "CANTIDAD PRODUCTO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(742, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "PRECIO PRODUCTO:";
            // 
            // cbbDetalleProducto
            // 
            this.cbbDetalleProducto.FormattingEnabled = true;
            this.cbbDetalleProducto.Location = new System.Drawing.Point(557, 174);
            this.cbbDetalleProducto.Name = "cbbDetalleProducto";
            this.cbbDetalleProducto.Size = new System.Drawing.Size(165, 21);
            this.cbbDetalleProducto.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(374, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "DETALLE PRODUCTO:";
            // 
            // cbbNombreProducto
            // 
            this.cbbNombreProducto.FormattingEnabled = true;
            this.cbbNombreProducto.Location = new System.Drawing.Point(557, 125);
            this.cbbNombreProducto.Name = "cbbNombreProducto";
            this.cbbNombreProducto.Size = new System.Drawing.Size(165, 21);
            this.cbbNombreProducto.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(374, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "NOMBRE PRODUCTO:";
            // 
            // cbbCodigoProducto
            // 
            this.cbbCodigoProducto.FormattingEnabled = true;
            this.cbbCodigoProducto.Location = new System.Drawing.Point(557, 62);
            this.cbbCodigoProducto.Name = "cbbCodigoProducto";
            this.cbbCodigoProducto.Size = new System.Drawing.Size(165, 21);
            this.cbbCodigoProducto.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(374, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "CODIGO PRODUCTO:";
            // 
            // cbbNombreCliente
            // 
            this.cbbNombreCliente.FormattingEnabled = true;
            this.cbbNombreCliente.Location = new System.Drawing.Point(181, 123);
            this.cbbNombreCliente.Name = "cbbNombreCliente";
            this.cbbNombreCliente.Size = new System.Drawing.Size(165, 21);
            this.cbbNombreCliente.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "NOMBRE CLIENTE:";
            // 
            // cbbCodigoCliente
            // 
            this.cbbCodigoCliente.FormattingEnabled = true;
            this.cbbCodigoCliente.Location = new System.Drawing.Point(181, 63);
            this.cbbCodigoCliente.Name = "cbbCodigoCliente";
            this.cbbCodigoCliente.Size = new System.Drawing.Size(165, 21);
            this.cbbCodigoCliente.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "CODIGO CLIENTE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(462, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "FACTURA:";
            // 
            // cbbPrecioProducto
            // 
            this.cbbPrecioProducto.FormattingEnabled = true;
            this.cbbPrecioProducto.Location = new System.Drawing.Point(932, 58);
            this.cbbPrecioProducto.Name = "cbbPrecioProducto";
            this.cbbPrecioProducto.Size = new System.Drawing.Size(121, 21);
            this.cbbPrecioProducto.TabIndex = 53;
            // 
            // cbbCantidadProducto
            // 
            this.cbbCantidadProducto.FormattingEnabled = true;
            this.cbbCantidadProducto.Location = new System.Drawing.Point(932, 119);
            this.cbbCantidadProducto.Name = "cbbCantidadProducto";
            this.cbbCantidadProducto.Size = new System.Drawing.Size(121, 21);
            this.cbbCantidadProducto.TabIndex = 53;
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTotalPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPago.Location = new System.Drawing.Point(875, 179);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(178, 20);
            this.txtTotalPago.TabIndex = 54;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(828, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 34);
            this.button2.TabIndex = 57;
            this.button2.Text = "IMPRIMIR FACTURA";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(828, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 34);
            this.button1.TabIndex = 56;
            this.button1.Text = "NUEVA";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // addcliente
            // 
            this.addcliente.BackColor = System.Drawing.Color.Green;
            this.addcliente.ForeColor = System.Drawing.Color.White;
            this.addcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addcliente.Location = new System.Drawing.Point(828, 341);
            this.addcliente.Name = "addcliente";
            this.addcliente.Size = new System.Drawing.Size(180, 34);
            this.addcliente.TabIndex = 55;
            this.addcliente.Text = "FACTURAR";
            this.addcliente.UseVisualStyleBackColor = false;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addcliente);
            this.Controls.Add(this.txtTotalPago);
            this.Controls.Add(this.cbbCantidadProducto);
            this.Controls.Add(this.cbbPrecioProducto);
            this.Controls.Add(this.cbbCodigoEmpleado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbFecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbDetalleProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbNombreProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbCodigoProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbCodigoCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCodigoEmpleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigopro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombreproduc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProduc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPago;
        private System.Windows.Forms.TextBox txbFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbDetalleProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbNombreProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbCodigoProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCodigoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPrecioProducto;
        private System.Windows.Forms.ComboBox cbbCantidadProducto;
        private System.Windows.Forms.TextBox txtTotalPago;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addcliente;
    }
}