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
using FluentValidation;

namespace PuntoDeVenta
{
    public partial class Inventario : Form
    {
        ConexionSQL2 cn = new ConexionSQL2();
        public Inventario()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.consultaInventario();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevoP_Click(object sender, EventArgs e)
        {
            string producto = txt_producto.Text;
            string categoria = txt_categoria.Text;
            string precio = txt_precio.Text;
            string cantidad = txt_cantidad.Text;

            var datos = new ProductoDatos();

            datos.producto = Convert.ToString(producto);
            datos.categoria = Convert.ToString(categoria);
            datos.precio = Convert.ToString(precio);
            datos.cantidad = Convert.ToString(cantidad);

            if (datos != null) 
            {
                ValidacionesProducto validar = new ValidacionesProducto();
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

                cn.InsertarInventario(txt_producto.Text, txt_categoria.Text, txt_precio.Text, txt_cantidad.Text);
                dataGridView1.DataSource = cn.consultaInventario();

                txt_producto.Text = "";
                txt_categoria.Text = "";
                txt_precio.Text = "";
                txt_cantidad.Text = "";

                MessageBox.Show("Producto ingresado correctamente.");
            }

            
        }

        private void btn_modificarP_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("No se encuentra ningún ID para modifica.");
            }
            else {
                DialogResult confirmacion;
                confirmacion = MessageBox.Show("¿Estás seguro que desas modificar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes) 
                {
                    cn.modificarInventario(txt_producto.Text, txt_categoria.Text, txt_precio.Text, txt_cantidad.Text, Convert.ToInt32(txt_id.Text));
                    dataGridView1.DataSource = cn.consultaInventario();

                    txt_producto.Text = "";
                    txt_categoria.Text = "";
                    txt_precio.Text = "";
                    txt_cantidad.Text = "";
                    txt_id.Text = "";

                    btn_modificarP.Enabled = false;
                    btn_eliminarP.Enabled = false;

                    MessageBox.Show("Producto modificado.");
                }
            }
        }

        private void btn_eliminarP_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("No se encontró un producto. Por favor, ingrese un ID para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                DialogResult confirmacion;
                confirmacion = MessageBox.Show("¿Estás seguro que deseas eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes) 
                {
                    int id = Convert.ToInt32(txt_id.Text);
                    cn.eliminarInventario(Convert.ToInt32(id));
                    dataGridView1.DataSource = cn.consultaInventario();

                    txt_id.Text = "";
                    txt_producto.Text = "";
                    txt_categoria.Text = "";
                    txt_precio.Text = "";
                    txt_cantidad.Text = "";

                    btn_modificarP.Enabled = false;
                    btn_eliminarP.Enabled = false;

                    MessageBox.Show("Producto ELiminado");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txt_id.Text = Convert.ToString(row.Cells[0].Value);
            txt_producto.Text = Convert.ToString(row.Cells[1].Value);
            txt_categoria.Text = Convert.ToString(row.Cells[2].Value);
            txt_precio.Text = Convert.ToString(row.Cells[3].Value);
            txt_cantidad.Text = Convert.ToString(row.Cells[4].Value);

            btn_modificarP.Enabled = true;
            btn_eliminarP.Enabled = true;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                dataGridView1.DataSource = cn.consultaInventario();
                txt_id.Text = "";
                txt_producto.Text = "";
                txt_categoria.Text = "";
                txt_precio.Text = "";
                txt_cantidad.Text = "";

                btn_modificarP.Enabled = false;
                btn_eliminarP.Enabled = false;
            }
            else 
            {
                int id = Convert.ToInt32(txt_id.Text);
                dataGridView1.DataSource = cn.consultaInventarioID(id);

                txt_id.Text = "";
                txt_producto.Text = "";
                txt_categoria.Text = "";
                txt_precio.Text = "";
                txt_cantidad.Text = "";

                btn_modificarP.Enabled = false;
                btn_eliminarP.Enabled = false;
            }
        }
    }
}
