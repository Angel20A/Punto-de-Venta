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
    public partial class FacturaDetalle : Form
    {
        ConexionSQL2 cn = new ConexionSQL2();

        public FacturaDetalle()
        {
            InitializeComponent();
            
            int id = IdFactura.idFactura;

            dataGridView1.DataSource = cn.ConsultaFacturaDetalle(id);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
