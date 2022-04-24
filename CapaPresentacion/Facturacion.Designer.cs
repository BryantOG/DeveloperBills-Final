
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.cbbCodigoEmpleado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbCodigoProducto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbCodigoCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fechaF = new System.Windows.Forms.DateTimePicker();
            this.gridfacturar = new System.Windows.Forms.DataGridView();
            this.nomcliF = new System.Windows.Forms.TextBox();
            this.textnomp2 = new System.Windows.Forms.TextBox();
            this.textDetaP2 = new System.Windows.Forms.TextBox();
            this.textPrecioP2 = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.CantidaP2 = new System.Windows.Forms.NumericUpDown();
            this.ColumCodiVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTotalPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumPreProduc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumDetaProdu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodiPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodiCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridfacturar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidaP2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCodigoEmpleado
            // 
            this.cbbCodigoEmpleado.FormattingEnabled = true;
            this.cbbCodigoEmpleado.Location = new System.Drawing.Point(547, 236);
            this.cbbCodigoEmpleado.Name = "cbbCodigoEmpleado";
            this.cbbCodigoEmpleado.Size = new System.Drawing.Size(165, 21);
            this.cbbCodigoEmpleado.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(367, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 18);
            this.label11.TabIndex = 51;
            this.label11.Text = "CODIGO VENDEDOR:";
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
            this.label7.Location = new System.Drawing.Point(734, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "PRECIO PRODUCTO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(361, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "DETALLE PRODUCTO:";
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
            this.cbbCodigoProducto.SelectedIndexChanged += new System.EventHandler(this.cbbCodigoProducto_SelectedIndexChanged);
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
            this.cbbCodigoCliente.Items.AddRange(new object[] {
            ""});
            this.cbbCodigoCliente.Location = new System.Drawing.Point(181, 63);
            this.cbbCodigoCliente.Name = "cbbCodigoCliente";
            this.cbbCodigoCliente.Size = new System.Drawing.Size(165, 21);
            this.cbbCodigoCliente.TabIndex = 36;
            this.cbbCodigoCliente.SelectedIndexChanged += new System.EventHandler(this.cbbCodigoCliente_SelectedIndexChanged);
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
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "FACTURA";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(665, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 34);
            this.button2.TabIndex = 57;
            this.button2.Text = "IMPRIMIR FACTURA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(166, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 34);
            this.button1.TabIndex = 56;
            this.button1.Text = "AÑADIR PRODUCTO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fechaF
            // 
            this.fechaF.Location = new System.Drawing.Point(146, 181);
            this.fechaF.Name = "fechaF";
            this.fechaF.Size = new System.Drawing.Size(200, 20);
            this.fechaF.TabIndex = 59;
            // 
            // gridfacturar
            // 
            this.gridfacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridfacturar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodiCli,
            this.ColumnNomCli,
            this.ColumnCodiPro,
            this.ColumnNomPro,
            this.ColumDetaProdu,
            this.ColumPreProduc,
            this.ColumCantPro,
            this.ColumTotalPro,
            this.ColumnFecha,
            this.ColumCodiVendedor});
            this.gridfacturar.Location = new System.Drawing.Point(12, 364);
            this.gridfacturar.Name = "gridfacturar";
            this.gridfacturar.Size = new System.Drawing.Size(1041, 252);
            this.gridfacturar.TabIndex = 60;
            // 
            // nomcliF
            // 
            this.nomcliF.Enabled = false;
            this.nomcliF.Location = new System.Drawing.Point(183, 121);
            this.nomcliF.Name = "nomcliF";
            this.nomcliF.Size = new System.Drawing.Size(163, 20);
            this.nomcliF.TabIndex = 61;
            // 
            // textnomp2
            // 
            this.textnomp2.Enabled = false;
            this.textnomp2.Location = new System.Drawing.Point(557, 124);
            this.textnomp2.Name = "textnomp2";
            this.textnomp2.Size = new System.Drawing.Size(165, 20);
            this.textnomp2.TabIndex = 62;
            // 
            // textDetaP2
            // 
            this.textDetaP2.Enabled = false;
            this.textDetaP2.Location = new System.Drawing.Point(547, 175);
            this.textDetaP2.Multiline = true;
            this.textDetaP2.Name = "textDetaP2";
            this.textDetaP2.Size = new System.Drawing.Size(165, 55);
            this.textDetaP2.TabIndex = 63;
            // 
            // textPrecioP2
            // 
            this.textPrecioP2.Enabled = false;
            this.textPrecioP2.Location = new System.Drawing.Point(905, 56);
            this.textPrecioP2.Name = "textPrecioP2";
            this.textPrecioP2.Size = new System.Drawing.Size(163, 20);
            this.textPrecioP2.TabIndex = 64;
            // 
            // printDocument1
            // 
            this.printDocument1.OriginAtMargins = true;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal2.ForeColor = System.Drawing.Color.White;
            this.lblTotal2.Location = new System.Drawing.Point(734, 239);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(143, 18);
            this.lblTotal2.TabIndex = 66;
            this.lblTotal2.Text = "TOTAL A PAGAR:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(898, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 18);
            this.label13.TabIndex = 67;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Location = new System.Drawing.Point(886, 236);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 20);
            this.lblTotal.TabIndex = 68;
            this.lblTotal.Text = "0";
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtTotalPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPago.Location = new System.Drawing.Point(890, 176);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(178, 20);
            this.txtTotalPago.TabIndex = 54;
            this.txtTotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotalPago.Visible = false;
            // 
            // CantidaP2
            // 
            this.CantidaP2.Location = new System.Drawing.Point(932, 121);
            this.CantidaP2.Name = "CantidaP2";
            this.CantidaP2.Size = new System.Drawing.Size(121, 20);
            this.CantidaP2.TabIndex = 58;
            // 
            // ColumCodiVendedor
            // 
            this.ColumCodiVendedor.HeaderText = "Codigo Vendedor";
            this.ColumCodiVendedor.Name = "ColumCodiVendedor";
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            // 
            // ColumTotalPro
            // 
            this.ColumTotalPro.HeaderText = "Total Producto";
            this.ColumTotalPro.Name = "ColumTotalPro";
            // 
            // ColumCantPro
            // 
            this.ColumCantPro.HeaderText = "Cantidad Producto";
            this.ColumCantPro.Name = "ColumCantPro";
            // 
            // ColumPreProduc
            // 
            this.ColumPreProduc.HeaderText = "Precio Producto";
            this.ColumPreProduc.Name = "ColumPreProduc";
            // 
            // ColumDetaProdu
            // 
            this.ColumDetaProdu.HeaderText = "Detalle Producto";
            this.ColumDetaProdu.Name = "ColumDetaProdu";
            // 
            // ColumnNomPro
            // 
            this.ColumnNomPro.HeaderText = "Nombre Producto";
            this.ColumnNomPro.Name = "ColumnNomPro";
            // 
            // ColumnCodiPro
            // 
            this.ColumnCodiPro.HeaderText = "Codigo Producto";
            this.ColumnCodiPro.Name = "ColumnCodiPro";
            // 
            // ColumnNomCli
            // 
            this.ColumnNomCli.HeaderText = "Nombre Cliente";
            this.ColumnNomCli.Name = "ColumnNomCli";
            // 
            // ColumnCodiCli
            // 
            this.ColumnCodiCli.HeaderText = "Codigo Cliente";
            this.ColumnCodiCli.Name = "ColumnCodiCli";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 621);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.textPrecioP2);
            this.Controls.Add(this.textDetaP2);
            this.Controls.Add(this.textnomp2);
            this.Controls.Add(this.nomcliF);
            this.Controls.Add(this.gridfacturar);
            this.Controls.Add(this.fechaF);
            this.Controls.Add(this.CantidaP2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotalPago);
            this.Controls.Add(this.cbbCodigoEmpleado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbCodigoProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbCodigoCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridfacturar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidaP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCodigoEmpleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbCodigoProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCodigoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fechaF;
        private System.Windows.Forms.DataGridView gridfacturar;
        private System.Windows.Forms.TextBox nomcliF;
        private System.Windows.Forms.TextBox textnomp2;
        private System.Windows.Forms.TextBox textDetaP2;
        private System.Windows.Forms.TextBox textPrecioP2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalPago;
        private System.Windows.Forms.NumericUpDown CantidaP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodiCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodiPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumDetaProdu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumPreProduc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTotalPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCodiVendedor;
    }
}