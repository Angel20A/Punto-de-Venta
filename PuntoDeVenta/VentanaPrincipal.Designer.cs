
namespace PuntoDeVenta
{
    partial class VentanaPrincipal
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
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestoDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_impVentaEdit = new System.Windows.Forms.ToolStripTextBox();
            this.descuentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_descEdit = new System.Windows.Forms.ToolStripTextBox();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cproducto = new System.Windows.Forms.TextBox();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.dtg_facturacion = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_impVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nofactura = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_empleado = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_facturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Maroon;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Source Sans Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btn_cerrar.Location = new System.Drawing.Point(684, 465);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(104, 40);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirFacturaToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirFacturaToolStripMenuItem
            // 
            this.abrirFacturaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.abrirFacturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impuestoDeVentaToolStripMenuItem,
            this.descuentoToolStripMenuItem});
            this.abrirFacturaToolStripMenuItem.Font = new System.Drawing.Font("Source Sans Pro Semibold", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirFacturaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.abrirFacturaToolStripMenuItem.Name = "abrirFacturaToolStripMenuItem";
            this.abrirFacturaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.abrirFacturaToolStripMenuItem.Text = "Imp. ventas y desc.";
            this.abrirFacturaToolStripMenuItem.Click += new System.EventHandler(this.abrirFacturaToolStripMenuItem_Click);
            // 
            // impuestoDeVentaToolStripMenuItem
            // 
            this.impuestoDeVentaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.impuestoDeVentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_impVentaEdit});
            this.impuestoDeVentaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.impuestoDeVentaToolStripMenuItem.Name = "impuestoDeVentaToolStripMenuItem";
            this.impuestoDeVentaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.impuestoDeVentaToolStripMenuItem.Text = "Impuesto de venta";
            // 
            // txt_impVentaEdit
            // 
            this.txt_impVentaEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.txt_impVentaEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_impVentaEdit.Name = "txt_impVentaEdit";
            this.txt_impVentaEdit.Size = new System.Drawing.Size(100, 23);
            this.txt_impVentaEdit.TextChanged += new System.EventHandler(this.ImpVentaYDescChanged);
            // 
            // descuentoToolStripMenuItem
            // 
            this.descuentoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.descuentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_descEdit});
            this.descuentoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.descuentoToolStripMenuItem.Name = "descuentoToolStripMenuItem";
            this.descuentoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.descuentoToolStripMenuItem.Text = "Descuento";
            // 
            // txt_descEdit
            // 
            this.txt_descEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.txt_descEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_descEdit.Name = "txt_descEdit";
            this.txt_descEdit.Size = new System.Drawing.Size(100, 23);
            this.txt_descEdit.TextChanged += new System.EventHandler(this.ImpVentaYDescChanged);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(92, 23);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDeFacturasToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // historialDeFacturasToolStripMenuItem
            // 
            this.historialDeFacturasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.historialDeFacturasToolStripMenuItem.Font = new System.Drawing.Font("Source Sans Pro Semibold", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialDeFacturasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.historialDeFacturasToolStripMenuItem.Name = "historialDeFacturasToolStripMenuItem";
            this.historialDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.historialDeFacturasToolStripMenuItem.Text = "Historial de facturas";
            this.historialDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.historialDeFacturasToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(325, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código producto";
            // 
            // txt_cproducto
            // 
            this.txt_cproducto.BackColor = System.Drawing.Color.White;
            this.txt_cproducto.Location = new System.Drawing.Point(322, 405);
            this.txt_cproducto.Name = "txt_cproducto";
            this.txt_cproducto.Size = new System.Drawing.Size(114, 23);
            this.txt_cproducto.TabIndex = 3;
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btn_agregarProducto.FlatAppearance.BorderSize = 0;
            this.btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProducto.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btn_agregarProducto.Location = new System.Drawing.Point(322, 436);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(243, 42);
            this.btn_agregarProducto.TabIndex = 4;
            this.btn_agregarProducto.Text = "Agregar producto";
            this.btn_agregarProducto.UseVisualStyleBackColor = false;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // dtg_facturacion
            // 
            this.dtg_facturacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.dtg_facturacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_facturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_facturacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.dtg_facturacion.Location = new System.Drawing.Point(118, 77);
            this.dtg_facturacion.Name = "dtg_facturacion";
            this.dtg_facturacion.Size = new System.Drawing.Size(673, 301);
            this.dtg_facturacion.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(3, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sub Total";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Source Sans Pro", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.lbl_subtotal.Location = new System.Drawing.Point(8, 382);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(83, 46);
            this.lbl_subtotal.TabIndex = 7;
            this.lbl_subtotal.Text = "0.00";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Source Sans Pro", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.lbl_total.Location = new System.Drawing.Point(103, 460);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(109, 60);
            this.lbl_total.TabIndex = 9;
            this.lbl_total.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(101, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total";
            // 
            // txt_descuento
            // 
            this.txt_descuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txt_descuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descuento.Location = new System.Drawing.Point(211, 415);
            this.txt_descuento.Multiline = true;
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.ReadOnly = true;
            this.txt_descuento.Size = new System.Drawing.Size(98, 23);
            this.txt_descuento.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(143, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Descuento";
            // 
            // btn_facturar
            // 
            this.btn_facturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(147)))));
            this.btn_facturar.FlatAppearance.BorderSize = 0;
            this.btn_facturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facturar.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btn_facturar.Location = new System.Drawing.Point(607, 388);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(179, 61);
            this.btn_facturar.TabIndex = 12;
            this.btn_facturar.Text = "Facturar";
            this.btn_facturar.UseVisualStyleBackColor = false;
            this.btn_facturar.Click += new System.EventHandler(this.btn_facturar_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.Color.White;
            this.txt_cantidad.Location = new System.Drawing.Point(451, 405);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(114, 23);
            this.txt_cantidad.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label7.Location = new System.Drawing.Point(454, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(9, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = " ";
            // 
            // txt_impVenta
            // 
            this.txt_impVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txt_impVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_impVenta.Location = new System.Drawing.Point(211, 385);
            this.txt_impVenta.Multiline = true;
            this.txt_impVenta.Name = "txt_impVenta";
            this.txt_impVenta.ReadOnly = true;
            this.txt_impVenta.Size = new System.Drawing.Size(98, 23);
            this.txt_impVenta.TabIndex = 15;
            this.txt_impVenta.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label9.Location = new System.Drawing.Point(9, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "No. Factura";
            // 
            // txt_nofactura
            // 
            this.txt_nofactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txt_nofactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nofactura.Font = new System.Drawing.Font("Source Sans Pro", 8.25F);
            this.txt_nofactura.Location = new System.Drawing.Point(84, 39);
            this.txt_nofactura.Multiline = true;
            this.txt_nofactura.Name = "txt_nofactura";
            this.txt_nofactura.ReadOnly = true;
            this.txt_nofactura.Size = new System.Drawing.Size(113, 20);
            this.txt_nofactura.TabIndex = 17;
            this.txt_nofactura.TextChanged += new System.EventHandler(this.txt_nofactura_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label10.Location = new System.Drawing.Point(145, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Imp. venta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label11.Location = new System.Drawing.Point(15, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "NIT cliente";
            // 
            // txt_cCliente
            // 
            this.txt_cCliente.BackColor = System.Drawing.Color.White;
            this.txt_cCliente.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cCliente.Location = new System.Drawing.Point(12, 162);
            this.txt_cCliente.Name = "txt_cCliente";
            this.txt_cCliente.Size = new System.Drawing.Size(97, 21);
            this.txt_cCliente.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label12.Location = new System.Drawing.Point(453, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Cliente";
            // 
            // txt_cliente
            // 
            this.txt_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txt_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cliente.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(498, 39);
            this.txt_cliente.Multiline = true;
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.ReadOnly = true;
            this.txt_cliente.Size = new System.Drawing.Size(290, 20);
            this.txt_cliente.TabIndex = 23;
            this.txt_cliente.TextChanged += new System.EventHandler(this.txt_cliente_TextChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btn_buscar.Location = new System.Drawing.Point(12, 192);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(97, 35);
            this.btn_buscar.TabIndex = 24;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Empleado";
            // 
            // txt_empleado
            // 
            this.txt_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txt_empleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_empleado.Font = new System.Drawing.Font("Source Sans Pro", 8.25F);
            this.txt_empleado.Location = new System.Drawing.Point(12, 96);
            this.txt_empleado.Multiline = true;
            this.txt_empleado.Name = "txt_empleado";
            this.txt_empleado.ReadOnly = true;
            this.txt_empleado.Size = new System.Drawing.Size(97, 20);
            this.txt_empleado.TabIndex = 26;
            this.txt_empleado.TextChanged += new System.EventHandler(this.txt_empleado_TextChanged);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.lbl_fecha.Location = new System.Drawing.Point(285, 36);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(82, 27);
            this.lbl_fecha.TabIndex = 27;
            this.lbl_fecha.Text = "--/--/----";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirFactura);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_empleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_cCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_nofactura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_impVenta);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_facturar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtg_facturacion);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.txt_cproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Source Sans Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "Ventana principal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_facturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cproducto;
        private System.Windows.Forms.Button btn_agregarProducto;
        private System.Windows.Forms.DataGridView dtg_facturacion;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeFacturasToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_facturar;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_impVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nofactura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ToolStripMenuItem impuestoDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txt_impVentaEdit;
        private System.Windows.Forms.ToolStripMenuItem descuentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txt_descEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_fecha;
        public System.Windows.Forms.TextBox txt_empleado;
        private System.Windows.Forms.TextBox txt_cCliente;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}