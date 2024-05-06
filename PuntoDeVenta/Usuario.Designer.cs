
namespace PuntoDeVenta
{
    partial class Usuario
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
            this.btn_nuevoU = new System.Windows.Forms.Button();
            this.btn_modificarU = new System.Windows.Forms.Button();
            this.btn_eliminarU = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 273);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_nuevoU
            // 
            this.btn_nuevoU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(114)))), ((int)(((byte)(147)))));
            this.btn_nuevoU.FlatAppearance.BorderSize = 0;
            this.btn_nuevoU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoU.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btn_nuevoU.Location = new System.Drawing.Point(12, 401);
            this.btn_nuevoU.Name = "btn_nuevoU";
            this.btn_nuevoU.Size = new System.Drawing.Size(119, 37);
            this.btn_nuevoU.TabIndex = 1;
            this.btn_nuevoU.Text = "Nuevo Usuario";
            this.btn_nuevoU.UseVisualStyleBackColor = false;
            this.btn_nuevoU.Click += new System.EventHandler(this.btn_nuevoU_Click);
            // 
            // btn_modificarU
            // 
            this.btn_modificarU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btn_modificarU.Enabled = false;
            this.btn_modificarU.FlatAppearance.BorderSize = 0;
            this.btn_modificarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarU.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificarU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btn_modificarU.Location = new System.Drawing.Point(137, 401);
            this.btn_modificarU.Name = "btn_modificarU";
            this.btn_modificarU.Size = new System.Drawing.Size(119, 37);
            this.btn_modificarU.TabIndex = 2;
            this.btn_modificarU.Text = "Modificar Usuario";
            this.btn_modificarU.UseVisualStyleBackColor = false;
            this.btn_modificarU.Click += new System.EventHandler(this.btn_modificarU_Click);
            // 
            // btn_eliminarU
            // 
            this.btn_eliminarU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btn_eliminarU.Enabled = false;
            this.btn_eliminarU.FlatAppearance.BorderSize = 0;
            this.btn_eliminarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarU.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btn_eliminarU.Location = new System.Drawing.Point(262, 401);
            this.btn_eliminarU.Name = "btn_eliminarU";
            this.btn_eliminarU.Size = new System.Drawing.Size(119, 37);
            this.btn_eliminarU.TabIndex = 3;
            this.btn_eliminarU.Text = "Eliminar Usuario";
            this.btn_eliminarU.UseVisualStyleBackColor = false;
            this.btn_eliminarU.Click += new System.EventHandler(this.btn_eliminarU_Click);
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
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(22, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(25, 363);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(115, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(150, 363);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(115, 20);
            this.txt_apellidos.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(147, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellidos";
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(275, 363);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(115, 20);
            this.txt_nit.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(272, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "NIT";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(396, 363);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(115, 20);
            this.txt_telefono.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(393, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefono";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_contrasena);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_usuario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.groupBox1.Location = new System.Drawing.Point(522, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 71);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de acceso";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasena.Location = new System.Drawing.Point(127, 38);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(115, 21);
            this.txt_contrasena.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(124, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(6, 39);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(115, 21);
            this.txt_usuario.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Usuario";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Source Sans Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(592, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(115, 23);
            this.txt_id.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Source Sans Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(568, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btn_buscar.Location = new System.Drawing.Point(710, 10);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 27);
            this.btn_buscar.TabIndex = 16;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_eliminarU);
            this.Controls.Add(this.btn_modificarU);
            this.Controls.Add(this.btn_nuevoU);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Usuario";
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_nuevoU;
        private System.Windows.Forms.Button btn_modificarU;
        private System.Windows.Forms.Button btn_eliminarU;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_buscar;
    }
}