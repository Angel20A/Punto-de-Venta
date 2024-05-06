
namespace PuntoDeVenta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.txt_usuario.Location = new System.Drawing.Point(104, 60);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(272, 21);
            this.txt_usuario.TabIndex = 0;
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Font = new System.Drawing.Font("Source Sans Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.txt_contrasena.Location = new System.Drawing.Point(104, 119);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(272, 21);
            this.txt_contrasena.TabIndex = 1;
            this.txt_contrasena.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(101, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(101, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btn_entrar.FlatAppearance.BorderSize = 0;
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F);
            this.btn_entrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btn_entrar.Location = new System.Drawing.Point(111, 169);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(110, 30);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F);
            this.btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.btn_salir.Location = new System.Drawing.Point(254, 169);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(110, 30);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(503, 248);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_usuario);
            this.Name = "Form1";
            this.Text = "Inicio Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_salir;
        public System.Windows.Forms.Button btn_entrar;
    }
}

