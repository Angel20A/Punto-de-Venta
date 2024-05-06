
namespace PuntoDeVenta
{
    partial class Clientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_nuevoC = new System.Windows.Forms.Button();
            this.btn_modificarC = new System.Windows.Forms.Button();
            this.btn_eliminarC = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.txt_apellidoCliente = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_nuevoC
            // 
            this.btn_nuevoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(147)))));
            this.btn_nuevoC.FlatAppearance.BorderSize = 0;
            this.btn_nuevoC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoC.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btn_nuevoC.Location = new System.Drawing.Point(13, 401);
            this.btn_nuevoC.Name = "btn_nuevoC";
            this.btn_nuevoC.Size = new System.Drawing.Size(119, 37);
            this.btn_nuevoC.TabIndex = 3;
            this.btn_nuevoC.Text = "Nuevo Cliente";
            this.btn_nuevoC.UseVisualStyleBackColor = false;
            this.btn_nuevoC.Click += new System.EventHandler(this.btn_nuevoC_Click);
            // 
            // btn_modificarC
            // 
            this.btn_modificarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btn_modificarC.Enabled = false;
            this.btn_modificarC.FlatAppearance.BorderSize = 0;
            this.btn_modificarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarC.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btn_modificarC.Location = new System.Drawing.Point(138, 401);
            this.btn_modificarC.Name = "btn_modificarC";
            this.btn_modificarC.Size = new System.Drawing.Size(119, 37);
            this.btn_modificarC.TabIndex = 4;
            this.btn_modificarC.Text = "Modificar Cliente";
            this.btn_modificarC.UseVisualStyleBackColor = false;
            this.btn_modificarC.Click += new System.EventHandler(this.btn_modificarC_Click);
            // 
            // btn_eliminarC
            // 
            this.btn_eliminarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btn_eliminarC.Enabled = false;
            this.btn_eliminarC.FlatAppearance.BorderSize = 0;
            this.btn_eliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarC.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btn_eliminarC.Location = new System.Drawing.Point(263, 401);
            this.btn_eliminarC.Name = "btn_eliminarC";
            this.btn_eliminarC.Size = new System.Drawing.Size(119, 37);
            this.btn_eliminarC.TabIndex = 5;
            this.btn_eliminarC.Text = "Eliminar Cliente";
            this.btn_eliminarC.UseVisualStyleBackColor = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Maroon;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btn_cerrar.Location = new System.Drawing.Point(669, 401);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(119, 37);
            this.btn_cerrar.TabIndex = 6;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(302, 361);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Size = new System.Drawing.Size(92, 20);
            this.txt_nombreCliente.TabIndex = 7;
            // 
            // txt_apellidoCliente
            // 
            this.txt_apellidoCliente.Location = new System.Drawing.Point(400, 361);
            this.txt_apellidoCliente.Name = "txt_apellidoCliente";
            this.txt_apellidoCliente.Size = new System.Drawing.Size(92, 20);
            this.txt_apellidoCliente.TabIndex = 8;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(498, 361);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(92, 20);
            this.txt_telefono.TabIndex = 9;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(596, 361);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(92, 20);
            this.txt_correo.TabIndex = 10;
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(694, 361);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(92, 20);
            this.txt_descuento.TabIndex = 11;
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(92, 361);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(92, 20);
            this.txt_nit.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(691, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Descuento";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btn_buscar.Location = new System.Drawing.Point(12, 359);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 19;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "NIT";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_apellidoCliente);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_eliminarC);
            this.Controls.Add(this.btn_modificarC);
            this.Controls.Add(this.btn_nuevoC);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_nuevoC;
        private System.Windows.Forms.Button btn_modificarC;
        private System.Windows.Forms.Button btn_eliminarC;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.TextBox txt_apellidoCliente;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label6;
    }
}