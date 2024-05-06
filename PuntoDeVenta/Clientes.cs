using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using Entidades;
using FluentValidation.Results;


namespace PuntoDeVenta
{
    public partial class Clientes : Form
    {
        ConexionSQL2 cn = new ConexionSQL2();

        public Clientes()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.consultaClienteSelect();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevoC_Click(object sender, EventArgs e)
        {
            string nit = Convert.ToString(txt_nit.Text);
            string nombre = Convert.ToString(txt_nombreCliente.Text);
            string apellido = Convert.ToString(txt_nombreCliente.Text);
            string telefono = Convert.ToString(txt_telefono.Text);
            string correo = Convert.ToString(txt_correo.Text);
            string descuento = Convert.ToString(txt_descuento.Text);

            var datos = new ClienteDatos();

            datos.nit = nit;
            datos.nombre = nombre;
            datos.apellido = apellido;
            datos.telefono = telefono;
            datos.correo = correo;
            datos.descuento = descuento;

            if (datos != null) 
            {
                ValidacionesClientes validar = new ValidacionesClientes();
                ValidationResult resultado = validar.Validate(datos);
                List<ValidationFailure> error = resultado.Errors;

                if (!resultado.IsValid) 
                {
                    foreach (ValidationFailure failure in error) 
                    {
                        MessageBox.Show(failure.ErrorMessage, "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    float descuento1 = float.Parse(txt_descuento.Text);

                    cn.insertarCliente(nit, nombre, apellido, telefono, correo, descuento1);
                    dataGridView1.DataSource = cn.consultaClienteSelect();

                    txt_nit.Text = "";
                    txt_nombreCliente.Text = "";
                    txt_apellidoCliente.Text = "";
                    txt_telefono.Text = "";
                    txt_correo.Text = "";
                    txt_descuento.Text = "";

                    MessageBox.Show("Cliente ingresado correctamente.");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txt_nit.Text = Convert.ToString(row.Cells[0].Value);
            txt_nombreCliente.Text = Convert.ToString(row.Cells[1].Value);
            txt_apellidoCliente.Text = Convert.ToString(row.Cells[2].Value);
            txt_telefono.Text = Convert.ToString(row.Cells[3].Value);
            txt_correo.Text = Convert.ToString(row.Cells[4].Value);
            txt_descuento.Text = Convert.ToString(row.Cells[5].Value);

            btn_modificarC.Enabled = true;
            btn_eliminarC.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_nit.Text == "")
            {
                dataGridView1.DataSource = cn.consultaClienteSelect();
                txt_nombreCliente.Text = "";
                txt_apellidoCliente.Text = "";
                txt_telefono.Text = "";
                txt_correo.Text = "";
                txt_descuento.Text = "";

                btn_modificarC.Enabled = false;
                btn_eliminarC.Enabled = false;
            }
            else 
            {
                dataGridView1.DataSource = cn.ConsultaClienteNIT(Convert.ToString(txt_nit.Text));

                txt_nit.Text = "";
                txt_nombreCliente.Text = "";
                txt_apellidoCliente.Text = "";
                txt_telefono.Text = "";
                txt_correo.Text = "";
                txt_descuento.Text = "";

                btn_modificarC.Enabled = false;
                btn_eliminarC.Enabled = false;
            }
        }

        private void btn_modificarC_Click(object sender, EventArgs e)
        {
            if (txt_nit.Text == "")
            {
                MessageBox.Show("No se he indicado el NIT para modificar.");
            }
            else 
            {
                DialogResult confirmacion;
                confirmacion = MessageBox.Show("¿Estás seguro que deseas modificar este usuario?", "Confirmación", MessageBoxButtons.YesNo);

                if (confirmacion == DialogResult.Yes) 
                {
                    string nit = Convert.ToString(txt_nit.Text);
                    string nombre = Convert.ToString(txt_nombreCliente.Text);
                    string apellido = Convert.ToString(txt_apellidoCliente.Text);
                    string telefono = Convert.ToString(txt_telefono.Text);
                    string correo = Convert.ToString(txt_correo.Text);
                    float descuento = float.Parse(txt_descuento.Text);

                    cn.ModificarCliente(nombre, apellido, telefono, correo, descuento, nit);
                    dataGridView1.DataSource = cn.consultaClienteSelect();

                    txt_nit.Text = "";
                    txt_nombreCliente.Text = "";
                    txt_apellidoCliente.Text = "";
                    txt_telefono.Text = "";
                    txt_correo.Text = "";
                    txt_descuento.Text = "";

                    btn_modificarC.Enabled = false;
                    btn_eliminarC.Enabled = false;

                    MessageBox.Show("Cliente modificado.");
                }
            }
        }
    }
}
