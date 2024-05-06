
namespace PuntoDeVenta
{
    partial class Inventario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_nuevoP = new System.Windows.Forms.Button();
            this.btn_modificarP = new System.Windows.Forms.Button();
            this.btn_eliminarP = new System.Windows.Forms.Button();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Maroon;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btn_cerrar.Location = new System.Drawing.Point(669, 401);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(119, 37);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 300);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_nuevoP
            // 
            this.btn_nuevoP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(147)))));
            this.btn_nuevoP.FlatAppearance.BorderSize = 0;
            this.btn_nuevoP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoP.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btn_nuevoP.Location = new System.Drawing.Point(13, 401);
            this.btn_nuevoP.Name = "btn_nuevoP";
            this.btn_nuevoP.Size = new System.Drawing.Size(129, 37);
            this.btn_nuevoP.TabIndex = 2;
            this.btn_nuevoP.Text = "Nuevo Producto";
            this.btn_nuevoP.UseVisualStyleBackColor = false;
            this.btn_nuevoP.Click += new System.EventHandler(this.btn_nuevoP_Click);
            // 
            // btn_modificarP
            // 
            this.btn_modificarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btn_modificarP.Enabled = false;
            this.btn_modificarP.FlatAppearance.BorderSize = 0;
            this.btn_modificarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarP.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btn_modificarP.Location = new System.Drawing.Point(148, 401);
            this.btn_modificarP.Name = "btn_modificarP";
            this.btn_modificarP.Size = new System.Drawing.Size(129, 37);
            this.btn_modificarP.TabIndex = 3;
            this.btn_modificarP.Text = "Modificar Producto";
            this.btn_modificarP.UseVisualStyleBackColor = false;
            this.btn_modificarP.Click += new System.EventHandler(this.btn_modificarP_Click);
            // 
            // btn_eliminarP
            // 
            this.btn_eliminarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btn_eliminarP.Enabled = false;
            this.btn_eliminarP.FlatAppearance.BorderSize = 0;
            this.btn_eliminarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarP.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btn_eliminarP.Location = new System.Drawing.Point(283, 401);
            this.btn_eliminarP.Name = "btn_eliminarP";
            this.btn_eliminarP.Size = new System.Drawing.Size(128, 37);
            this.btn_eliminarP.TabIndex = 4;
            this.btn_eliminarP.Text = "Eliminar Producto";
            this.btn_eliminarP.UseVisualStyleBackColor = false;
            this.btn_eliminarP.Click += new System.EventHandler(this.btn_eliminarP_Click);
            // 
            // txt_producto
            // 
            this.txt_producto.BackColor = System.Drawing.Color.White;
            this.txt_producto.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_producto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.txt_producto.Location = new System.Drawing.Point(13, 351);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(118, 21);
            this.txt_producto.TabIndex = 5;
            // 
            // txt_categoria
            // 
            this.txt_categoria.BackColor = System.Drawing.Color.White;
            this.txt_categoria.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.txt_categoria.Location = new System.Drawing.Point(138, 351);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(118, 21);
            this.txt_categoria.TabIndex = 6;
            // 
            // txt_precio
            // 
            this.txt_precio.BackColor = System.Drawing.Color.White;
            this.txt_precio.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.txt_precio.Location = new System.Drawing.Point(263, 351);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(118, 21);
            this.txt_precio.TabIndex = 7;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.Color.White;
            this.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cantidad.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.txt_cantidad.Location = new System.Drawing.Point(387, 351);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(118, 21);
            this.txt_cantidad.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(13, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(135, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(260, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(384, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.White;
            this.txt_id.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.txt_id.Location = new System.Drawing.Point(669, 351);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(118, 21);
            this.txt_id.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(666, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Source Sans Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btn_buscar.Location = new System.Drawing.Point(589, 349);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(74, 23);
            this.btn_buscar.TabIndex = 15;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.btn_eliminarP);
            this.Controls.Add(this.btn_modificarP);
            this.Controls.Add(this.btn_nuevoP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cerrar);
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_nuevoP;
        private System.Windows.Forms.Button btn_modificarP;
        private System.Windows.Forms.Button btn_eliminarP;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscar;
    }
}