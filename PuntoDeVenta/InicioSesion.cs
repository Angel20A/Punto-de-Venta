using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Negocios; //para conectar con la Solución "Negocios"
using Entidades;

namespace PuntoDeVenta
{
    public partial class Form1 : Form
    {
        ConexionSQL2 cn = new ConexionSQL2();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            if (cn.conSQL(txt_usuario.Text, txt_contrasena.Text) == 1)
            {
                var resultadoEmpleado = cn.ConsultaEmpleado(txt_usuario.Text, txt_contrasena.Text);
                int id = Convert.ToInt32(resultadoEmpleado.Item1);
                string nombre = Convert.ToString(resultadoEmpleado.Item2);
                string apellido = Convert.ToString(resultadoEmpleado.Item3);

                MessageBox.Show("¡Bienvenido "+nombre+" "+apellido+"!");

                Empleado.Id = id;
                Empleado.Nombre = nombre;
                Empleado.Apellido = apellido;

                this.Hide(); //esconder este form

                VentanaPrincipal v1 = new VentanaPrincipal(); //Se crea el objeto del form VentanaPrincipal                
                v1.Show(); //Se muestra el form
            }
            else {
                MessageBox.Show("El usuario no ha sido encontrado. Usuario o contraseña incorrecto.");
            }
        }
    }
}
