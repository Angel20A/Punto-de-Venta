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

namespace PuntoDeVenta
{
    public partial class HistorialFacturacion : Form
    {
        ConexionSQL2 cn = new ConexionSQL2();

        public HistorialFacturacion()
        {
            InitializeComponent();

            dataGridView1.DataSource = cn.ConsultaFacturaEncabezado();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            int idFactura = Convert.ToInt32(row.Cells[0].Value);

            IdFactura.idFactura = idFactura;

            MessageBox.Show("Factura No. " + Convert.ToString(IdFactura.idFactura));

            FacturaDetalle v1 = new FacturaDetalle();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }
    }
}
