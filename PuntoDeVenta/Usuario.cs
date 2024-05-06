using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios; //Para llamar a la capa Negocios
using Entidades;
using FluentValidation.Results; //para usar el ValidationResult

namespace PuntoDeVenta
{
    public partial class Usuario : Form
    {
        ConexionSQL2 cn = new ConexionSQL2();

        public Usuario()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.consultaDT();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevoU_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellidos = txt_apellidos.Text;
            string nit = txt_nit.Text;
            string telefono = txt_telefono.Text;
            string usuario = txt_usuario.Text;
            string contrasena = txt_contrasena.Text;

            var datos = new UsuarioDatos();

            datos.Nombre = nombre;
            datos.Apellidos = apellidos;
            datos.Nit = nit;
            datos.telefono = telefono;
            datos.Usuario = usuario;
            datos.Contrasena = contrasena;

            if (datos != null)
            {
                Validaciones validar = new Validaciones();
                ValidationResult resultado = validar.Validate(datos);
                List<ValidationFailure> error = resultado.Errors;

                if (!resultado.IsValid)
                {
                    foreach (ValidationFailure failure in error)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                cn.InsertarUsuario(nombre, apellidos, nit, telefono, usuario, contrasena);
                dataGridView1.DataSource = cn.consultaDT();

                txt_nombre.Text = "";
                txt_apellidos.Text = "";
                txt_nit.Text = "";
                txt_telefono.Text = "";
                txt_usuario.Text = "";
                txt_contrasena.Text = "";

                btn_modificarU.Enabled = false;
                btn_eliminarU.Enabled = false;

                MessageBox.Show("Usuario ingresado correctamente");

            }
        }

        private void btn_modificarU_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("No se encuentra ningún ID para modificar.");
            }
            else {
                DialogResult confirmacion;
                confirmacion = MessageBox.Show("¿Está seguro que desea modificar este usuario?", "Confirmación", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes)
                {
                    cn.ModificarUsuario(txt_nombre.Text, txt_apellidos.Text, Convert.ToInt32(txt_id.Text), txt_telefono.Text, txt_usuario.Text, txt_contrasena.Text, txt_nit.Text);
                    dataGridView1.DataSource = cn.consultaDT();

                    txt_nombre.Text = "";
                    txt_apellidos.Text = "";
                    txt_nit.Text = "";
                    txt_telefono.Text = "";
                    txt_usuario.Text = "";
                    txt_contrasena.Text = "";

                    btn_modificarU.Enabled = false;
                    btn_eliminarU.Enabled = false;

                    MessageBox.Show("Usuario modificado.");
                }
            }

        }

        private void btn_eliminarU_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("No se encuentra ningún ID para eliminar."+"Error"+MessageBoxIcon.Error);
            }
            else {
                DialogResult confirmacion;
                confirmacion = MessageBox.Show("¿Seguro quieres eliminar a este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    cn.EliminarUsuario(Convert.ToInt32(txt_id.Text));
                    dataGridView1.DataSource = cn.consultaDT();

                    txt_nombre.Text = "";
                    txt_apellidos.Text = "";
                    txt_nit.Text = "";
                    txt_telefono.Text = "";
                    txt_usuario.Text = "";
                    txt_contrasena.Text = "";

                    btn_eliminarU.Enabled = false;
                    btn_modificarU.Enabled = false;

                    MessageBox.Show("Usuario Eliminado");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0) //e.RowIndex >= 0 //e.ColumnIndex == this.dataGridView1.Columns[e.RowIndex].Index
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_id.Text = Convert.ToString(row.Cells[0].Value);
                txt_nombre.Text = Convert.ToString(row.Cells[1].Value);
                txt_apellidos.Text = Convert.ToString(row.Cells[2].Value);
                txt_nit.Text = Convert.ToString(row.Cells[3].Value);
                txt_telefono.Text = Convert.ToString(row.Cells[4].Value);
                txt_usuario.Text = Convert.ToString(row.Cells[5].Value);
                txt_contrasena.Text = Convert.ToString(row.Cells[6].Value);

                btn_modificarU.Enabled = true;
                btn_eliminarU.Enabled = true;

            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                dataGridView1.DataSource = cn.consultaDT();
                txt_nombre.Text = "";
                txt_apellidos.Text = "";
                txt_nit.Text = "";
                txt_telefono.Text = "";
                txt_usuario.Text = "";
                txt_contrasena.Text = "";

                btn_modificarU.Enabled = false;
                btn_eliminarU.Enabled = false;
            }
            else 
            {
                dataGridView1.DataSource = cn.consultaUsuarioID(Convert.ToInt32(txt_id.Text));
                txt_id.Text = "";
                txt_nombre.Text = "";
                txt_apellidos.Text = "";
                txt_nit.Text = "";
                txt_telefono.Text = "";
                txt_usuario.Text = "";
                txt_contrasena.Text = "";

                btn_modificarU.Enabled = false;
                btn_eliminarU.Enabled = false;
            }
            
        }
    }
}
